using System;
using System.IO;
using System.Net;
using ImageCompress.API.Entities;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace ImageCompress.API.Helpers
{
    public static class ProcessImage
    {
        public static string imageToBase64(Image image)
        {
            string path = "traitement/";
            string name = image.Id.ToString() + "." + image.Format;
            string filepath = path + name;

            DownloadRemoteImageFile(image.Url, filepath);

            using (var imageStream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            using (var picture = new System.Drawing.Bitmap(imageStream))
            {
                var resizedImage = new System.Drawing.Bitmap(image.Width, image.Height);
                using (var graphics = System.Drawing.Graphics.FromImage(resizedImage))
                {
                    graphics.DrawImage(picture, 0, 0, image.Width, image.Height);
                    System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                    var textconverter = (byte[])converter.ConvertTo(resizedImage, typeof(byte[]));
                    string imgBase64 = Convert.ToBase64String(textconverter);

                    imageStream.Close();

                    File.Delete(filepath);

                    if(imgBase64 == null)
                    {
                        return "Error";
                    }
                    else
                    {
                        return imgBase64;
                    }
                }
            }
        }

        public static Image uploadBase64(Image image, string imageBase64)
        {
            Console.WriteLine("Start upload 64");
            string apiKey = "?key=e5b1392f122030ce9fb8c108b906a88d";
            string title = "&name=" + Uri.EscapeDataString(image.Titre);
            string apiUrl = "https://api.imgbb.com/1/upload" + apiKey + title;

            // Api url build
            Console.WriteLine(apiUrl);

            var client = new RestClient(apiUrl);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("image", imageBase64);
            IRestResponse response = client.Execute(request);
            var JsonResponse = JObject.Parse(response.Content);

            // Api response formated on Json
            Console.WriteLine(JsonResponse);

            image.Url = JsonResponse.SelectToken("data").SelectToken("url").Value<string>();
            image.Size = int.Parse(JsonResponse.SelectToken("data").SelectToken("size").Value<string>()) / 1024;// Taille de Octets vers Ko
            image.Format = JsonResponse.SelectToken("data").SelectToken("image").SelectToken("extension").Value<string>();
            image.CreationDate = DateTime.Now;

            return image;
        }

        private static void DownloadRemoteImageFile(string url, string filepath)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(url), filepath);
            }
        }

        public static bool IsAnImageUrl(string url)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (result)
            {
                string[] urlList = url.Split(".");
                string[] allowedFiles = { "png", "jpg", "jpeg" };
                int pos = Array.IndexOf(allowedFiles, urlList.Last());
                if (pos > -1)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool isValidBase64(string base64)
        {
            Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out int bytesParsed);
        }
    }
}

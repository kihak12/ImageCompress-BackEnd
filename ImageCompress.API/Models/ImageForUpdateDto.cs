using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageCompress.API.Models
{
    public class ImageForUpdateDto
    {
        public string Titre { get; set; }
        public string Url { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public int Size { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Format { get; set; }
    }
}

using ImageCompress.API.DbContexts;
using ImageCompress.API.Entities;
using ImageCompress.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using ImageCompress.API.Helpers;
using ImageCompress.API.Repositories;

namespace ImageCompress.API.Services
{
    public class ImageCompressRepository : IImageCompressRepository, IDisposable
    {
        private readonly ImageCompressContext _context;

        public ImageCompressRepository(ImageCompressContext context )
        {
            _context = context;
        }


        public void AddImage(Image image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            // the repository fills the id (instead of using identity columns)
            image.Id = Guid.NewGuid();

            _context.Images.Add(image);
        }

        public bool ImageExists(Guid ImageId)
        {
            if (ImageId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(ImageId));
            }

            return _context.Images.Any(a => a.Id == ImageId);
        }

        public void DeleteImage(Image image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            _context.Images.Remove(image);
        }
        
        public Image GetImage(Guid imageId)
        {
            if (imageId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(imageId));
            }

            return _context.Images.FirstOrDefault(a => a.Id == imageId);
        }

        public IEnumerable<Image> GetImages()
        {
            return _context.Images.ToList<Image>();
        }
         
        public IEnumerable<Image> GetImages(IEnumerable<Guid> imageIds)
        {
            if (imageIds == null)
            {
                throw new ArgumentNullException(nameof(imageIds));
            }

            return _context.Images.Where(a => imageIds.Contains(a.Id))
                .ToList();
        }

        public void UpdateImage(Image image)
        {
            // no code in this implementation
        }

        public Image ResizeImage(Image image, ImageForResizeInfoDto newImage)
        {
            if (image == null){ throw new ArgumentNullException(nameof(image));}
            else if (newImage == null){ throw new ArgumentNullException(nameof(newImage));}

            // the repository fills the id (instead of using identity columns)
            image.Id = Guid.NewGuid();

            if(newImage.Titre != null){image.Titre = newImage.Titre;}
            if(newImage.Height != 0){image.Height = newImage.Height;}
            if(newImage.Width != 0){image.Width = newImage.Width;}
            if(newImage.Format != null){image.Format = newImage.Format;}

            string Base64 = ProcessImage.imageToBase64(image);
            if (Base64 != "Error")
            {
                Image apiImage = ProcessImage.uploadBase64(image, Base64);

                _context.Images.Add(apiImage);
                return apiImage;
            }
            else
            {
                throw new ArgumentNullException(nameof(image));
            }
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
               // dispose resources when needed
            }
        }
    }
}

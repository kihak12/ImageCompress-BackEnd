using ImageCompress.API.Entities;
using ImageCompress.API.Models;
using System;
using System.Collections.Generic;

namespace ImageCompress.API.Repositories
{
    public interface IImageCompressRepository
    {    
        IEnumerable<Image> GetImages();
        Image GetImage(Guid imageId);
        void AddImage(Image image);
        void DeleteImage(Image image);
        void UpdateImage(Image image);
        bool ImageExists(Guid imageId);
        Image ResizeImage(Image oldImage, ImageForResizeInfoDto newImage);
        bool Save();
    }
}

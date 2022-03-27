using ImageCompress.API.Entities;
using ImageCompress.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageCompress.API.Services.Interface
{
    public interface IImageService
    {
        IEnumerable<ImageDto> GetImages();
        ImageDto GetImage(Guid imageId);
        ImageDto CreateImage(ImageForCreationDto image);
        void UpdateImage(Guid imageId, JsonPatchDocument<ImageForUpdateDto> patchDocument);
        void DeleteImage(Guid imageId);
        ImageDto ResizeImage(Guid imageId, ImageForResizeInfoDto infoImage);
        ImageDto UploadImage(ImageForCreationDto image);
    }
}

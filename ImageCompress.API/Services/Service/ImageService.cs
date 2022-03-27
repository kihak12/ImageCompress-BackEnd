using AutoMapper;
using ImageCompress.API.Exceptions;
using ImageCompress.API.Models;
using ImageCompress.API.Repositories;
using ImageCompress.API.Services.Interface;
using Microsoft.AspNetCore.JsonPatch;
using ImageCompress.API.Helpers;
using System;
using System.Collections.Generic;
using ImageCompress.API.Entities;

namespace ImageCompress.API.Services.Service
{
    public class ImageService : IImageService
    {
        private readonly IImageCompressRepository _imageCompressRepository;
        private readonly IMapper _mapper;

        public ImageService(IMapper mapper, IImageCompressRepository imageCompressRepository)
        {
            _mapper = mapper;
            _imageCompressRepository = imageCompressRepository;
        }


        public IEnumerable<ImageDto> GetImages()
        {
            var imagesFromRepo = _imageCompressRepository.GetImages();
            if (imagesFromRepo == null)
            {
                throw new NotFoundException("Aucune image n'a pas été trouvé.");
            }
            return _mapper.Map<IEnumerable<ImageDto>>(imagesFromRepo);
        }

        public ImageDto GetImage(Guid imageId)
        {
            var imageFromRepo = _imageCompressRepository.GetImage(imageId);
            if (imageFromRepo == null)
            {
                throw new NotFoundException("L'image n'a pas été trouvé.");
            }

            return _mapper.Map<ImageDto>(imageFromRepo);
        }

        public ImageDto CreateImage(ImageForCreationDto image)
        {
            var imageEntity = _mapper.Map<Entities.Image>(image);
            _imageCompressRepository.AddImage(imageEntity);
            _imageCompressRepository.Save();

            return _mapper.Map<ImageDto>(imageEntity);
        }

        public void UpdateImage(Guid imageId, JsonPatchDocument<ImageForUpdateDto> patchDocument)
        {
            if (!_imageCompressRepository.ImageExists(imageId))
            {
                throw new NotFoundException("L'image n'a pas été trouvé.");
            }

            var imageFromRepo = _imageCompressRepository.GetImage(imageId);

            var imageToPatch = _mapper.Map<ImageForUpdateDto>(imageFromRepo);

            patchDocument.ApplyTo(imageToPatch);

            _mapper.Map(imageToPatch, imageFromRepo);
            _imageCompressRepository.UpdateImage(imageFromRepo);
            _imageCompressRepository.Save();
        }

        public void DeleteImage(Guid imageId)
        {
            var imageFromRepo = _imageCompressRepository.GetImage(imageId);
            if (imageFromRepo == null)
            {
                throw new NotFoundException("L'image n'a pas été trouvé.");
            }
            _imageCompressRepository.DeleteImage(imageFromRepo);
            _imageCompressRepository.Save();
        }

        public ImageDto ResizeImage(Guid imageId, ImageForResizeInfoDto infoImage)
        {
            var oldImage = _imageCompressRepository.GetImage(imageId);
            var newImage = _mapper.Map<Models.ImageForResizeInfoDto>(infoImage);

            var result = _imageCompressRepository.ResizeImage(oldImage, newImage);

            _imageCompressRepository.Save();

            return _mapper.Map<ImageDto>(result);
        }

        public ImageDto UploadImage(ImageForCreationDto EntryImage)
        {
            if(EntryImage.Url == null)
            {
                throw new NotFoundException("Aucun media saisie.");
            }
            Image image = _mapper.Map<Entities.Image>(EntryImage);

            string imageData = EntryImage.Url;
            if (ProcessImage.IsAnImageUrl(imageData))
            {
                ///Convert to Base64
                string Base64 = ProcessImage.imageToBase64(image);

                //Upload to Imgbb
                image = ProcessImage.uploadBase64(image, Base64);
                ImageForCreationDto FinalImage = _mapper.Map<Models.ImageForCreationDto>(image);

                return CreateImage(FinalImage);

            }
            else if(ProcessImage.isValidBase64(imageData))
            {
                Console.WriteLine("Start base 64");
                image = ProcessImage.uploadBase64(image, imageData);
                Console.WriteLine("Done");
                ImageForCreationDto FinalImage = _mapper.Map<Models.ImageForCreationDto>(image);

                return CreateImage(FinalImage);
            }
            else
            {
                throw new NotFoundException("Format saisie non prit en charge.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ImageCompress.API.Models;

namespace ImageCompress.API.Profiles
{
    public class ImagesProfile : Profile
    {
        public ImagesProfile()
        {
            CreateMap<Entities.Image, Models.ImageDto>();
            CreateMap<Models.ImageForCreationDto, Entities.Image>();
            CreateMap<Entities.Image, Models.ImageForCreationDto>();
            CreateMap<Entities.Image, Models.ImageForUpdateDto>();
            CreateMap<Models.ImageForUpdateDto, Entities.Image>();
            CreateMap<Entities.Image, Models.ImageForResizeInfoDto>();
            CreateMap<Models.ImageForResizeInfoDto, Entities.Image>();
        }
    }
}

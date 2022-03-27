using ImageCompress.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;
using ImageCompress.API.Services.Interface;
using ImageCompress.API.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ImageCompress.API.Controllers
{
    [ApiController]
    [Route("api/images")]
    public class ImagesController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }
         
        [HttpGet()]
        [HttpHead]
        public ActionResult<IEnumerable<ImageDto>> GetImages()
        {
            try
            {
                return Ok(_imageService.GetImages());
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("{imageId}", Name = "GetImage")]
        public ActionResult<ImageDto> GetImage(Guid imageId)
        {
            try
            {
                return Ok(_imageService.GetImage(imageId));
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpPatch("{imageId}")]
        public ActionResult UpdateImage(Guid imageId, JsonPatchDocument<ImageForUpdateDto> patchDocument)
        {
            try
            {
                _imageService.UpdateImage(imageId, patchDocument);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpOptions]
        public IActionResult GetAuthorsOptions()
        {
            Response.Headers.Add("Allow", "GET,OPTIONS,DELETE");
            return Ok();
        }

        [HttpDelete("{imageId}")]
        public ActionResult DeleteImage(Guid imageId)
        {
            try
            {
                _imageService.DeleteImage(imageId);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost("{imageId}/resize", Name = "ResizeImage")]
        public ActionResult<ImageDto> ResizeImage(Guid imageId, ImageForResizeInfoDto infoImage)
        {
            try
            {
                var imageToReturn = _imageService.ResizeImage(imageId, infoImage);
                return CreatedAtRoute("GetImage",
                    new { imageId = imageToReturn.Id },
                    imageToReturn);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost("upload", Name = "UploadImage")]
        public ActionResult<ImageDto> UploadImage(ImageForCreationDto image)
        {
            try
            {
                var imageToReturn = _imageService.UploadImage(image);
                return CreatedAtRoute("GetImage",
                    new { imageId = imageToReturn.Id },
                    imageToReturn);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}

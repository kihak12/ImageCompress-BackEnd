using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImageCompress.API.Models
{
    public class ImageForResizeInfoDto
    {
        public string Titre { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Format { get; set; }
    }
}

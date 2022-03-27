using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ImageCompress.API.Entities
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Titre { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public DateTimeOffset CreationDate { get; set; }

        [Required]
        public int Size { get; set; }


        [Required]
        public int Height { get; set; }

        [Required]
        public int Width { get; set; }

        [Required]
        [MaxLength(10)]
        public string Format { get; set; }

    }
}

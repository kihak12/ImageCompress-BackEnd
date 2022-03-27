using ImageCompress.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ImageCompress.API.DbContexts
{
    public class ImageCompressContext : DbContext
    {
        public ImageCompressContext(DbContextOptions<ImageCompressContext> options)
           : base(options)
        {
        }

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Image>().HasData(
                new Image()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Titre = "Image éléphant",
                    Url = "https://www.referenseo.com/wp-content/uploads/2019/03/image-attractive.jpg",
                    CreationDate = new DateTime(2022, 03, 08),
                    Size = 188,
                    Height = 1280,
                    Width = 720,
                    Format = "png",
                },
                new Image()
                {
                    Id = Guid.Parse("6b448be7-59c1-42d5-9070-0d058e5bd66f"),
                    Titre = "Paysage montagne",
                    Url = "https://i.ibb.co/gT43K7r/C-est-le-titre.png",
                    CreationDate = new DateTime(2022, 12, 09),
                    Size = 1980,
                    Height = 630,
                    Width = 1200,
                    Format = "png",
                },
                new Image()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    Titre = "Nuage",
                    Url = "https://i.ibb.co/Tq1vKSx/Nuage.png",
                    CreationDate = new DateTime(2019, 03, 16),
                    Size = 813,
                    Height = 647,
                    Width = 1150,
                    Format = "png",
                },
                new Image()
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    Titre = "Elden Ring Media",
                    Url = "https://i.ibb.co/SwBvMN9/Elden-Ring-Media.png",
                    CreationDate = new DateTime(1702, 3, 6),
                    Size = 733,
                    Height = 432,
                    Width = 768,
                    Format = "png",
                },
                new Image()
                {
                    Id = Guid.Parse("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                    Titre = "Spider Man",
                    Url = "https://i.ibb.co/tBYD8kG/Spider-Man.png",
                    CreationDate = new DateTime(1690, 11, 23),
                    Size = 3524,
                    Height = 1200,
                    Width = 1200,
                    Format = "png",
                },
                new Image()
                {
                    Id = Guid.Parse("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                    Titre = "Voiture",
                    Url = "https://i.ibb.co/pxmCsCB/Voiture.png",
                    CreationDate = new DateTime(1723, 4, 5),
                    Size = 519,
                    Height = 410,
                    Width = 750,
                    Format = "png",
                },
                new Image()
                {
                    Id = Guid.Parse("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                    Titre = "Suricates",
                    Url = "https://i.ibb.co/w79kXb0/Suricates.png",
                    CreationDate = new DateTime(1721, 10, 11),
                    Size = 1906,
                    Height = 680,
                    Width = 1200,
                    Format = "png",
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
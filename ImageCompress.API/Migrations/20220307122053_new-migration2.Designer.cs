﻿// <auto-generated />
using System;
using ImageCompress.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImageCompress.API.Migrations
{
    [DbContext(typeof(ImageCompressContext))]
    [Migration("20220307122053_new-migration2")]
    partial class newmigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImageCompress.API.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            CreationDate = new DateTimeOffset(new DateTime(1650, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Format = "png",
                            Height = 112,
                            Size = 36,
                            Titre = "C'est le titre",
                            Url = "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png",
                            Width = 200
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            CreationDate = new DateTimeOffset(new DateTime(1668, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Format = "png",
                            Height = 112,
                            Size = 36,
                            Titre = "C'est le titre",
                            Url = "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png",
                            Width = 200
                        },
                        new
                        {
                            Id = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            CreationDate = new DateTimeOffset(new DateTime(1701, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Format = "png",
                            Height = 112,
                            Size = 36,
                            Titre = "C'est le titre",
                            Url = "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png",
                            Width = 200
                        },
                        new
                        {
                            Id = new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                            CreationDate = new DateTimeOffset(new DateTime(1702, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Format = "png",
                            Height = 112,
                            Size = 36,
                            Titre = "C'est le titre",
                            Url = "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png",
                            Width = 200
                        },
                        new
                        {
                            Id = new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                            CreationDate = new DateTimeOffset(new DateTime(1690, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Format = "png",
                            Height = 112,
                            Size = 36,
                            Titre = "C'est le titre",
                            Url = "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png",
                            Width = 200
                        },
                        new
                        {
                            Id = new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                            CreationDate = new DateTimeOffset(new DateTime(1723, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Format = "png",
                            Height = 112,
                            Size = 36,
                            Titre = "C'est le titre",
                            Url = "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png",
                            Width = 200
                        },
                        new
                        {
                            Id = new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                            CreationDate = new DateTimeOffset(new DateTime(1721, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Format = "png",
                            Height = 112,
                            Size = 36,
                            Titre = "C'est le titre",
                            Url = "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png",
                            Width = 200
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

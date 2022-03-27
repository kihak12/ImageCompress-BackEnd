using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageCompress.API.Migrations
{
    public partial class Image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                columns: new[] { "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { 432, 733, "Elden Ring Media", "https://i.ibb.co/SwBvMN9/Elden-Ring-Media.png", 768 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                columns: new[] { "CreationDate", "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 647, 813, "Nuage", "https://i.ibb.co/Tq1vKSx/Nuage.png", 1150 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                columns: new[] { "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { 410, 519, "Voiture", "https://i.ibb.co/pxmCsCB/Voiture.png", 750 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                columns: new[] { "Height", "Size", "Url", "Width" },
                values: new object[] { 680, 1906, "https://i.ibb.co/w79kXb0/Suricates.png", 1200 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                columns: new[] { "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { 1200, 3524, "Spider Man", "https://i.ibb.co/tBYD8kG/Spider-Man.png", 1200 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                columns: new[] { "CreationDate", "Height", "Size", "Titre", "Width" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 1280, 188, "Image éléphant", 720 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreationDate", "Format", "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { new Guid("6b448be7-59c1-42d5-9070-0d058e5bd66f"), new DateTimeOffset(new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "png", 630, 1980, "Paysage montagne", "https://i.ibb.co/gT43K7r/C-est-le-titre.png", 1200 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6b448be7-59c1-42d5-9070-0d058e5bd66f"));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                columns: new[] { "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { 112, 36, "C'est le titre", "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                columns: new[] { "CreationDate", "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { new DateTimeOffset(new DateTime(1701, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 112, 36, "C'est le titre", "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                columns: new[] { "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { 112, 36, "C'est le titre", "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                columns: new[] { "Height", "Size", "Url", "Width", "titre" },
                values: new object[] { 112, 36, "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200, "Suricates" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                columns: new[] { "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { 112, 36, "C'est le titre", "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                columns: new[] { "CreationDate", "Height", "Size", "Titre", "Width" },
                values: new object[] { new DateTimeOffset(new DateTime(1650, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), 112, 36, "C'est le titre", 200 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreationDate", "Format", "Height", "Size", "Titre", "Url", "Width" },
                values: new object[] { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), new DateTimeOffset(new DateTime(1668, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "png", 112, 36, "C'est le titre", "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 });
        }
    }
}

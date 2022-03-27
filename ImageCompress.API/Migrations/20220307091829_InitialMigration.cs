using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageCompress.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    url = table.Column<string>(nullable: false),
                    creationDate = table.Column<DateTimeOffset>(nullable: false),
                    size = table.Column<int>(nullable: false),
                    height = table.Column<int>(nullable: false),
                    width = table.Column<int>(nullable: false),
                    format = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "creationDate", "format", "height", "size", "url", "width" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), new DateTimeOffset(new DateTime(1650, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "png", 112, 36, "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), new DateTimeOffset(new DateTime(1668, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "png", 112, 36, "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), new DateTimeOffset(new DateTime(1701, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "png", 112, 36, "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 },
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), new DateTimeOffset(new DateTime(1702, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "png", 112, 36, "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 },
                    { new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"), new DateTimeOffset(new DateTime(1690, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "png", 112, 36, "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 },
                    { new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"), new DateTimeOffset(new DateTime(1723, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "png", 112, 36, "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 },
                    { new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"), new DateTimeOffset(new DateTime(1721, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "png", 112, 36, "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png", 200 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}

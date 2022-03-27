using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageCompress.API.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "Url",
                value: "https://www.referenseo.com/wp-content/uploads/2019/03/image-attractive.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "Url",
                value: "https://i.ibb.co/JdjXQ67/maxresdefault-jpg.png");
        }
    }
}

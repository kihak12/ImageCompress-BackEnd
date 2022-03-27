using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageCompress.API.Migrations
{
    public partial class newmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Titre",
                table: "Images",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                column: "Titre",
                value: "C'est le titre");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                column: "Titre",
                value: "C'est le titre");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                column: "Titre",
                value: "C'est le titre");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                column: "Titre",
                value: "C'est le titre");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                column: "Titre",
                value: "C'est le titre");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "Titre",
                value: "C'est le titre");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                column: "Titre",
                value: "C'est le titre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titre",
                table: "Images");
        }
    }
}

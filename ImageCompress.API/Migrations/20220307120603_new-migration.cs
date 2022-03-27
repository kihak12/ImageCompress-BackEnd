using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageCompress.API.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "width",
                table: "Images",
                newName: "Width");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Images",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "size",
                table: "Images",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "height",
                table: "Images",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "format",
                table: "Images",
                newName: "Format");

            migrationBuilder.RenameColumn(
                name: "creationDate",
                table: "Images",
                newName: "CreationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Width",
                table: "Images",
                newName: "width");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Images",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Images",
                newName: "size");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "Images",
                newName: "height");

            migrationBuilder.RenameColumn(
                name: "Format",
                table: "Images",
                newName: "format");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Images",
                newName: "creationDate");
        }
    }
}

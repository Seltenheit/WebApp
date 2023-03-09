using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestWebApp.Domain.Migrations
{
    public partial class WebAppV1001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Catalogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Catalogs");
        }
    }
}

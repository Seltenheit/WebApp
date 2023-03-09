using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestWebApp.Domain.Migrations
{
    public partial class WebAppV1002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "Catalogs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Catalogs_Path",
                table: "Catalogs",
                column: "Path",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Catalogs_Path",
                table: "Catalogs");

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "Catalogs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace LaymarClientSide.Server.Migrations
{
    public partial class ProductoCodigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "codigo",
                table: "producto",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "codigo",
                table: "producto");
        }
    }
}

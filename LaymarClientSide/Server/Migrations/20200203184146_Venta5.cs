using Microsoft.EntityFrameworkCore.Migrations;

namespace LaymarClientSide.Server.Migrations
{
    public partial class Venta5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "comprobante");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "comprobante",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "comprobante");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "comprobante",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

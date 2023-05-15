using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace LaymarClientSide.Server.Migrations
{
    public partial class Ventas4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaBaja",
                table: "comprobante",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<double>(
                name: "efectivo",
                table: "comprobante",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "tarjeta",
                table: "comprobante",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "efectivo",
                table: "comprobante");

            migrationBuilder.DropColumn(
                name: "tarjeta",
                table: "comprobante");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaBaja",
                table: "comprobante",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}

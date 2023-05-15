using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace LaymarClientSide.Server.Migrations
{
    public partial class fechaTipoMovimientoStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "fechaAlta",
                table: "tipoMovimientoStock",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaBaja",
                table: "tipoMovimientoStock",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "comprobante",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaAlta",
                table: "tipoMovimientoStock");

            migrationBuilder.DropColumn(
                name: "fechaBaja",
                table: "tipoMovimientoStock");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "comprobante");
        }
    }
}

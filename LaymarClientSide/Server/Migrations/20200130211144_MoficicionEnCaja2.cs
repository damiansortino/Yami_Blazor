using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace LaymarClientSide.Server.Migrations
{
    public partial class MoficicionEnCaja2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaIngreso",
                table: "movimientoCaja");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaBaja",
                table: "movimientoCaja",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaBaja",
                table: "movimientoCaja",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaIngreso",
                table: "movimientoCaja",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

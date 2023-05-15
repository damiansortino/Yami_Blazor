using Microsoft.EntityFrameworkCore.Migrations;

namespace LaymarClientSide.Server.Migrations
{
    public partial class MoficicionEnCaja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimientoCaja_caja_CajaId",
                table: "movimientoCaja");

            migrationBuilder.AlterColumn<int>(
                name: "CajaId",
                table: "movimientoCaja",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_movimientoCaja_caja_CajaId",
                table: "movimientoCaja",
                column: "CajaId",
                principalTable: "caja",
                principalColumn: "CajaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimientoCaja_caja_CajaId",
                table: "movimientoCaja");

            migrationBuilder.AlterColumn<int>(
                name: "CajaId",
                table: "movimientoCaja",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_movimientoCaja_caja_CajaId",
                table: "movimientoCaja",
                column: "CajaId",
                principalTable: "caja",
                principalColumn: "CajaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

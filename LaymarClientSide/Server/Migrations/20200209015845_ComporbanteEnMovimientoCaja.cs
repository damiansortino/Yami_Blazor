using Microsoft.EntityFrameworkCore.Migrations;

namespace LaymarClientSide.Server.Migrations
{
    public partial class ComporbanteEnMovimientoCaja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComprobanteId",
                table: "movimientoCaja",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_movimientoCaja_ComprobanteId",
                table: "movimientoCaja",
                column: "ComprobanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_movimientoCaja_comprobante_ComprobanteId",
                table: "movimientoCaja",
                column: "ComprobanteId",
                principalTable: "comprobante",
                principalColumn: "ComprobanteId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimientoCaja_comprobante_ComprobanteId",
                table: "movimientoCaja");

            migrationBuilder.DropIndex(
                name: "IX_movimientoCaja_ComprobanteId",
                table: "movimientoCaja");

            migrationBuilder.DropColumn(
                name: "ComprobanteId",
                table: "movimientoCaja");
        }
    }
}

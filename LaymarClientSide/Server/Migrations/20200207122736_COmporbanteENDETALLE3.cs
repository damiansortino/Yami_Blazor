using Microsoft.EntityFrameworkCore.Migrations;

namespace LaymarClientSide.Server.Migrations
{
    public partial class COmporbanteENDETALLE3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComprobanteId",
                table: "detalleFactura",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_detalleFactura_ComprobanteId",
                table: "detalleFactura",
                column: "ComprobanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_detalleFactura_comprobante_ComprobanteId",
                table: "detalleFactura",
                column: "ComprobanteId",
                principalTable: "comprobante",
                principalColumn: "ComprobanteId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detalleFactura_comprobante_ComprobanteId",
                table: "detalleFactura");

            migrationBuilder.DropIndex(
                name: "IX_detalleFactura_ComprobanteId",
                table: "detalleFactura");

            migrationBuilder.DropColumn(
                name: "ComprobanteId",
                table: "detalleFactura");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace LaymarClientSide.Server.Migrations
{
    public partial class removeStateComprobante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comprobante_estadoComprobante_EstadoComprobanteId",
                table: "comprobante");

            migrationBuilder.DropIndex(
                name: "IX_comprobante_EstadoComprobanteId",
                table: "comprobante");

            migrationBuilder.DropColumn(
                name: "EstadoComprobanteId",
                table: "comprobante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstadoComprobanteId",
                table: "comprobante",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_comprobante_EstadoComprobanteId",
                table: "comprobante",
                column: "EstadoComprobanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_comprobante_estadoComprobante_EstadoComprobanteId",
                table: "comprobante",
                column: "EstadoComprobanteId",
                principalTable: "estadoComprobante",
                principalColumn: "EstadoComprobanteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

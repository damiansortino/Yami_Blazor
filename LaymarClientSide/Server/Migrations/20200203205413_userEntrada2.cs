using Microsoft.EntityFrameworkCore.Migrations;

namespace LaymarClientSide.Server.Migrations
{
    public partial class userEntrada2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userEntradas_sucursal_SucursalId",
                table: "userEntradas");

            migrationBuilder.DropColumn(
                name: "SucusalId",
                table: "userEntradas");

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "userEntradas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_userEntradas_sucursal_SucursalId",
                table: "userEntradas",
                column: "SucursalId",
                principalTable: "sucursal",
                principalColumn: "SucursalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userEntradas_sucursal_SucursalId",
                table: "userEntradas");

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "userEntradas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SucusalId",
                table: "userEntradas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_userEntradas_sucursal_SucursalId",
                table: "userEntradas",
                column: "SucursalId",
                principalTable: "sucursal",
                principalColumn: "SucursalId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

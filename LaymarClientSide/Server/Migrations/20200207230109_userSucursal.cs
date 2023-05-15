using Microsoft.EntityFrameworkCore.Migrations;

namespace LaymarClientSide.Server.Migrations
{
    public partial class userSucursal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userSucursal",
                columns: table => new
                {
                    UserSucursalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(nullable: true),
                    SucursalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userSucursal", x => x.UserSucursalId);
                    table.ForeignKey(
                        name: "FK_userSucursal_sucursal_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "sucursal",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userSucursal_SucursalId",
                table: "userSucursal",
                column: "SucursalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userSucursal");
        }
    }
}

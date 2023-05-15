using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace LaymarClientSide.Server.Migrations
{
    public partial class entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "estadoComprobante",
                columns: table => new
                {
                    EstadoComprobanteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreEstadoComprobante = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadoComprobante", x => x.EstadoComprobanteId);
                });

            migrationBuilder.CreateTable(
                name: "personaJuridica",
                columns: table => new
                {
                    PersonaJuridicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cuit = table.Column<string>(nullable: true),
                    razonSocial = table.Column<string>(nullable: false),
                    nombreFantasia = table.Column<string>(nullable: true),
                    direccion1 = table.Column<string>(nullable: true),
                    direccion2 = table.Column<string>(nullable: true),
                    numeroTelefono1 = table.Column<string>(nullable: true),
                    numeroTelefono2 = table.Column<string>(nullable: true),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    fechaBaja = table.Column<DateTime>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    ClienteId = table.Column<string>(nullable: true),
                    ProveedorId = table.Column<string>(nullable: true),
                    porcentajeRentabilidad = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personaJuridica", x => x.PersonaJuridicaId);
                });

            migrationBuilder.CreateTable(
                name: "sucursal",
                columns: table => new
                {
                    SucursalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreSucursal = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sucursal", x => x.SucursalId);
                });

            migrationBuilder.CreateTable(
                name: "tipoComprobante",
                columns: table => new
                {
                    TipoComprobanteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTipoComprobante = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoComprobante", x => x.TipoComprobanteId);
                });

            migrationBuilder.CreateTable(
                name: "tipoMovimientoCaja",
                columns: table => new
                {
                    TipoMovimientoCajaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTipoMovimientoCaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoMovimientoCaja", x => x.TipoMovimientoCajaId);
                });

            migrationBuilder.CreateTable(
                name: "tipoMovimientoStock",
                columns: table => new
                {
                    TipoMovimientoStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTipoMovimientoStock = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoMovimientoStock", x => x.TipoMovimientoStockId);
                });

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    ProductoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(nullable: true),
                    precioUnitario = table.Column<double>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    fechaBaja = table.Column<DateTime>(nullable: true),
                    porcentajeRentabilidad = table.Column<double>(nullable: false),
                    talle = table.Column<string>(nullable: true),
                    color = table.Column<string>(nullable: true),
                    marca = table.Column<string>(nullable: true),
                    ProveedorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_producto_personaJuridica_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "personaJuridica",
                        principalColumn: "PersonaJuridicaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "caja",
                columns: table => new
                {
                    CajaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaCaja = table.Column<DateTime>(nullable: false),
                    fechaCierreCaja = table.Column<DateTime>(nullable: true),
                    montoCaja = table.Column<double>(nullable: false),
                    SucursalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caja", x => x.CajaId);
                    table.ForeignKey(
                        name: "FK_caja_sucursal_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "sucursal",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comprobante",
                columns: table => new
                {
                    ComprobanteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(nullable: true),
                    importe = table.Column<double>(nullable: false),
                    bonificacion = table.Column<double>(nullable: false),
                    fechaComprobante = table.Column<DateTime>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    fechaBaja = table.Column<DateTime>(nullable: false),
                    PersonaJuridicaId = table.Column<int>(nullable: false),
                    EstadoComprobanteId = table.Column<int>(nullable: false),
                    TipoComprobanteId = table.Column<int>(nullable: false),
                    SucursalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comprobante", x => x.ComprobanteId);
                    table.ForeignKey(
                        name: "FK_comprobante_estadoComprobante_EstadoComprobanteId",
                        column: x => x.EstadoComprobanteId,
                        principalTable: "estadoComprobante",
                        principalColumn: "EstadoComprobanteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comprobante_personaJuridica_PersonaJuridicaId",
                        column: x => x.PersonaJuridicaId,
                        principalTable: "personaJuridica",
                        principalColumn: "PersonaJuridicaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comprobante_sucursal_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "sucursal",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comprobante_tipoComprobante_TipoComprobanteId",
                        column: x => x.TipoComprobanteId,
                        principalTable: "tipoComprobante",
                        principalColumn: "TipoComprobanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalleFactura",
                columns: table => new
                {
                    DetalleFacturaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidad = table.Column<int>(nullable: false),
                    subtotal = table.Column<double>(nullable: false),
                    bonificacion = table.Column<double>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    fechaBaja = table.Column<DateTime>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleFactura", x => x.DetalleFacturaId);
                    table.ForeignKey(
                        name: "FK_detalleFactura_producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "producto",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stock",
                columns: table => new
                {
                    StockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidad = table.Column<int>(nullable: false),
                    SucursalId = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_stock_producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "producto",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stock_sucursal_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "sucursal",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movimientoCaja",
                columns: table => new
                {
                    MovimientoCajaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    entra = table.Column<bool>(nullable: false),
                    sale = table.Column<bool>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    fechaBaja = table.Column<DateTime>(nullable: false),
                    fechaIngreso = table.Column<DateTime>(nullable: false),
                    importe = table.Column<double>(nullable: false),
                    observaciones = table.Column<string>(nullable: true),
                    tipoMovimientoCajaId = table.Column<int>(nullable: false),
                    CajaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimientoCaja", x => x.MovimientoCajaId);
                    table.ForeignKey(
                        name: "FK_movimientoCaja_caja_CajaId",
                        column: x => x.CajaId,
                        principalTable: "caja",
                        principalColumn: "CajaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_movimientoCaja_tipoMovimientoCaja_tipoMovimientoCajaId",
                        column: x => x.tipoMovimientoCajaId,
                        principalTable: "tipoMovimientoCaja",
                        principalColumn: "TipoMovimientoCajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movimientoStock",
                columns: table => new
                {
                    MovimientoStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidad = table.Column<int>(nullable: false),
                    entra = table.Column<bool>(nullable: false),
                    sale = table.Column<bool>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    fechaBaja = table.Column<DateTime>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    StockId = table.Column<int>(nullable: false),
                    ComprobanteId = table.Column<int>(nullable: true),
                    TipoMovimientoStockId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimientoStock", x => x.MovimientoStockId);
                    table.ForeignKey(
                        name: "FK_movimientoStock_comprobante_ComprobanteId",
                        column: x => x.ComprobanteId,
                        principalTable: "comprobante",
                        principalColumn: "ComprobanteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_movimientoStock_stock_StockId",
                        column: x => x.StockId,
                        principalTable: "stock",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movimientoStock_tipoMovimientoStock_TipoMovimientoStockId",
                        column: x => x.TipoMovimientoStockId,
                        principalTable: "tipoMovimientoStock",
                        principalColumn: "TipoMovimientoStockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_caja_SucursalId",
                table: "caja",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_comprobante_EstadoComprobanteId",
                table: "comprobante",
                column: "EstadoComprobanteId");

            migrationBuilder.CreateIndex(
                name: "IX_comprobante_PersonaJuridicaId",
                table: "comprobante",
                column: "PersonaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_comprobante_SucursalId",
                table: "comprobante",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_comprobante_TipoComprobanteId",
                table: "comprobante",
                column: "TipoComprobanteId");

            migrationBuilder.CreateIndex(
                name: "IX_detalleFactura_ProductoId",
                table: "detalleFactura",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_movimientoCaja_CajaId",
                table: "movimientoCaja",
                column: "CajaId");

            migrationBuilder.CreateIndex(
                name: "IX_movimientoCaja_tipoMovimientoCajaId",
                table: "movimientoCaja",
                column: "tipoMovimientoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_movimientoStock_ComprobanteId",
                table: "movimientoStock",
                column: "ComprobanteId");

            migrationBuilder.CreateIndex(
                name: "IX_movimientoStock_StockId",
                table: "movimientoStock",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_movimientoStock_TipoMovimientoStockId",
                table: "movimientoStock",
                column: "TipoMovimientoStockId");

            migrationBuilder.CreateIndex(
                name: "IX_producto_ProveedorId",
                table: "producto",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_stock_ProductoId",
                table: "stock",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_stock_SucursalId",
                table: "stock",
                column: "SucursalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleFactura");

            migrationBuilder.DropTable(
                name: "movimientoCaja");

            migrationBuilder.DropTable(
                name: "movimientoStock");

            migrationBuilder.DropTable(
                name: "caja");

            migrationBuilder.DropTable(
                name: "tipoMovimientoCaja");

            migrationBuilder.DropTable(
                name: "comprobante");

            migrationBuilder.DropTable(
                name: "stock");

            migrationBuilder.DropTable(
                name: "tipoMovimientoStock");

            migrationBuilder.DropTable(
                name: "estadoComprobante");

            migrationBuilder.DropTable(
                name: "tipoComprobante");

            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "sucursal");

            migrationBuilder.DropTable(
                name: "personaJuridica");
        }
    }
}

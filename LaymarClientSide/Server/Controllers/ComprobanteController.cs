using LaymarClientSide.Server.Context;
using LaymarClientSide.Shared.Dtos;
using LaymarClientSide.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LaymarClientSide.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComprobanteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Comprobante
        [HttpGet("ListarVentas/{sucursalId}/{userName}/{fechaDesde}/{fechaHasta}")]
        public async Task<ActionResult<List<FacturaDto>>> ListarVentas(int sucursalId, string userName, string fechaDesde, string fechaHasta)
        {

            List<FacturaDto> ventasDto = new List<FacturaDto>();
            List<Comprobante> comprobantes = new List<Comprobante>();
            DateTime _fechaDesde = Convert.ToDateTime(fechaDesde);
            DateTime _fechaHasta = Convert.ToDateTime(fechaHasta).AddHours(24);

            if (userName == "TODOS" && sucursalId != 0)
            {
                comprobantes = await _context.comprobante.Where(x => x.SucursalId == sucursalId && x.fechaAlta > _fechaDesde && x.fechaAlta < _fechaHasta && x.fechaBaja == null && x.tipoComprobante.nombreTipoComprobante == "Venta")
                     .Include(x => x.personaJuridica).Include(x => x.sucursal).ToListAsync();
            }
            else if (sucursalId == 0 && userName != "TODOS")
            {
                comprobantes = await _context.comprobante.Where(x => x.UserName == userName && x.fechaAlta > _fechaDesde && x.fechaAlta < _fechaHasta && x.fechaBaja == null && x.tipoComprobante.nombreTipoComprobante == "Venta" && x.sucursal.fechaBaja == null)
                .Include(x => x.personaJuridica).Include(x => x.sucursal).ToListAsync();

            }
            else if (sucursalId == 0 && userName == "TODOS")
            {
                comprobantes = await _context.comprobante.Where(x => x.fechaAlta > _fechaDesde && x.fechaAlta < _fechaHasta && x.fechaBaja == null && x.tipoComprobante.nombreTipoComprobante == "Venta" && x.sucursal.fechaBaja == null)
               .Include(x => x.personaJuridica).Include(x => x.sucursal).ToListAsync();
            }
            else
            {

                comprobantes = await _context.comprobante.Where(x => x.sucursal.SucursalId == sucursalId && x.UserName == userName && x.fechaAlta > _fechaDesde && x.fechaAlta < _fechaHasta && x.fechaBaja == null && x.tipoComprobante.nombreTipoComprobante == "Venta")
                  .Include(x => x.personaJuridica).Include(x => x.sucursal).ToListAsync();

            }

            foreach (Comprobante comprobante in comprobantes)
            {

                ventasDto.Add(new FacturaDto
                {
                    comprobante = comprobante,
                    detalles = await _context.detalleFactura.Where(x => x.ComprobanteId == comprobante.ComprobanteId).Include(x => x.producto).ToListAsync()
                });

            }
            return ventasDto;
        }
        [HttpGet("ListarVentasTarjeta/{fechaDesde}/{fechaHasta}")]
        public async Task<ActionResult<List<FacturaDto>>> ListarVentasTarjeta(string fechaDesde, string fechaHasta)
        {

            List<FacturaDto> ventasDto = new List<FacturaDto>();

            List<Comprobante> comprobantes = new List<Comprobante>();
            DateTime _fechaDesde = Convert.ToDateTime(fechaDesde);
            DateTime _fechaHasta = Convert.ToDateTime(fechaHasta).AddHours(24);

            comprobantes = await _context.comprobante.Where(x => x.tarjeta != 0 && x.fechaAlta > _fechaDesde && x.fechaAlta < _fechaHasta && x.fechaBaja == null && x.tipoComprobante.nombreTipoComprobante == "Venta" && x.sucursal.fechaBaja == null)
                .Include(x => x.personaJuridica).Include(x => x.sucursal).ToListAsync();

            foreach (Comprobante comprobante in comprobantes)
            {

                ventasDto.Add(new FacturaDto
                {
                    comprobante = comprobante,
                    detalles = await _context.detalleFactura.Where(x => x.ComprobanteId == comprobante.ComprobanteId).Include(x => x.producto).ToListAsync()
                });

            }
            return ventasDto;

        }

        [HttpGet("ListarCompras/{sucursalId}/{userName}/{fechaDesde}/{fechaHasta}")]
        public async Task<ActionResult<List<FacturaDto>>> ListarCompras(int sucursalId, string userName, string fechaDesde, string fechaHasta)
        {

            List<FacturaDto> compraDto = new List<FacturaDto>();

            List<Comprobante> comprobantes = new List<Comprobante>();
            DateTime _fechaDesde = Convert.ToDateTime(fechaDesde);
            DateTime _fechaHasta = Convert.ToDateTime(fechaHasta).AddHours(24);

            comprobantes = await _context.comprobante.Where(x => x.SucursalId == sucursalId && x.UserName == userName && x.fechaAlta > _fechaDesde && x.fechaAlta < _fechaHasta && x.fechaBaja == null && x.tipoComprobante.nombreTipoComprobante == "Compra")
                .Include(x => x.personaJuridica).Include(x => x.sucursal).ToListAsync();

            foreach (Comprobante comprobante in comprobantes)
            {

                compraDto.Add(new FacturaDto
                {
                    comprobante = comprobante,
                    detalles = await _context.detalleFactura.Where(x => x.ComprobanteId == comprobante.ComprobanteId).Include(x => x.producto).ToListAsync()
                });

            }


            return compraDto;

        }




        //// GET: api/Comprobante/5
        //[HttpGet("Buscar/{id}")]
        //public async Task<ActionResult<Comprobante>> GetComprobante(int id)
        //{
        //    var comprobante = await _context.comprobante.FindAsync(id);

        //    if (comprobante == null)
        //    {
        //        return NotFound();
        //    }

        //    return comprobante;
        //}


        [HttpPost("CrearVenta")]
        public async Task<Comprobante> CrearVenta(FacturaDto venta)
        {
            try
            {
                //CREACION COMPROBANTE
                string codigo = "XV";
                string sucursalCodigo = Convert.ToString(venta.comprobante.sucursal.SucursalId);
                string numeroComprobante = Convert.ToString(_context.comprobante.Where(x => x.sucursal == venta.comprobante.sucursal && x.tipoComprobante.nombreTipoComprobante == "Venta").Count() + 1);
                for (int i = 0; i < (3 - sucursalCodigo.Length); i++)
                {
                    codigo = codigo + "0";
                }
                codigo = codigo + sucursalCodigo + "-";
                for (int i = 0; i < (6 - numeroComprobante.Length); i++)
                {
                    codigo = codigo + "0";
                }
                codigo = codigo + numeroComprobante;

                venta.comprobante.codigo = codigo;
                venta.comprobante.sucursal = await _context.sucursal.FindAsync(venta.comprobante.sucursal.SucursalId);
                venta.comprobante.personaJuridica = await _context.personaJuridica.FindAsync(venta.comprobante.personaJuridica.PersonaJuridicaId);
                venta.comprobante.tipoComprobante = await _context.tipoComprobante.Where(x => x.nombreTipoComprobante == "Venta").FirstAsync();
                _context.comprobante.Add(venta.comprobante);
                await _context.SaveChangesAsync();

                //CREACION DE LOS DETALLES
                TipoMovimientoStock tipoMovimiento = await _context.tipoMovimientoStock.Where(x => x.nombreTipoMovimientoStock == "Venta").FirstAsync();
                Stock stock;

                foreach (DetalleFactura detalle in venta.detalles)
                {
                    detalle.comprobante = await _context.comprobante.FindAsync(venta.comprobante.ComprobanteId);
                    detalle.producto = await _context.producto.FindAsync(detalle.producto.ProductoId);
                    _context.detalleFactura.Add(detalle);
                    await _context.SaveChangesAsync();


                    //CREACION DEL MOVIMIENTO DE STOCK
                    try
                    {
                        stock = await _context.stock.Where(x => x.ProductoId == detalle.ProductoId && x.SucursalId == venta.comprobante.SucursalId).FirstAsync();

                    }
                    catch (Exception)
                    {
                        stock = new Stock { cantidad = 0, sucursal = venta.comprobante.sucursal, producto = await _context.producto.FindAsync(detalle.producto.ProductoId) };
                        _context.stock.Add(stock);
                        await _context.SaveChangesAsync();
                    }
                    stock.cantidad -= detalle.cantidad;
                    _context.movimientoStock.Add(new MovimientoStock { sale = true, cantidad = detalle.cantidad, entra = false, stock = stock, tipoMovimientoStock = tipoMovimiento, comprobante = venta.comprobante });

                    await _context.SaveChangesAsync();

                }

                //CREACION MOVIMIENTO CAJA
                if (venta.comprobante.efectivo > 0)
                {
                    string fecha = DateTime.Now.AddHours(-3).ToString("dd/MM/yyyy");
                    List<Caja> cajas = await _context.caja.Where(x => x.SucursalId == venta.comprobante.sucursal.SucursalId).ToListAsync();

                    MovimientoCaja movimiento = new MovimientoCaja
                    {

                        caja = cajas.Where(x => x.fechaCaja.ToString("dd/MM/yyyy") == fecha).First(),
                        importe = venta.comprobante.efectivo,
                        entra = true,
                        sale = false,
                        comprobante = venta.comprobante,
                        tipoMovimientoCaja = await _context.tipoMovimientoCaja.Where(x => x.nombreTipoMovimientoCaja == "Venta").FirstAsync()


                    };
                    movimiento.caja.montoCaja += venta.comprobante.efectivo;
                    _context.movimientoCaja.Add(movimiento);

                }

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw;
            }


            return venta.comprobante;
        }
        [HttpPost("CrearCompra")]
        public async Task<Comprobante> CrearCompra(FacturaDto compra)
        {
            try
            {
                //CREACION COMPROBANTE
                string codigo = "XC";
                string sucursalCodigo = Convert.ToString(compra.comprobante.sucursal.SucursalId);

                string numeroComprobante = Convert.ToString(_context.comprobante.Where(x => x.sucursal == compra.comprobante.sucursal && x.tipoComprobante.nombreTipoComprobante == "Compra").Count() + 1);
                for (int i = 0; i < (3 - sucursalCodigo.Length); i++)
                {
                    codigo = codigo + "0";
                }
                codigo = codigo + sucursalCodigo + "-";
                for (int i = 0; i < (6 - numeroComprobante.Length); i++)
                {
                    codigo = codigo + "0";
                }
                codigo = codigo + numeroComprobante;

                compra.comprobante.codigo = codigo;
                compra.comprobante.sucursal = await _context.sucursal.FindAsync(compra.comprobante.sucursal.SucursalId);
                compra.comprobante.personaJuridica = await _context.personaJuridica.FindAsync(compra.comprobante.personaJuridica.PersonaJuridicaId);
                compra.comprobante.tipoComprobante = await _context.tipoComprobante.Where(x => x.nombreTipoComprobante == "Compra").FirstAsync();
                _context.comprobante.Add(compra.comprobante);
                await _context.SaveChangesAsync();

                //CREACION DE LOS DETALLES
                TipoMovimientoStock tipoMovimiento = await _context.tipoMovimientoStock.Where(x => x.nombreTipoMovimientoStock == "Compra").FirstAsync();
                Stock stock;

                foreach (DetalleFactura detalle in compra.detalles)
                {
                    detalle.comprobante = await _context.comprobante.FindAsync(compra.comprobante.ComprobanteId);
                    detalle.producto = await _context.producto.FindAsync(detalle.producto.ProductoId);

                    _context.detalleFactura.Add(detalle);
                    await _context.SaveChangesAsync();


                    //CREACION DEL MOVIMIENTO DE STOCK
                    try
                    {
                        stock = await _context.stock.Where(x => x.ProductoId == detalle.ProductoId && x.SucursalId == compra.comprobante.SucursalId).FirstAsync();

                    }
                    catch (Exception)
                    {
                        stock = new Stock { cantidad = 0, sucursal = compra.comprobante.sucursal, producto = await _context.producto.FindAsync(detalle.producto.ProductoId) };
                        _context.stock.Add(stock);
                        await _context.SaveChangesAsync();
                    }
                    stock.cantidad += detalle.cantidad;
                    _context.movimientoStock.Add(new MovimientoStock { sale = false, cantidad = detalle.cantidad, entra = true, stock = stock, tipoMovimientoStock = tipoMovimiento, comprobante = compra.comprobante });

                    await _context.SaveChangesAsync();

                }


                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw;
            }


            return compra.comprobante;
        }
        [HttpDelete("AnularVenta/{id}")]
        public async Task<ActionResult<Comprobante>> AnularVenta(int id)
        {
            Comprobante comprobante = await _context.comprobante.FindAsync(id);
            List<DetalleFactura> detalles = await _context.detalleFactura.Where(x => x.comprobante.ComprobanteId == comprobante.ComprobanteId).ToListAsync();
            List<MovimientoStock> movimientoStocks = await _context.movimientoStock.Where(x => x.comprobante.ComprobanteId == comprobante.ComprobanteId).Include(x => x.stock).ToListAsync();
            List<MovimientoCaja> movimientosCaja = await _context.movimientoCaja.Where(x => x.comprobante.ComprobanteId == comprobante.ComprobanteId).Include(x => x.caja).ToListAsync();

            foreach (DetalleFactura detalle in detalles)
            {

                detalle.fechaBaja = DateTime.Now.AddHours(-3);
            }
            foreach (MovimientoStock movimientoStock in movimientoStocks)
            {

                movimientoStock.fechaBaja = DateTime.Now.AddHours(-3);
                movimientoStock.stock.cantidad += movimientoStock.cantidad;
            }
            foreach (MovimientoCaja movimientoCaja in movimientosCaja)
            {

                movimientoCaja.fechaBaja = DateTime.Now.AddHours(-3);
                movimientoCaja.caja.montoCaja -= movimientoCaja.importe;
            }

            comprobante.fechaBaja = DateTime.Now.AddHours(-3);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {


            }
            return comprobante;



        }



        [HttpDelete("AnularCompra/{id}")]
        public async Task<ActionResult<Comprobante>> AnularCompra(int id)
        {
            Comprobante comprobante = await _context.comprobante.FindAsync(id);
            List<DetalleFactura> detalles = await _context.detalleFactura.Where(x => x.comprobante == comprobante).ToListAsync();
            List<MovimientoStock> movimientoStocks = await _context.movimientoStock.Where(x => x.comprobante == comprobante).Include(x => x.stock).ToListAsync();

            foreach (DetalleFactura detalle in detalles)
            {
                detalle.fechaBaja = DateTime.Now.AddHours(-3);
            }

            foreach (MovimientoStock movimientoStock in movimientoStocks)
            {
                movimientoStock.fechaBaja = DateTime.Now.AddHours(-3);
                movimientoStock.stock.cantidad -= movimientoStock.cantidad;
            }


            comprobante.fechaBaja = DateTime.Now.AddHours(-3);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {


            }
            return comprobante;



        }

    }
}

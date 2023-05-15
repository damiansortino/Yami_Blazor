using LaymarClientSide.Server.Context;
using LaymarClientSide.Server.Helpers;
using LaymarClientSide.Shared;
using LaymarClientSide.Shared.Dtos;
using LaymarClientSide.Shared.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymarClientSide.Servicios
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("Listar")]

        public async Task<List<Stock>> Listar()
        {
            return await _context.stock.Where(x => x.producto.fechaBaja == null && x.sucursal.fechaBaja == null).Include(x => x.sucursal).Include(x => x.producto).ToListAsync();
        }
        [HttpGet("ListarPorProducto/{id}")]

        public async Task<List<Stock>> ListarPorProducto(int id)
        {
            List<Stock> stocks = new List<Stock>();

            try
            {
                stocks = await _context.stock.Where(x => x.producto.fechaBaja == null && x.ProductoId == id && x.sucursal.fechaBaja == null).Include(x => x.sucursal).ToListAsync();

            }
            catch (Exception ex)
            {

                throw;
            }
            return stocks;
        }


        [HttpGet("ListarTipoMovimientoStock")]
        public async Task<List<TipoMovimientoStock>> ListarTipoMovimientoStock()
        {
            return await _context.tipoMovimientoStock.ToListAsync();
        }
        [HttpGet("ListarMovimientoStock")]

        public async Task<List<MovimientoStock>> ListarMovimientoStock([FromQuery] Paginacion paginacion, string fechaDesde, string fechaHasta)
        {
            DateTime _fechaDesde = Convert.ToDateTime(fechaDesde);
            DateTime _fechaHasta = Convert.ToDateTime(fechaHasta);

            List<MovimientoStock> movimientos = new List<MovimientoStock>();
            var query = _context.movimientoStock.Where(x => x.stock.producto.fechaBaja == null && x.fechaBaja == null && x.stock.sucursal.fechaBaja == null && x.fechaAlta > _fechaDesde && x.fechaAlta < _fechaHasta.AddHours(24))
                .Include(x => x.tipoMovimientoStock)
                .Include(x => x.comprobante)
                .Include(x => x.stock).ThenInclude(x => x.producto)
                .Include(x => x.stock).ThenInclude(x => x.sucursal).OrderByDescending(x => x.MovimientoStockId)
               .AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(query, paginacion.CantidadRegistros);
            movimientos = await query.Paginar(paginacion).ToListAsync();

            return movimientos;
        }

        [HttpGet("ListarMovimientoStock/{id}")]

        public async Task<List<MovimientoStock>> ListarMovimientoStock([FromQuery] Paginacion paginacion, int cantidadDeRegistros, int id)
        {
            List<MovimientoStock> movimientos = new List<MovimientoStock>();
            var query = _context.movimientoStock.Where(x => x.stock.producto.fechaBaja == null
                                                        && x.StockId == id && x.stock.sucursal.fechaBaja == null)
                                                .Include(x => x.tipoMovimientoStock)
                                                .Include(x => x.comprobante)
                                                .Include(x => x.stock).ThenInclude(x => x.producto)
                                                .Include(x => x.stock).ThenInclude(x => x.sucursal)
                                                .AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(query, paginacion.CantidadRegistros);
            movimientos = await query.Paginar(paginacion).ToListAsync();
            return movimientos;
        }
        [HttpGet("Buscar")]

        public async Task<Stock> Buscar(int idProducto, int idSucursal)
        {
            var stock = await _context.stock.Where(x => x.ProductoId == idProducto && x.SucursalId == idSucursal).FirstAsync();

            if (stock == null)
            {
                return new Stock();
            }

            return stock;
        }
        [HttpPut("Editar")]

        public async Task<IActionResult> Edit(int id, Stock stock)
        {
            if (id != stock.StockId)
            {
                return BadRequest();
            }

            _context.Entry(stock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Existe(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StocksService
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("Crear")]

        public async Task<Stock> Crear(Stock stock)
        {
            _context.stock.Add(stock);
            await _context.SaveChangesAsync();

            return stock;
        }

        [HttpPost("CrearMovimiento")]

        public async Task<MovimientoStock> CrearMovimiento(MovimientoStockDto moviminetoDto)
        {
            try
            {
                moviminetoDto.movimiento.stock = await Buscar(moviminetoDto.producto.ProductoId, moviminetoDto.sucursal.SucursalId);
            }
            catch (Exception)
            {
                moviminetoDto.movimiento.stock = new Stock { cantidad = 0, sucursal = await _context.sucursal.FindAsync(moviminetoDto.sucursal.SucursalId), producto = await _context.producto.FindAsync(moviminetoDto.producto.ProductoId) };
                _context.stock.Add(moviminetoDto.movimiento.stock);
                await _context.SaveChangesAsync();
            }

            moviminetoDto.movimiento.tipoMovimientoStock = await _context.tipoMovimientoStock.Where(x => x.TipoMovimientoStockId == moviminetoDto.movimiento.tipoMovimientoStock.TipoMovimientoStockId).FirstAsync();
            if (moviminetoDto.movimiento.entra == true)
            {
                moviminetoDto.movimiento.stock.cantidad += moviminetoDto.movimiento.cantidad;
            }
            else
            {
                moviminetoDto.movimiento.stock.cantidad -= moviminetoDto.movimiento.cantidad;

            }

            try
            {
                _context.movimientoStock.Add(moviminetoDto.movimiento);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw;
            }

            return moviminetoDto.movimiento;
        }

        // DELETE: api/StocksService/5
        //public async Task<Stock> Anular(int id)
        //{
        //    var stock = await _context.stock.FindAsync(id);
        //    if (stock == null)
        //    {
        //        return null;
        //    }
        //    stock.fechaBaja = DateTime.Now.AddHours(-3);
        //    await Edit(stock.StockId, stock);

        //    return stock;
        //}
        [HttpGet("Existe")]

        private bool Existe(int id)
        {
            return _context.stock.Any(e => e.StockId == id);
        }


    }
}
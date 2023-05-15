using LaymarClientSide.Server.Context;
using LaymarClientSide.Shared.Dtos;
using LaymarClientSide.Shared.Entidades;
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
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("Listar")]

        public async Task<List<Producto>> Listar()
        {
            return await _context.producto.Include(x => x.proveedor).Where(x => x.fechaBaja == null).ToListAsync();
        }
        [HttpGet("Buscar")]

        public async Task<Producto> Buscar(int id)
        {
            var producto = await _context.producto.Where(x => x.ProductoId == id).Include(x => x.proveedor).FirstAsync();

            if (producto == null)
            {
                return null;
            }

            return producto;
        }

        [HttpPut("Editar/{id}")]

        public async Task<IActionResult> Edit(int id, [FromBody] Producto producto)
        {
            if (id != producto.ProductoId)
            {
                return BadRequest();
            }

            _context.Entry(producto).State = EntityState.Modified;

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
        [HttpPost("EditarPrecios")]
        public async Task<IActionResult> EditarPrecios(List<Producto> productos)
        {
            foreach (Producto producto in productos)
            {
                _context.Entry(producto).State = EntityState.Modified;

            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return NoContent();
        }


        // POST: api/ProductosService
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD
        [HttpPost("Crear")]
        public async Task<Producto> Crear(ProductoDto productoDto)
        {
            try
            {
                productoDto.producto.proveedor = await _context.proveedor.FindAsync(productoDto.producto.proveedor.PersonaJuridicaId);
                _context.producto.Add(productoDto.producto);

                await _context.SaveChangesAsync();

                string productoCodigo = "";
                for (int i = 0; i < 8 - Convert.ToInt32((Convert.ToString(productoDto.producto.ProductoId).Length)); i++)
                {
                    productoCodigo = productoCodigo + "0";
                }

                productoCodigo = productoCodigo + Convert.ToString(productoDto.producto.ProductoId);

                productoDto.producto.codigo = productoCodigo;

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw;
            }

            //CREACION STOCKS
            TipoMovimientoStock MovimientoInicial = await _context.tipoMovimientoStock.Where(x => x.TipoMovimientoStockId == 1).FirstAsync(); // 1 = Carga Inicial            

            foreach (Stock stock in productoDto.stocks)
            {
                stock.producto = productoDto.producto;
                stock.sucursal = await _context.sucursal.FindAsync(stock.sucursal.SucursalId);
                _context.stock.Add(stock);
                await _context.SaveChangesAsync();

                _context.movimientoStock.Add(new MovimientoStock { stock = stock, sale = false, entra = true, cantidad = stock.cantidad, tipoMovimientoStock = MovimientoInicial });
                await _context.SaveChangesAsync();

            }

            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }

            return productoDto.producto;
        }

        // DELETE: api/ProductosService/5
        [HttpDelete("Anular/{id}")]

        public async Task<Producto> Anular(int id)
        {
            var producto = await _context.producto.FindAsync(id);

            producto.fechaBaja = DateTime.Now.AddHours(-3);
            await _context.SaveChangesAsync();
            return producto;
        }
        [HttpGet("Existe")]

        private bool Existe(int id)
        {
            return _context.producto.Any(e => e.ProductoId == id);
        }


    }
}

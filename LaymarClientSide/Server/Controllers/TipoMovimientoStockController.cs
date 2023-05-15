using LaymarClientSide.Server.Context;
using LaymarClientSide.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymarClientSide.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoMovimientoStockController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TipoMovimientoStockController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoMovimientoStock
        [HttpGet("Listar")]
        public async Task<ActionResult<IEnumerable<TipoMovimientoStock>>> GettipoMovimientoStock()
        {
            return await _context.tipoMovimientoStock.ToListAsync();
        }

        // GET: api/TipoMovimientoStock/5
        [HttpGet("Buscar/{id}")]
        public async Task<ActionResult<TipoMovimientoStock>> GetTipoMovimientoStock(int id)
        {
            var tipoMovimientoStock = await _context.tipoMovimientoStock.FindAsync(id);

            if (tipoMovimientoStock == null)
            {
                return NotFound();
            }

            return tipoMovimientoStock;
        }

        // PUT: api/TipoMovimientoStock/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("Editar/{id}")]
        public async Task<IActionResult> PutTipoMovimientoStock(int id, TipoMovimientoStock tipoMovimientoStock)
        {
            if (id != tipoMovimientoStock.TipoMovimientoStockId)
            {
                return BadRequest();
            }

            _context.Entry(tipoMovimientoStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoMovimientoStockExists(id))
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

        // POST: api/TipoMovimientoStock
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("Crear")]
        public async Task<ActionResult<TipoMovimientoStock>> PostTipoMovimientoStock(TipoMovimientoStock tipoMovimientoStock)
        {
            _context.tipoMovimientoStock.Add(tipoMovimientoStock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoMovimientoStock", new { id = tipoMovimientoStock.TipoMovimientoStockId }, tipoMovimientoStock);
        }

        // DELETE: api/TipoMovimientoStock/5
        [HttpDelete("Anular/{id}")]
        public async Task<ActionResult<TipoMovimientoStock>> DeleteTipoMovimientoStock(int id)
        {
            var tipoMovimientoStock = await _context.tipoMovimientoStock.FindAsync(id);
            if (tipoMovimientoStock == null)
            {
                return NotFound();
            }

            _context.tipoMovimientoStock.Remove(tipoMovimientoStock);
            await _context.SaveChangesAsync();

            return tipoMovimientoStock;
        }

        private bool TipoMovimientoStockExists(int id)
        {
            return _context.tipoMovimientoStock.Any(e => e.TipoMovimientoStockId == id);
        }
    }
}

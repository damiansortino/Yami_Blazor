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
    public class TipoMovimientoCajaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TipoMovimientoCajaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoMovimientoCaja
        [HttpGet("Listar")]
        public async Task<ActionResult<IEnumerable<TipoMovimientoCaja>>> GettipoMovimientoCaja()
        {
            return await _context.tipoMovimientoCaja.ToListAsync();
        }

        // GET: api/TipoMovimientoCaja/5
        [HttpGet("Buscar/{id}")]
        public async Task<ActionResult<TipoMovimientoCaja>> GetTipoMovimientoCaja(int id)
        {
            var tipoMovimientoCaja = await _context.tipoMovimientoCaja.FindAsync(id);

            if (tipoMovimientoCaja == null)
            {
                return NotFound();
            }

            return tipoMovimientoCaja;
        }

        // PUT: api/TipoMovimientoCaja/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("Editar/{id}")]
        public async Task<IActionResult> PutTipoMovimientoCaja(int id, TipoMovimientoCaja tipoMovimientoCaja)
        {
            if (id != tipoMovimientoCaja.TipoMovimientoCajaId)
            {
                return BadRequest();
            }

            _context.Entry(tipoMovimientoCaja).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoMovimientoCajaExists(id))
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

        // POST: api/TipoMovimientoCaja
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("Crear")]
        public async Task<ActionResult<TipoMovimientoCaja>> PostTipoMovimientoCaja(TipoMovimientoCaja tipoMovimientoCaja)
        {
            _context.tipoMovimientoCaja.Add(tipoMovimientoCaja);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoMovimientoCaja", new { id = tipoMovimientoCaja.TipoMovimientoCajaId }, tipoMovimientoCaja);
        }

        // DELETE: api/TipoMovimientoCaja/5
        [HttpDelete("Anular/{id}")]
        public async Task<ActionResult<TipoMovimientoCaja>> DeleteTipoMovimientoCaja(int id)
        {
            var tipoMovimientoCaja = await _context.tipoMovimientoCaja.FindAsync(id);
            if (tipoMovimientoCaja == null)
            {
                return NotFound();
            }

            _context.tipoMovimientoCaja.Remove(tipoMovimientoCaja);
            await _context.SaveChangesAsync();

            return tipoMovimientoCaja;
        }

        private bool TipoMovimientoCajaExists(int id)
        {
            return _context.tipoMovimientoCaja.Any(e => e.TipoMovimientoCajaId == id);
        }
    }
}

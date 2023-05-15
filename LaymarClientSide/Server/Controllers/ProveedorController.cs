using LaymarClientSide.Server.Context;
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
    public class ProveedorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProveedorController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("Listar")]

        public async Task<List<Proveedor>> Listar()
        {
            return await _context.proveedor.Where(x => x.fechaBaja == null).ToListAsync();
        }
        [HttpGet("Buscar")]

        public async Task<Proveedor> Buscar(string id)
        {
            var proveedor = await _context.proveedor.Where(x => x.ProveedorId == id).FirstAsync();

            if (proveedor == null)
            {
                return null;
            }

            return proveedor;
        }

        [HttpPut("Editar/{id}")]

        public async Task<IActionResult> Edit(int id, Proveedor proveedor)
        {
            if (id != proveedor.PersonaJuridicaId)
            {
                return BadRequest();
            }

            _context.Entry(proveedor).State = EntityState.Modified;

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

        // POST: api/ClientesService
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("Crear")]

        public async Task<Proveedor> Crear(Proveedor proveedor)
        {
            _context.proveedor.Add(proveedor);
            await _context.SaveChangesAsync();

            return proveedor;
        }
        [HttpDelete("Anular/{id}")]

        // DELETE: api/ClientesService/5
        public async Task<Proveedor> Anular(int id)
        {
            var proveedor = await _context.proveedor.FindAsync(id);
            if (proveedor == null)
            {
                return null;
            }
            proveedor.fechaBaja = DateTime.Now.AddHours(-3);
            await Edit(proveedor.PersonaJuridicaId, proveedor);

            return proveedor;
        }
        [HttpGet("Existe")]

        private bool Existe(int id)
        {
            return _context.proveedor.Any(e => e.PersonaJuridicaId == id);
        }
    }
}

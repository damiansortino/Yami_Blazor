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
    public class SucursalController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SucursalController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("Listar")]

        public async Task<List<Sucursal>> Listar()
        {
            return await _context.sucursal.Where(x => x.fechaBaja == null).ToListAsync();
        }
        [HttpGet("Buscar")]

        public async Task<Sucursal> Buscar(int id)
        {
            var sucursal = await _context.sucursal.Where(x => x.SucursalId == id).FirstAsync();

            if (sucursal == null)
            {
                return null;
            }

            return sucursal;
        }

        [HttpPut("Editar/{id}")]

        public async Task<IActionResult> Edit(int id, Sucursal sucursal)
        {
            if (id != sucursal.SucursalId)
            {
                return BadRequest();
            }

            _context.Entry(sucursal).State = EntityState.Modified;

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

        // POST: api/SucursalsService
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("Crear")]

        public async Task<Sucursal> Crear(Sucursal sucursal)
        {
            _context.sucursal.Add(sucursal);
            await _context.SaveChangesAsync();

            return sucursal;
        }

        [HttpDelete("Anular/{id}")]
        // DELETE: api/ClientesService/5
        public async Task<Sucursal> Anular(int id)
        {
            var sucursal = await _context.sucursal.FindAsync(id);
            if (sucursal == null)
            {
                return null;
            }
            sucursal.fechaBaja = DateTime.Now.AddHours(-3);
            await Edit(sucursal.SucursalId, sucursal);

            return sucursal;
        }
        [HttpGet("Existe")]

        private bool Existe(int id)
        {
            return _context.sucursal.Any(e => e.SucursalId == id);
        }


    }
}
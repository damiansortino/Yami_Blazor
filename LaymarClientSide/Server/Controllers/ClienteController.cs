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
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("Listar")]

        public async Task<List<Cliente>> Listar()
        {
            return await _context.cliente.Where(x => x.fechaBaja == null).ToListAsync();
        }
        [HttpGet("Buscar")]

        public async Task<Cliente> Buscar(string id)
        {
            var cliente = await _context.cliente.Where(x => x.ClienteId == id).FirstAsync();

            if (cliente == null)
            {
                return null;
            }

            return cliente;
        }

        [HttpPut("Editar/{id}")]

        public async Task<IActionResult> Edit(int id, [FromBody] Cliente cliente)
        {
            if (id != cliente.PersonaJuridicaId)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;

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

        public async Task<Cliente> Crear([FromBody] Cliente cliente)
        {
            _context.cliente.Add(cliente);
            await _context.SaveChangesAsync();

            return cliente;
        }
        [HttpDelete("Anular/{id}")]
        // DELETE: api/ClientesService/5
        public async Task<Cliente> Anular(int id)
        {
            var cliente = await _context.cliente.FindAsync(id);
            if (cliente == null)
            {
                return null;
            }
            cliente.fechaBaja = DateTime.Now.AddHours(-3);
            await Edit(cliente.PersonaJuridicaId, cliente);

            return cliente;
        }
        [HttpGet("Existe")]

        private bool Existe(int id)
        {
            return _context.cliente.Any(e => e.PersonaJuridicaId == id);
        }


    }
}

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

    public class CajaController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public CajaController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("Listar")]

        public async Task<List<Caja>> Listar()
        {
            return await _context.caja.Include(y => y.sucursal).ToListAsync();

        }

        [HttpGet("ListarMovimientos/{id}")]

        public async Task<List<MovimientoCaja>> ListarMovimientos(int id)
        {
            return await _context.movimientoCaja.Where(x => x.CajaId == id).Include(x => x.comprobante).Include(x => x.caja).Include(y => y.tipoMovimientoCaja).ToListAsync();
        }
        [HttpGet("Buscar")]

        public async Task<Caja> Buscar(int id)
        {
            var caja = await _context.caja.Where(x => x.CajaId == id).Include(y => y.sucursal).FirstAsync();

            if (caja == null)
            {
                return null;
            }

            return caja;
        }
        [HttpGet("Buscar/{sucursalId}")]

        public async Task<Caja> BuscarPorSucursal(int sucursalId)
        {
            Caja caja = null;
            string fecha = DateTime.Now.AddHours(-3).ToString("dd/MM/yyyy");
            List<Caja> cajas = new List<Caja>();
            try
            {
                cajas = await _context.caja.Where(x => x.SucursalId == sucursalId).ToListAsync();
                cajas = cajas.Where(x => x.fechaCaja.ToString("dd/MM/yyyy") == fecha).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            if (cajas.Count > 0)
            {
                caja = cajas.First();
            }
            if (caja == null)
            {
                return null;
            }

            return caja;
        }
        [HttpPut("Editar")]

        public async Task<IActionResult> Edit(int id, Caja caja)
        {
            if (id != caja.CajaId)
            {
                return BadRequest();
            }

            _context.Entry(caja).State = EntityState.Modified;

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

        // POST: api/CajasService
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("Crear")]

        public async Task<Caja> Crear(Caja caja)
        {

            _context.caja.Add(caja);
            await _context.SaveChangesAsync();

            return caja;
        }

        [HttpPost("CrearMovimientoCaja/{cajaId}")]
        public async Task<MovimientoCaja> CrearMovimientoCaja(int cajaId, MovimientoCaja movimiento)
        {
            Caja caja = await _context.caja.FindAsync(cajaId);
            movimiento.caja = caja;
            movimiento.tipoMovimientoCaja = await _context.tipoMovimientoCaja.FindAsync(movimiento.tipoMovimientoCaja.TipoMovimientoCajaId);
            _context.movimientoCaja.Add(movimiento);

            if (movimiento.entra == true)
            {
                caja.montoCaja += movimiento.importe;
            }
            else
            {
                caja.montoCaja -= movimiento.importe;

            }

            try
            {
                await Edit(caja.CajaId, caja);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

            return movimiento;
        }
        // DELETE: api/CajasService/5
        [HttpGet("Existe")]

        private bool Existe(int id)
        {
            return _context.caja.Any(e => e.CajaId == id);
        }

        [HttpPost("IniciarCaja/{montoInicial}")]

        public async Task<Caja> IniciarCajaDiaria(double montoInicial, [FromBody] Sucursal sucursal)
        {

            Caja caja = null;
            string fecha = DateTime.Now.AddHours(-3).ToString("dd/MM/yyyy");
            List<Caja> cajas = new List<Caja>();
            cajas = _context.caja.Where(x => x.fechaCaja.ToString() == fecha && x.SucursalId == sucursal.SucursalId).ToList();

            if (cajas.Count == 0)
            {
                caja = new Caja();
                caja.sucursal = await _context.sucursal.FindAsync(sucursal.SucursalId);
                caja.montoCaja = montoInicial;
                caja.fechaCaja = DateTime.Now.AddHours(-3);
                await Crear(caja);


                //Creacion Movimiento de Caja
                TipoMovimientoCaja tipoMovimientoCaja = await _context.tipoMovimientoCaja.FindAsync(1);
                _context.movimientoCaja.Add(new MovimientoCaja
                {
                    caja = caja,
                    tipoMovimientoCaja = tipoMovimientoCaja,
                    importe = montoInicial,
                    entra = true,
                    sale = false,
                    fechaAlta = DateTime.Now.AddHours(-3)
                });
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            return caja;


        }
        [HttpPost("ExisteCajaDia")]

        public async Task<bool> ExisteCajaDia([FromBody] Sucursal sucursal)
        {

            List<Caja> cajas = new List<Caja>();


            cajas = await _context.caja.ToListAsync();

            if (cajas.Count > 0)
            {

                cajas = cajas.Where(e => e.fechaCaja.ToString("dd/MM/yyyy") == DateTime.Now.AddHours(-3).ToString("dd/MM/yyyy") && e.SucursalId == sucursal.SucursalId).ToList();
                if (cajas.Count > 0)
                {

                    return true;
                }
                return false;
            }
            return false;
        }

        [HttpGet("ConsultarCaja/{fecha}/{sucursalId}")]

        public async Task<ActionResult<List<CajaDto>>> ConsultarCaja(string fecha, string sucursalId)
        {
            DateTime fechaConvertida = Convert.ToDateTime(fecha);
            List<Caja> cajas = new List<Caja>();
            List<CajaDto> cajasDto = new List<CajaDto>();


            cajas = await _context.caja.Include(x => x.sucursal).ToListAsync();

            if (cajas.Count > 0)
            {
                if (sucursalId != "Todas")
                {
                    cajas = cajas.Where(e => e.fechaCaja.ToString("dd/MM/yyyy") == fechaConvertida.ToString("dd/MM/yyyy") && e.SucursalId == Convert.ToInt32(sucursalId)).ToList();
                }
                else
                {
                    cajas = cajas.Where(e => e.fechaCaja.ToString("dd/MM/yyyy") == fechaConvertida.ToString("dd/MM/yyyy") && e.sucursal.fechaBaja == null).ToList();
                }

                foreach (Caja caja in cajas)
                {

                    cajasDto.Add(new CajaDto { caja = caja, movimientosCaja = await _context.movimientoCaja.Where(x => x.CajaId == caja.CajaId).Include(x => x.comprobante).Include(x => x.tipoMovimientoCaja).ToListAsync() });
                }


                if (cajasDto.Count > 0)
                {
                    return cajasDto;
                }
                return cajasDto;
            }
            return cajasDto;
        }
    }
}
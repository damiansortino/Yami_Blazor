using System;

namespace LaymarClientSide.Shared.Entidades
{
    public class Caja
    {
        public int CajaId { get; set; }
        public DateTime fechaCaja { get; set; } = DateTime.Now;
        public DateTime? fechaCierreCaja { get; set; }
        public double montoCaja { get; set; } = 0.00;
        //RELACIONES
        public int SucursalId { get; set; }
        public virtual Sucursal sucursal { get; set; }
    }
}

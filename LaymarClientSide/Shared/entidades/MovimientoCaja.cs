using System;

namespace LaymarClientSide.Shared.Entidades
{
    public class MovimientoCaja
    {
        public int MovimientoCajaId { get; set; }
        public bool entra { get; set; }
        public bool sale { get; set; }
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime? fechaBaja { get; set; }
        public double importe { get; set; }
        public string observaciones { get; set; }

        //RELACIONES
        public int tipoMovimientoCajaId { get; set; }
        public TipoMovimientoCaja tipoMovimientoCaja { get; set; }

        public int? ComprobanteId { get; set; }
        public virtual Comprobante comprobante { get; set; }
        public int CajaId { get; set; }
        public Caja caja { get; set; }

    }
}
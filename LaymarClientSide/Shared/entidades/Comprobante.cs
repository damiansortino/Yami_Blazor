using System;

namespace LaymarClientSide.Shared.Entidades
{
    public class Comprobante
    {
        public int ComprobanteId { get; set; }
        public string codigo { get; set; }
        public double importe { get; set; }
        public double bonificacion { get; set; }
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime? fechaBaja { get; set; }
        //RELACIONES
        public int PersonaJuridicaId { get; set; }
        public PersonaJuridica personaJuridica { get; set; }

        public int TipoComprobanteId { get; set; }
        public virtual TipoComprobante tipoComprobante { get; set; }
        public int SucursalId { get; set; }
        public Sucursal sucursal { get; set; }
        public double efectivo { get; set; }
        public double tarjeta { get; set; }
        public string UserName { get; set; }
    }
}

using System;

namespace LaymarClientSide.Shared.Entidades
{
    public class MovimientoStock
    {
        public int MovimientoStockId { get; set; }
        public int cantidad { get; set; }
        public bool entra { get; set; }
        public bool sale { get; set; }
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime? fechaBaja { get; set; }
        public string descripcion { get; set; }

        //RELACIONES
        public int StockId { get; set; }
        public virtual Stock stock { get; set; }

        public int? ComprobanteId { get; set; }
        public virtual Comprobante comprobante { get; set; }
        public int TipoMovimientoStockId { get; set; }
        public virtual TipoMovimientoStock tipoMovimientoStock { get; set; }

    }
}
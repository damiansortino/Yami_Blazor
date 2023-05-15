using System;

namespace LaymarClientSide.Shared.Entidades
{
    public class TipoMovimientoStock
    {
        public int TipoMovimientoStockId { get; set; }
        public string nombreTipoMovimientoStock { get; set; }

        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime? fechaBaja { get; set; }
    }
}
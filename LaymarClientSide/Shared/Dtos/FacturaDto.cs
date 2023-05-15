using LaymarClientSide.Shared.Entidades;
using System.Collections.Generic;

namespace LaymarClientSide.Shared.Dtos
{
    public class FacturaDto
    {
        public Comprobante comprobante { get; set; }
        public List<DetalleFactura> detalles { get; set; }
    }
}

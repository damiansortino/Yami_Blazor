using System;

namespace LaymarClientSide.Shared.Entidades
{
    public class DetalleFactura
    {

        public int DetalleFacturaId { get; set; }
        public string cadenaBusquedaProducto { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }
        public double bonificacion { get; set; }
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime? fechaBaja { get; set; }
        public int ComprobanteId { get; set; }
        public virtual Comprobante comprobante { get; set; }



        public int ProductoId { get; set; }
        public virtual Producto producto { get; set; }
    }
}

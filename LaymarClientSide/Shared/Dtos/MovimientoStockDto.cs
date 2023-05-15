using LaymarClientSide.Shared.Entidades;

namespace LaymarClientSide.Shared.Dtos
{
    public class MovimientoStockDto
    {
        public MovimientoStock movimiento { get; set; }
        public Producto producto { get; set; }
        public Sucursal sucursal { get; set; }
    }
}

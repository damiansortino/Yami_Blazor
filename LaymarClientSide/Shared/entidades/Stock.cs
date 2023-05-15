using System.ComponentModel.DataAnnotations;

namespace LaymarClientSide.Shared.Entidades
{
    public class Stock
    {
        public int StockId { get; set; }
        public int cantidad { get; set; }



        //RELACIONES
        [Required]

        public int SucursalId { get; set; }
        public virtual Sucursal sucursal { get; set; }
        [Required]

        public int ProductoId { get; set; }
        public virtual Producto producto { get; set; }

    }
}

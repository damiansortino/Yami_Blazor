using System;
using System.ComponentModel.DataAnnotations;

namespace LaymarClientSide.Shared.Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        [Required]
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        [Required]
        public double precioUnitario { get; set; } = 0.00;
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime? fechaBaja { get; set; }
        public double porcentajeRentabilidad { get; set; }
        public string talle { get; set; }
        public string color { get; set; }
        public string marca { get; set; }


        //RELACIONES
        [Required]
        public int ProveedorId { get; set; }
        public virtual Proveedor proveedor { get; set; }


    }
}

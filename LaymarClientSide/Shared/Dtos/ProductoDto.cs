using LaymarClientSide.Shared.Entidades;
using System.Collections.Generic;

namespace LaymarClientSide.Shared.Dtos
{
    public class ProductoDto
    {
        public Producto producto { get; set; }
        public List<Stock> stocks { get; set; } = new List<Stock>();
    }
}

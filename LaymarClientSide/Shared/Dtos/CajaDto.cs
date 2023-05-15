using LaymarClientSide.Shared.Entidades;
using System.Collections.Generic;

namespace LaymarClientSide.Shared.Dtos
{
    public class CajaDto
    {
        public Caja caja { get; set; }
        public List<MovimientoCaja> movimientosCaja { get; set; }
    }
}

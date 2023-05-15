using System;
using System.ComponentModel.DataAnnotations;

namespace LaymarClientSide.Shared.Entidades
{
    public class Sucursal
    {
        public int SucursalId { get; set; }
        [Required]
        public string nombreSucursal { get; set; }

        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime? fechaBaja { get; set; }
    }
}

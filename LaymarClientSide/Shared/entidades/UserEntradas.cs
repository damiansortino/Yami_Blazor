using System;

namespace LaymarClientSide.Shared.Entidades
{
    public class UserEntradas
    {
        public int UserEntradasId { get; set; }
        public string userName { get; set; }
        public DateTime fechaIngreso { get; set; } = DateTime.Now;
        public int SucursalId { get; set; }
        public Sucursal sucursal { get; set; }
    }
}

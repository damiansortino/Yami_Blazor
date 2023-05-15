namespace LaymarClientSide.Shared.Entidades
{
    public class UserSucursal
    {
        public int UserSucursalId { get; set; }
        public string userName { get; set; }

        public int SucursalId { get; set; }
        public Sucursal sucursal { get; set; }
    }
}

using LaymarClientSide.Shared.Entidades;

namespace LaymarClientSide.Client.Shared
{
    public static class VariablesGlobales
    {
        public static Sucursal sucursal { get; set; } = new Sucursal();
        public static int minutosSesion { get; set; }
        public static int horas { get; set; }

    }
}

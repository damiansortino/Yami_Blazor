using LaymarClientSide.Shared.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LaymarClientSide.Shared
{
    public class UserInfo
    {
        public string id { get; set; }
        public string Email { get; set; }
        [Required]
        public string username { get; set; }
        public string Password { get; set; }
        public List<Roles> roles { get; set; } = new List<Roles>();

        public List<Sucursal> sucursales { get; set; } = new List<Sucursal>();

    }
}

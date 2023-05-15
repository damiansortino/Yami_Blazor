using System;
using System.ComponentModel.DataAnnotations;

namespace LaymarClientSide.Shared.Entidades
{
    public class PersonaJuridica
    {
        public int PersonaJuridicaId { get; set; }

        public string cuit { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string razonSocial { get; set; }
        public string nombreFantasia { get; set; }

        public string direccion1 { get; set; }
        public string direccion2 { get; set; }

        public string numeroTelefono1 { get; set; }
        public string numeroTelefono2 { get; set; }
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime? fechaBaja { get; set; }

    }
}

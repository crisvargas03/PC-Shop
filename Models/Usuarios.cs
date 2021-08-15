using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GestorPC.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Facturas = new HashSet<Facturas>();
        }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string Contrasena { get; set; }
        public string TelefonoUsuario { get; set; }
        public string TurnoUsuario { get; set; }

        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}

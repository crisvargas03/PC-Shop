using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GestorPC.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Facturas = new HashSet<Facturas>();
        }

        public long DniCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string Direccion { get; set; }
        public string CorreoCliente { get; set; }
        public string TelefonoCliente { get; set; }

        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}

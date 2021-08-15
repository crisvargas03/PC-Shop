using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GestorPC.Models
{
    public partial class Computadoras
    {
        public Computadoras()
        {
            Facturas = new HashSet<Facturas>();
        }

        public int IdComputadora { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public DateTime? FechaLlegada { get; set; }
        public decimal? Precio { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}

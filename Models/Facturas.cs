using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GestorPC.Models
{
    public partial class Facturas
    {
        public int IdFactura { get; set; }
        public long DniCliente { get; set; }
        public int IdComputadora { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaVenta { get; set; }
        public float Subtotal { get; set; }
        public float Descuento { get; set; }
        public float TotalVenta { get; set; }

        public virtual Clientes DniClienteNavigation { get; set; }
        public virtual Computadoras IdComputadoraNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}

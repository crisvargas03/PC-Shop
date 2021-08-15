using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestorPC.Models;

namespace GestorPC.Data.AdminClientes
{
    interface IServicioCliente
    {
        Task<bool> InsertCliente(Clientes clientes);
        Task<bool> UpdateCliente(Clientes clientes);
        Task<bool> SaveCliente(Clientes clientes);
    }
}

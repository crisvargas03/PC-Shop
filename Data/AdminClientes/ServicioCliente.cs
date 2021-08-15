using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestorPC.Models;

namespace GestorPC.Data.AdminClientes
{
    public class ServicioCliente: IServicioCliente
    {
        private readonly bfzebczn9tgtxtf05ivfContext con;

        public ServicioCliente(bfzebczn9tgtxtf05ivfContext context)
        {
            con = context;
        }

        public async Task<bool> InsertCliente(Clientes clientes)
        {
            con.Clientes.Add(clientes);
            return await con.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveCliente(Clientes clientes)
        {
            if(clientes.DniCliente > 0)
                return await UpdateCliente(clientes);
            else
                return await InsertCliente(clientes);
        }

        public async Task<bool> UpdateCliente(Clientes clientes)
        {
            con.Entry(clientes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return await con.SaveChangesAsync() > 0;
        }
    }
}

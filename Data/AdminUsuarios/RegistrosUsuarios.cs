using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestorPC.Models;

namespace GestorPC.Data.AdminUsuarios
{
    public class RegistrosUsuarios: IRegistrosUsuarios
    {
        private readonly bfzebczn9tgtxtf05ivfContext con;

        public RegistrosUsuarios(bfzebczn9tgtxtf05ivfContext context)
        {
            con = context;
        }

        public async Task<bool> InsertUser(Usuarios usuarios)
        {
            con.Usuarios.Add(usuarios);

            return await con.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveUser(Usuarios usuarios)
        {
            if (usuarios.IdUsuario > 0)
                return await UpdateUser(usuarios);
            else
                return await InsertUser(usuarios);
        }


         public async Task<bool> UpdateUser(Usuarios usuarios)
        {
            con.Entry(usuarios).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return await con.SaveChangesAsync() > 0;
        }   
    }
}

using AppViajes.modelo;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppViajes.data
{
    public class DbContexto
    {
        private readonly SQLiteAsyncConnection cnx;
        //Contructor
        public DbContexto(String data)
        {
            cnx = new SQLiteAsyncConnection(data);
            //Crear una tabla
            cnx.CreateTableAsync<ClsCounters>().Wait();
        }

        // Métodos de mantenimientos
        public async Task<int> ingresar(ClsCounters registro)
        {
            return await cnx.InsertAsync(registro);
        }
        public async Task<int> eliminar(int id)
        {
            return await cnx.DeleteAsync(id);
        }
        public async Task<List<ClsCounters>> GetCounters()
        {
            return await cnx.Table<ClsCounters>().ToListAsync();
        }

    }
}

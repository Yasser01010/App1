using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace App1.Controllers
{
    public class DBemple
    {
        readonly SQLiteAsyncConnection _connection;
        public DBemple()
        {
            
        }

        public DBemple(String dbpath)
        {
            _connection = new SQLiteAsyncConnection(dbpath);

            _connection.CreateTableAsync<Models.Empleado>().Wait();

        }

        public Task<int> StoreEmple(Models.Empleado emple)
        {
            if (emple.id != 0)
            {
                return _connection.UpdateAsync(emple);
            }
            else 
            {
                return _connection.InsertAsync(emple);
            }
        }

        public Task<List<Models.Empleado>> ListaEmpleadosAll()
        {
            return _connection.Table<Models.Empleado>().ToListAsync();
        }

        public Task<int> DeleteEmple(Models.Empleado emple)
        {
            return _connection.DeleteAsync(emple);
        }
    }
}

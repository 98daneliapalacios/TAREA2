using System;
using System.Collections.Generic;
using System.Text;

using Tarea2_3.Models;
using System.Threading.Tasks;

namespace Tarea2_3.Clases
{
    internal class db
    {

        Conexion conexion = new Conexion();

        public Task<List<Modelo>> getReadFirmas()
        {
            return conexion.getConnectionAsync().Table<Modelo>().ToListAsync();
        }

        public Task<Modelo> getFirmaId(int id)
        {
            return conexion.getConnectionAsync().Table<Modelo>().Where(item => item.id == id).FirstOrDefaultAsync();
        }

        public Task<int> updateFirma(Modelo firma)
        {
            return conexion.getConnectionAsync().UpdateAsync(firma);
        }

        public Task<int> delteFirma(Modelo firma)
        {
            return conexion.getConnectionAsync().DeleteAsync(firma);
        }
    }
}

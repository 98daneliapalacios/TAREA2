using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SQLite;

namespace Tarea2_3.Clases
{
    public class Conexion
    {
        private String dbruta;
        public Conexion(){}

        public string Conector()
        {
            String dbName = "dbfirmas";
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            dbruta = Path.Combine(path, dbName);
            return dbruta;

        }
        public SQLiteConnection conn()
        {
            SQLiteConnection conn = new SQLiteConnection(App.dbfirma);
            return conn;
        }

        public SQLiteAsyncConnection getConnectionAsync()
        {
            return new SQLiteAsyncConnection(App.dbfirma);
        }
    }
}

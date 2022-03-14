using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Tarea2_3.Models
{
    class Modelo
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string foto { get; set; }
    }

}

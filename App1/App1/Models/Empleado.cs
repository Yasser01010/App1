using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1.Models
{
    public class Empleado
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public String nombre { get; set; }

        [MaxLength(100)]
        public String apellidos { get; set; }
        public int edad { get; set; }
        public String correos { get; set; }

    }
}

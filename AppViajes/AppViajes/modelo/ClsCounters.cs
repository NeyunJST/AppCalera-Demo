using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppViajes.modelo
{
    public class ClsCounters
    {
        [PrimaryKey, AutoIncrement]
        public int id_counter { get; set; }
        [MaxLength(25)]
        public String nom_counter { get; set; }
        [MaxLength(25)]
        public String ape_counter { get; set; }
        [MaxLength(8)]
        public String dni_counter { get; set; }
        [MaxLength(35)]
        public String correo { get; set; }
        [MaxLength(11)]
        public String cel_counter { get; set; }
    }
}

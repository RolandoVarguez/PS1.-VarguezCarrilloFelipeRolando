using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVENTOS.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string NombreEvento { get; set; }
        public string CategoriaEvento { get; set; }
        public DateTime? FechaEvento { get; set; }
        public Ciudad Ciudad { get; set; }
        public string LugarEvento { get; set; }
        public DateTime? HoraEvento { get; set; }
        public int CapacidadEvento { get; set; }


    
    }
}
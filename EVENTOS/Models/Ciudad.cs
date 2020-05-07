using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVENTOS.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string NombreCiudad { get; set; }
    }
}
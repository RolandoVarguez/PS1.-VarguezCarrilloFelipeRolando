using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EVENTOS.Models
{
    public class EventoDbContext:DbContext
    {
        public EventoDbContext():base("MyConnection")
        {

        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
    }
}
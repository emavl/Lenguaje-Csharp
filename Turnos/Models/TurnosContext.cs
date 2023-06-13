using Microsoft.EntityFrameworkCore;

namespace Turnos.Models {

    public class TurnosContext : DbContext {
        

        public TurnosContext(DbContextOptions <TurnosContext> optiones) // le pasamos por argumento unas opciones por default. 
        : base(optiones)
         { 

         }

         public DbSet< Especialidad > Especialidad {get; set; }
         // Aqui definimos un objeto "especialidad" que va a ser de tipo Dbset( una entidad - una tabla)
         // que al mismo tiempo va a ser del tipo " Especialidad " . 

    }
}
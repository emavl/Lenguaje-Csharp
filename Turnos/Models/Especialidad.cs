

using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{

    public class Especialidad
    {
       [Key]
       
        public int IdEspecialidad { get; set;}
      
        public string Description { get; set;}
    }
}
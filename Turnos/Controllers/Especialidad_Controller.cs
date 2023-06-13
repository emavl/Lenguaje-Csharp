using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Turnos.Controllers
{
    public class Especialidad_Controller : Controller 
    {
        
            // Creamos el constructor utilizando el mismo nombre de la clase.
        public Especialidad_Controller()
        {

        }
        // Creamos otro metodo el cual nos muestra los datos en la pantalla del usuario

        public IActionResult Index ()
        {
            return View();
        }
    }
}
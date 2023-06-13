using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Turnos
{
    public class Program // Clase principal "Program".
    {   
        public static void Main(string[] args)// Este metodo main es un metodo interno que se ejecuta cuando compilamos y ejecutamos la aplicacion.
        {   
            CreateHostBuilder(args).Build().Run();
            //se encarga de servir las aplicaciones, que estan desarrolladas
            //con .net core - al correr el codigo.
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    // con este metodo levantamos la app 
                });
    }
}

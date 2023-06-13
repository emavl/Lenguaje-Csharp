using System;

namespace _16_Logging
{

    /*
     *  Logging es registrar eventos de mi aplicacion 
     *  
     *  Logging es el proceso de registro de acontecimientos significativos que suceden dentro nuestra aplicación.
     *  El objetivo es poder exteriorizar lo que está sucediendo en puntos claves así poder monitorear 
     *  el comportamiento del sistema con la finalidad de tomar métricas de uso, de velocidad o para resolución de errores y bugs.
     *  
     *  
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Log("Programa iniciando");
            Console.Write("\npor favor, ingrese su nombre ");

            string nombre = Console.ReadLine();

            Log("nombre ingresado: " + nombre);
            Console.WriteLine("\nPrograma finalizado");

            Console.ReadLine();

        }

        static void Log(string logtext)
        {
            /*
             *   Incorporar la hora es fundamental a la hora de investigar en que momento la aplicación falló
             *   o correlacionar cierto evento con otro suceso en el sistema.
             *   
             */

            Console.WriteLine("\nHora exacta");
            Console.WriteLine(DateTime.Now.ToString() + " - " + logtext);
        }
    }
}

// ────────►  Dependencias o bibliotecas.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tips_desharp // agupamos los elementos con namespace
{
     class Program 
    {
        static async void Main(string[] args) // Aqui comienza a ejecutarse el codigo.
        {
            
            int? numero = null;
            string respuesta;
            Console.WriteLine(numero);

            /* para hacer un salto de linea */ 
            Console.WriteLine("hola amigo"+ Environment.NewLine + "como estas ? ");

            Console.Write("¿desea continuar? ────► ");
            respuesta = Console.ReadLine();

            if (respuesta == "no") {
                Console.WriteLine("termino");
            }

            Console.ReadKey(); 
        }
    }
}

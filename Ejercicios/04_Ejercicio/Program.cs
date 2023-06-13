using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
/*
 *  Ejercicio 4 ----> Dada una cadena de texto, comprobar si es un polidromo o no. Los polídromos son palabras que se leen igual aun estando al derecho o al
 *  al revez, ej: Ana, Menem, otto, bob. 
 */
namespace _04_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] texto = {"emanuel"};
            Console.WriteLine("Ingrese un nombre");
            texto = Console.ReadKey();
            Console.WriteLine(texto);
            Console.ReadKey();
        }

    }
}

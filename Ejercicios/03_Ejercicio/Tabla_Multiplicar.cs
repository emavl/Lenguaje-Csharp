using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *  Ejercicio n° 1 --->  Dado un numero, devolver su tabla de multiplicar completa. 
 */

namespace _03_Ejercicio
{
    internal class Tabla_Multiplicar
    {
        static void Main(string[] args)
        {
            int numero;
            string resp;


            do
            {
                Console.Clear();
                Console.Write("Por favor ingrese un numero el cual va a ser multiplicado  ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");
                Tabla(numero);
                Console.Write("\n¿ Desea agregar otro numero ?  ");
                resp = Console.ReadLine();
            } while (resp == "si");

            Console.WriteLine("Precione una tecla para salir . . . =)");
            Console.ReadKey();
        }

        public static void Tabla(int numero1)
        {
            int result, i = 1;

            for (; i <= 10; i++)
            {
                result = i * numero1;
                Console.WriteLine($"{i} x {numero1} = " + result);
            }
        }

    }
}

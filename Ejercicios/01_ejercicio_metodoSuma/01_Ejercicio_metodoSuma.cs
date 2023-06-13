using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ejercicio_metodoSuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Background("Suma de 2 numeros pedidos al usuadio");
            Console.WriteLine("La suma es: "+ Sumar());
            Console.ReadKey();
        }

        public static int Sumar() { 
                    
            int num1, num2;        

            Console.Write("Ingrese un numero a sumar por favor ────► ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ingrese otro numero por favor ────► ");
            num2 = Convert.ToInt32(Console.ReadLine());
            

            return num1 + num2;
        }

        public static void Background(string titulo)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.Title = titulo;
        }
    }
}

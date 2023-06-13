using System;

namespace _01_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Background("Calculo IVA");
            double precioIVA = 0;

            Console.Write("Por favor, ingrese el precio del producto ");
            string precioStr = Console.ReadLine();
            int.TryParse(precioStr, out int precio);

            if (precio < 0 || precio == 0)
            {
                Console.WriteLine("\nError el valor no es el correcto\no el numero es menor a 0 ");
            }
            else
            {
                precioIVA = precio * 1.21;
                Console.WriteLine($"\n\nEl IVA es el 21 % y su valor final es: {precioIVA} %");
            }
            Console.WriteLine("\n\n\nPrecione una tecla para continuar o salir del programa . . .");
            Console.ReadKey();

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

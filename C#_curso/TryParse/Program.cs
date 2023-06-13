using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa la temperatura actual");

            string temperatura = Console.ReadLine();
            int numTemperatura;

            int numero;

            // tryParse evalua que la variable sea de tipo string y la asígna a una nueva variable del tipo int.

            // A partir de C# 7: podemos utilizar de esta forma
            // creando la variable dentro.
            int.TryParse(temperatura, out int numTemp);
            Console.WriteLine(numTemp);

            if (int.TryParse(temperatura, out numero))
            {
                numTemperatura = numero;
            }
            else
            {
                numTemperatura = 0;
                Console.WriteLine("El valor ingresado no es válido, se estableció que la temperatura es 0");
            }

            if (numTemperatura < 20)
            {
                Console.Write("Abrígate!");
            }
            else if (numTemperatura == 20)
            {
                Console.WriteLine("Vístete cómodo");
            }
            else if (numTemperatura > 30)
            {
                Console.WriteLine("Hacen 30 grados, ¡qué calor!");
            }
            else
            {
                Console.WriteLine("Usa ropa bien liviana");
            }


            Console.Read();
        }
    }
}

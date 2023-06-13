using System;

namespace _06_01_tryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];
            int i = 0, V = 0;

            do
            {

                Console.WriteLine(" Introduce un n° por favor " + i);

                try
                {
                    V = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("No se introdujo un valor numerico valido");
                }
                catch (OverflowException) // cuando el numero introducido es demaciado grande 
                {
                    Console.WriteLine("\nEl numero ingresado de un tamaño no valido");
                }
                numero[i] = V;


                i++;

            } while (i != numero.Length);

            Console.Write("\n Los numeros ingresados son: ");
            for (int j = 0; j < numero.Length; j++)
            {
                Console.Write(", " + numero[j]);
            }


            Console.ReadKey();

        }
    }
}

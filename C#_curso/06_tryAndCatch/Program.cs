using System;

namespace _06_tryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;

            do
            {
                intentos++;

                Console.WriteLine("Por favor, ingresa un número: ");
                string valorIngresado = Console.ReadLine();

                try
                {
                    int valorComoInt = int.Parse(valorIngresado);
                }
                catch (FormatException)
                {
                    Console.WriteLine("El valor es incorrecto");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El numero ingresado es demaciado largo o corto");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("No se a ingresado ningun valor");
                }
                finally { Console.WriteLine("Esta frace aparecera pase lo que pase"); }
                Console.Read();

            } while (intentos == 10);
        }
    }
}


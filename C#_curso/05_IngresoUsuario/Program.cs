using System;

namespace _05_IngresoUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La suma es ────► " + Calcular());
            Console.ReadKey();
        }

        public static int Calcular()
        {
            Console.Write("Por favor, ingrese un numero: ");
            string num1Input = Console.ReadLine();
            Console.Write("Por favor, ingrese otro numero: ");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);

            int resultado = num1 + num2;

            return resultado;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Si bien puedo hacer esta forma para imprimir el resultado
             * hay otra manera de hacerlo y es la siguiente.
             * 
                int resultado = Sumar(20, 30);
                Console.WriteLine(resultado);
            */
                Console.WriteLine( Sumar(20, 30) );
                Console.ReadKey();
        }

        public static int Sumar(int num1, int num2)
        {
            return (num1 + num2);
        }
        
    }
}

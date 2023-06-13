using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_para_usar
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

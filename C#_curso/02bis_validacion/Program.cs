using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06Bis_TryandCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            
            Console.WriteLine("ingrese el nombre");
            name = Console.ReadLine();

            Console.WriteLine(isValidName(name));
            Console.ReadKey();
        }
       
        public static bool isValidName(string nameInput)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(nameInput))
                isValid = false;
            else
            {

                //opcion 1
                isValid = Regex.IsMatch(nameInput, @"^[a-zA-Z]+$");

                //opcion 2 
                foreach (char c in nameInput)
                {
                    if (!Char.IsLetter(c))
                        isValid = false;
                }

            }
            return isValid;
        }
    }
}

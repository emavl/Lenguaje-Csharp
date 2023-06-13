using System;
using System.Text.RegularExpressions;

/*   Consigna.
 *   
 *  Atributos: nombre, e-mail, sueldo, sexo, peso y altura. 
 *  Pensar qué modificador de visibilidad es el más adecuado junto con el tipo de cada uno ya que no se debe acceder a sus atributos directamente.
 *  Implementar un constructor que defina todos los atributos por parámetro salvo el e-mail que se especifica luego.
 *  
 *  Métodos  a implementar:
 ◦         Todos los métodos Getters, No implementar Setters.

 ◦         CrearEmail():  Crea el e-mail de la persona a partir del nombre + @superempresa.com. Este método es privado y se llama por medio del constructor. 
 *
 */

namespace _14_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string name, sexo, email;
            int edad, peso;
            double altura, sueldo;

            Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("| Bienvenidos al gestor de datos personales, por favor ingrese los siguientes datos |");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────");

            Console.WriteLine("\n\nPrecione una tecla para continuar, muchas gracias =)");
            Console.ReadKey();
            Console.Clear();

            name = ValidateString(" Por favor, ingrese su nombre ──────> ");

            do
            {
                Console.Clear();
                Console.Write("Por favor, ingrese su genero (m) masculino o (f) femenino ──────> ");
                sexo = Console.ReadLine();

            } while (!(sexo == "f" || sexo == "m"));

            Console.Clear();
            edad = ValidateNumber(" Por favor, ingrese su edad ──────> ");

            Console.Clear();
            Console.WriteLine(" Por favor, ingrese su altura ");
            altura = double.Parse(Console.ReadLine());

            Console.Clear();
            peso = ValidateNumber(" Por favor, ingrese su peso ──────> ");

            Console.Clear();
            sueldo = ValidateNumber(" Por favor, ingrese su sueldo ──────> ");

            email = name + "@superempresa.com";

            Persona miPersona = new Persona(name, sexo, email, edad, peso, altura, sueldo);

            Console.Clear();
            Console.WriteLine("Los datos ingresados son los siguientes: \n");
            Console.WriteLine("Nombre : " + miPersona.GetNombre());
            Console.WriteLine("Email: " + miPersona.GetMail());
            Console.WriteLine("Sexo: " + miPersona.GetSexo());
            Console.WriteLine("Sueldo: " + miPersona.GetSueldo() + "ARS");
            Console.WriteLine("Peso: " + miPersona.GetPeso() + "Kg");
            Console.WriteLine("Altura: " + miPersona.GetAltura() + "cm");

            Console.WriteLine("\n\nPrecione una tecla para finalizar el programa . . . ");
            Console.ReadKey();
        }

        public static string ValidateString(string mensaje)
        {
            bool isValid = true;
            string nameInput;

            do
            {
                Console.Write(mensaje);
                isValid = IsValidName(nameInput = Console.ReadLine());

                if (isValid == false)
                    Console.WriteLine("\nError nombre incorrecto");

            } while (isValid != true);

            return nameInput;
        }
        public static int ValidateNumber(string mennsaje)
        {
            bool isValid = true;
            string numeroStr;
            int numero = 0;

            do
            {
                Console.Write(mennsaje);
                isValid = IsOnlyDigits(numeroStr = Console.ReadLine());

                if (isValid == false)
                    Console.WriteLine("\n Error !!! - numero incorrecto\n ");

            } while (isValid != true);

            numero = int.Parse(numeroStr);

            return numero;
        }

        public static bool IsOnlyDigits(string inputString)
        {
            bool isValid = true;

            foreach (char c in inputString)
            {
                if (!Char.IsDigit(c))
                    isValid = false;
            }
            return isValid;
        }

        public static bool IsValidName(string nameInput)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(nameInput))
                isValid = false;
            else
            {

                //process 1
                isValid = Regex.IsMatch(nameInput, @"^[a-zA-Z]+$");

                //process 2
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

using System;

namespace _08_ifAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreDeUsuario = "";

            Console.WriteLine("Por favor, ingrese su nombre de usuario");
            nombreDeUsuario = Console.ReadLine(); //    variableAEvaluar.Equals("cadena") es para evaluar si la variable es igual a la cadena asignada como tal. 
            if (estaRegistrado && nombreDeUsuario != "" && nombreDeUsuario.Equals("Admin"))
            {
                Console.WriteLine("Hola usuario registrado");
                Console.WriteLine("Hola " + nombreDeUsuario);
                Console.WriteLine("Hola Admin");
            }

            if (esAdmin || estaRegistrado)
            {
                Console.WriteLine("Estás loguado");
            }


            Console.Read();
        }
    }
}

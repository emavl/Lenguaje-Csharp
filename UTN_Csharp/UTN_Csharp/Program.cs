using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN_Csharp // Aqui vamos a poder agrupar las clases.
{
    internal class Program
    {
        // Los métodos estáticos son pequeñas piezas de código que se encargan de realizar una tarea concreta. 
        static void Main(string[] args)
        {
            int num1, num2, suma, edad;
            DateTime fechaNac;

            Console.Write("Ingrese su fecha de nacimiento");
            fechaNac = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(fechaNac);


            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine()); // parceamos el dato ingresado como string a un tipo de dato INT 

            if (edad > 17) // condicional Compuesto contiene if / else.
                Console.WriteLine("Usted es mayor ");
            else
                Console.WriteLine("Usted es menor");


            Saludo();
            Console.WriteLine(Suma(23, 13));

            //suma = num1 + num2; // debo asignar los valores porque estan NULL entonce no puedo hacer NULL + NULL.

            Console.Read();
        }

        // funcion que no tiene retorno, solo ejecuta sentencias / Procedimientos 
        static void Saludo()
        {
            Console.WriteLine("hola buenas tardes");
        }

        // funcion que retorne un valor.
        static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

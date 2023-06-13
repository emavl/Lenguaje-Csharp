using System;

namespace _13_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea un array de 4 elementos sin añadir valores. 
            string[] texto = new string[4];

            // Crea un array de 4 elementos asignando los valores que tenemos con {}
            string[] texto2 = new string[4] { "laura", "juan", "pedro", "horacio" };

            // Crea un array sin especificar size y le asignamos informacion.
            string[] texto3 = new string[] { "laura", "juan", "pedro", "horacio" };

            // Crea un array de 4 elementos, omitiendo la palabra
            // reservada keyword y sin especificar la longitud.
            string[] texto4 = { "laura", "juan", "pedro", "horacio" };


            // primera forma de crear un array. 

            int[] calificaciones = new int[5];

            for (int h = 0; h < calificaciones.Length; h++)
            {
                Console.WriteLine($"Ingrese el valor de la nota {h + 1}");
                string ingreso = Console.ReadLine();
                calificaciones[h] = int.Parse(ingreso);
            }
            Console.WriteLine("primera calificacion: {0}", calificaciones[0]);
            Console.WriteLine("Las siguientes son:");

            for (int e = 1; e < calificaciones.Length; e++)
            {
                Console.WriteLine(calificaciones[e]);
            }

            Console.Read();

            // segunda forma de crear un array.
            int[] edades = { 17, 35, 12, 43, 23 };

            // tercera forma de crear un array.
            int[] faltasAlColegio = new int[] { 17, 35, 12, 43, 23 };

            for (int i = 0; i < 5; i++)
            {
                calificaciones[i] = i + 1;
            }

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("El valor del indice {0} es {1}", j, calificaciones[j]);
            }

            string[] name = new string[5];

            Console.Read();
        }

    }
}

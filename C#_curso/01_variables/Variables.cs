using System;

namespace _01_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    TOMA DE APUNTES
             *    
             *  Los tipos de valor que son los enumerados y las estructuras, se guardan en el Stack y cuando 
             *  los pasamos a un metodo u otro ámbito se genera una copia, no es la misma direccion de memoria.
             *  
             *  A diferencia de las interfaces y los delegados 
             *  comparten una direccion de memoria en el heap y manteniendo la referencia pueden modificar la memoria.
             *  
             */
            // variables 
            string nombre = "Emanuel";
            int edad = 35;
            float estatura = 1.76f; // coloco la letra f para que C# reconozca que es una variable del tipo float
            decimal numero = 9.5m; // colocamos la letra m para que C# reconozca que es una variable del tipo decimal.
            double numero1 = 7.5d; // colocamos la letra d para que C# reconozca que es una variable  del tipo double.
            bool aprobado = true;
            /*
             * En esta parte donde se ( entra un proceso, concatenamos, llamamos a una variable
             * volvemos a concatenar, volvemos a entrar en un proceso y volvemos a concatenar
             *  y así sucesivamente . . .  eso no es bueno ya que no aprovechamos los recursos 
             *  de nuestra PC.
             */
            Console.WriteLine("Mi nombre es: " + nombre +
                " tengo " + edad + " años y mido " + estatura);
            Console.ReadKey();

            Console.WriteLine("\notra forma de mostrar los datos es:\n ");
            Console.ReadKey();
            /*
             *  Siendo las variables.
             *    nombre { indice 0 }
             *      edad { indice 1 }
             *  estatura { indice 2 }
             *    numero { indice 2 }
             *   numero1 { indice 2 }
             */
            Console.WriteLine("Mi nombre es: {0} ,tengo {1} años y mido {2} \n" +
                "aprobe todas las materias con {3} y mi promedio es {4}\n" +
                "aprobe la carrera {5}\n\n" +
                "en este caso utilizaremos los corchetes colcocando su indice " +
                "\npara asígnar las variables a cada uno de ellos", nombre, edad, estatura, numero, numero1, aprobado);
            Console.ReadKey();

            byte num1 = 20;
            byte num2 = 10;

            double miDouble = 13.56;

            int suma = num1 + num2;
            int resta = num1 - num2;
            float div = num1 / num2;

            Console.WriteLine("La suma es: {0}", suma);
            Console.WriteLine("La resta es: {0}", resta);
            Console.WriteLine("La divicion es: {0}", div);
            /*
             * al trabajar en diferentes lineas utilizaremos el indice {0} 
             * de otra forma sería si colocaramos de esta forma.
             * 
             * ej: (" la suma es: {0}, y la resta es: {1}"),suma, resta);
             */

            // ------------------------------------------------------------

            // conversion explisita.
            Console.WriteLine("Haciendo conversión Explícita");

            suma = (int)miDouble;

            // conversion implícita.

            int num = 12345;
            long number = num;

            float miFloat = 13.14f;
            double miNuevoDouble = miFloat;

            // Conversion de Tipo.
            // un numero en un string.

            string miString = miDouble.ToString();

            // tambien podemos hacerlo con un booleano.

            bool elSolBrilla = false;
            string miBooleano = elSolBrilla.ToString();

            Console.WriteLine(miDouble + miBooleano);




            Console.ReadKey();


        }
    }
}

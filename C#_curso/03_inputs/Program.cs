using System;

namespace _03_inputs
{
    internal class Program // la clase refiere a objetos, utilizando Pascalcase, donde la primer letra es en mayusculas.
    {
        static void Main(string[] args)
        {
            // para cambiar el color de la letra en la consola. 
            Console.ForegroundColor = ConsoleColor.Black;

            // para cambiar el color de fondo en la consola. 
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            string nombre, apellido, edadstr;
            int edad;
            double estatura;


            Console.Write("Dime tu nombre por favor ────► ");
            Console.WriteLine("Hola " + Console.ReadLine());

            Console.Write("Dime tu edad por favor ────► ");
            edadstr = Console.ReadLine();
            Console.WriteLine($"usted tiene {edadstr}");

            Console.Write("────────────────────────────────────────────────────────\n");
            // podemos utilizar solamente ( write ) que a diferencia de writeline es el salto de linea.
            Console.Write("Ingrese su nombre por favor ────► ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido por favor ────► ");
            apellido = Console.ReadLine();

            Console.Write("Ingrese su edad por favor ────► ");
            edad = Int32.Parse(Console.ReadLine());
            //   con Convert.toint32 o Int32.Parse , casteamos el numero ingresado como un string a un int .

            Console.Write("Ingrese su altura por favor ────► ");
            estatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Datos ingresados: \nNombre {0}\napellido {3}\nEdad: {1}\nAltura es: {2}", nombre, edad, estatura, apellido);
            Console.ReadKey();
        }
    }
}

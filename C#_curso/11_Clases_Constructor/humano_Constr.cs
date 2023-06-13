using System;

namespace _11_Clases_Constructor
{
    internal class humano_Constr
    {
        // Miembro variable
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;

        // Miembro Método
        public void presentame()
        {
            if (edad == 1)
                Console.WriteLine("hola, soy {0} y mi " +
                    "apellido es {1}, tengo ojos color {2}, y tengo {3} año", primerNombre, apellido, colorOjos, edad);
            else
                Console.WriteLine("hola, soy {0} y mi " +
                    "apellido es {1}, tengo ojos color {2}, y tengo {3} años", primerNombre, apellido, colorOjos, edad);
        }

        // Miembro Cosntructor, donde pasaremos por parametros las variables a utilizar.

        public humano_Constr(string nombre, string apellido, string colorOjos, int edad)
        {
            this.primerNombre = nombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }
    }
}

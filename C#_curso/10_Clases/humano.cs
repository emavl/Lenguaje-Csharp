using System;

namespace _10_Clases
{
    internal class humano
    {
        // Miembro variable
        public string primerNombre;
        public string apellido;

        // Miembro Método - Forma basica.

        public void presentame()
        {
            Console.WriteLine("hola, soy {0} y mi " +
                "apellido es {1} ", primerNombre, apellido);

        }

    }
}

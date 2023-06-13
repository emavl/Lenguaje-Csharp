using System;

namespace _11_Clases_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * . Anteriormente Creamos un objeto desde mi clase
            *  una instancia de humano, en el ejercicio 10_clase
            *  ahora, de forma mas sencilla y en menos lineas armaremos
            *  un constructor el cual nos va a permitir agregar dentro 
            *  los parametros necesarios.
            *  
            */
            humano_Constr Juan = new humano_Constr("Juan", "Nicolino", "marrones", 54);
            humano_Constr Pedro = new humano_Constr("Pedro", "D´tomazo", "celestes", 44);
            humano_Constr Laura = new humano_Constr("Laura", "matienzos", "miel", 31);
            humano_Constr Franco = new humano_Constr("Franco", "sanchez", "verdes", 14);
            humano_Constr Anita = new humano_Constr("Anita", "tisiana", "miel", 1);

            /*
             * 
             *  Anteriormente accediamos a una variable publica externa
               y asignamos los valores para cada uno de ellos.

             Juan.primerNombre = "Juan";
             Juan.apellido = "Nicolino";

              . Pero con el constructor es diferente

            */


            // Llamamos al método de la clase
            Juan.presentame();
            Pedro.presentame();
            Laura.presentame();
            Franco.presentame();
            Anita.presentame();

            Console.Read();
        }
    }
}

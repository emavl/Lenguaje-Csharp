using System;


/*
 *  -------------->  Clases.
 *  
 *  . Una clase es el plano de un Objeto.
 *  
 *  . Tiene acciones/habilidades, llamadas funciones de miembro o 
 *  metodos.
 *  
 *  . Tiene propiedades, llamadas variables de miembro.
 *  
 *  . Permite la herencia.
 *  
 *  . Puede ser usada como tipo de datos. como el tipo de dato  String.
 *  
 *  
 * 
 */

namespace _10_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Crea un objeto desde mi clase
             *  una instancia de humano
             */
            humano Juan = new humano();
            humano Pedro = new humano();
            humano Laura = new humano();
            humano Franco = new humano();


            //Acceder a una variable publica externa
            // y asignamos los valores para cada uno de ellos.
            Juan.primerNombre = "Juan";
            Juan.apellido = "Nicolino";

            Pedro.primerNombre = "Pedro";
            Laura.primerNombre = "Laura";
            Franco.primerNombre = "Franco";

            Pedro.apellido = "D´tomazo";
            Franco.apellido = "matienzos";
            Laura.apellido = "sanchez";

            // Llamamos al método de la clase
            Juan.presentame();
            Pedro.presentame();
            Laura.presentame();

            Console.Read();
        }
    }
}

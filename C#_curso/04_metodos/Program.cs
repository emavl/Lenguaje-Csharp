using System;

/*  Clase de metodos.
 *   
 *  <especificador de Acceso> <Tipo de retorno> <Nombre del metodo> (lista de parametros)
 *  {
 *  
 *      Cuerpo del metodo.
 *      
 *  }
 *
 *  Especificador de Acceso ──────► Determina la visibilidad de una variable o de un método desde otra clase.
 *  
 *    - static = estatico es algo que ocupa en la memoria ram de forma fija que cuando se inicia cuando se usa por primera vez
 *    y hasta que no se mata el programa no va a morir.
 *  
 *  Tipo de Retorno ──────► Un método puede devolver un valor. El tipo de retorno es el tipo de dato del valor.
 *  que va a devolver el método, si no devuelve nada el tipo de retorno es void.
 *  
 *  Nombre del Método. ──────► Encerrados entre paréntesis, los parámetros se usan para pasar y recibir datos
 *  en el metodo. La lista de parámetros se refiere al tipo, orden y cantidad de parámetros en un método. 
 *  Los parámetros son opcionales. Un método puede no contener parámetros.
 *  
 *  Cuerpo del método - Contiene el conjunto de instrucciones necesarios para completar las actividades
 *  requeridas.
 *  
 */



namespace _04_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Background("Matodos");
            entradaDatos();
            Mensaje_a_escribir("mensaje escrito");
            Console.Read();
        }
        //          (static) es una declaracion de que no pertenece a un objeto.

        // Nivel de accieso - ( static ) - tipoDeRetorno - NombreDelMetodo (Parametro1 - Parametro2)
        public static void entradaDatos()
        {
            Console.WriteLine("El siguiente mensaje es pasado por referencia\n");
        }

        public static void Mensaje_a_escribir(string miTexto)
        {

            Console.WriteLine(miTexto);
        }

        public static void Background(string titulo)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.Title = titulo;
        }

    }
}

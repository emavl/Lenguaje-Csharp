
using System;

namespace _02_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Background("Strings");
            Console.WriteLine("");


            // cada una de las lineas es una sentencia 

            char letra = 'a';    // esto es una sentencia 
            string miCadena = " ";
            string miCadena1 = string.Empty; /* Ambas demarcan que son una cadena vacia  */

            Console.WriteLine("Ingrese un texto: ");
            string miIngreso = Console.ReadLine();


            /*  ---------- ►  T E C L A S     R A P I D A S.
             *  
             * Duplicar linea   ──────► Control + D.
             * Acomodar codigo  ──────► Control K + D.
             * Comentar codigo  ──────► Control  k + C (comenta) / (descomentar) K + U.
             * Edicion multiple ──────► Controls + Alt + click. o bien.
             * colocandonos arriba de la palabra y tipeando/ shift + alt + . (e ir seleccionando)
             * Cambiar nombre   ──────► Control + RR.
             * de una variable 
             * Historial de busqueda ───► Control + shift + V.
             * Buscar metodo ──────► Control y coma ,
             * Donde se usa el metodo? ──────► Shift + F12
             * llaves automaticas ──────► Shift + Enter.
             * 
             * Si da error y falta alguna librería precionamos ──────► Control + .
             * ésto nos va agregar la librería que falte
             * 
            */

            Console.ReadLine();


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

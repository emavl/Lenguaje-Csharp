using System;

namespace _09_ifMejorada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Condicion ? primera expresión : segunda_expresión;
             * la condicion solo puede ser verdadera o falsa 
             * el operador condicional es correcto, osea es asociativo.
             * la expresión a ? b : c ? d : e
             * es evaluada como a ? b : (c ? d : e ),
             * no como (a ? b : c) ? d : e
             * 
             */

            int temperatura = -5;
            string estadoDelAgua;

            if (temperatura < 0)
                estadoDelAgua = "solido";
            else
                estadoDelAgua = "liquido";

            Console.WriteLine("El estado del agua es " + estadoDelAgua);
            Console.Read();

            // aqui se ejecuta   la condicion    preguntamos?  verdadero  : Falso
            estadoDelAgua = temperatura < 0 ? "solido" : "liquido";
        }
    }
}

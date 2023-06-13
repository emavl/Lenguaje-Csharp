using System;
using System.Collections;
using System.Collections.Generic;

namespace U5DatosComplejos3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********  ARRAY    *********/
            Console.WriteLine("*****Con Array*****");
            //Declaramos un array de 6 strings
            String[] listaDeEquipos = new String[6];

            //Ingresamos los strings
            listaDeEquipos[0] = "River";
            listaDeEquipos[1] = "Boca";
            listaDeEquipos[2] = "Racing";
            listaDeEquipos[3] = "Velez";
            listaDeEquipos[4] = "Independiente";
            listaDeEquipos[5] = "San Lorenzo";

            //Recorremos el Array y mostramos los datos
            for (int i = 0; i < listaDeEquipos.Length; i++)
            {
                Console.WriteLine(i + " | " + listaDeEquipos[i]);
            }
            Console.ReadLine();

            /*********   ARRAYLIST   *********/
            Console.WriteLine("*****Con ArrayList*****");
            //El arrayList se declara sin tipo
            ArrayList listaDeEquiposEnArrayList = new ArrayList();
            listaDeEquiposEnArrayList.Add("River");
            listaDeEquiposEnArrayList.Add("Boca");
            listaDeEquiposEnArrayList.Add("Racing");
            listaDeEquiposEnArrayList.Add("Velez");
            listaDeEquiposEnArrayList.Add("Independiente");
            listaDeEquiposEnArrayList.Add("San Lorenzo");
            listaDeEquiposEnArrayList.Add(6); // al declararse sin tipo, permite distintos tipos de objetos

            for (int i = 0; i < listaDeEquiposEnArrayList.Count; i++)
            {
                //Acá trasnformo al "no-tipo" en tipo string
                if (i < 6) // Esto va a fallar si tengo algun dato no string por eso dejo afuera el 6
                {
                    string elemento = (String)listaDeEquiposEnArrayList[i];
                    Console.WriteLine(i + " | " + elemento);
                }

                //string elemento = (String)listaDeEquiposEnArrayList[6]; // Prueben ustedes mismos, aca trata de string a un numero y falla
            }
            Console.WriteLine("\nsiguiente . . .\n");
            Console.ReadLine();


            /*********   LIST   *********/
            Console.WriteLine("*****Con List*****");
            //List me obliga a declarar un tipo entre <>, esto me salva de problemas como el del ejemplo anterior.
            List<String> listaDeEquiposEnList = new List<String>();
            listaDeEquiposEnList.Add("River");
            listaDeEquiposEnList.Add("Boca");
            listaDeEquiposEnList.Add("Racing");
            listaDeEquiposEnList.Add("Velez");
            listaDeEquiposEnList.Add("Independiente");
            listaDeEquiposEnList.Add("San Lorenzo");
            // listaDeEquiposEnList.Add(6); // esto ni lo puedo escribir que me va a tirar error, me salva de un error en ejecucion.

            for (int i = 0; i < listaDeEquiposEnList.Count; i++)
            {

                string elemento = listaDeEquiposEnList[i];
                Console.WriteLine(i + " | " + elemento);

            }
            Console.ReadLine();


        }
    }
}

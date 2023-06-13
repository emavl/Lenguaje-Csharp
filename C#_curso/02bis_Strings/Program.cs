using System;

namespace U5DatosComplejos2_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Este es un string ; o no?";
            Console.WriteLine(texto);
            //Tamaño total del texto
            Console.WriteLine(" y su tamaño es " + texto.Length);
            //42

            //Contiene la palabra "ponerme"?
            Console.WriteLine(" \nContains me devuelve true or false si se encuentra o no la palabra que busco ej: \"ponerme\" ");
            Console.WriteLine(texto.Contains("ponerme"));
            //True

            Console.WriteLine("\n remplazamos la palabra creativo por original");
            //reemplazar la palabra "creativo" por "original".
            Console.WriteLine(texto.Replace("creativo", "original"));
            //Me cuesta ponerme original en estos textos

            //En que posicion está "cuesta"?
            Console.WriteLine(texto.IndexOf("cuesta"));
            //3

            //Convertir todo a Mayusculas y luego todo a Minusculas
            Console.WriteLine(texto.ToUpper());
            //"ME CUESTA PONERME CREATIVO EN ESTOS TEXTOS
            Console.WriteLine(texto.ToLower());
            //me cuesta ponerme original en estos textos

            //Separar en substrings todo lo que este entre espacios.
            //para mas información revisar arrays en el siguiente tema.
            Console.WriteLine(texto.Substring(0));
            String[] textoEntreEspacios = texto.Split(' ');  //las comillas simples denotan un caracter simple, y los corchetes definen un array.
            Console.WriteLine(textoEntreEspacios[0]); //se pueden acceder a los elementos del array con el número de indice.
            //Me
            Console.WriteLine(textoEntreEspacios[3]);
            //creativo
            Console.Read();

            string cadena = "Hola, este es un ejemplo de cadena de caracteres.";

            // Length: devuelve la longitud de la cadena
            int longitud = cadena.Length;
            Console.WriteLine($"Longitud de la cadena: {longitud}");

            // ToLower: convierte la cadena a minúsculas
            string enMinúsculas = cadena.ToLower();
            Console.WriteLine($"Cadena en minúsculas: {enMinúsculas}");

            // ToUpper: convierte la cadena a mayúsculas
            string enMayúsculas = cadena.ToUpper();
            Console.WriteLine($"Cadena en mayúsculas: {enMayúsculas}");

            // Split: divide la cadena en una matriz de palabras separadas por espacios
            string[] palabras = cadena.Split(' ');
            Console.WriteLine("Palabras en la cadena:");
            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }

            // Replace: reemplaza una subcadena por otra
            string reemplazada = cadena.Replace("ejemplo", "caso");
            Console.WriteLine($"Cadena reemplazada: {reemplazada}");

            // IndexOf: encuentra la posición de una subcadena en la cadena
            int posicion = cadena.IndexOf("cadena");
            Console.WriteLine($"Posición de 'cadena' en la cadena: {posicion}");

            // LastIndexOf: encuentra la última posición de una subcadena en la cadena
            int ultimaPosicion = cadena.LastIndexOf("caracteres");
            Console.WriteLine($"Última posición de 'caracteres' en la cadena: {ultimaPosicion}");

            // Contains: verifica si la cadena contiene una subcadena específica
            bool contiene = cadena.Contains("ejemplo");
            Console.WriteLine($"¿La cadena contiene 'ejemplo'? {contiene}");

            // StartsWith: verifica si la cadena comienza con una subcadena específica
            bool comienzaCon = cadena.StartsWith("Hola");
            Console.WriteLine($"¿La cadena comienza con 'Hola'? {comienzaCon}");

            // EndsWith: verifica si la cadena termina con una subcadena específica
            bool terminaCon = cadena.EndsWith("caracteres.");
            Console.WriteLine($"¿La cadena termina con 'caracteres.'? {terminaCon}");
        }
    }
    }
}

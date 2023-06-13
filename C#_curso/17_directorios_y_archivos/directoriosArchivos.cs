using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace U6GestiondeArchivos_1DirectoriosyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Directorios****/

            //Crear un directorio
            Directory.CreateDirectory("C:\\Users\\Public\\MiDirectorio");

            //Eliminar un directorio
            Directory.Delete("C:\\Users\\Public\\MiDirectorio", true);

            //Verificar si un directorio existe
            Directory.Exists("C:\\Users\\Public\\MiDirectorio");

            //Enumerar los directorios dentro de:
            String[] directorios = Directory.GetDirectories("C:\\Users\\Public\\");

            //Enumerar los archivos de un directorio
            String[] archivos = Directory.GetFiles("C:\\Users\\Public\\");


            /*FILES****/

            //Crear un file
            StreamWriter archivo;
            archivo = File.CreateText("C:\\Users\\Public\\miArchivo.txt");

            //Escribir en el file
            archivo.WriteLine("Escribo una linea");
            archivo.WriteLine("Escribo otra linea");
            archivo.WriteLine("tercer linea escrita");
            archivo.WriteLine("bueno ya esta");
            archivo.WriteLine(DateTime.Now.ToShortTimeString());

            //Cerrar el archivo
            archivo.Close();


            //Leer una linea de un file
            StreamReader archivoALeer;
            archivoALeer = File.OpenText("C:\\Users\\Public\\miArchivo.txt");
            string lectura = archivoALeer.ReadLine();
            Console.WriteLine(lectura);

            //Leer hasta el final
            do
            {
                lectura = archivoALeer.ReadLine();
                Console.WriteLine(lectura);
            } while (lectura != null);
            archivoALeer.Close();

            //Agregar contenido a un archivo
            StreamWriter ficheroAppend;
            ficheroAppend = File.AppendText("C:\\Users\\Public\\miArchivo.txt");
            ficheroAppend.WriteLine("añadimos texto al fichero, sino existe se va a crear uno nuevo");
            ficheroAppend.Close();


        }
    }
}

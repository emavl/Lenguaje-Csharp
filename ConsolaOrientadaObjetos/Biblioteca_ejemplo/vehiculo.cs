using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_ejemplo
{
    public class Vehiculo
    {   // por buenas practicas se colocan las caracteristicas

        private string color;
        private int año;
        private int puertas;
        private string modelo;
        private int velocidad;
        public int Puertas { get; set; } // puedo definir un geter y seter de esta manera.


        // Codigo.
        // Catacteristicas que quiero modelar: Atributos Los expongo con propiedades.

        //Consturctor.
        public Vehiculo(string color, int anio, int puertas, string modelo)
        {
            this.color = color;
            this.puertas = puertas;

        }
        // Funcionalidad : Metodos. geters y seters

        public void Velocidad(int velocidadNueva)
        {
            this.velocidad = velocidadNueva;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return this.color;
        }


    }



}

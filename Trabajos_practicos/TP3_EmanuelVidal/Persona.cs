using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _14_OOP
{
    internal class Persona
    {
        private string nombre, sexo, email;
        private int edad;
        private double altura, sueldo, peso;

        public Persona(string nombre, string sexo, string email, int edad, double peso, double altura, double sueldo)
        {
            if (this != null && edad > 0 && altura > 0 && sueldo > 0)
            {
                this.nombre = nombre;
                this.sexo = sexo;
                this.email = email;
                this.edad = edad;
                this.altura = altura;
                this.sueldo = sueldo;
                this.peso = peso;
            }
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetSexo()
        {
            return this.sexo;
        }
        public string GetMail()
        {
            return this.email;
        }
        public string GetEdad()
        {
            return this.edad.ToString();
        }
        public string GetAltura()
        {
            return this.altura.ToString();
        }
        public string GetSueldo()
        {
            return this.sueldo.ToString();
        }
        public string GetPeso()
        {
            return this.peso.ToString();
        }


    }
}

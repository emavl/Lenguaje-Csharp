namespace _01_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // tipo de referencia (clase)
            Persona persona = new Persona()
            {
                Nombre = "Sebastian Carrizo"
            };

            // Tipo de valor (estructura).
            int numero;
            /*  
             *  Apuntes :   Todos los tipos de valor tienen un valor por defecto.
             *   los enteros va a ser 0, los booleanos van a ser false y los de
             *   referencia van apuntar a NULL.
             *   
             *   NULL se refiere a nada, la ausencia de un valor o la faltante de contenido.
             *   En programacion, null se refiere a un valor especial que se utiliza para indicar,
             *   que una variable no tiene asignado ningun valor en un momento dado.
             * 
             */
            // Tipo de valor (estructura).
            string nombre = "lucas";
            nombre = "Facundo";

            // Un string es Inmutable al igual que los arrays, tienen un tamaño fijo.


        }

    }
}

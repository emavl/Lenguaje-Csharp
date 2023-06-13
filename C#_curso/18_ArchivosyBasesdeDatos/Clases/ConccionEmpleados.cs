using System.Collections.Generic;
using System.Data.SqlClient;

namespace _18_ArchivosyBasesdeDatos
{
    internal class ConccionEmpleados
    {
        public List<Empleado> listarEmpleados()
        {
            /* para realizar la coneccion a la base de datos    
             * utilizaremos diferentes objetos 
             * 1° incluimos la librería using System.Data.SqlClient
             * 2° ahí podremos colocar un SQL conecction un SQL command y un SQLDataReader lector
             */

            List<Empleado> list = new List<Empleado>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "Data Source=DESKTOP-3FQKROH\\SQLEXPRESS01; Initial Catalog=EMPLEADOS_DB; Integrated Security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Empleados";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                var auxEmpleado = new Empleado();
                auxEmpleado.NombreCompleto = lector.GetString(1);
                auxEmpleado.DNI = lector.GetString(2);
                auxEmpleado.Edad = lector.GetInt32(3);
                auxEmpleado.Casado = lector.GetBoolean(4);
                auxEmpleado.Salario = lector.GetDecimal(5);

                list.Add(auxEmpleado);
            }
            conexion.Close();



            return list;
        }

        public void AdicionarEmpleado(string nombre, string DNI, int edad, bool estadoCivil, decimal honorario)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DESKTOP-3FQKROH\\SQLEXPRESS01; Initial Catalog=EMPLEADOS_DB; Integrated Security=sspi";

            string query = $" Insert into Empleados (NombreCompleto, DNI, Edad, Casado, Salario) Values('{nombre}','{DNI}','{edad}','{estadoCivil}','{honorario}')";

            SqlCommand comando = new SqlCommand(query, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

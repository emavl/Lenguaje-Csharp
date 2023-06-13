using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_ArchivosyBasesdeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConccionEmpleados conexion = new ConccionEmpleados();
            dgvEmpleados.DataSource = conexion.listarEmpleados();
        }

        private void button_adicion_Click(object sender, EventArgs e)
        {
            var conexion = new ConccionEmpleados();
            var empleado = new Empleado();

            string edadStr = textB_edad.Text;
            string honoraios = textB_honorarios.Text;
            
            int edad;
            bool booleanEdad = int.TryParse(edadStr, out edad);
            decimal SDecimal;
            bool booleanSalario = decimal.TryParse(honoraios, out SDecimal);


            empleado.NombreCompleto = textB_nombre.Text;
            empleado.DNI = textB_documento.Text;
            empleado.Casado = checkB_estadoCivil.Checked ? true : false;

            conexion.AdicionarEmpleado(empleado.NombreCompleto, empleado.DNI, empleado.Edad, empleado.Casado, empleado.Salario);

            checkB_estadoCivil.Checked = false;

            dgvEmpleados.DataSource = conexion.listarEmpleados();
        }
    }
}

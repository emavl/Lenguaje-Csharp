using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _15_winwosForm
{
    public partial class Form_Principal : Form
    {
        List<string> listaDeDatos = new List<string>();

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void ema_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Etiqueta Autor
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Etiqueta paginas
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void ingresoDatos_Click(object sender, EventArgs e)
        {
            // ingreso de los datos 
            string texto_Nombre, texto_Autor, texto_Genero, texto_Paginas, texto_Precio, texto_importado;

            texto_Nombre = textBox_Nombre.Text;
            texto_Autor = textBox_Autor.Text;
            texto_Genero = textBox_Genero.Text;
            texto_Paginas = textBox_Paginas.Text;
            texto_Precio = textBox_Precio.Text;


            listaDeDatos.Add(texto_Nombre);
            listaDeDatos.Add(texto_Genero);
            listaDeDatos.Add(texto_Autor);
            listaDeDatos.Add(texto_Paginas);
            listaDeDatos.Add(texto_Precio);

            if (checkBox1.Checked)
            {
                texto_importado = "Importado";
                listaDeDatos.Add(texto_importado);
            }
            else
            {
                texto_importado = "Nacional";
                listaDeDatos.Add(texto_importado);
            }

            string mensaje = "";

            foreach (var item in listaDeDatos)
            {
                mensaje += $"{item.ToString()} - ";
            }
            lista_datos_ingresados.Items.Add(mensaje);

            textBox_Nombre.Clear();
            textBox_Autor.Clear();
            textBox_Genero.Clear();
            textBox_Paginas.Clear();
            textBox_Precio.Clear();
            listaDeDatos.Clear();
            checkBox1.Checked = false;

            mensaje = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Genero_Click(object sender, EventArgs e)
        {

        }

        private void label_Importado_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lista_datos_ingresados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

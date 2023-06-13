namespace _15_winwosForm
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.label_Genero = new System.Windows.Forms.Label();
            this.label_Autor = new System.Windows.Forms.Label();
            this.label_Paginas = new System.Windows.Forms.Label();
            this.label_Importado = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Autor = new System.Windows.Forms.TextBox();
            this.textBox_Genero = new System.Windows.Forms.TextBox();
            this.textBox_Paginas = new System.Windows.Forms.TextBox();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ingresButton = new System.Windows.Forms.Button();
            this.page1_datos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lista_datos_ingresados = new System.Windows.Forms.ListBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.page1_datos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Label_Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Nombre.Location = new System.Drawing.Point(34, 28);
            this.Label_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(52, 13);
            this.Label_Nombre.TabIndex = 0;
            this.Label_Nombre.Text = "Nombre";
            this.Label_Nombre.Click += new System.EventHandler(this.Label_Nombre_Click);
            // 
            // label_Genero
            // 
            this.label_Genero.AutoSize = true;
            this.label_Genero.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label_Genero.Location = new System.Drawing.Point(34, 97);
            this.label_Genero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Genero.Name = "label_Genero";
            this.label_Genero.Size = new System.Drawing.Size(49, 13);
            this.label_Genero.TabIndex = 1;
            this.label_Genero.Text = "Genero";
            this.label_Genero.Click += new System.EventHandler(this.label_Genero_Click);
            // 
            // label_Autor
            // 
            this.label_Autor.AutoSize = true;
            this.label_Autor.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label_Autor.Location = new System.Drawing.Point(47, 62);
            this.label_Autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Autor.Name = "label_Autor";
            this.label_Autor.Size = new System.Drawing.Size(38, 13);
            this.label_Autor.TabIndex = 2;
            this.label_Autor.Text = "Autor";
            this.label_Autor.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Paginas
            // 
            this.label_Paginas.AutoSize = true;
            this.label_Paginas.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label_Paginas.Location = new System.Drawing.Point(32, 133);
            this.label_Paginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Paginas.Name = "label_Paginas";
            this.label_Paginas.Size = new System.Drawing.Size(51, 13);
            this.label_Paginas.TabIndex = 3;
            this.label_Paginas.Text = "Páginas";
            this.label_Paginas.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Importado
            // 
            this.label_Importado.AutoSize = true;
            this.label_Importado.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label_Importado.Location = new System.Drawing.Point(13, 168);
            this.label_Importado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Importado.Name = "label_Importado";
            this.label_Importado.Size = new System.Drawing.Size(67, 13);
            this.label_Importado.TabIndex = 4;
            this.label_Importado.Text = "Importado";
            this.label_Importado.Click += new System.EventHandler(this.label_Importado_Click);
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label_precio.Location = new System.Drawing.Point(42, 202);
            this.label_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(42, 13);
            this.label_precio.TabIndex = 5;
            this.label_precio.Text = "Precio";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(98, 25);
            this.textBox_Nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(173, 21);
            this.textBox_Nombre.TabIndex = 6;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // textBox_Autor
            // 
            this.textBox_Autor.Location = new System.Drawing.Point(98, 59);
            this.textBox_Autor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Autor.Name = "textBox_Autor";
            this.textBox_Autor.Size = new System.Drawing.Size(173, 21);
            this.textBox_Autor.TabIndex = 7;
            // 
            // textBox_Genero
            // 
            this.textBox_Genero.Location = new System.Drawing.Point(98, 94);
            this.textBox_Genero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Genero.Name = "textBox_Genero";
            this.textBox_Genero.Size = new System.Drawing.Size(173, 21);
            this.textBox_Genero.TabIndex = 8;
            // 
            // textBox_Paginas
            // 
            this.textBox_Paginas.Location = new System.Drawing.Point(98, 130);
            this.textBox_Paginas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Paginas.Name = "textBox_Paginas";
            this.textBox_Paginas.Size = new System.Drawing.Size(173, 21);
            this.textBox_Paginas.TabIndex = 9;
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(98, 199);
            this.textBox_Precio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(173, 21);
            this.textBox_Precio.TabIndex = 10;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Location = new System.Drawing.Point(45, 259);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 32);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ingresButton
            // 
            this.ingresButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingresButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ingresButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresButton.Location = new System.Drawing.Point(244, 259);
            this.ingresButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ingresButton.Name = "ingresButton";
            this.ingresButton.Size = new System.Drawing.Size(78, 32);
            this.ingresButton.TabIndex = 13;
            this.ingresButton.Text = "Ingresar";
            this.ingresButton.UseVisualStyleBackColor = false;
            this.ingresButton.Click += new System.EventHandler(this.ingresoDatos_Click);
            // 
            // page1_datos
            // 
            this.page1_datos.AccessibleName = "Ingreso de datos";
            this.page1_datos.Controls.Add(this.tabPage1);
            this.page1_datos.Controls.Add(this.tabPage2);
            this.page1_datos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.page1_datos.Location = new System.Drawing.Point(12, 12);
            this.page1_datos.Name = "page1_datos";
            this.page1_datos.SelectedIndex = 0;
            this.page1_datos.Size = new System.Drawing.Size(372, 332);
            this.page1_datos.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.textBox_Nombre);
            this.tabPage1.Controls.Add(this.ingresButton);
            this.tabPage1.Controls.Add(this.Label_Nombre);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.label_Genero);
            this.tabPage1.Controls.Add(this.label_Autor);
            this.tabPage1.Controls.Add(this.textBox_Precio);
            this.tabPage1.Controls.Add(this.label_Paginas);
            this.tabPage1.Controls.Add(this.textBox_Paginas);
            this.tabPage1.Controls.Add(this.label_Importado);
            this.tabPage1.Controls.Add(this.textBox_Genero);
            this.tabPage1.Controls.Add(this.label_precio);
            this.tabPage1.Controls.Add(this.textBox_Autor);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de datos";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lista_datos_ingresados);
            this.tabPage2.Controls.Add(this.label_titulo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lista_datos_ingresados
            // 
            this.lista_datos_ingresados.BackColor = System.Drawing.SystemColors.Menu;
            this.lista_datos_ingresados.FormattingEnabled = true;
            this.lista_datos_ingresados.Location = new System.Drawing.Point(25, 50);
            this.lista_datos_ingresados.Name = "lista_datos_ingresados";
            this.lista_datos_ingresados.Size = new System.Drawing.Size(318, 212);
            this.lista_datos_ingresados.TabIndex = 1;
            this.lista_datos_ingresados.SelectedIndexChanged += new System.EventHandler(this.lista_datos_ingresados_SelectedIndexChanged);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_titulo.Location = new System.Drawing.Point(22, 14);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(156, 18);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Datos ingresados:";
            this.label_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(98, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(36, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Si";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 354);
            this.Controls.Add(this.page1_datos);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Principal";
            this.Text = "Gestión de libros";
            this.Load += new System.EventHandler(this.ema_Load);
            this.page1_datos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label label_Genero;
        private System.Windows.Forms.Label label_Autor;
        private System.Windows.Forms.Label label_Paginas;
        private System.Windows.Forms.Label label_Importado;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Autor;
        private System.Windows.Forms.TextBox textBox_Genero;
        private System.Windows.Forms.TextBox textBox_Paginas;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button ingresButton;
        private System.Windows.Forms.TabControl page1_datos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lista_datos_ingresados;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


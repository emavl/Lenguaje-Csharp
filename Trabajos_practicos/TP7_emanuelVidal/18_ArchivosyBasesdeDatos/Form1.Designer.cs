namespace _18_ArchivosyBasesdeDatos
{
    partial class Form1
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.checkB_estadoCivil = new System.Windows.Forms.CheckBox();
            this.button_adicion = new System.Windows.Forms.Button();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label2_Doc = new System.Windows.Forms.Label();
            this.label3_edad = new System.Windows.Forms.Label();
            this.textB_nombre = new System.Windows.Forms.TextBox();
            this.textB_documento = new System.Windows.Forms.TextBox();
            this.textB_edad = new System.Windows.Forms.TextBox();
            this.textB_honorarios = new System.Windows.Forms.TextBox();
            this.label1_honorarios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(13, 221);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(390, 150);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkB_estadoCivil
            // 
            this.checkB_estadoCivil.AutoSize = true;
            this.checkB_estadoCivil.Location = new System.Drawing.Point(70, 150);
            this.checkB_estadoCivil.Name = "checkB_estadoCivil";
            this.checkB_estadoCivil.Size = new System.Drawing.Size(35, 17);
            this.checkB_estadoCivil.TabIndex = 1;
            this.checkB_estadoCivil.Text = "Si";
            this.checkB_estadoCivil.UseVisualStyleBackColor = true;
            // 
            // button_adicion
            // 
            this.button_adicion.BackColor = System.Drawing.SystemColors.Menu;
            this.button_adicion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adicion.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button_adicion.Location = new System.Drawing.Point(240, 138);
            this.button_adicion.Name = "button_adicion";
            this.button_adicion.Size = new System.Drawing.Size(137, 29);
            this.button_adicion.TabIndex = 2;
            this.button_adicion.Text = "Adicionar";
            this.button_adicion.UseVisualStyleBackColor = false;
            this.button_adicion.Click += new System.EventHandler(this.button_adicion_Click);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(5, 29);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(59, 16);
            this.label_Nombre.TabIndex = 3;
            this.label_Nombre.Text = "Nombre";
            // 
            // label2_Doc
            // 
            this.label2_Doc.AutoSize = true;
            this.label2_Doc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_Doc.Location = new System.Drawing.Point(213, 29);
            this.label2_Doc.Name = "label2_Doc";
            this.label2_Doc.Size = new System.Drawing.Size(83, 16);
            this.label2_Doc.TabIndex = 4;
            this.label2_Doc.Text = "Documento";
            // 
            // label3_edad
            // 
            this.label3_edad.AutoSize = true;
            this.label3_edad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_edad.Location = new System.Drawing.Point(5, 74);
            this.label3_edad.Name = "label3_edad";
            this.label3_edad.Size = new System.Drawing.Size(39, 16);
            this.label3_edad.TabIndex = 5;
            this.label3_edad.Text = "Edad";
            // 
            // textB_nombre
            // 
            this.textB_nombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_nombre.Location = new System.Drawing.Point(70, 26);
            this.textB_nombre.Name = "textB_nombre";
            this.textB_nombre.Size = new System.Drawing.Size(122, 23);
            this.textB_nombre.TabIndex = 6;
            // 
            // textB_documento
            // 
            this.textB_documento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_documento.Location = new System.Drawing.Point(302, 26);
            this.textB_documento.Name = "textB_documento";
            this.textB_documento.Size = new System.Drawing.Size(100, 23);
            this.textB_documento.TabIndex = 7;
            // 
            // textB_edad
            // 
            this.textB_edad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_edad.Location = new System.Drawing.Point(70, 71);
            this.textB_edad.Name = "textB_edad";
            this.textB_edad.Size = new System.Drawing.Size(100, 23);
            this.textB_edad.TabIndex = 8;
            // 
            // textB_honorarios
            // 
            this.textB_honorarios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_honorarios.Location = new System.Drawing.Point(302, 71);
            this.textB_honorarios.Name = "textB_honorarios";
            this.textB_honorarios.Size = new System.Drawing.Size(100, 23);
            this.textB_honorarios.TabIndex = 9;
            // 
            // label1_honorarios
            // 
            this.label1_honorarios.AutoSize = true;
            this.label1_honorarios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_honorarios.Location = new System.Drawing.Point(213, 74);
            this.label1_honorarios.Name = "label1_honorarios";
            this.label1_honorarios.Size = new System.Drawing.Size(78, 16);
            this.label1_honorarios.TabIndex = 10;
            this.label1_honorarios.Text = "Honorarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "EstadoC. - casado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1_honorarios);
            this.Controls.Add(this.textB_honorarios);
            this.Controls.Add(this.textB_edad);
            this.Controls.Add(this.textB_documento);
            this.Controls.Add(this.textB_nombre);
            this.Controls.Add(this.label3_edad);
            this.Controls.Add(this.label2_Doc);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.button_adicion);
            this.Controls.Add(this.checkB_estadoCivil);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.CheckBox checkB_estadoCivil;
        private System.Windows.Forms.Button button_adicion;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label2_Doc;
        private System.Windows.Forms.Label label3_edad;
        private System.Windows.Forms.TextBox textB_nombre;
        private System.Windows.Forms.TextBox textB_documento;
        private System.Windows.Forms.TextBox textB_edad;
        private System.Windows.Forms.TextBox textB_honorarios;
        private System.Windows.Forms.Label label1_honorarios;
        private System.Windows.Forms.Label label1;
    }
}


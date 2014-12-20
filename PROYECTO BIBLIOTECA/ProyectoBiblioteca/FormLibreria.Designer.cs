namespace ProyectoBiblioteca
{
    partial class FormLibreria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listViewCategoria = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCategoriaOrganizado = new System.Windows.Forms.ListView();
            this.columnHeaderTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaginas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEdicion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAnio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewEstilo = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCargarLibreria = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewEstiloOrganizado = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNuevoLibro = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(646, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIBRERIA";
            // 
            // listViewCategoria
            // 
            this.listViewCategoria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewCategoria.FullRowSelect = true;
            this.listViewCategoria.Location = new System.Drawing.Point(12, 251);
            this.listViewCategoria.Name = "listViewCategoria";
            this.listViewCategoria.Size = new System.Drawing.Size(605, 307);
            this.listViewCategoria.TabIndex = 3;
            this.listViewCategoria.UseCompatibleStateImageBehavior = false;
            this.listViewCategoria.View = System.Windows.Forms.View.Details;
            this.listViewCategoria.SelectedIndexChanged += new System.EventHandler(this.listViewCategoria_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cantidad de Libros";
            this.columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Categoria";
            this.columnHeader2.Width = 276;
            // 
            // listViewCategoriaOrganizado
            // 
            this.listViewCategoriaOrganizado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitulo,
            this.columnHeaderPaginas,
            this.columnHeaderEdicion,
            this.columnHeaderAnio,
            this.columnHeader5});
            this.listViewCategoriaOrganizado.FullRowSelect = true;
            this.listViewCategoriaOrganizado.Location = new System.Drawing.Point(736, 251);
            this.listViewCategoriaOrganizado.Name = "listViewCategoriaOrganizado";
            this.listViewCategoriaOrganizado.Size = new System.Drawing.Size(973, 307);
            this.listViewCategoriaOrganizado.TabIndex = 5;
            this.listViewCategoriaOrganizado.UseCompatibleStateImageBehavior = false;
            this.listViewCategoriaOrganizado.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitulo
            // 
            this.columnHeaderTitulo.Text = "Titulo";
            this.columnHeaderTitulo.Width = 132;
            // 
            // columnHeaderPaginas
            // 
            this.columnHeaderPaginas.Text = "Nº Pag.";
            this.columnHeaderPaginas.Width = 160;
            // 
            // columnHeaderEdicion
            // 
            this.columnHeaderEdicion.Text = "Nº Edicion";
            this.columnHeaderEdicion.Width = 184;
            // 
            // columnHeaderAnio
            // 
            this.columnHeaderAnio.Text = "Año";
            this.columnHeaderAnio.Width = 158;
            // 
            // listViewEstilo
            // 
            this.listViewEstilo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEstilo.FullRowSelect = true;
            this.listViewEstilo.Location = new System.Drawing.Point(12, 652);
            this.listViewEstilo.Name = "listViewEstilo";
            this.listViewEstilo.Size = new System.Drawing.Size(597, 297);
            this.listViewEstilo.TabIndex = 6;
            this.listViewEstilo.UseCompatibleStateImageBehavior = false;
            this.listViewEstilo.View = System.Windows.Forms.View.Details;
            this.listViewEstilo.SelectedIndexChanged += new System.EventHandler(this.listViewEstilo_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad de Libros";
            this.columnHeader3.Width = 318;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estilo";
            this.columnHeader4.Width = 274;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(4, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 44);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estilo Literario";
            // 
            // buttonCargarLibreria
            // 
            this.buttonCargarLibreria.Location = new System.Drawing.Point(1382, 12);
            this.buttonCargarLibreria.Name = "buttonCargarLibreria";
            this.buttonCargarLibreria.Size = new System.Drawing.Size(327, 58);
            this.buttonCargarLibreria.TabIndex = 11;
            this.buttonCargarLibreria.Text = "Cargar Libreria";
            this.buttonCargarLibreria.UseVisualStyleBackColor = true;
            this.buttonCargarLibreria.Click += new System.EventHandler(this.buttonCargarLibreria_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(728, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(636, 44);
            this.label3.TabIndex = 12;
            this.label3.Text = "LIBROS ORGANIZADOS POR CATEGORIA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(728, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(739, 44);
            this.label7.TabIndex = 13;
            this.label7.Text = "LIBROS ORGANIZADOS POR ESTILO LITERARIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(4, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 44);
            this.label8.TabIndex = 14;
            this.label8.Text = "Categoria";
            // 
            // listViewEstiloOrganizado
            // 
            this.listViewEstiloOrganizado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewEstiloOrganizado.FullRowSelect = true;
            this.listViewEstiloOrganizado.Location = new System.Drawing.Point(736, 652);
            this.listViewEstiloOrganizado.Name = "listViewEstiloOrganizado";
            this.listViewEstiloOrganizado.Size = new System.Drawing.Size(973, 307);
            this.listViewEstiloOrganizado.TabIndex = 15;
            this.listViewEstiloOrganizado.UseCompatibleStateImageBehavior = false;
            this.listViewEstiloOrganizado.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Titulo";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nº Pag.";
            this.columnHeader9.Width = 160;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nº Edicion";
            this.columnHeader10.Width = 184;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Año";
            this.columnHeader11.Width = 158;
            // 
            // buttonNuevoLibro
            // 
            this.buttonNuevoLibro.Location = new System.Drawing.Point(1382, 77);
            this.buttonNuevoLibro.Name = "buttonNuevoLibro";
            this.buttonNuevoLibro.Size = new System.Drawing.Size(327, 60);
            this.buttonNuevoLibro.TabIndex = 16;
            this.buttonNuevoLibro.Text = "Nuevo Libro";
            this.buttonNuevoLibro.UseVisualStyleBackColor = true;
            this.buttonNuevoLibro.Click += new System.EventHandler(this.buttonNuevoLibro_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Categoria";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Nombre Estilo";
            this.columnHeader12.Width = 240;
            // 
            // FormLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1721, 1088);
            this.Controls.Add(this.buttonNuevoLibro);
            this.Controls.Add(this.listViewEstiloOrganizado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCargarLibreria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listViewEstilo);
            this.Controls.Add(this.listViewCategoriaOrganizado);
            this.Controls.Add(this.listViewCategoria);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormLibreria";
            this.Text = "FormLibreria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewCategoria;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewCategoriaOrganizado;
        private System.Windows.Forms.ListView listViewEstilo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCargarLibreria;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeaderTitulo;
        private System.Windows.Forms.ColumnHeader columnHeaderPaginas;
        private System.Windows.Forms.ColumnHeader columnHeaderEdicion;
        private System.Windows.Forms.ColumnHeader columnHeaderAnio;
        private System.Windows.Forms.ListView listViewEstiloOrganizado;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button buttonNuevoLibro;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}
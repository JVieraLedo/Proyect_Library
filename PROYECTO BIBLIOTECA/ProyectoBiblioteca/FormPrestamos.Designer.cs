namespace ProyectoBiblioteca
{
    partial class FormPrestamos
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
            this.textBoxUS = new System.Windows.Forms.TextBox();
            this.textBoxPR = new System.Windows.Forms.TextBox();
            this.textBoxEM = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.listViewPrestamos = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUsuarios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCrearPrestamo = new System.Windows.Forms.Button();
            this.buttonCargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(432, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "ZONA PRESTAMOS";
            // 
            // textBoxUS
            // 
            this.textBoxUS.Location = new System.Drawing.Point(528, 832);
            this.textBoxUS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUS.Name = "textBoxUS";
            this.textBoxUS.Size = new System.Drawing.Size(408, 36);
            this.textBoxUS.TabIndex = 30;
            // 
            // textBoxPR
            // 
            this.textBoxPR.Location = new System.Drawing.Point(528, 778);
            this.textBoxPR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPR.Name = "textBoxPR";
            this.textBoxPR.Size = new System.Drawing.Size(408, 36);
            this.textBoxPR.TabIndex = 29;
            // 
            // textBoxEM
            // 
            this.textBoxEM.Location = new System.Drawing.Point(528, 723);
            this.textBoxEM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEM.Name = "textBoxEM";
            this.textBoxEM.Size = new System.Drawing.Size(408, 36);
            this.textBoxEM.TabIndex = 28;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(528, 668);
            this.textBoxFecha.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(408, 36);
            this.textBoxFecha.TabIndex = 27;
            this.textBoxFecha.Text = "dd/MM/yyyy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 835);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "US#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 781);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "PR#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 726);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "EM#";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(435, 671);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(85, 29);
            this.labelFecha.TabIndex = 26;
            this.labelFecha.Text = "Fecha";
            // 
            // listViewPrestamos
            // 
            this.listViewPrestamos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewPrestamos.Location = new System.Drawing.Point(64, 428);
            this.listViewPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.listViewPrestamos.Name = "listViewPrestamos";
            this.listViewPrestamos.Size = new System.Drawing.Size(1256, 204);
            this.listViewPrestamos.TabIndex = 22;
            this.listViewPrestamos.UseCompatibleStateImageBehavior = false;
            this.listViewPrestamos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "PR#";
            this.columnHeader11.Width = 146;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fecha";
            this.columnHeader7.Width = 157;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fecha devolucion";
            this.columnHeader8.Width = 229;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Fecha limite";
            this.columnHeader9.Width = 181;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Libro";
            this.columnHeader10.Width = 207;
            // 
            // listViewUsuarios
            // 
            this.listViewUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewUsuarios.FullRowSelect = true;
            this.listViewUsuarios.Location = new System.Drawing.Point(62, 129);
            this.listViewUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.listViewUsuarios.Name = "listViewUsuarios";
            this.listViewUsuarios.Size = new System.Drawing.Size(1258, 291);
            this.listViewUsuarios.TabIndex = 21;
            this.listViewUsuarios.UseCompatibleStateImageBehavior = false;
            this.listViewUsuarios.View = System.Windows.Forms.View.Details;
            this.listViewUsuarios.SelectedIndexChanged += new System.EventHandler(this.listViewUsuarios_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "US#";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 184;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellidos";
            this.columnHeader3.Width = 194;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Direccion";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dias bloqueado";
            this.columnHeader5.Width = 198;
            // 
            // buttonCrearPrestamo
            // 
            this.buttonCrearPrestamo.Location = new System.Drawing.Point(168, 778);
            this.buttonCrearPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrearPrestamo.Name = "buttonCrearPrestamo";
            this.buttonCrearPrestamo.Size = new System.Drawing.Size(191, 56);
            this.buttonCrearPrestamo.TabIndex = 20;
            this.buttonCrearPrestamo.Text = "Nuevo";
            this.buttonCrearPrestamo.UseVisualStyleBackColor = true;
            this.buttonCrearPrestamo.Click += new System.EventHandler(this.buttonCrearPrestamo_Click);
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.Location = new System.Drawing.Point(168, 712);
            this.buttonCargarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.Size = new System.Drawing.Size(194, 57);
            this.buttonCargarDatos.TabIndex = 19;
            this.buttonCargarDatos.Text = "Cargar datos";
            this.buttonCargarDatos.UseVisualStyleBackColor = true;
            this.buttonCargarDatos.Click += new System.EventHandler(this.buttonCargarDatos_Click);
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1384, 948);
            this.Controls.Add(this.textBoxUS);
            this.Controls.Add(this.textBoxPR);
            this.Controls.Add(this.textBoxEM);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.listViewPrestamos);
            this.Controls.Add(this.listViewUsuarios);
            this.Controls.Add(this.buttonCrearPrestamo);
            this.Controls.Add(this.buttonCargarDatos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrestamos";
            this.Text = "FormPrestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUS;
        private System.Windows.Forms.TextBox textBoxPR;
        private System.Windows.Forms.TextBox textBoxEM;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ListView listViewPrestamos;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView listViewUsuarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonCrearPrestamo;
        private System.Windows.Forms.Button buttonCargarDatos;
    }
}
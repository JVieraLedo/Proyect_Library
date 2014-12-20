namespace ProyectoBiblioteca
{
    partial class FormBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiblioteca));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.buttonLibreria = new System.Windows.Forms.Button();
            this.buttonAcercaDe = new System.Windows.Forms.Button();
            this.buttonPrestamos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(234, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIBLIOTECA MUNICIPAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.BackColor = System.Drawing.Color.Transparent;
            this.buttonUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUsuario.BackgroundImage")));
            this.buttonUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsuario.FlatAppearance.BorderSize = 0;
            this.buttonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuario.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuario.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonUsuario.Location = new System.Drawing.Point(508, 160);
            this.buttonUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(249, 105);
            this.buttonUsuario.TabIndex = 1;
            this.buttonUsuario.Text = "USUARIO";
            this.buttonUsuario.UseVisualStyleBackColor = false;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.buttonEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEmpleados.BackgroundImage")));
            this.buttonEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmpleados.FlatAppearance.BorderSize = 0;
            this.buttonEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleados.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleados.ForeColor = System.Drawing.Color.Moccasin;
            this.buttonEmpleados.Location = new System.Drawing.Point(132, 160);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(243, 95);
            this.buttonEmpleados.TabIndex = 2;
            this.buttonEmpleados.Text = "EMPLEADOS";
            this.buttonEmpleados.UseVisualStyleBackColor = false;
            this.buttonEmpleados.Click += new System.EventHandler(this.buttonEmpleados_Click);
            // 
            // buttonLibreria
            // 
            this.buttonLibreria.BackColor = System.Drawing.Color.Transparent;
            this.buttonLibreria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLibreria.BackgroundImage")));
            this.buttonLibreria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLibreria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLibreria.FlatAppearance.BorderSize = 0;
            this.buttonLibreria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibreria.Location = new System.Drawing.Point(150, 327);
            this.buttonLibreria.Name = "buttonLibreria";
            this.buttonLibreria.Size = new System.Drawing.Size(201, 203);
            this.buttonLibreria.TabIndex = 3;
            this.buttonLibreria.UseVisualStyleBackColor = false;
            this.buttonLibreria.Click += new System.EventHandler(this.buttonLibreria_Click);
            // 
            // buttonAcercaDe
            // 
            this.buttonAcercaDe.Location = new System.Drawing.Point(662, 639);
            this.buttonAcercaDe.Name = "buttonAcercaDe";
            this.buttonAcercaDe.Size = new System.Drawing.Size(171, 43);
            this.buttonAcercaDe.TabIndex = 4;
            this.buttonAcercaDe.Text = "Acerca de...";
            this.buttonAcercaDe.UseVisualStyleBackColor = true;
            this.buttonAcercaDe.Click += new System.EventHandler(this.buttonAcercaDe_Click);
            // 
            // buttonPrestamos
            // 
            this.buttonPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrestamos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrestamos.BackgroundImage")));
            this.buttonPrestamos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrestamos.FlatAppearance.BorderSize = 0;
            this.buttonPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrestamos.Location = new System.Drawing.Point(526, 322);
            this.buttonPrestamos.Name = "buttonPrestamos";
            this.buttonPrestamos.Size = new System.Drawing.Size(203, 213);
            this.buttonPrestamos.TabIndex = 5;
            this.buttonPrestamos.UseVisualStyleBackColor = false;
            this.buttonPrestamos.Click += new System.EventHandler(this.buttonPrestamos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(550, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prestamos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(196, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Libreria";
            // 
            // FormBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(859, 710);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPrestamos);
            this.Controls.Add(this.buttonAcercaDe);
            this.Controls.Add(this.buttonLibreria);
            this.Controls.Add(this.buttonEmpleados);
            this.Controls.Add(this.buttonUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormBiblioteca";
            this.Text = "PROYECTO BIBLIOTECA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUsuario;
        private System.Windows.Forms.Button buttonEmpleados;
        private System.Windows.Forms.Button buttonLibreria;
        private System.Windows.Forms.Button buttonAcercaDe;
        private System.Windows.Forms.Button buttonPrestamos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


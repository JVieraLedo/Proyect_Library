namespace ProyectoBiblioteca
{
    partial class FormUsuario
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.textBoxApellidosUsuario = new System.Windows.Forms.TextBox();
            this.textBoxDireccionUsuario = new System.Windows.Forms.TextBox();
            this.buttonNuevoUsuario = new System.Windows.Forms.Button();
            this.buttonModificarDatosUsuario = new System.Windows.Forms.Button();
            this.buttonDarBajaUsuario = new System.Windows.Forms.Button();
            this.buttonCargarDatosUsuario = new System.Windows.Forms.Button();
            this.listViewUsuario = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxID_US = new System.Windows.Forms.TextBox();
            this.labelID_US = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(602, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZONA DEL USUARIO";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(66, 219);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(115, 35);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(54, 267);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(127, 35);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellidos";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(53, 315);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(128, 35);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Dirección";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(203, 216);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(504, 42);
            this.textBoxNombreUsuario.TabIndex = 4;
            // 
            // textBoxApellidosUsuario
            // 
            this.textBoxApellidosUsuario.Location = new System.Drawing.Point(203, 264);
            this.textBoxApellidosUsuario.Name = "textBoxApellidosUsuario";
            this.textBoxApellidosUsuario.Size = new System.Drawing.Size(504, 42);
            this.textBoxApellidosUsuario.TabIndex = 5;
            // 
            // textBoxDireccionUsuario
            // 
            this.textBoxDireccionUsuario.Location = new System.Drawing.Point(203, 312);
            this.textBoxDireccionUsuario.Name = "textBoxDireccionUsuario";
            this.textBoxDireccionUsuario.Size = new System.Drawing.Size(504, 42);
            this.textBoxDireccionUsuario.TabIndex = 6;
            // 
            // buttonNuevoUsuario
            // 
            this.buttonNuevoUsuario.Location = new System.Drawing.Point(968, 170);
            this.buttonNuevoUsuario.Name = "buttonNuevoUsuario";
            this.buttonNuevoUsuario.Size = new System.Drawing.Size(230, 50);
            this.buttonNuevoUsuario.TabIndex = 7;
            this.buttonNuevoUsuario.Text = "Nuevo Usuario";
            this.buttonNuevoUsuario.UseVisualStyleBackColor = true;
            this.buttonNuevoUsuario.Click += new System.EventHandler(this.buttonNuevoUsuario_Click);
            // 
            // buttonModificarDatosUsuario
            // 
            this.buttonModificarDatosUsuario.Location = new System.Drawing.Point(968, 225);
            this.buttonModificarDatosUsuario.Name = "buttonModificarDatosUsuario";
            this.buttonModificarDatosUsuario.Size = new System.Drawing.Size(230, 50);
            this.buttonModificarDatosUsuario.TabIndex = 8;
            this.buttonModificarDatosUsuario.Text = "Modificar Datos";
            this.buttonModificarDatosUsuario.UseVisualStyleBackColor = true;
            this.buttonModificarDatosUsuario.Click += new System.EventHandler(this.buttonModificarDatosUsuario_Click);
            // 
            // buttonDarBajaUsuario
            // 
            this.buttonDarBajaUsuario.Location = new System.Drawing.Point(968, 281);
            this.buttonDarBajaUsuario.Name = "buttonDarBajaUsuario";
            this.buttonDarBajaUsuario.Size = new System.Drawing.Size(230, 50);
            this.buttonDarBajaUsuario.TabIndex = 9;
            this.buttonDarBajaUsuario.Text = "Darse de Baja";
            this.buttonDarBajaUsuario.UseVisualStyleBackColor = true;
            this.buttonDarBajaUsuario.Click += new System.EventHandler(this.buttonDarBajaUsuario_Click);
            // 
            // buttonCargarDatosUsuario
            // 
            this.buttonCargarDatosUsuario.Location = new System.Drawing.Point(1338, 23);
            this.buttonCargarDatosUsuario.Name = "buttonCargarDatosUsuario";
            this.buttonCargarDatosUsuario.Size = new System.Drawing.Size(241, 73);
            this.buttonCargarDatosUsuario.TabIndex = 10;
            this.buttonCargarDatosUsuario.Text = "CARGAR DATOS";
            this.buttonCargarDatosUsuario.UseVisualStyleBackColor = true;
            this.buttonCargarDatosUsuario.Click += new System.EventHandler(this.buttonCargarDatosUsuario_Click);
            // 
            // listViewUsuario
            // 
            this.listViewUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewUsuario.FullRowSelect = true;
            this.listViewUsuario.Location = new System.Drawing.Point(27, 394);
            this.listViewUsuario.Name = "listViewUsuario";
            this.listViewUsuario.Size = new System.Drawing.Size(1552, 670);
            this.listViewUsuario.TabIndex = 11;
            this.listViewUsuario.UseCompatibleStateImageBehavior = false;
            this.listViewUsuario.View = System.Windows.Forms.View.Details;
            this.listViewUsuario.SelectedIndexChanged += new System.EventHandler(this.listViewUsuario_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "US#";
            this.columnHeader0.Width = 106;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nombre";
            this.columnHeader7.Width = 198;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Apellidos";
            this.columnHeader8.Width = 230;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Direccion";
            this.columnHeader9.Width = 750;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Dias Bloqueo";
            this.columnHeader10.Width = 224;
            // 
            // textBoxID_US
            // 
            this.textBoxID_US.Location = new System.Drawing.Point(203, 167);
            this.textBoxID_US.Name = "textBoxID_US";
            this.textBoxID_US.Size = new System.Drawing.Size(504, 42);
            this.textBoxID_US.TabIndex = 15;
            // 
            // labelID_US
            // 
            this.labelID_US.AutoSize = true;
            this.labelID_US.Location = new System.Drawing.Point(66, 170);
            this.labelID_US.Name = "labelID_US";
            this.labelID_US.Size = new System.Drawing.Size(70, 35);
            this.labelID_US.TabIndex = 14;
            this.labelID_US.Text = "US#";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1591, 1076);
            this.Controls.Add(this.textBoxID_US);
            this.Controls.Add(this.labelID_US);
            this.Controls.Add(this.listViewUsuario);
            this.Controls.Add(this.buttonCargarDatosUsuario);
            this.Controls.Add(this.buttonDarBajaUsuario);
            this.Controls.Add(this.buttonModificarDatosUsuario);
            this.Controls.Add(this.buttonNuevoUsuario);
            this.Controls.Add(this.textBoxDireccionUsuario);
            this.Controls.Add(this.textBoxApellidosUsuario);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.TextBox textBoxApellidosUsuario;
        private System.Windows.Forms.TextBox textBoxDireccionUsuario;
        private System.Windows.Forms.Button buttonNuevoUsuario;
        private System.Windows.Forms.Button buttonModificarDatosUsuario;
        private System.Windows.Forms.Button buttonDarBajaUsuario;
        private System.Windows.Forms.Button buttonCargarDatosUsuario;
        private System.Windows.Forms.ListView listViewUsuario;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox textBoxID_US;
        private System.Windows.Forms.Label labelID_US;
    }
}
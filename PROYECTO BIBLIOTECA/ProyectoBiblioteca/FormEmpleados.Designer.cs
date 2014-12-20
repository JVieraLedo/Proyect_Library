namespace ProyectoBiblioteca
{
    partial class FormEmpleados
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
            this.labelEmpleadoAcceso = new System.Windows.Forms.Label();
            this.labelEmpleadoClave = new System.Windows.Forms.Label();
            this.textBoxAccesoUsuario = new System.Windows.Forms.TextBox();
            this.textBoxClaveEmpleado = new System.Windows.Forms.TextBox();
            this.tabControlEmpleados = new System.Windows.Forms.TabControl();
            this.tabPageEmpleados = new System.Windows.Forms.TabPage();
            this.listViewEmpleados = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderApellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTurno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTurno = new System.Windows.Forms.TextBox();
            this.textBoxApellidosEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxID_Empleado = new System.Windows.Forms.TextBox();
            this.labelEM = new System.Windows.Forms.Label();
            this.labelTurno = new System.Windows.Forms.Label();
            this.labelApellidosEmpleado = new System.Windows.Forms.Label();
            this.labelNombreEmpleado = new System.Windows.Forms.Label();
            this.buttonEliminarEmpleado = new System.Windows.Forms.Button();
            this.buttonModificarEmpleado = new System.Windows.Forms.Button();
            this.buttonCrearEmpleado = new System.Windows.Forms.Button();
            this.tabPageControlAcceso = new System.Windows.Forms.TabPage();
            this.buttonCargarUsuarios = new System.Windows.Forms.Button();
            this.buttonUsuariosBloqueados = new System.Windows.Forms.Button();
            this.listViewUsuariosBloqueados = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDesbloquearUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewUsuariosGeneral = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCargarDatosEmpleado = new System.Windows.Forms.Button();
            this.tabControlEmpleados.SuspendLayout();
            this.tabPageEmpleados.SuspendLayout();
            this.tabPageControlAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(549, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ZONA DEL EMPLEADO";
            // 
            // labelEmpleadoAcceso
            // 
            this.labelEmpleadoAcceso.AutoSize = true;
            this.labelEmpleadoAcceso.Location = new System.Drawing.Point(61, 128);
            this.labelEmpleadoAcceso.Name = "labelEmpleadoAcceso";
            this.labelEmpleadoAcceso.Size = new System.Drawing.Size(215, 35);
            this.labelEmpleadoAcceso.TabIndex = 3;
            this.labelEmpleadoAcceso.Text = "Empleado Acceso";
            // 
            // labelEmpleadoClave
            // 
            this.labelEmpleadoClave.AutoSize = true;
            this.labelEmpleadoClave.Location = new System.Drawing.Point(132, 176);
            this.labelEmpleadoClave.Name = "labelEmpleadoClave";
            this.labelEmpleadoClave.Size = new System.Drawing.Size(144, 35);
            this.labelEmpleadoClave.TabIndex = 4;
            this.labelEmpleadoClave.Text = "Contraseña";
            // 
            // textBoxAccesoUsuario
            // 
            this.textBoxAccesoUsuario.Location = new System.Drawing.Point(282, 125);
            this.textBoxAccesoUsuario.Name = "textBoxAccesoUsuario";
            this.textBoxAccesoUsuario.Size = new System.Drawing.Size(262, 42);
            this.textBoxAccesoUsuario.TabIndex = 5;
            // 
            // textBoxClaveEmpleado
            // 
            this.textBoxClaveEmpleado.Location = new System.Drawing.Point(282, 173);
            this.textBoxClaveEmpleado.Name = "textBoxClaveEmpleado";
            this.textBoxClaveEmpleado.Size = new System.Drawing.Size(262, 42);
            this.textBoxClaveEmpleado.TabIndex = 6;
            this.textBoxClaveEmpleado.UseSystemPasswordChar = true;
            // 
            // tabControlEmpleados
            // 
            this.tabControlEmpleados.Controls.Add(this.tabPageEmpleados);
            this.tabControlEmpleados.Controls.Add(this.tabPageControlAcceso);
            this.tabControlEmpleados.Location = new System.Drawing.Point(12, 315);
            this.tabControlEmpleados.Name = "tabControlEmpleados";
            this.tabControlEmpleados.SelectedIndex = 0;
            this.tabControlEmpleados.Size = new System.Drawing.Size(1532, 698);
            this.tabControlEmpleados.TabIndex = 7;
            // 
            // tabPageEmpleados
            // 
            this.tabPageEmpleados.Controls.Add(this.listViewEmpleados);
            this.tabPageEmpleados.Controls.Add(this.textBoxTurno);
            this.tabPageEmpleados.Controls.Add(this.textBoxApellidosEmpleado);
            this.tabPageEmpleados.Controls.Add(this.textBoxNombreEmpleado);
            this.tabPageEmpleados.Controls.Add(this.textBoxID_Empleado);
            this.tabPageEmpleados.Controls.Add(this.labelEM);
            this.tabPageEmpleados.Controls.Add(this.labelTurno);
            this.tabPageEmpleados.Controls.Add(this.labelApellidosEmpleado);
            this.tabPageEmpleados.Controls.Add(this.labelNombreEmpleado);
            this.tabPageEmpleados.Controls.Add(this.buttonEliminarEmpleado);
            this.tabPageEmpleados.Controls.Add(this.buttonModificarEmpleado);
            this.tabPageEmpleados.Controls.Add(this.buttonCrearEmpleado);
            this.tabPageEmpleados.Location = new System.Drawing.Point(4, 44);
            this.tabPageEmpleados.Name = "tabPageEmpleados";
            this.tabPageEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmpleados.Size = new System.Drawing.Size(1524, 650);
            this.tabPageEmpleados.TabIndex = 0;
            this.tabPageEmpleados.Text = "Empleados";
            this.tabPageEmpleados.UseVisualStyleBackColor = true;
            // 
            // listViewEmpleados
            // 
            this.listViewEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNombre,
            this.columnHeaderApellidos,
            this.columnHeaderTurno});
            this.listViewEmpleados.FullRowSelect = true;
            this.listViewEmpleados.Location = new System.Drawing.Point(6, 212);
            this.listViewEmpleados.Name = "listViewEmpleados";
            this.listViewEmpleados.Size = new System.Drawing.Size(982, 438);
            this.listViewEmpleados.TabIndex = 11;
            this.listViewEmpleados.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleados.View = System.Windows.Forms.View.Details;
            this.listViewEmpleados.SelectedIndexChanged += new System.EventHandler(this.listViewEmpleados_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 92;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 210;
            // 
            // columnHeaderApellidos
            // 
            this.columnHeaderApellidos.Text = "Apellidos";
            this.columnHeaderApellidos.Width = 394;
            // 
            // columnHeaderTurno
            // 
            this.columnHeaderTurno.Text = "Turno";
            this.columnHeaderTurno.Width = 250;
            // 
            // textBoxTurno
            // 
            this.textBoxTurno.Location = new System.Drawing.Point(361, 150);
            this.textBoxTurno.Name = "textBoxTurno";
            this.textBoxTurno.Size = new System.Drawing.Size(366, 42);
            this.textBoxTurno.TabIndex = 10;
            // 
            // textBoxApellidosEmpleado
            // 
            this.textBoxApellidosEmpleado.Location = new System.Drawing.Point(361, 102);
            this.textBoxApellidosEmpleado.Name = "textBoxApellidosEmpleado";
            this.textBoxApellidosEmpleado.Size = new System.Drawing.Size(366, 42);
            this.textBoxApellidosEmpleado.TabIndex = 9;
            // 
            // textBoxNombreEmpleado
            // 
            this.textBoxNombreEmpleado.Location = new System.Drawing.Point(361, 54);
            this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
            this.textBoxNombreEmpleado.Size = new System.Drawing.Size(366, 42);
            this.textBoxNombreEmpleado.TabIndex = 8;
            // 
            // textBoxID_Empleado
            // 
            this.textBoxID_Empleado.Location = new System.Drawing.Point(361, 6);
            this.textBoxID_Empleado.Name = "textBoxID_Empleado";
            this.textBoxID_Empleado.Size = new System.Drawing.Size(366, 42);
            this.textBoxID_Empleado.TabIndex = 7;
            // 
            // labelEM
            // 
            this.labelEM.AutoSize = true;
            this.labelEM.Location = new System.Drawing.Point(196, 11);
            this.labelEM.Name = "labelEM";
            this.labelEM.Size = new System.Drawing.Size(159, 35);
            this.labelEM.TabIndex = 6;
            this.labelEM.Text = "ID Empleado";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(273, 153);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(82, 35);
            this.labelTurno.TabIndex = 5;
            this.labelTurno.Text = "Turno";
            // 
            // labelApellidosEmpleado
            // 
            this.labelApellidosEmpleado.AutoSize = true;
            this.labelApellidosEmpleado.Location = new System.Drawing.Point(116, 105);
            this.labelApellidosEmpleado.Name = "labelApellidosEmpleado";
            this.labelApellidosEmpleado.Size = new System.Drawing.Size(239, 35);
            this.labelApellidosEmpleado.TabIndex = 4;
            this.labelApellidosEmpleado.Text = "Apellidos Empleado";
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Location = new System.Drawing.Point(246, 57);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(109, 35);
            this.labelNombreEmpleado.TabIndex = 3;
            this.labelNombreEmpleado.Text = "Nombre";
            // 
            // buttonEliminarEmpleado
            // 
            this.buttonEliminarEmpleado.Location = new System.Drawing.Point(1161, 108);
            this.buttonEliminarEmpleado.Name = "buttonEliminarEmpleado";
            this.buttonEliminarEmpleado.Size = new System.Drawing.Size(235, 45);
            this.buttonEliminarEmpleado.TabIndex = 2;
            this.buttonEliminarEmpleado.Text = "Eliminar Empleado";
            this.buttonEliminarEmpleado.UseVisualStyleBackColor = true;
            this.buttonEliminarEmpleado.Click += new System.EventHandler(this.buttonEliminarEmpleado_Click);
            // 
            // buttonModificarEmpleado
            // 
            this.buttonModificarEmpleado.Location = new System.Drawing.Point(1161, 57);
            this.buttonModificarEmpleado.Name = "buttonModificarEmpleado";
            this.buttonModificarEmpleado.Size = new System.Drawing.Size(235, 45);
            this.buttonModificarEmpleado.TabIndex = 1;
            this.buttonModificarEmpleado.Text = "Modificar Datos";
            this.buttonModificarEmpleado.UseVisualStyleBackColor = true;
            this.buttonModificarEmpleado.Click += new System.EventHandler(this.buttonModificarEmpleado_Click);
            // 
            // buttonCrearEmpleado
            // 
            this.buttonCrearEmpleado.Location = new System.Drawing.Point(1161, 6);
            this.buttonCrearEmpleado.Name = "buttonCrearEmpleado";
            this.buttonCrearEmpleado.Size = new System.Drawing.Size(235, 45);
            this.buttonCrearEmpleado.TabIndex = 0;
            this.buttonCrearEmpleado.Text = "Crear Empleado";
            this.buttonCrearEmpleado.UseVisualStyleBackColor = true;
            this.buttonCrearEmpleado.Click += new System.EventHandler(this.buttonCrearEmpleado_Click);
            // 
            // tabPageControlAcceso
            // 
            this.tabPageControlAcceso.Controls.Add(this.buttonCargarUsuarios);
            this.tabPageControlAcceso.Controls.Add(this.buttonUsuariosBloqueados);
            this.tabPageControlAcceso.Controls.Add(this.listViewUsuariosBloqueados);
            this.tabPageControlAcceso.Controls.Add(this.buttonDesbloquearUsuario);
            this.tabPageControlAcceso.Controls.Add(this.label2);
            this.tabPageControlAcceso.Controls.Add(this.listViewUsuariosGeneral);
            this.tabPageControlAcceso.Location = new System.Drawing.Point(4, 44);
            this.tabPageControlAcceso.Name = "tabPageControlAcceso";
            this.tabPageControlAcceso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageControlAcceso.Size = new System.Drawing.Size(1524, 650);
            this.tabPageControlAcceso.TabIndex = 1;
            this.tabPageControlAcceso.Text = "Zona de Control";
            this.tabPageControlAcceso.UseVisualStyleBackColor = true;
            // 
            // buttonCargarUsuarios
            // 
            this.buttonCargarUsuarios.Location = new System.Drawing.Point(0, 0);
            this.buttonCargarUsuarios.Name = "buttonCargarUsuarios";
            this.buttonCargarUsuarios.Size = new System.Drawing.Size(260, 54);
            this.buttonCargarUsuarios.TabIndex = 16;
            this.buttonCargarUsuarios.Text = "Cargar Usuarios";
            this.buttonCargarUsuarios.UseVisualStyleBackColor = true;
            this.buttonCargarUsuarios.Click += new System.EventHandler(this.buttonCargarUsuarios_Click);
            // 
            // buttonUsuariosBloqueados
            // 
            this.buttonUsuariosBloqueados.Location = new System.Drawing.Point(1057, 71);
            this.buttonUsuariosBloqueados.Name = "buttonUsuariosBloqueados";
            this.buttonUsuariosBloqueados.Size = new System.Drawing.Size(339, 49);
            this.buttonUsuariosBloqueados.TabIndex = 15;
            this.buttonUsuariosBloqueados.Text = "Usuarios Bloqueados";
            this.buttonUsuariosBloqueados.UseVisualStyleBackColor = true;
            this.buttonUsuariosBloqueados.Click += new System.EventHandler(this.buttonUsuariosBloqueados_Click);
            // 
            // listViewUsuariosBloqueados
            // 
            this.listViewUsuariosBloqueados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listViewUsuariosBloqueados.FullRowSelect = true;
            this.listViewUsuariosBloqueados.Location = new System.Drawing.Point(975, 154);
            this.listViewUsuariosBloqueados.Name = "listViewUsuariosBloqueados";
            this.listViewUsuariosBloqueados.Size = new System.Drawing.Size(523, 490);
            this.listViewUsuariosBloqueados.TabIndex = 14;
            this.listViewUsuariosBloqueados.UseCompatibleStateImageBehavior = false;
            this.listViewUsuariosBloqueados.View = System.Windows.Forms.View.Details;
            this.listViewUsuariosBloqueados.SelectedIndexChanged += new System.EventHandler(this.listViewUsuariosBloqueados_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Usuario";
            this.columnHeader6.Width = 310;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Días Bloqueado";
            this.columnHeader7.Width = 204;
            // 
            // buttonDesbloquearUsuario
            // 
            this.buttonDesbloquearUsuario.Location = new System.Drawing.Point(1057, 14);
            this.buttonDesbloquearUsuario.Name = "buttonDesbloquearUsuario";
            this.buttonDesbloquearUsuario.Size = new System.Drawing.Size(339, 51);
            this.buttonDesbloquearUsuario.TabIndex = 10;
            this.buttonDesbloquearUsuario.Text = "Desbloquear Usuario";
            this.buttonDesbloquearUsuario.UseVisualStyleBackColor = true;
            this.buttonDesbloquearUsuario.Click += new System.EventHandler(this.buttonDesbloquearUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(296, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIOS";
            // 
            // listViewUsuariosGeneral
            // 
            this.listViewUsuariosGeneral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewUsuariosGeneral.FullRowSelect = true;
            this.listViewUsuariosGeneral.Location = new System.Drawing.Point(6, 154);
            this.listViewUsuariosGeneral.Name = "listViewUsuariosGeneral";
            this.listViewUsuariosGeneral.Size = new System.Drawing.Size(963, 500);
            this.listViewUsuariosGeneral.TabIndex = 0;
            this.listViewUsuariosGeneral.UseCompatibleStateImageBehavior = false;
            this.listViewUsuariosGeneral.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Usuario";
            this.columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Título";
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha Inicial";
            this.columnHeader3.Width = 194;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha Devolucion";
            this.columnHeader4.Width = 182;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha Limite";
            this.columnHeader5.Width = 154;
            // 
            // buttonCargarDatosEmpleado
            // 
            this.buttonCargarDatosEmpleado.Location = new System.Drawing.Point(1318, 32);
            this.buttonCargarDatosEmpleado.Name = "buttonCargarDatosEmpleado";
            this.buttonCargarDatosEmpleado.Size = new System.Drawing.Size(226, 72);
            this.buttonCargarDatosEmpleado.TabIndex = 8;
            this.buttonCargarDatosEmpleado.Text = "Cargar Datos";
            this.buttonCargarDatosEmpleado.UseVisualStyleBackColor = true;
            this.buttonCargarDatosEmpleado.Click += new System.EventHandler(this.buttonCargarDatosEmpleado_Click);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1577, 1106);
            this.Controls.Add(this.buttonCargarDatosEmpleado);
            this.Controls.Add(this.tabControlEmpleados);
            this.Controls.Add(this.textBoxClaveEmpleado);
            this.Controls.Add(this.textBoxAccesoUsuario);
            this.Controls.Add(this.labelEmpleadoClave);
            this.Controls.Add(this.labelEmpleadoAcceso);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormEmpleados";
            this.Text = "FormEmpleados";
            this.tabControlEmpleados.ResumeLayout(false);
            this.tabPageEmpleados.ResumeLayout(false);
            this.tabPageEmpleados.PerformLayout();
            this.tabPageControlAcceso.ResumeLayout(false);
            this.tabPageControlAcceso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmpleadoAcceso;
        private System.Windows.Forms.Label labelEmpleadoClave;
        private System.Windows.Forms.TextBox textBoxAccesoUsuario;
        private System.Windows.Forms.TextBox textBoxClaveEmpleado;
        private System.Windows.Forms.TabControl tabControlEmpleados;
        private System.Windows.Forms.TabPage tabPageEmpleados;
        private System.Windows.Forms.Label labelEM;
        private System.Windows.Forms.Label labelTurno;
        private System.Windows.Forms.Label labelApellidosEmpleado;
        private System.Windows.Forms.Label labelNombreEmpleado;
        private System.Windows.Forms.Button buttonEliminarEmpleado;
        private System.Windows.Forms.Button buttonModificarEmpleado;
        private System.Windows.Forms.Button buttonCrearEmpleado;
        private System.Windows.Forms.TabPage tabPageControlAcceso;
        private System.Windows.Forms.Button buttonCargarDatosEmpleado;
        private System.Windows.Forms.ListView listViewEmpleados;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderApellidos;
        private System.Windows.Forms.ColumnHeader columnHeaderTurno;
        private System.Windows.Forms.TextBox textBoxTurno;
        private System.Windows.Forms.TextBox textBoxApellidosEmpleado;
        private System.Windows.Forms.TextBox textBoxNombreEmpleado;
        private System.Windows.Forms.TextBox textBoxID_Empleado;
        private System.Windows.Forms.ListView listViewUsuariosBloqueados;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buttonDesbloquearUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewUsuariosGeneral;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonUsuariosBloqueados;
        private System.Windows.Forms.Button buttonCargarUsuarios;
    }
}
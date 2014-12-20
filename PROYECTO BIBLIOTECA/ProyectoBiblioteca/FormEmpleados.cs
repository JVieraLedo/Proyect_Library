using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ProyectoBiblioteca
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void cargarDatosEmpleado()
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString = 
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                //"Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=" + textBoxAccesoUsuario.Text +
                //    "; Password=" + textBoxClaveEmpleado.Text;
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT EM#, Nombre, Apellidos, Turno FROM Empleado ORDER BY EM# ASC";

                reader = comando.ExecuteReader();
                listViewEmpleados.Items.Clear();

                while (reader.Read())
                {
                    string EM, nombre, apellidos, turno;

                    EM = reader.GetString(0);
                    nombre = reader.GetString(1);
                    apellidos = reader.GetString(2);
                    turno = reader.GetString(3);

                    ListViewItem item = new ListViewItem();

                    item.Text = EM;
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(apellidos);
                    item.SubItems.Add(turno);

                    listViewEmpleados.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

                MessageBox.Show("Datos Cargados con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR en Carga Usuarios: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void usuariosBloqueados()
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=" + textBoxAccesoUsuario.Text +
                    //"; Password=" + textBoxClaveEmpleado.Text;
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                //--Usuarios con libros sin devolver y fuera de plazo.
                comando.CommandText =
                "UPDATE Usuario " +
                "SET  DiasBloqueo = (SELECT (TRUNC(SYSDATE - Realiza.FechaLimite) * 5 ) " + 
					"FROM Realiza  " +
					"WHERE Realiza.US# = Usuario.US# AND " +
					"FechaDevolucion IS NULL         AND " +
					"SYSDATE > FechaLimite) " +
                "WHERE US# IN (SELECT US# FROM Realiza WHERE SYSDATE > FechaLimite AND FechaDevolucion IS NULL)";
                comando.ExecuteNonQuery();

                //--Usuarios con libros devueltos fuera de la fecha limite.
                comando.CommandText =
                "UPDATE Usuario " +
                "SET  DiasBloqueo = (SELECT (TRUNC(Realiza.FechaDevolucion - Realiza.FechaLimite) * 5 ) " + 
					"FROM Realiza " +
					"WHERE Realiza.US# = Usuario.US# AND " +
					"FechaDevolucion > FechaLimite) " +
                "WHERE US# IN (SELECT US# FROM Realiza " +
			    "WHERE Realiza.US# = Usuario.US# AND FechaDevolucion > FechaLimite)";
                comando.ExecuteNonQuery();

                comando.CommandText = "SELECT Nombre, diasbloqueo FROM usuario WHERE (diasbloqueo>0)";

                reader = comando.ExecuteReader();
                listViewUsuariosBloqueados.Items.Clear();

                while (reader.Read())
                {
                    string nombre;
                    int diasbloqueo;

                    nombre = reader.GetString(0);
                    diasbloqueo = reader.GetInt32(1);

                    ListViewItem item = new ListViewItem();

                    item.Text = nombre;
                    item.SubItems.Add(diasbloqueo.ToString());

                    listViewUsuariosBloqueados.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

               // MessageBox.Show("Datos Cargados con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR en Carga Usuarios: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCargarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=" + textBoxAccesoUsuario.Text +
                    //"; Password=" + textBoxClaveEmpleado.Text;
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Nombre, Titulo, Fecha, FechaDevolucion ,FechaLimite " +
                                      "FROM Usuario, Realiza, Prestamo, Tiene, Libro " +
                                      "WHERE Usuario.US# = Realiza.US# AND " +
                                                          "Realiza.PR# = Prestamo.PR# AND " +
                                                          "Prestamo.PR# = Tiene.PR# AND " +
                                                          "Tiene.LI# = Libro.LI#";
                reader = comando.ExecuteReader();
                listViewEmpleados.Items.Clear();

                while (reader.Read())
                {
                    string nombre, titulo, fecha, fechaDevolucion, fechaLimite;

                    nombre = reader.GetString(0);
                    titulo = reader.GetString(1);
                    fecha = reader.GetDateTime(2).ToShortDateString();
                    if (!reader.IsDBNull(3))
                        fechaDevolucion = reader.GetDateTime(3).ToShortDateString();
                    else
                        fechaDevolucion = "";
                    fechaLimite = reader.GetDateTime(4).ToShortDateString();

                    ListViewItem item = new ListViewItem();

                    item.Text = nombre;
                    item.SubItems.Add(titulo);
                    item.SubItems.Add(fecha);
                    item.SubItems.Add(fechaDevolucion);
                    item.SubItems.Add(fechaLimite);

                    listViewUsuariosGeneral.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

               // MessageBox.Show("Datos Cargados con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR en Carga Usuarios: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCargarDatosEmpleado_Click(object sender, EventArgs e)
        {
            cargarDatosEmpleado();
        }

        private void buttonCrearEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=" + textBoxAccesoUsuario.Text +
                    //"; Password=" + textBoxClaveEmpleado.Text;
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO Empleado ( EM#, Nombre, Apellidos, Turno) VALUES (" +
                    "'" + textBoxID_Empleado.Text + "', " +
                    "'" + textBoxNombreEmpleado.Text + "', " +
                    "'" + textBoxApellidosEmpleado.Text + "', " +
                    "'" + textBoxTurno.Text + "')";

                comando.ExecuteNonQuery();
                conexion.Close();

                cargarDatosEmpleado();

                //MessageBox.Show("Datos Creados con Éxito con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR en Crear Datos: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=" + textBoxAccesoUsuario.Text +
                    //"; Password=" + textBoxClaveEmpleado.Text;
                conexion.Open();

                comando = new OracleCommand();

                comando.Connection = conexion;
                comando.CommandText = "UPDATE Empleado SET " +
                    "Nombre = '" + textBoxNombreEmpleado.Text + "', " +
                    "Apellidos = '" + textBoxApellidosEmpleado.Text + "', " +
                    "Turno = '" + textBoxTurno.Text + "' " +
                    " WHERE EM# = '" + textBoxID_Empleado.Text + "'";

                comando.ExecuteNonQuery();
                conexion.Close();

                cargarDatosEmpleado();

                //MessageBox.Show("Datos Modificados con Éxito con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR al Modificar Datos: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F"
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=" + textBoxAccesoUsuario.Text +
                    //"; Password=" + textBoxClaveEmpleado.Text;
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "DELETE FROM Empleado " +
                    " WHERE EM# = '" + textBoxID_Empleado.Text + "'";

                comando.ExecuteNonQuery();
                conexion.Close();

                cargarDatosEmpleado();

                //MessageBox.Show("Datos Eliminados con Éxito con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR al Eliminar Datos: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listViewEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmpleados.SelectedItems.Count != 0)
            {

                ListViewItem item = listViewEmpleados.SelectedItems[0];

                textBoxID_Empleado.Text = item.SubItems[0].Text;
                textBoxNombreEmpleado.Text = item.SubItems[1].Text;
                textBoxApellidosEmpleado.Text = item.SubItems[2].Text;
                textBoxTurno.Text = item.SubItems[3].Text;

            }
        }

        private void buttonUsuariosBloqueados_Click(object sender, EventArgs e)
        {
            usuariosBloqueados();
        }

        private void buttonDesbloquearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=" + textBoxAccesoUsuario.Text +
                    //"; Password=" + textBoxClaveEmpleado.Text;
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "UPDATE Usuario SET DiasBloqueo = NULL WHERE nombre = '" + listViewUsuariosBloqueados.Text + "'";

                reader = comando.ExecuteReader();
                listViewUsuariosBloqueados.Items.Clear();

                while (reader.Read())
                {
                    string nombre;
                    int diasbloqueo;

                    nombre = reader.GetString(0);
                    diasbloqueo = reader.GetInt32(1);

                    ListViewItem item = new ListViewItem();

                    item.Text = nombre;
                    item.SubItems.Add(diasbloqueo.ToString());

                    listViewUsuariosBloqueados.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

                usuariosBloqueados();

               // MessageBox.Show("Datos Cargados con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR en Carga Usuarios: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listViewUsuariosBloqueados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsuariosBloqueados.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewUsuariosBloqueados.SelectedItems[0];

                listViewUsuariosBloqueados.Text = item.SubItems[0].Text;
            }

        }
    }
}

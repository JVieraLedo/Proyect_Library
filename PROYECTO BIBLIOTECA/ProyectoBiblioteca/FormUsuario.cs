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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }     

        private void cargarDatosUsuario()
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID= prueba; Password= prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT US#, Nombre, Apellidos, Direccion, DiasBloqueo FROM Usuario ORDER BY US# ASC";

                reader = comando.ExecuteReader();
                listViewUsuario.Items.Clear();

                while (reader.Read())
                {
                    string US, nombre, apellidos, direccion;
                    int diasBloqueo;
                    US = reader.GetString(0);
                    nombre = reader.GetString(1);
                    apellidos = reader.GetString(2);
                    direccion = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        diasBloqueo = reader.GetInt32(4);
                    else
                        diasBloqueo = 0;

                    ListViewItem item = new ListViewItem();

                    item.Text = US;
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(apellidos);
                    item.SubItems.Add(direccion);
                    item.SubItems.Add(diasBloqueo.ToString());

                    listViewUsuario.Items.Add(item);
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
        private void buttonCargarDatosUsuario_Click(object sender, EventArgs e)
        {
            cargarDatosUsuario();
        }

        private void listViewUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsuario.SelectedItems.Count != 0)
            {

                ListViewItem item = listViewUsuario.SelectedItems[0];

                textBoxID_US.Text = item.SubItems[0].Text;
                textBoxNombreUsuario.Text = item.SubItems[1].Text;
                textBoxApellidosUsuario.Text = item.SubItems[2].Text;
                textBoxDireccionUsuario.Text = item.SubItems[3].Text;
            }
        }

        private void buttonNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID= prueba; Password= prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO Usuario ( US#, Nombre, Apellidos, Direccion) VALUES (" +
                    "'" + textBoxID_US.Text + "', " +
                    "'" + textBoxNombreUsuario.Text + "', " +
                    "'" + textBoxApellidosUsuario.Text + "', " +
                    "'" + textBoxDireccionUsuario.Text + "')";

                comando.ExecuteNonQuery();
                conexion.Close();

                cargarDatosUsuario();

                MessageBox.Show("Datos Creados con Éxito con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR en Crear Datos: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonModificarDatosUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=prueba; Password=prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "UPDATE Usuario SET " +
                    "Nombre = '" + textBoxNombreUsuario.Text + "' " +
                    "Apellidos = '" + textBoxApellidosUsuario.Text + "' " +
                    "Direccion = '" + textBoxDireccionUsuario.Text + "' " +
                    //"DiasBloqueo = '' " +
                    " WHERE US# = '" + textBoxID_US.Text + "'";


                comando.ExecuteNonQuery();
                conexion.Close();

                cargarDatosUsuario();

                MessageBox.Show("Datos Modificados con Éxito con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR al Modificar Datos: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDarBajaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=prueba; Password=prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "DELETE FROM Usuario " +
                    " WHERE US# = '" + textBoxID_US.Text + "'";

                comando.ExecuteNonQuery();
                conexion.Close();

                cargarDatosUsuario();

                MessageBox.Show("Datos Eliminados con Éxito con éxito", "Aplicación Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException err)
            {
                MessageBox.Show(
                    "ERROR al Eliminar Datos: " + err.Message,
                    "Aplicacion de Conexion a Base de Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


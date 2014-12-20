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
    public partial class FormPrestamos : Form
    {
        public FormPrestamos()
        {
            InitializeComponent();
        }

        private void cargarUsuarios()
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;


                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                conexion.Open();


                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM Usuario";


                reader = comando.ExecuteReader();

                listViewUsuarios.Items.Clear();


                while (reader.Read())
                {

                    string claveUS, nombre, apellidos, direccion;
                    int diasBloqueo;

                    claveUS = reader.GetString(0);
                    nombre = reader.GetString(1);
                    apellidos = reader.GetString(2);
                    direccion = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        diasBloqueo = reader.GetInt32(4);
                    else
                        diasBloqueo = 0;

                    ListViewItem item = new ListViewItem();

                    item.Text = claveUS;                 
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(apellidos);
                    item.SubItems.Add(direccion);
                    item.SubItems.Add(diasBloqueo.ToString());

                    listViewUsuarios.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

                MessageBox.Show(
                    "Datos cargados con éxito",
                    "Aplicacion de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error en conexión a base de datos: " + ex.Message,
                    "Aplicacion de Conexion a base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

        }

        private void cargarUsuariosConPrestamos(string US)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=prueba; Password=prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Prestamo.PR#, Realiza.Fecha, Realiza.FechaDevolucion, Realiza.FechaLimite, Libro.Titulo " +
                                      "FROM Libro, Tiene, Prestamo, Realiza, Usuario " +
                                      "WHERE Libro.LI# = Tiene.LI# AND " +
                                      "Tiene.PR# = Prestamo.PR# AND " +
                                      "Prestamo.PR# = Realiza.PR# AND " +
                                      "Usuario.US# = Realiza.US# AND " +
                                      "FechaDevolucion IS NOT NULL AND " +
                                      "Usuario.US# = '" + US + "' " +
                                      "ORDER BY Realiza.Fecha";

                reader = comando.ExecuteReader();

                listViewPrestamos.Items.Clear();

                while (reader.Read())
                {

                    string clavePR, nombreLibro;
                    DateTime fecha, fechaDevolucion, fechaLimite;

                    clavePR = reader.GetString(0);
                    fecha = reader.GetDateTime(1);
                    fechaDevolucion = reader.GetDateTime(2);
                    fechaLimite = reader.GetDateTime(3);
                    nombreLibro = reader.GetString(4);

                    ListViewItem item = new ListViewItem();

                    item.Text = clavePR;
                    item.SubItems.Add(fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(fechaDevolucion.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(fechaLimite.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(nombreLibro);

                    listViewPrestamos.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error en carga empleados: " + ex.Message,
                    "Aplicación de Conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void buttonCrearPrestamo_Click(object sender, EventArgs e)
        {
            try
            {

                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F";
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID=prueba; Password=prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO Realiza (Fecha, FechaLimite, EM#, PR#, US#) VALUES (" +
                                      "'" + textBoxFecha.Text + "'," +
                                      "TO_DATE('" + textBoxFecha.Text + "')+14 ," +
                                      "'" + textBoxEM.Text + "'," +
                                      "'" + textBoxPR.Text + "'," +
                                      "'" + textBoxUS.Text + "')";

                comando.ExecuteNonQuery();

                reader = comando.ExecuteReader();

                conexion.Close();

                listViewUsuarios.Items.Clear();
                cargarUsuarios();

               // MessageBox.Show( "Empleado añadido satisfactoriamente", "Aplicacion de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error en conexión a base de datos: " + ex.Message,
                    "Aplicacion de Conexion a base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void listViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsuarios.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewUsuarios.SelectedItems[0];
                string claveUS;

                claveUS = item.SubItems[0].Text;
                cargarUsuariosConPrestamos(claveUS);
            }
        }
    }
}

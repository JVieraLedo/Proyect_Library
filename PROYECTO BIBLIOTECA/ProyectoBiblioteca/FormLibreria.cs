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
    public partial class FormLibreria : Form
    {
        public FormLibreria()
        {
            InitializeComponent();
        }

        private void cargarLibrosPorCantidadCategorias()
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F"
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID= prueba; Password= prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT COUNT(Libro.Titulo), Categoria.Nombre  " +
                                      "FROM Libro, Categoria " +
                                      "WHERE Libro.CA# = Categoria.CA# " +
                                      "GROUP BY Categoria.Nombre " +
                                      "ORDER BY Categoria.Nombre ";            

                reader = comando.ExecuteReader();

                listViewCategoria.Items.Clear();

                while (reader.Read())
                {
                    string categoria;
                    int numero;

                    numero = reader.GetInt32(0);
                    categoria = reader.GetString(1);                    

                    ListViewItem item = new ListViewItem();

                    item.Text = numero.ToString();
                    item.SubItems.Add(categoria);

                    listViewCategoria.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

                //MessageBox.Show("Datos cargados con éxito",
                //    "Aplicación de base de datos",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error en carga Libros: " + ex.Message,
                    "Aplicación de Conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarLibrosPorCategoria(string cat)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F"
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID= prueba; Password= prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Li.Titulo, Li.NumPaginas, Li.NumEdicion, Anio, Ca.Nombre  " +
                    "FROM Libro Li JOIN Categoria Ca ON Li.CA# = Ca.CA# " +
                    "WHERE Ca.Nombre = '" + cat + "' ";

                reader = comando.ExecuteReader();

                listViewCategoriaOrganizado.Items.Clear();
                while (reader.Read())
                {

                    string titulo, numPaginas, numEdicion, anio, categoria;

                    titulo = reader.GetString(0);
                    numPaginas = reader.GetString(1);
                    numEdicion = reader.GetString(2);
                    anio = reader.GetString(3);
                    categoria = reader.GetString(4);

                    ListViewItem item = new ListViewItem();

                    item.Text = titulo;
                    item.SubItems.Add(numPaginas);
                    item.SubItems.Add(numEdicion);
                    item.SubItems.Add(anio);
                    item.SubItems.Add(categoria);

                    listViewCategoriaOrganizado.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

                //MessageBox.Show("Datos cargados con éxito",
                //    "Aplicación de base de datos",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error en carga Libros: " + ex.Message,
                    "Aplicación de Conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarLibrosPorCantidadEstilos()
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F"
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID= prueba; Password= prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Categoria.Nombre, COUNT(Libro.Titulo) AS \"NUMERO DE LIBROS\" " +
                                      "FROM Libro, Categoria " +
                                      "WHERE Libro.CA# = Categoria.CA# " +
                                      "GROUP BY Categoria.Nombre " +
                                      "ORDER BY Categoria.Nombre";
                comando.ExecuteNonQuery();

                comando.CommandText = "SELECT COUNT(Libro.Titulo) AS \"NUMERO DE LIBROS\", Estilo.Nombre AS \"NOMBRE ESTILO\" " +
                                      "FROM Libro, Autor, Escribe, Estilo " +
                                      "WHERE Estilo.ES# = Autor.ES# AND " +
                                      "Autor.AU# = Escribe.AU# AND " +
                                      "Escribe.LI# = Libro.LI# " +
                                      "GROUP BY Estilo.Nombre " +
                                      "ORDER BY Estilo.Nombre";
                comando.ExecuteNonQuery();

                reader = comando.ExecuteReader();

                listViewEstilo.Items.Clear();

                while (reader.Read())
                {
                    string estilo;
                    int numero;

                    numero = reader.GetInt32(0);
                    estilo = reader.GetString(1);
                    

                    ListViewItem item = new ListViewItem();

                    item.Text = numero.ToString();
                    item.SubItems.Add(estilo);

                    listViewEstilo.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

                //MessageBox.Show("Datos cargados con éxito",
                //    "Aplicación de base de datos",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error en carga Libros: " + ex.Message,
                    "Aplicación de Conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarLibrosPorEstilo(string estilo)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; Data Source=172.18.35.50/bddam; User ID=BD_JVIERA; Password=2717204F"
                    //"Persist Security Info=False; Data Source=127.0.0.1; User ID= prueba; Password= prueba";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Libro.Titulo, Libro.NumPaginas, Libro.NumEdicion, Libro.Anio, Estilo.Nombre " +
                                      "FROM Libro, Autor, Escribe, Estilo " +
                                      "WHERE Estilo.ES# = Autor.ES# AND " +
                                              "Autor.AU# = Escribe.AU# AND " +
                                              "Escribe.LI# = Libro.LI# AND " +
                                              "Estilo.Nombre = '" + estilo + "'";

                reader = comando.ExecuteReader();

                listViewEstiloOrganizado.Items.Clear();
                while (reader.Read())
                {

                    string titulo, numPaginas, numEdicion, anio, nombreEstilo;

                    titulo = reader.GetString(0);
                    numPaginas = reader.GetString(1);
                    numEdicion = reader.GetString(2);
                    anio = reader.GetString(3);
                    nombreEstilo = reader.GetString(4);

                    ListViewItem item = new ListViewItem();

                    item.Text = titulo;
                    item.SubItems.Add(numPaginas);
                    item.SubItems.Add(numEdicion);
                    item.SubItems.Add(anio);
                    item.SubItems.Add(nombreEstilo);

                    listViewEstiloOrganizado.Items.Add(item);
                }

                reader.Close();
                conexion.Close();

                //MessageBox.Show("Datos cargados con éxito",
                //    "Aplicación de base de datos",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error en carga Libros: " + ex.Message,
                    "Aplicación de Conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonNuevoLibro_Click(object sender, EventArgs e)
        {
            FormNuevoLibro formularioNuevoLibro;

            formularioNuevoLibro = new FormNuevoLibro();
            formularioNuevoLibro.ShowDialog();
        }

        private void buttonCargarLibreria_Click(object sender, EventArgs e)
        {
            cargarLibrosPorCantidadCategorias();
            cargarLibrosPorCantidadEstilos();
        }

        private void listViewCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCategoria.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewCategoria.SelectedItems[0];
                string categoriaSeleccionada;

                categoriaSeleccionada = item.SubItems[1].Text; // Primera columna
                cargarLibrosPorCategoria(categoriaSeleccionada);
            }
        }

        private void listViewEstilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEstilo.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewEstilo.SelectedItems[0];
                string estiloSeleccionado;

                estiloSeleccionado = item.SubItems[1].Text; // Primera columna
                cargarLibrosPorEstilo(estiloSeleccionado);
            }
        }

    }
}

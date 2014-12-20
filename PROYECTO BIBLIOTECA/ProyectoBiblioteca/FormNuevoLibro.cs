using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ProyectoBiblioteca
{
    public partial class FormNuevoLibro : Form
    {
        public FormNuevoLibro()
        {
            InitializeComponent();
        }

        private void cargarLibros()
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
                comando.CommandText = "SELECT Autor.AU#, Autor.Nombre, Autor.Apellidos, Libro.LI#, Libro.Titulo, Libro.NumPaginas, " +
                                              "Libro.NumEdicion, Libro.Anio, Estilo.Nombre, Categoria.Nombre, Estilo.ES#, Categoria.CA#  " +
                                      "FROM Estilo, Autor, Categoria, Libro, Escribe " +
                                      "WHERE Estilo.ES# = Autor.ES#  AND " +
                                            "Autor.AU# = Escribe.AU# AND " +
                                            "Escribe.LI# = Libro.LI# AND " +
                                            "Libro.CA# = Categoria.CA#";

                reader = comando.ExecuteReader();
                listViewLibrosCompletos.Items.Clear();

                while (reader.Read())
                {
                    string AU, nombreAutor, apellidosAutor, 
                        LI, tituloLibro, numPaginas, 
                        numEdicion, anio, nombreEstilo,
                        nombreCategoria, ES, CA;

                    AU = reader.GetString(0);
                    nombreAutor = reader.GetString(1);
                    apellidosAutor = reader.GetString(2);
                    LI = reader.GetString(3);
                    tituloLibro = reader.GetString(4);
                    numPaginas = reader.GetString(5);
                    numEdicion = reader.GetString(6);
                    anio = reader.GetString(7);
                    nombreEstilo = reader.GetString(8);
                    nombreCategoria = reader.GetString(9);
                    ES = reader.GetString(10);
                    CA = reader.GetString(11);

                    ListViewItem item = new ListViewItem();

                    item.Text = AU;
                    item.SubItems.Add(nombreAutor);
                    item.SubItems.Add(apellidosAutor);
                    item.SubItems.Add(LI);
                    item.SubItems.Add(tituloLibro);
                    item.SubItems.Add(numPaginas);
                    item.SubItems.Add(numEdicion);
                    item.SubItems.Add(anio);
                    item.SubItems.Add(nombreEstilo);
                    item.SubItems.Add(nombreCategoria);
                    item.SubItems.Add(ES);
                    item.SubItems.Add(CA);

                    listViewLibrosCompletos.Items.Add(item);
                }

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT AU#, Nombre, Apellidos " +
                                       "FROM Autor";

                reader = comando.ExecuteReader();
                listViewAutores.Items.Clear();

                while (reader.Read())
                {
                    string AU, nombreAutor, apellidosAutor;

                    AU = reader.GetString(0);
                    nombreAutor = reader.GetString(1);
                    apellidosAutor = reader.GetString(2);

                    ListViewItem item = new ListViewItem();

                    item.Text = AU;
                    item.SubItems.Add(nombreAutor);
                    item.SubItems.Add(apellidosAutor);

                    listViewAutores.Items.Add(item);
                }

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT LI#, Titulo, NumPaginas, NumEdicion, Anio " +
                                       "FROM Libro";

                reader = comando.ExecuteReader();
                listViewLibros.Items.Clear();

                while (reader.Read())
                {
                    string LI, tituloLibro, numPaginas,
                           numEdicion, anio;

                    LI = reader.GetString(0);
                    tituloLibro = reader.GetString(1);
                    numPaginas = reader.GetString(2);
                    numEdicion = reader.GetString(3);
                    anio = reader.GetString(4);

                    ListViewItem item = new ListViewItem();

                    item.Text = LI;
                    item.SubItems.Add(tituloLibro);
                    item.SubItems.Add(numPaginas);
                    item.SubItems.Add(numEdicion);
                    item.SubItems.Add(anio);

                    listViewLibros.Items.Add(item);
                }

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Nombre " +
                                       "FROM Estilo";

                reader = comando.ExecuteReader();
                comboBoxEstilo.Items.Clear();

                while (reader.Read())
                {
                    string nombre;

                    nombre = reader.GetString(0);

                    ListViewItem item = new ListViewItem();

                    comboBoxEstilo.Items.Add(nombre);
                }


                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Nombre " +
                                       "FROM Categoria";

                reader = comando.ExecuteReader();
                comboBoxCategoria.Items.Clear();

                while (reader.Read())
                {
                    string nombre;

                    nombre = reader.GetString(0);

                    ListViewItem item = new ListViewItem();

                    comboBoxCategoria.Items.Add(nombre);
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

        private void buttonCargarLibros_Click(object sender, EventArgs e)
        {
            cargarLibros();
        }

        private void listViewAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAutores.SelectedItems.Count != 0)
            {

                ListViewItem item = listViewAutores.SelectedItems[0];

                textBoxAU.Text = item.SubItems[0].Text;
                textBoxNombreAutor.Text = item.SubItems[1].Text;
                textBoxApellidosAutor.Text = item.SubItems[2].Text;
            }
        }

        private void listViewLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLibros.SelectedItems.Count != 0)
            {

                ListViewItem item = listViewLibros.SelectedItems[0];

                textBoxLI.Text = item.SubItems[0].Text;
                textBoxTituloLibro.Text = item.SubItems[1].Text;
                textBoxPaginas.Text = item.SubItems[2].Text;
                textBoxEdicion.Text = item.SubItems[3].Text;
                textBoxAnio.Text = item.SubItems[4].Text;
            }
        }

        private void listViewLibrosCompletos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLibrosCompletos.SelectedItems.Count != 0)
            {

                ListViewItem item = listViewLibrosCompletos.SelectedItems[0];

                textBoxAU.Text = item.SubItems[0].Text;
                textBoxNombreAutor.Text = item.SubItems[1].Text;
                textBoxApellidosAutor.Text = item.SubItems[2].Text;
                textBoxLI.Text = item.SubItems[3].Text;
                textBoxTituloLibro.Text = item.SubItems[4].Text;
                textBoxPaginas.Text = item.SubItems[5].Text;
                textBoxEdicion.Text = item.SubItems[6].Text;
                textBoxAnio.Text = item.SubItems[7].Text;
                comboBoxEstilo.Text = item.SubItems[8].Text;
                comboBoxCategoria.Text = item.SubItems[9].Text;
                labelID_ES.Text = item.SubItems[10].Text;
                labelID_CA.Text = item.SubItems[11].Text;

            }
        }

        private void buttonNuevoLibro_Click(object sender, EventArgs e)
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
                comando.CommandText = "INSERT INTO Autor VALUES (" +
                    "'" + textBoxAU.Text + "', " +
                    "'" + textBoxNombreAutor.Text + "', " +
                    "'" + textBoxApellidosAutor.Text + "', " +
                    "'" + labelID_ES.Text + "')";

                comando.ExecuteNonQuery();
                comando.CommandText = "INSERT INTO Libro VALUES (" +
                    "'" + textBoxLI.Text + "', " +
                    "'" + textBoxTituloLibro.Text + "', " +
                    "'" + textBoxPaginas.Text + "', " +
                    "'" + textBoxEdicion.Text + "', " +
                    "'" + textBoxAnio.Text + "', " +
                    "'" + labelID_CA.Text + "')";
                 
                comando.ExecuteNonQuery();
                comando.CommandText = "INSERT INTO Escribe VALUES (" +
                    "'" + textBoxLI.Text + "', " +
                    "'" + textBoxAU.Text + "')";

                comando.ExecuteNonQuery();
                conexion.Close();

                cargarLibros();

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

        private void buttonModificarLibro_Click(object sender, EventArgs e)
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
                comando.CommandText = "UPDATE Autor SET" +
                    "'" + textBoxNombreAutor.Text + "', " +
                    "'" + textBoxApellidosAutor.Text + "', " +
                    "'" + textBoxLI.Text + "' " +
                    " WHERE AU# = '" + textBoxAU.Text + "'";

                comando.CommandText = "UPDATE Libro SET" +
                    "'" + textBoxTituloLibro.Text + "', " +
                    "'" + textBoxPaginas.Text + "', " +
                    "'" + textBoxEdicion.Text + "', " +
                    "'" + textBoxAnio.Text + "', " +
                    "'" + labelID_CA.Text + "' " +
                    " WHERE LI# = '" + textBoxLI.Text + "'";
                comando.ExecuteNonQuery();
                conexion.Close();

                cargarLibros();

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

        private void buttonEliminarLibros_Click(object sender, EventArgs e)
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
               comando.CommandText = "DELETE FROM Libro " +
                    " WHERE LI# = '" + textBoxLI.Text + "'";

                comando.ExecuteNonQuery();
                comando.CommandText = "DELETE FROM Autor " +
                    " WHERE AU# = '" + textBoxAU.Text + "'";

                comando.ExecuteNonQuery();


                conexion.Close();

                cargarLibros();

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

        private void comboBoxEstilo_SelectedIndexChanged(object sender, EventArgs e)
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
                comando.CommandText = "SELECT ES# " +
                                       "FROM Estilo WHERE Nombre ='" + comboBoxEstilo.Text + "'";

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string ES;

                    ES = reader.GetString(0);
                    labelID_ES.Text = ES;

                }

                comando.ExecuteNonQuery();
                conexion.Close();

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

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
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
                comando.CommandText = "SELECT CA# " +
                                       "FROM Categoria WHERE Nombre ='" + comboBoxCategoria.Text + "'";

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string CA;

                    CA = reader.GetString(0);
                    labelID_CA.Text = CA;

                }

                comando.ExecuteNonQuery();
                conexion.Close();

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

    }
}

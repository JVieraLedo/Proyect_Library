using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class FormBiblioteca : Form
    {
        public FormBiblioteca()
        {
            InitializeComponent();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario formularioUsuario;

            formularioUsuario = new FormUsuario();
            formularioUsuario.ShowDialog();
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formularioEmpleados;

            formularioEmpleados = new FormEmpleados();
            formularioEmpleados.ShowDialog();
        }

        private void buttonLibreria_Click(object sender, EventArgs e)
        {
            FormLibreria formularioBiblioteca;

            formularioBiblioteca = new FormLibreria();
            formularioBiblioteca.ShowDialog();
        }

        private void buttonPrestamos_Click(object sender, EventArgs e)
        {
            FormPrestamos formularioPrestamos;

            formularioPrestamos = new FormPrestamos();
            formularioPrestamos.ShowDialog();
        }

        private void buttonAcercaDe_Click(object sender, EventArgs e)
        {
            FormAcercaDe formularioAcercaDe;

            formularioAcercaDe = new FormAcercaDe();
            formularioAcercaDe.ShowDialog();
        }
    }
}

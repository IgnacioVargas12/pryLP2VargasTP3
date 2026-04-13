using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLP2VargasTP3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmPrincipal();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeClientesOrdenadorPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListadoOrdenado();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}

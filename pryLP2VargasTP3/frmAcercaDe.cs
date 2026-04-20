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
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void frmAcercaDe_Load(object sender, EventArgs e)
        {
            //Aca cambio los colores de los paneles y etiquetas en los cuales uso colores que no son de visual
            this.BackColor = ColorTranslator.FromHtml("#2B2B2B");
            panel1.BackColor = ColorTranslator.FromHtml("#3a3a3a");
            label4.ForeColor = ColorTranslator.FromHtml("#007ACC");
            label5.Text = "El sistema lleva a cabo la gestión de clientes de un negocio, \npermitiendo cargar nuevos clientes y visualizarlos a través \nde distintas grillas. ";
        }
    }
}

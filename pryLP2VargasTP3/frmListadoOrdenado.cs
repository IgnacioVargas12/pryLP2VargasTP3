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
    public partial class frmListadoOrdenado : Form
    {
        public frmListadoOrdenado()
        {
            InitializeComponent();
        }

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            cmbCampo.SelectedIndex = 0;
            cmbModo.SelectedIndex = 0;
        }
    }
}

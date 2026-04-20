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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            clsVector.Precarga();

            dgvClientes.Rows.Clear();
            Decimal TotalDeuda = 0;
            Decimal PromedioDeuda = 0;
            for (Int32 i = 0; i < clsVector.IND; i++)
            {
                dgvClientes.Rows.Add(clsVector.vecClientes[i].CampoCodigo,
                    clsVector.vecClientes[i].CampoUsuario,
                    clsVector.vecClientes[i].CampoDeuda,
                    clsVector.vecClientes[i].CampoLimite);
                TotalDeuda = TotalDeuda + clsVector.vecClientes[i].CampoDeuda;
            }
            lblTotalDeuda.Text = "$" + TotalDeuda.ToString();
            lblTotalClientes.Text = Convert.ToString(clsVector.IND);
            PromedioDeuda = Math.Round(TotalDeuda / clsVector.IND , 2); //Redondea p/tener 2 decimales
            lblPromedioDeuda.Text = "$" + Convert.ToString(PromedioDeuda);
        }
    }
    
}

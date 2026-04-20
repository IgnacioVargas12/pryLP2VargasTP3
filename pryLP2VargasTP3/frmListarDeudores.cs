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
    public partial class frmListarDeudores : Form
    {
        public frmListarDeudores()
        {
            InitializeComponent();
        }

        private void frmListarDeudores_Load(object sender, EventArgs e)
        {
            clsVector.Precarga();

            dgvClientes.Rows.Clear();
            Decimal TotalDeuda = 0;
            Decimal PromedioDeuda = 0;
            int Indice = 0;
            for (Int32 i = 0; i < clsVector.IND; i++)
            {
                if (clsVector.vecClientes[i].CampoDeuda > 0)
                {
                    dgvClientes.Rows.Add(clsVector.vecClientes[i].CampoCodigo,
                    clsVector.vecClientes[i].CampoUsuario,
                    clsVector.vecClientes[i].CampoDeuda,
                    clsVector.vecClientes[i].CampoLimite);
                    TotalDeuda = TotalDeuda + clsVector.vecClientes[i].CampoDeuda;
                    Indice++;
                }
            }
            lblTotalDeuda.Text = "$" + TotalDeuda.ToString();
            lblTotalClientes.Text = Convert.ToString(Indice);
            PromedioDeuda = Math.Round(TotalDeuda / Indice , 2); //Redondea el numero y solo muestra 2 decimales
            lblPromedioDeuda.Text = "$" + Convert.ToString(PromedioDeuda);
        }
    }
    
}

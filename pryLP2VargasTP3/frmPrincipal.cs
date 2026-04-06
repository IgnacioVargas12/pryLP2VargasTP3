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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Declaración de un registro
        private struct RegCli
        {
            public Int32 CampoCodigo;
            public String CampoUsuario;
            public decimal CampoDeuda;
            public decimal CampoLimite;
        }

        //Declaración de vector
        private RegCli[] vecClientes = new RegCli[10];

        //Declaración de indice
        private Int32 IND = 0;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (IND < vecClientes.Length)
            {
                vecClientes[IND].CampoCodigo = Convert.ToInt32(txtCodigo.Text);
                vecClientes[IND].CampoUsuario = txtUsuario.Text;
                vecClientes[IND].CampoDeuda = Convert.ToDecimal(txtDeuda.Text);
                vecClientes[IND].CampoLimite = Convert.ToDecimal(txtLimite.Text);
                IND++;
                MessageBox.Show("Los datos se han cargado correctamente", "Datos cargados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();

            }
            else
            {
                MessageBox.Show("No es posible cargar más datos", "Espacio lleno",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                btnCargar.Enabled = false;
            }
        }

        private void Limpiar() 
        {
            txtCodigo.Text = "";
            txtDeuda.Text = "";
            txtDeuda.Enabled = false;
            txtLimite.Text = "";
            txtLimite.Enabled = false;
            txtUsuario.Text = "";
            txtUsuario.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            Decimal TotalDeuda = 0;
            for (Int32 i = 0; i < IND; i++)
            {
                dgvClientes.Rows.Add(vecClientes[i].CampoCodigo,
                    vecClientes[i].CampoUsuario,
                    vecClientes[i].CampoDeuda,
                    vecClientes[i].CampoLimite);
                TotalDeuda = TotalDeuda + vecClientes[i].CampoDeuda;
            }
            lblTotalDeuda.Text = "$" + TotalDeuda.ToString();
        }

        private void Validar() 
        {
            if (txtCodigo.Text != "" && txtUsuario.Text != ""
                && txtDeuda.Text != "" && txtLimite.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else 
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
        Validar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }
    }
}

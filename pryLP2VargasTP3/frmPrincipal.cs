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

       

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (clsVector.IND < clsVector.vecClientes.Length)
            {
                Int32 i = 0;
                while (clsVector.vecClientes[i].CampoCodigo != Convert.ToInt32(txtCodigo.Text) && i < clsVector.IND)
                {
                    i++;
                }

                if (i == clsVector.IND)
                {
                    clsVector.vecClientes[clsVector.IND].CampoCodigo = Convert.ToInt32(txtCodigo.Text);
                    clsVector.vecClientes[clsVector.IND].CampoUsuario = txtUsuario.Text;
                    clsVector.vecClientes[clsVector.IND].CampoDeuda = Convert.ToDecimal(txtDeuda.Text);
                    clsVector.vecClientes[clsVector.IND].CampoLimite = Convert.ToDecimal(txtLimite.Text);
                    clsVector.IND++;
                    MessageBox.Show("Los datos se han cargado correctamente", "Datos cargados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El código ya existe, ingrese otro", "Código repetido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Text = "";
                }
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
            for (Int32 i = 0; i < clsVector.IND; i++)
            {
                dgvClientes.Rows.Add(clsVector.vecClientes[i].CampoCodigo,
                    clsVector.vecClientes[i].CampoUsuario,
                    clsVector.vecClientes[i].CampoDeuda,
                    clsVector.vecClientes[i].CampoLimite);
                TotalDeuda = TotalDeuda + clsVector.vecClientes[i].CampoDeuda;
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

        private void PreCarga() 
        {
            clsVector.vecClientes[clsVector.IND].CampoCodigo = 10;
            clsVector.vecClientes[clsVector.IND].CampoUsuario = "Ana";
            clsVector.vecClientes[clsVector.IND].CampoDeuda = 500;
            clsVector.vecClientes[clsVector.IND].CampoLimite = 10000;
            clsVector.IND++;
            clsVector.vecClientes[clsVector.IND].CampoCodigo = 20;
            clsVector.vecClientes[clsVector.    IND].CampoUsuario = "Diego";
            clsVector.vecClientes[clsVector.IND].CampoDeuda = 0;
            clsVector.vecClientes[clsVector.IND].CampoLimite = 20000;
            clsVector.IND++;
            clsVector.vecClientes[clsVector.IND].CampoCodigo = 30;
            clsVector.vecClientes[clsVector.IND].CampoUsuario = "Maria";
            clsVector.vecClientes[clsVector.IND].CampoDeuda = 3000;
            clsVector.vecClientes[clsVector.IND].CampoLimite = 30000;
            clsVector.IND++;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            PreCarga();
        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            Decimal TotalDeuda = 0;
            for (Int32 i = 0; i < clsVector.IND; i++)
            {
                if (clsVector.vecClientes[i].CampoDeuda > 0)
                {
                    dgvClientes.Rows.Add(clsVector.vecClientes[i].CampoCodigo,
                    clsVector.vecClientes[i].CampoUsuario,
                    clsVector.vecClientes[i].CampoDeuda,
                    clsVector.vecClientes[i].CampoLimite);
                    TotalDeuda = TotalDeuda + clsVector.vecClientes[i].CampoDeuda;
                }
            }
            lblTotalDeuda.Text = "$" + TotalDeuda.ToString();
        }
    }
}

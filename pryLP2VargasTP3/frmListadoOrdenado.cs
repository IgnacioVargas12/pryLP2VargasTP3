using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            clsVector.Precarga();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cmbCampo.SelectedIndex)
            {
                case 0: //Codigo
                    if (cmbModo.SelectedIndex == 0)
                    { 
                        clsVector.OrdenarCodigoAscendente();
                    }
                    else 
                    { 
                        clsVector.OrdenarCodigoDescendente(); 
                    }
                     break;
                case 1: //Nombre
                    if (cmbModo.SelectedIndex == 0)
                    { 
                        clsVector.OrdenarNombreAscendente(); 
                    }
                    else 
                    { 
                        clsVector.OrdenarNombreDescendente(); 
                    }
                    break;
                case 2: //Deuda
                    if (cmbModo.SelectedIndex == 0)
                    { 
                        clsVector.OrdenarDeudaAscendente(); 
                    }
                    else 
                    { 
                        clsVector.OrdenarDeudaDescendente(); 
                    }
                    break;
                case 3: //Limite
                    if (cmbModo.SelectedIndex == 0)
                    { clsVector.OrdenarLimiteAscendente(); }
                    else { clsVector.OrdenarLimiteDescendente(); }
                    break;
            }

            //Mostramos en la grilla
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < clsVector.IND; i++)
            {
                dgvClientes.Rows.Add(clsVector.vecClientes[i].CampoCodigo,
                    clsVector.vecClientes[i].CampoUsuario,
                    clsVector.vecClientes[i].CampoDeuda,
                    clsVector.vecClientes[i].CampoLimite);
            }
        }
    }
}

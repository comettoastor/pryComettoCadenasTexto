using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoLP2SP2
{
    public partial class frmPrincipal : Form
    {
        string varTextoA = "";
        public void BuscarCaracter()
        {
            if (txtBuscar.Text != "" && varTextoA.IndexOf(txtBuscar.Text) > -1)
            {
                txtBuscar.BackColor = Color.Green;
            }
            else
            {
                txtBuscar.BackColor = Color.Red;
            }
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void txtTextoA_TextChanged(object sender, EventArgs e)
        {
            varTextoA = txtTextoA.Text;
            lblTextoA.Text = varTextoA.Length.ToString();
            BuscarCaracter();
        }

        private void txtTextoB_TextChanged(object sender, EventArgs e)
        {
            string varTextoB;
            varTextoB = txtTextoB.Text;
            lblTextoB.Text = varTextoB.Length.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarCaracter();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Visible == false)
            {
                txtBuscar.Visible = true;
            }
            else
            {
                txtBuscar.Visible = false;
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            lblFecha.Text = dtpFecha.Value.ToString("d");
            lblHora.Text = dtpFecha.Value.ToString("t");
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int comparador = string.Compare(txtTextoB.Text,txtTextoC.Text);
            if (comparador == 0)
            {
                MessageBox.Show("Los Textos son IGUALES","Iguales",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (comparador > 0)
                {
                    MessageBox.Show("El Texto B es MÁS GRANDE que el Texto C", "Diferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Texto C es MÁS GRANDE que el Texto B", "Diferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            if (txtTextoD.Text != "")
            {
                string varTextoD;
                varTextoD = txtTextoD.Text.Replace("h","H");
                txtTextoE.Text = varTextoD;
            }
        }

        private void btnIndice_Click(object sender, EventArgs e)
        {
            string varTextoF;
            varTextoF = txtTextoF.Text;
            int indice = varTextoF.IndexOf(txtIndice.Text);
            MessageBox.Show("El índice de la letra " + txtIndice.Text + " en el texto " + varTextoF + " es: "  + indice.ToString(), "Índice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTextoC_TextChanged(object sender, EventArgs e)
        {
            string varTextoC;
            varTextoC = txtTextoC.Text;
            lblTextoC.Text = varTextoC.Length.ToString();
        }

        private void txtTextoD_TextChanged(object sender, EventArgs e)
        {
            string varTextoD;
            varTextoD = txtTextoD.Text;
            lblTextoD.Text = varTextoD.Length.ToString();
        }

        private void txtTextoE_TextChanged(object sender, EventArgs e)
        {
            string varTextoE;
            varTextoE = txtTextoE.Text;
            lblTextoE.Text = varTextoE.Length.ToString();
        }

        private void txtTextoF_TextChanged(object sender, EventArgs e)
        {
            string varTextoF;
            varTextoF = txtTextoF.Text;
            lblTextoF.Text = varTextoF.Length.ToString();
        }
    }
}

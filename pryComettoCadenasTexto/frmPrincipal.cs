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
        string varTextoA;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void txtTextoA_TextChanged(object sender, EventArgs e)
        {
            varTextoA = txtTextoA.Text;
            lblTextoA.Text = varTextoA.Length.ToString();
        }

        private void txtTextoB_TextChanged(object sender, EventArgs e)
        {
            string varTextoB;
            varTextoB = txtTextoB.Text;
            lblTextoB.Text = varTextoB.Length.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (varTextoA.IndexOf(txtBuscar.Text) > -1 && txtBuscar.Text != "")
            {
                txtBuscar.BackColor = Color.Green;
            }
            else
            {
                txtBuscar.BackColor = Color.Red;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = true;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            lblFecha.Text = dtpFecha.Value.ToString("d");
            lblHora.Text = dtpFecha.Value.ToString("t");
        }
    }
}

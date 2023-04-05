using PryCampo.CASTEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCampo
{
    public partial class frmCastexMain : Form
    {
        public frmCastexMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain abrir = new frmMain();
            abrir.Show();
        }

        private void btnPlanCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlanCuentasCX abrir = new frmPlanCuentasCX();
            abrir.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain abrir = new frmMain();
            abrir.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrosCX abrir = new frmRegistrosCX();
            abrir.Show();
        }

        private void btnFlujo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFlujoCX frm = new frmFlujoCX();
            frm.Show();
        }
    }
}

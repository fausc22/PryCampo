using PryCampo.CHARITO.AGRICOLA;
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
    public partial class frmCharitoAgr : Form
    {
        public frmCharitoAgr()
        {
            InitializeComponent();
        }

        private void btnPlanCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlanCuentasAgr abrir = new frmPlanCuentasAgr();
            abrir.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrosAgr abrir = new frmRegistrosAgr();
            abrir.Show();
        }

        private void btnFlujo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCharitoMain abrir = new frmCharitoMain();
            abrir.Show();
        }
    }
}

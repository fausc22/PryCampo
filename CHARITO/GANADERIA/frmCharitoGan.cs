using PryCampo.CHARITO.GANADERIA;
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
    public partial class frmCharitoGan : Form
    {
        public frmCharitoGan()
        {
            InitializeComponent();
        }

        private void frmCharitoGan_Load(object sender, EventArgs e)
        {

        }

        private void btnPlanCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlanCuentasGan abrir = new frmPlanCuentasGan();
            abrir.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCharitoMain abrir = new frmCharitoMain();
            abrir.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrosGan frm = new frmRegistrosGan();
            frm.Show();
            
        }
    }
}

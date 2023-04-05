using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCampo.CASTEX
{
    public partial class frmPlanCuentasCX : Form
    {
        public frmPlanCuentasCX()
        {
            InitializeComponent();
        }

        private void frmPlanCuentasCX_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCastexMain abrir = new frmCastexMain();
            abrir.Show();
        }
    }
}

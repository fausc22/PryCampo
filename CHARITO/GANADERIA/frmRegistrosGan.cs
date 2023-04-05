using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCampo.CHARITO.GANADERIA
{
    public partial class frmRegistrosGan : Form
    {
        public frmRegistrosGan()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCharitoGan frm = new frmCharitoGan();
            frm.Show();
        }
    }
}

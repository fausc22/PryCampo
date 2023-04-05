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
    public partial class frmRegistrosCX : Form
    {
        public frmRegistrosCX()
        {
            InitializeComponent();
        }

        private void frmRegistrosCX_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCastexMain abrir = new frmCastexMain();
            abrir.Show();
        }
    }
}

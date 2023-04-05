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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCharito_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCharitoMain abrir = new frmCharitoMain();
            abrir.ShowDialog();
        }

        private void btnCastex_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCastexMain abrir1 = new frmCastexMain();
            abrir1.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apriete el boton del campo preferente, toque SALIR para volver atras",
                "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

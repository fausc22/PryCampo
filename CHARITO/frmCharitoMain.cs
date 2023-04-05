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
    public partial class frmCharitoMain : Form
    {
        public frmCharitoMain()
        {
            InitializeComponent();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apriete el boton de la actividad preferente, toque SALIR para volver atras",
                "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain abrir = new frmMain();
            abrir.Show();
        }

        private void btnAgro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCharitoAgr abrir = new frmCharitoAgr();
            abrir.Show();
        }

        private void btnGanado_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCharitoGan abrir = new frmCharitoGan();
            abrir.Show();
        }

        private void frmCharitoMain_Load(object sender, EventArgs e)
        {

        }
    }
}

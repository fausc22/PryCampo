using PryCampo.CASTEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCampo
{
    public partial class frmEditarIngreso : Form
    {
        public frmEditarIngreso()
        {
            InitializeComponent();
        }

        private void frmEditarRegistro_Load(object sender, EventArgs e)
        {
            string linea = "";
            StreamReader sr = new StreamReader("editI.txt");
            while (sr.EndOfStream == false)
            {
                linea = sr.ReadLine();
                txtTipo.Text = linea.Split(',')[0];
                txtPrecio.Text = linea.Split(',')[1];
                txtDescripcion.Text = linea.Split(',')[2];

            }
            sr.Close();
            sr.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}

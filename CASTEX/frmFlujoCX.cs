using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCampo.CASTEX
{
    public partial class frmFlujoCX : Form
    {
        public frmFlujoCX()
        {
            InitializeComponent();
            cargarTablaIngreso(null);
        }

        private void frmFlujoCX_Load(object sender, EventArgs e)
        {
            

            
            




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCastexMain frm = new frmCastexMain();
            frm.ShowDialog();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void cargarTablaIngreso(string dato)
        {
            List<ClsIngreso> lista = new List<ClsIngreso>();
            ClsTablaIngreso ListaIngresos = new ClsTablaIngreso();
            dgvIngreso.DataSource = ListaIngresos.consulta(dato);
            
        }
    }
}

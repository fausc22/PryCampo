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
            cargarTablaGasto(null);
            
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
            List<Productos> lista = new List<Productos>();  
            ClsTablaIngreso TablaIngreso = new ClsTablaIngreso();
            dgvIngreso.DataSource = TablaIngreso.consultaIngreso(dato);
            
        }

        private void cargarTablaGasto(string dato)
        {
            List<Productos> lista = new List<Productos>();
            ClsTablaGasto TablaGasto = new ClsTablaGasto();
            dgvGasto.DataSource = TablaGasto.consultaGasto(dato);

        }
    }
}

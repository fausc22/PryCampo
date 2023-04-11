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
            btnAgregarIngreso.Enabled = false;
            btnAgregarGasto.Enabled = false;
            btnEliminarGasto.Enabled = false;
            btnEliminarIngreso.Enabled = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ClsIngreso NuevoTipo = new ClsIngreso();
            
            NuevoTipo.Tipo = listIngreso.ToString();
            
            NuevoTipo.NombreArchivo = "tipoIngresos.txt";
            NuevoTipo.GrabarTipo(NuevoTipo);

            this.Hide();
            frmCastexMain abrir = new frmCastexMain();
            abrir.Show();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtIngreso.Text != "" && txtIngreso.Text != null)
            {
                btnAgregarIngreso.Enabled = true;

            }
        }

        private void txtGasto_TextChanged(object sender, EventArgs e)
        {
            if (txtGasto.Text != "" && txtGasto.Text != null)
            {
                btnAgregarGasto.Enabled = true;

            }
        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            listIngreso.Items.Add(txtIngreso.Text);
            txtIngreso.Clear();
        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            if (listIngreso.SelectedIndex != -1)
            {

                listIngreso.Items.RemoveAt(listIngreso.SelectedIndex);
            }

            
        }

        private void listIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listIngreso.SelectedIndex != -1)
            {
                btnEliminarIngreso.Enabled = true;
            }
        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            listGasto.Items.Add(txtGasto.Text);
            txtGasto.Clear();
        }

        private void listGasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGasto.SelectedIndex != 1)
            {
                btnEliminarGasto.Enabled = true;
            }
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            if (listGasto.SelectedIndex != -1)
            {
                listGasto.Items.RemoveAt(listGasto.SelectedIndex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
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



            
            StreamReader sr = new StreamReader(path: Path.GetFileName("tipoIngreso.txt"));
            foreach  (string line in File.ReadLines(path: Path.GetFileName("tipoIngreso.txt")))
            {
                
                
                    listIngreso.Items.Add(line);
                
            }
            sr.Close();
            sr.Dispose();
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
           

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

            ClsIngreso NuevoIngreso = new ClsIngreso();
            NuevoIngreso.NombreArchivo = "tipoIngreso.txt";
            foreach (string item in listIngreso.Items)
            {
                NuevoIngreso.Tipo = item.ToString();
            }

            NuevoIngreso.GrabarTipo(NuevoIngreso);


            txtIngreso.Clear();
        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            if (listIngreso.SelectedIndex != -1)
            {

                listIngreso.Items.RemoveAt(listIngreso.SelectedIndex);
                
            }

            ClsIngreso BorrarIngreso = new ClsIngreso();
            BorrarIngreso.NombreArchivo = "tipoIngreso.txt";
            foreach (string item in listIngreso.Items)
            {
                BorrarIngreso.Tipo = item.ToString();
            }

            BorrarIngreso.BorrarTipo(BorrarIngreso);


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

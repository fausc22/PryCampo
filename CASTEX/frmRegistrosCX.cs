using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            StreamReader sr = new StreamReader(path: Path.GetFileName("tipoIngreso.txt"));
            foreach (string line in File.ReadLines(path: Path.GetFileName("tipoIngreso.txt")))
            {


                cmbTipoIngreso.Items.Add(line);

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

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            
            ClsIngreso NuevoIngreso = new ClsIngreso();
             
                NuevoIngreso.Tipo = cmbTipoIngreso.SelectedItem.ToString();
                NuevoIngreso.Precio = Convert.ToInt32(txtPrecioIngreso.Text);
                NuevoIngreso.Descripcion = txtDescripcionI.Text;
            NuevoIngreso.Fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");
                NuevoIngreso.NombreArchivo = "ingresos.txt";
                NuevoIngreso.GrabarIngreso(NuevoIngreso);


            MessageBox.Show("Grabacion exitosa");
        }

        private void txtPrecioIngreso_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTipoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoIngreso.SelectedIndex != -1)
            {
                txtPrecioIngreso.Enabled = true;
            }

            if (cmbTipoIngreso.SelectedIndex != -1)
            {
                txtDescripcionI.Enabled = true;
            }
        }

        private void cmbTipoGasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoGasto.SelectedIndex != -1)
            {
                txtPrecioGasto.Enabled = true;
            }

            if (cmbTipoIngreso.SelectedIndex != -1)
            {
                txtDescripcionG.Enabled = true;
            }
        }
    }
}

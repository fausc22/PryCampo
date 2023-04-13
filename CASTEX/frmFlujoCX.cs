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
        }

        private void frmFlujoCX_Load(object sender, EventArgs e)
        {
            string Linea;
            decimal PrecioIngreso;
            decimal TotalIngreso = 0;
            StreamReader sr = new StreamReader("ingresos.txt");
            while (sr.EndOfStream == false)
            {
                Linea = sr.ReadLine();
                ClsIngreso TipoIngreso = new ClsIngreso();
                TipoIngreso.Tipo = Linea.Split(',')[0];
                TipoIngreso.Precio = decimal.Parse(Linea.Split(',')[1], CultureInfo.InvariantCulture);
                TipoIngreso.Descripcion = Linea.Split(',')[2];
                TipoIngreso.Fecha = Linea.Split(',')[3];
                dgvIngreso.Rows.Add(TipoIngreso.Fecha, TipoIngreso.Tipo, TipoIngreso.Precio.ToString(), TipoIngreso.Descripcion);
                PrecioIngreso = TipoIngreso.Precio;
                TotalIngreso = TotalIngreso + PrecioIngreso;
                txtTotalIngreso.Text = TotalIngreso.ToString();

            }
            sr.Close();
            sr.Dispose();

            
            




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
    }
}

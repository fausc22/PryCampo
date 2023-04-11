﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                NuevoIngreso.Fecha = DateTime.Now.Date;
                NuevoIngreso.NombreArchivo = "ingresos.txt";
                NuevoIngreso.GrabarIngreso(NuevoIngreso);


            MessageBox.Show("Grabacion exitosa");
        }
    }
}

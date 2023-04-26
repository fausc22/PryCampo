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
    public partial class frmEditarGasto : Form
    {
        public frmEditarGasto()
        {
            InitializeComponent();
        }

        private void frmEditarRegistro_Load(object sender, EventArgs e)
        {
            string linea = "";
            StreamReader sr = new StreamReader("editG.txt");
            while (sr.EndOfStream == false)
            {
                linea = sr.ReadLine();
                txtTipo.Text = linea.Split(',')[0];
                txtPrecio.Text = linea.Split(',')[1];
                txtDescripcion.Text = linea.Split(',')[2];
                lblId.Text = linea.Split(',')[3];

            }
            sr.Close();
            sr.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Productos _producto = new Productos();
            _producto.Id = int.Parse(lblId.Text);
            _producto.Tipo = txtTipo.Text;
            _producto.Precio = decimal.Parse(txtPrecio.Text);
            _producto.Descripcion = txtDescripcion.Text;
            _producto.Fecha = DateTime.Now.ToString("dd/MM/yyyy");

            ClsTablaIngreso ctrl = new ClsTablaIngreso();
            ctrl.Mes = lblMes.Text;
            ctrl.actualizarIngreso(_producto);


            string mes = DateTime.Now.ToString("MM");
            string mes1 = "";
            if (mes == "01")
            {
                mes1 = "ENERO";
            }
            else
            {
                if (mes == "02")
                {
                    mes1 = "FEBRERO";
                }
                else
                {
                    if (mes == "03")
                    {
                        mes1 = "MARZO";
                    }
                    else
                    {
                        if (mes == "04")
                        {
                            mes1 = "ABRIL";
                        }
                        else
                        {
                            if (mes == "05")
                            {
                                mes1 = "MAYO";
                            }
                            else
                            {
                                if (mes == "06")
                                {
                                    mes1 = "JUNIO";
                                }
                                else
                                {
                                    if (mes == "07")
                                    {
                                        mes1 = "JULIO";
                                    }
                                    else
                                    {
                                        if (mes == "08")
                                        {
                                            mes1 = "AGOSTO";
                                        }
                                        else
                                        {
                                            if (mes == "09")
                                            {
                                                mes1 = "SEPTIEMBRE";
                                            }
                                            else
                                            {
                                                if (mes == "10")
                                                {
                                                    mes1 = "OCTUBRE";
                                                }
                                                else
                                                {
                                                    if (mes == "11")
                                                    {
                                                        mes1 = "NOVIEMBRE";
                                                    }
                                                    else
                                                    {
                                                        if (mes == "12")
                                                        {
                                                            mes1 = "DICIEMBRE";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            this.Hide();
            frmFlujoCX frmFlujoCX = new frmFlujoCX();
            frmFlujoCX.cmbMes.Text = mes1;
            frmFlujoCX.ShowDialog();
        }
    }
}

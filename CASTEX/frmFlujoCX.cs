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

            if (cmbMes.Text == "ENERO")
            {
                TablaIngreso.Mes = "ingresos_enero23";
            }
            else
            {
                if (cmbMes.Text == "FEBRERO")
                {
                    TablaIngreso.Mes = "ingresos_febrero23";
                }
                else
                {
                    if (cmbMes.Text == "MARZO")
                    {
                        TablaIngreso.Mes = "ingresos_marzo23";
                    }
                    else
                    {
                        if (cmbMes.Text == "ABRIL")
                        {
                            TablaIngreso.Mes = "ingresos_abril23";
                        }
                        else
                        {
                            if (cmbMes.Text == "MAYO")
                            {
                                TablaIngreso.Mes = "ingresos_mayo23";
                            }
                            else
                            {
                                if (cmbMes.Text == "JUNIO")
                                {
                                    TablaIngreso.Mes = "ingresos_junio23";
                                }
                                else
                                {
                                    if (cmbMes.Text == "JULIO")
                                    {
                                        TablaIngreso.Mes = "ingresos_julio23";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "AGOSTO")
                                        {
                                            TablaIngreso.Mes = "ingresos_agosto23";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "SEPTIEMBRE")
                                            {
                                                TablaIngreso.Mes = "ingresos_septiembre23";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "MAYO")
                                                {
                                                    TablaIngreso.Mes = "ingresos_octubre23";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "MAYO")
                                                    {
                                                        TablaIngreso.Mes = "ingresos_noviembre23";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "MAYO")
                                                        {
                                                            TablaIngreso.Mes = "ingresos_diciembre23";
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
            



            dgvIngreso.DataSource = TablaIngreso.consultaIngreso(dato);
            
        }

        private void cargarTablaGasto(string dato)
        {
            List<Productos> lista = new List<Productos>();
            ClsTablaGasto TablaGasto = new ClsTablaGasto();

            if (cmbMes.Text == "ENERO")
            {
                TablaGasto.Mes = "ingresos_enero23";
            }
            else
            {
                if (cmbMes.Text == "FEBRERO")
                {
                    TablaGasto.Mes = "ingresos_febrero23";
                }
                else
                {
                    if (cmbMes.Text == "MARZO")
                    {
                        TablaGasto.Mes = "ingresos_marzo23";
                    }
                    else
                    {
                        if (cmbMes.Text == "ABRIL")
                        {
                            TablaGasto.Mes = "ingresos_abril23";
                        }
                        else
                        {
                            if (cmbMes.Text == "MAYO")
                            {
                                TablaGasto.Mes = "ingresos_mayo23";
                            }
                            else
                            {
                                if (cmbMes.Text == "JUNIO")
                                {
                                    TablaGasto.Mes = "ingresos_junio23";
                                }
                                else
                                {
                                    if (cmbMes.Text == "JULIO")
                                    {
                                        TablaGasto.Mes = "ingresos_julio23";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "AGOSTO")
                                        {
                                            TablaGasto.Mes = "ingresos_agosto23";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "SEPTIEMBRE")
                                            {
                                                TablaGasto.Mes = "ingresos_septiembre23";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "MAYO")
                                                {
                                                    TablaGasto.Mes = "ingresos_octubre23";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "MAYO")
                                                    {
                                                        TablaGasto.Mes = "ingresos_noviembre23";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "MAYO")
                                                        {
                                                            TablaGasto.Mes = "ingresos_diciembre23";
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




            dgvGasto.DataSource = TablaGasto.consultaGasto(dato);

        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarTablaIngreso(null);
            cargarTablaGasto(null);
        }
    }
}

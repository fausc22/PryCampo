using MySql.Data.MySqlClient;
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

           


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCastexMain abrir = new frmCastexMain();
            abrir.Show();
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {

            //valores para ingresar
            String tipo = txtIngreso.Text;
            decimal precio = decimal.Parse(txtPrecioIngreso.Text);
            String descripcion = txtDescripcionI.Text;
            String fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");



            string sql = "";
            //condicional que combina el combo box con el mes con la tabla en la base de datos
            if (cmbMes.Text == "ABRIL")
            {
                sql = "INSERT INTO ingresos_abril23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
            }
            else
            {
                if (cmbMes.Text == "MAYO")
                {
                    sql = "INSERT INTO ingresos_mayo23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                }
                else
                {
                    if (cmbMes.Text == "JUNIO")
                    {
                        sql = "INSERT INTO ingresos_junio23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                    }
                    else
                    {
                        if (cmbMes.Text == "JULIO")
                        {
                            sql = "INSERT INTO ingresos_julio23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                        }
                        else
                        {
                            if (cmbMes.Text == "AGOSTO")
                            {
                                sql = "INSERT INTO ingresos_agosto23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                            }
                            else
                            {
                                if (cmbMes.Text == "SEPTIEMBRE")
                                {
                                    sql = "INSERT INTO ingresos_septiembre23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                }
                                else
                                {
                                    if (cmbMes.Text == "OCTUBRE")
                                    {
                                        sql = "INSERT INTO ingresos_octubre23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "NOVIEMBRE")
                                        {
                                            sql = "INSERT INTO ingresos_noviembre23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "DICIEMBRE")
                                            {
                                                sql = "INSERT INTO ingresos_diciembre23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "ENERO")
                                                {
                                                    sql = "INSERT INTO ingresos_enero23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "FEBRERO")
                                                    {
                                                        sql = "INSERT INTO ingresos_febrero23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "MARZO")
                                                        {
                                                            sql = "INSERT INTO ingresos_marzo23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
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

            MySqlConnection conexionDB = ConexionDBStatic.conexion();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally { conexionDB.Close(); } 
            
            LimpiarControles();
        }


        private void txtPrecioIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecioGasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecioIngreso_TextChanged(object sender, EventArgs e)
        {

           


            if (txtIngreso.Text != "" && txtPrecioIngreso.Text != "")
            {
                btnNuevoIngreso.Enabled = true;
            }
        }

        private void cmbTipoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMes.SelectedIndex != -1)
            {
                txtIngreso.Enabled = true;
            }



            if (cmbMes.SelectedIndex != -1)
            {
                txtPrecioIngreso.Enabled = true;
            }

            if (cmbMes.SelectedIndex != -1)
            {
                txtDescripcionI.Enabled = true;
            }

            if (cmbMes.SelectedIndex != -1)
            {
                txtGasto.Enabled = true;
            }

            if (cmbMes.SelectedIndex != -1)
            {
                txtPrecioGasto.Enabled = true;
            }

            if (cmbMes.SelectedIndex != -1)
            {
                txtDescripcionG.Enabled = true;
            }

        }

        

        private void mrcIngreso_Enter(object sender, EventArgs e)
        {

        }

        private void lblingreso_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioGasto_TextChanged(object sender, EventArgs e)
        {
            if (txtGasto.Text != "" && txtPrecioGasto.Text != "")
            {
                btnNuevoGasto.Enabled = true;

            }
        }


        private void LimpiarControles()
        {
            cmbMes.SelectedIndex = -1;
            txtIngreso.Clear();
            txtPrecioIngreso.Clear();
            txtPrecioIngreso.Enabled = false;
            txtDescripcionI.Clear();
            txtDescripcionI.Enabled = false;
            txtGasto.Clear();
            txtPrecioGasto.Clear();
            txtPrecioGasto.Enabled = false;
            txtDescripcionG.Clear();
            txtDescripcionG.Enabled = false;
            txtIngreso.Enabled = false;
            txtGasto.Enabled = false;

        }

        private void btnNuevoGasto_Click(object sender, EventArgs e)
        {
            //valores para ingresar
            String tipo = txtGasto.Text;
            decimal precio = decimal.Parse(txtPrecioGasto.Text);
            String descripcion = txtDescripcionG.Text;
            String fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");



            string sql = "";
            //condicional que combina el combo box con el mes con la tabla en la base de datos
            if (cmbMes.Text == "ABRIL")
            {
                sql = "INSERT INTO gastos_abril23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
            }
            else
            {
                if (cmbMes.Text == "MAYO")
                {
                    sql = "INSERT INTO gastos_mayo23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                }
                else
                {
                    if (cmbMes.Text == "JUNIO")
                    {
                        sql = "INSERT INTO gastos_junio23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                    }
                    else
                    {
                        if (cmbMes.Text == "JULIO")
                        {
                            sql = "INSERT INTO gastos_julio23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                        }
                        else
                        {
                            if (cmbMes.Text == "AGOSTO")
                            {
                                sql = "INSERT INTO gastos_agosto23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                            }
                            else
                            {
                                if (cmbMes.Text == "SEPTIEMBRE")
                                {
                                    sql = "INSERT INTO gastos_septiembre23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                }
                                else
                                {
                                    if (cmbMes.Text == "OCTUBRE")
                                    {
                                        sql = "INSERT INTO gastos_octubre23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "NOVIEMBRE")
                                        {
                                            sql = "INSERT INTO gastos_noviembre23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "DICIEMBRE")
                                            {
                                                sql = "INSERT INTO gastos_diciembre23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "ENERO")
                                                {
                                                    sql = "INSERT INTO gastos_enero23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "FEBRERO")
                                                    {
                                                        sql = "INSERT INTO gastos_febrero23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "MARZO")
                                                        {
                                                            sql = "INSERT INTO gastos_marzo23 (tipo, precio, descripcion, fecha) VALUES ('" + tipo + "' , '" + precio + "' , '" + descripcion + "' , '" + fecha + "')";
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

            MySqlConnection conexionDB = ConexionDBStatic.conexion();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally { conexionDB.Close(); }

            LimpiarControles();
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFlujoCX frmFlujoCX = new frmFlujoCX();
            frmFlujoCX.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe seleccionar un MES para que se habiliten los controles para ingreso. Debe registar un ingreso o gasto a la vez, no ambos al mismo tiempo.",
                "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

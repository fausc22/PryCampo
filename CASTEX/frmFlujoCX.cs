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
                                                if (cmbMes.Text == "OCTUBRE")
                                                {
                                                    TablaIngreso.Mes = "ingresos_octubre23";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "NOVIEMBRE")
                                                    {
                                                        TablaIngreso.Mes = "ingresos_noviembre23";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "DICIEMBRE")
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
            ClsTablaIngreso TablaGasto = new ClsTablaIngreso();

            if (cmbMes.Text == "ENERO")
            {
                TablaGasto.Mes = "gastos_enero23";
            }
            else
            {
                if (cmbMes.Text == "FEBRERO")
                {
                    TablaGasto.Mes = "gastos_febrero23";
                }
                else
                {
                    if (cmbMes.Text == "MARZO")
                    {
                        TablaGasto.Mes = "gastos_marzo23";
                    }
                    else
                    {
                        if (cmbMes.Text == "ABRIL")
                        {
                            TablaGasto.Mes = "gastos_abril23";
                        }
                        else
                        {
                            if (cmbMes.Text == "MAYO")
                            {
                                TablaGasto.Mes = "gastos_mayo23";
                            }
                            else
                            {
                                if (cmbMes.Text == "JUNIO")
                                {
                                    TablaGasto.Mes = "gastos_junio23";
                                }
                                else
                                {
                                    if (cmbMes.Text == "JULIO")
                                    {
                                        TablaGasto.Mes = "gastos_julio23";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "AGOSTO")
                                        {
                                            TablaGasto.Mes = "gastos_agosto23";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "SEPTIEMBRE")
                                            {
                                                TablaGasto.Mes = "gastos_septiembre23";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "OCTUBRE")
                                                {
                                                    TablaGasto.Mes = "gastos_octubre23";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "NOVIEMBRE")
                                                    {
                                                        TablaGasto.Mes = "gastos_noviembre23";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "DICIEMBRE")
                                                        {
                                                            TablaGasto.Mes = "gastos_diciembre23";
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




                dgvGasto.DataSource = TablaGasto.consultaIngreso(dato);

            }

            dgvGasto.DataSource = TablaGasto.consultaIngreso(dato);
        }


        private void Calculos()
        {
            int contadorIngreso = 0;
            int contadorGasto = 0;
            int Total = 0;
            cargarTablaIngreso(null);
            cargarTablaGasto(null);
            



            for (int i = 0; i < dgvIngreso.Rows.Count; i++)
            {
                contadorIngreso = contadorIngreso + int.Parse(dgvIngreso.Rows[i].Cells[2].Value.ToString());
            }
            lblIngresoTotal.Text = "$ " + contadorIngreso.ToString();
            

            for (int i = 0; i < dgvGasto.Rows.Count; i++)
            {
                contadorGasto = contadorGasto + int.Parse(dgvGasto.Rows[i].Cells[2].Value.ToString());
            }
            lblGastoTotal.Text = "$ " + contadorGasto.ToString();

            Total = contadorIngreso - contadorGasto;
            lblResultadoTotal.Text = "$ " + Total.ToString();

            if (Total >= 0)
            {

                lblResultadoTotal.BackColor = Color.Green;
            }
            else
            {

                lblResultadoTotal.BackColor = Color.Red;
            }
            groupBox1.Visible = true;
            lblIngresoTotal.Visible = true;
            lblGastoTotal.Visible = true;
            lblResultadoTotal.Visible = true;
            btnHistoria.Visible = true;
            lblSigno1.Visible = true;
            lblSigno2.Visible = true;

            lblResultadoTitulo.Visible = true;
            btnEditarIngreso.Enabled = true;
            btnEditarGasto.Enabled = true;
            btnEliminarIngreso.Enabled = true;
            btnEliminarGasto.Enabled = true;


            //valores para los totales en la DB
            ClsTablaIngreso calculo = new ClsTablaIngreso();
            Productos valores = new Productos();
            valores.Ingresos = decimal.Parse(contadorIngreso.ToString());
            valores.Gastos = decimal.Parse(contadorGasto.ToString());
            valores.Resultados1 = decimal.Parse(Total.ToString());

            if (cmbMes.Text == "ENERO")
            {
               calculo.Mes = "ENERO";
            }
            else
            {
                if (cmbMes.Text == "FEBRERO")
                {
                    calculo.Mes = "FEBRERO";
                }
                else
                {
                    if (cmbMes.Text == "MARZO")
                    {
                        calculo.Mes = "MARZO";
                    }
                    else
                    {
                        if (cmbMes.Text == "ABRIL")
                        {
                            calculo.Mes = "ABRIL";
                        }
                        else
                        {
                            if (cmbMes.Text == "MAYO")
                            {
                                calculo.Mes = "MAYO";
                            }
                            else
                            {
                                if (cmbMes.Text == "JUNIO")
                                {
                                    calculo.Mes = "JUNIO";
                                }
                                else
                                {
                                    if (cmbMes.Text == "JULIO")
                                    {
                                        calculo.Mes = "JULIO";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "AGOSTO")
                                        {
                                            calculo.Mes = "AGOSTO";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "SEPTIEMBRE")
                                            {
                                                calculo.Mes = "SEPTIEMBRE";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "OCTUBRE")
                                                {
                                                    calculo.Mes = "OCTUBRE";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "NOVIEMBRE")
                                                    {
                                                        calculo.Mes = "NOVIEMBRE";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "DICIEMBRE")
                                                        {
                                                            calculo.Mes = "DICIEMBRE";
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

            calculo.SumaTotales(valores);


        }


        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

            Calculos();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvIngreso.CurrentRow != null)
            {
                StreamWriter sw = new StreamWriter("editI.txt", false);
                sw.WriteLine(dgvIngreso.CurrentRow.Cells[1].Value.ToString() + "," + dgvIngreso.CurrentRow.Cells[2].Value.ToString() + "," + dgvIngreso.CurrentRow.Cells[4].Value.ToString() + "," + dgvIngreso.CurrentRow.Cells[0].Value.ToString());
                sw.Close();
                sw.Dispose();

                this.Hide();
                frmEditarIngreso frmEditarRegistro = new frmEditarIngreso();
                if (cmbMes.Text == "ENERO")
                {
                    frmEditarRegistro.lblMes.Text = "ingresos_enero23";
                }
                else
                {
                    if (cmbMes.Text == "FEBRERO")
                    {
                        frmEditarRegistro.lblMes.Text = "ingresos_febrero23";
                    }
                    else
                    {
                        if (cmbMes.Text == "MARZO")
                        {
                            frmEditarRegistro.lblMes.Text = "ingresos_marzo23";
                        }
                        else
                        {
                            if (cmbMes.Text == "ABRIL")
                            {
                                frmEditarRegistro.lblMes.Text = "ingresos_abril23";
                            }
                            else
                            {
                                if (cmbMes.Text == "MAYO")
                                {
                                    frmEditarRegistro.lblMes.Text = "ingresos_mayo23";
                                }
                                else
                                {
                                    if (cmbMes.Text == "JUNIO")
                                    {
                                        frmEditarRegistro.lblMes.Text = "ingresos_junio23";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "JULIO")
                                        {
                                            frmEditarRegistro.lblMes.Text = "ingresos_julio23";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "AGOSTO")
                                            {
                                                frmEditarRegistro.lblMes.Text = "ingresos_agosto23";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "SEPTIEMBRE")
                                                {
                                                    frmEditarRegistro.lblMes.Text = "ingresos_septiembre23";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "OCTUBRE")
                                                    {
                                                        frmEditarRegistro.lblMes.Text = "ingresos_octubre23";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "NOVIEMBRE")
                                                        {
                                                            frmEditarRegistro.lblMes.Text = "ingresos_noviembre23";
                                                        }
                                                        else
                                                        {
                                                            if (cmbMes.Text == "DICIEMBRE")
                                                            {
                                                                frmEditarRegistro.lblMes.Text = "ingresos_diciembre23";
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
                frmEditarRegistro.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay registros actuales para editar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnEditarGasto_Click(object sender, EventArgs e)
        {
            if (dgvGasto.CurrentRow != null)
            {
                StreamWriter sw = new StreamWriter("editG.txt", false);
                sw.WriteLine(dgvGasto.CurrentRow.Cells[1].Value.ToString() + "," + dgvGasto.CurrentRow.Cells[2].Value.ToString() + "," + dgvGasto.CurrentRow.Cells[4].Value.ToString() + "," + dgvGasto.CurrentRow.Cells[0].Value.ToString());
                sw.Close();
                sw.Dispose();

                this.Hide();
                frmEditarGasto frm = new frmEditarGasto();
                if (cmbMes.Text == "ENERO")
                {
                    frm.lblMes.Text = "gastos_enero23";
                }
                else
                {
                    if (cmbMes.Text == "FEBRERO")
                    {
                        frm.lblMes.Text = "gastos_febrero23";
                    }
                    else
                    {
                        if (cmbMes.Text == "MARZO")
                        {
                            frm.lblMes.Text = "gastos_marzo23";
                        }
                        else
                        {
                            if (cmbMes.Text == "ABRIL")
                            {
                                frm.lblMes.Text = "gastos_abril23";
                            }
                            else
                            {
                                if (cmbMes.Text == "MAYO")
                                {
                                    frm.lblMes.Text = "gastos_mayo23";
                                }
                                else
                                {
                                    if (cmbMes.Text == "JUNIO")
                                    {
                                        frm.lblMes.Text = "gastos_junio23";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "JULIO")
                                        {
                                            frm.lblMes.Text = "gastos_julio23";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "AGOSTO")
                                            {
                                                frm.lblMes.Text = "gastos_agosto23";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "SEPTIEMBRE")
                                                {
                                                    frm.lblMes.Text = "gastos_septiembre23";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "OCTUBRE")
                                                    {
                                                        frm.lblMes.Text = "gastos_octubre23";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "NOVIEMBRE")
                                                        {
                                                            frm.lblMes.Text = "gastos_noviembre23";
                                                        }
                                                        else
                                                        {
                                                            if (cmbMes.Text == "DICIEMBRE")
                                                            {
                                                                frm.lblMes.Text = "gastos_diciembre23";
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
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay registros actuales para editar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe seleccionar un mes para que se habilite la información. Si desea editar o eliminar un registro, debe clickear el mismo en la tabla y luego presionar los distintos botones presentes: EDITAR o ELIMINAR REGISTRO.",
                "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvGasto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            if (dgvIngreso.CurrentRow != null)
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir",
                    MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    string Mes = "";

                    string id = dgvIngreso.CurrentRow.Cells[0].Value.ToString();


                    if (cmbMes.Text == "ENERO")
                    {
                        Mes = "ingresos_enero23";
                    }
                    else
                    {
                        if (cmbMes.Text == "FEBRERO")
                        {
                            Mes = "ingresos_febrero23";
                        }
                        else
                        {
                            if (cmbMes.Text == "MARZO")
                            {
                                Mes = "ingresos_marzo23";
                            }
                            else
                            {
                                if (cmbMes.Text == "ABRIL")
                                {
                                    Mes = "ingresos_abril23";
                                }
                                else
                                {
                                    if (cmbMes.Text == "MAYO")
                                    {
                                        Mes = "ingresos_mayo23";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "JUNIO")
                                        {
                                            Mes = "ingresos_junio23";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "JULIO")
                                            {
                                                Mes = "ingresos_julio23";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "AGOSTO")
                                                {
                                                    Mes = "ingresos_agosto23";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "SEPTIEMBRE")
                                                    {
                                                        Mes = "ingresos_septiembre23";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "OCTUBRE")
                                                        {
                                                            Mes = "ingresos_octubre23";
                                                        }
                                                        else
                                                        {
                                                            if (cmbMes.Text == "NOVIEMBRE")
                                                            {
                                                                Mes = "ingresos_noviembre23";
                                                            }
                                                            else
                                                            {
                                                                if (cmbMes.Text == "DICIEMBRE")
                                                                {
                                                                    Mes = "ingresos_diciembre23";
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











                    ClsTablaIngreso ctrl = new ClsTablaIngreso();



                    ctrl.eliminarIngreso(id, Mes);
                    Calculos();

                }
            }
            else
            {
                MessageBox.Show("No hay registros actuales para eliminar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            if (dgvGasto.CurrentRow != null)
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir",
                    MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    string Mes = "";

                    string id = dgvGasto.CurrentRow.Cells[0].Value.ToString();


                    if (cmbMes.Text == "ENERO")
                    {
                        Mes = "gastos_enero23";
                    }
                    else
                    {
                        if (cmbMes.Text == "FEBRERO")
                        {
                            Mes = "gastos_febrero23";
                        }
                        else
                        {
                            if (cmbMes.Text == "MARZO")
                            {
                                Mes = "gastos_marzo23";
                            }
                            else
                            {
                                if (cmbMes.Text == "ABRIL")
                                {
                                    Mes = "gastos_abril23";
                                }
                                else
                                {
                                    if (cmbMes.Text == "MAYO")
                                    {
                                        Mes = "gastos_mayo23";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "JUNIO")
                                        {
                                            Mes = "gastos_junio23";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "JULIO")
                                            {
                                                Mes = "gastos_julio23";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "AGOSTO")
                                                {
                                                    Mes = "gastos_agosto23";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "SEPTIEMBRE")
                                                    {
                                                        Mes = "gastos_septiembre23";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "OCTUBRE")
                                                        {
                                                            Mes = "gastos_octubre23";
                                                        }
                                                        else
                                                        {
                                                            if (cmbMes.Text == "NOVIEMBRE")
                                                            {
                                                                Mes = "gastos_noviembre23";
                                                            }
                                                            else
                                                            {
                                                                if (cmbMes.Text == "DICIEMBRE")
                                                                {
                                                                    Mes = "gastos_diciembre23";
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

                    ClsTablaIngreso ctrl = new ClsTablaIngreso();
                    ctrl.eliminarIngreso(id, Mes);
                    Calculos();
                }
            }
            else
            {
                MessageBox.Show("No hay registros actuales para eliminar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInformeCX frm = new frmInformeCX();
            frm.ShowDialog();
        }
    }
}


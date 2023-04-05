using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PryCampo
{
    public partial class frmRegistro : Form
    {
        public int[,] MatIngreso = new int[32, 3];
        public int[,] MatGasto = new int[32, 7];
        public int[] VecIngreso = new int[32];
        public int[] VecGasto = new int[32];
        public int[] VecResultadoDia = new int[32];
        public int[] VecIngresoCategoria = new int[3];
        public int[] VecGastoCategoria = new int[7];


        

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPlanCuentas_Load(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 30; i++)
            {
                dgvDatos.Rows.Add();
            }
            dgvDatos.Rows[0].Cells[0].Value = "1";
            dgvDatos.Rows[1].Cells[0].Value = "2";
            dgvDatos.Rows[2].Cells[0].Value = "3";
            dgvDatos.Rows[3].Cells[0].Value = "4";
            dgvDatos.Rows[4].Cells[0].Value = "5";
            dgvDatos.Rows[5].Cells[0].Value = "6";
            dgvDatos.Rows[6].Cells[0].Value = "7";
            dgvDatos.Rows[7].Cells[0].Value = "8";
            dgvDatos.Rows[8].Cells[0].Value = "9";
            dgvDatos.Rows[9].Cells[0].Value = "10";
            dgvDatos.Rows[10].Cells[0].Value = "11";
            dgvDatos.Rows[11].Cells[0].Value = "12";
            dgvDatos.Rows[12].Cells[0].Value = "13";
            dgvDatos.Rows[13].Cells[0].Value = "14";
            dgvDatos.Rows[14].Cells[0].Value = "15";
            dgvDatos.Rows[15].Cells[0].Value = "16";
            dgvDatos.Rows[16].Cells[0].Value = "17";
            dgvDatos.Rows[17].Cells[0].Value = "18";
            dgvDatos.Rows[18].Cells[0].Value = "19";
            dgvDatos.Rows[19].Cells[0].Value = "20";
            dgvDatos.Rows[20].Cells[0].Value = "21";
            dgvDatos.Rows[21].Cells[0].Value = "22";
            dgvDatos.Rows[22].Cells[0].Value = "23";
            dgvDatos.Rows[23].Cells[0].Value = "24";
            dgvDatos.Rows[24].Cells[0].Value = "25";
            dgvDatos.Rows[25].Cells[0].Value = "26";
            dgvDatos.Rows[26].Cells[0].Value = "27";
            dgvDatos.Rows[27].Cells[0].Value = "28";
            dgvDatos.Rows[28].Cells[0].Value = "29";
            dgvDatos.Rows[29].Cells[0].Value = "30";
            dgvDatos.Rows[30].Cells[0].Value = "31";
            dgvDatos.Columns[0].ReadOnly = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int Dia = 0;
            Dia = Convert.ToInt32(cmbDia.SelectedIndex.ToString());


            if (optSoja.Checked)
            {
                MatIngreso[Dia, 0] = Convert.ToInt32(txtIngreso.Text);


            }
            else
            {
                if (optMaiz.Checked)
                {
                    MatIngreso[Dia, 1] = Convert.ToInt32(txtIngreso.Text);
                }
                else
                {
                    if (optGanado.Checked)
                    {
                        MatIngreso[Dia, 2] = Convert.ToInt32(txtIngreso.Text);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tipo de Ingreso.", "ERROR.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            txtIngreso.Clear();
            optSoja.Checked = false;
            optMaiz.Checked = false;
            optGanado.Checked = false;

        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            int Dia = 0;

            Dia = Convert.ToInt32(cmbDia.SelectedIndex.ToString());

            if (optInsumos.Checked)
            {
                MatGasto[Dia, 0] = Convert.ToInt32(txtGasto.Text);
            }
            else
            {
                if (optServiciosG.Checked)
                {
                    MatGasto[Dia, 1] = Convert.ToInt32(txtGasto.Text);


                }
                else
                {
                    if (optMateriaPrima.Checked)
                    {
                        MatGasto[Dia, 2] = Convert.ToInt32(txtGasto.Text);
                    }
                    else
                    {
                        if (optRh.Checked)
                        {
                            MatGasto[Dia, 3] = Convert.ToInt32(txtGasto.Text);
                        }
                        else
                        {
                            if (optMaquinaria.Checked)
                            {
                                MatGasto[Dia, 4] = Convert.ToInt32(txtGasto.Text);
                            }
                            else
                            {
                                if (optImpuestos.Checked)
                                {
                                    MatGasto[Dia, 5] = Convert.ToInt32(txtGasto.Text);
                                }
                                else
                                {
                                    if (optInversiones.Checked)
                                    {
                                        MatGasto[Dia, 6] = Convert.ToInt32(txtGasto.Text);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingreso un tipo de Gasto.", "ERROR",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                            }
                        }
                    }
                }
            }
            txtGasto.Clear();
            optInsumos.Checked = false;
            optMateriaPrima.Checked = false;
            optImpuestos.Checked = false;
            optInversiones.Checked = false;
            optServiciosG.Checked = false;
            optRh.Checked = false;
            optMaquinaria.Checked = false;


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int C = 0;
            int Dia = 0;
            int Ingreso = 0;
            int Gasto = 0;
            int DiaGrilla = 0;
            int IngresoTotal = 0;
            int GastoTotal = 0;
            int ResultadoTotal = 0;


            for (Dia = 0; Dia <= MatIngreso.GetUpperBound(0); Dia++)
            {
                for (C = 0; C <= MatIngreso.GetUpperBound(1); C++)
                {
                    Ingreso = MatIngreso[Dia, C];
                    VecIngreso[Dia] = VecIngreso[Dia] + Ingreso;
                }

            }

            for (Dia = 0; Dia <= MatGasto.GetUpperBound(0); Dia++)
            {
                for (C = 0; C <= MatGasto.GetUpperBound(1); C++)
                {
                    Gasto = MatGasto[Dia, C];
                    VecGasto[Dia] = VecGasto[Dia] + Gasto;
                }

            }

            for (Dia = 0; Dia <= 31; Dia++)
            {
                VecResultadoDia[Dia] = VecIngreso[Dia] - VecGasto[Dia];
            }



            for (DiaGrilla = 0; DiaGrilla <= 30; DiaGrilla++)
            {
                dgvDatos.Rows[DiaGrilla].Cells[1].Value = Convert.ToString(VecIngreso[DiaGrilla]);
                dgvDatos.Rows[DiaGrilla].Cells[2].Value = Convert.ToString(VecGasto[DiaGrilla]);
                dgvDatos.Rows[DiaGrilla].Cells[3].Value = Convert.ToString(VecResultadoDia[DiaGrilla]);
            }

            for (Dia = 0; Dia < VecIngreso.Length; Dia++)
            {
                IngresoTotal = IngresoTotal + VecIngreso[Dia];
            }

            for (Dia = 0; Dia < VecGasto.Length; Dia++)
            {
                GastoTotal = GastoTotal + VecGasto[Dia];
            }

            for (Dia = 0; Dia < VecResultadoDia.Length; Dia++)
            {
                ResultadoTotal = ResultadoTotal + VecResultadoDia[Dia];
            }

            dgvDatos.Visible = true;
            lblTotalTitulo.Text = "Resultado Total ABRIL";
            lblIngresoTitulo.Text = "Ingreso Mensual";
            lblGastoTitulo.Text = "Gasto Mensual";
            lblTotalTitulo.Visible = true;
            lblIngresoTotal.Text = "$" + IngresoTotal.ToString();
            lblGastoTotal.Text = "$" + GastoTotal.ToString();
            lblResultadoTotal.Text = "$" + ResultadoTotal.ToString();


            for (Dia = 0; Dia < MatIngreso.GetUpperBound(0); Dia++)
            {
                VecIngresoCategoria[0] = VecIngresoCategoria[0] + Convert.ToInt32(MatIngreso[Dia, 0]);
                VecIngresoCategoria[1] = VecIngresoCategoria[1] + Convert.ToInt32(MatIngreso[Dia, 1]);
                VecIngresoCategoria[2] = VecIngresoCategoria[2] + Convert.ToInt32(MatIngreso[Dia, 2]);
            }


            for (Dia = 0; Dia < MatGasto.GetUpperBound(0); Dia++)
            {
                VecGastoCategoria[0] = VecGastoCategoria[0] + Convert.ToInt32(MatGasto[Dia, 0]);
                VecGastoCategoria[1] = VecGastoCategoria[1] + Convert.ToInt32(MatGasto[Dia, 1]);
                VecGastoCategoria[2] = VecGastoCategoria[2] + Convert.ToInt32(MatGasto[Dia, 2]);
                VecGastoCategoria[3] = VecGastoCategoria[3] + Convert.ToInt32(MatGasto[Dia, 3]);
                VecGastoCategoria[4] = VecGastoCategoria[4] + Convert.ToInt32(MatGasto[Dia, 4]);
                VecGastoCategoria[5] = VecGastoCategoria[5] + Convert.ToInt32(MatGasto[Dia, 5]);
                VecGastoCategoria[6] = VecGastoCategoria[6] + Convert.ToInt32(MatGasto[Dia, 6]);
                


            }


            // grafico ingreso
            chartIngreso.Visible = true;
            string[] titulos = { "SOJA", "MAIZ", "GANADO" };
            int[] totales = new int[3];
            chartIngreso.Titles.Add("Ingresos por Categorías");
            for (int i = 0; i < VecIngresoCategoria.Length; i++)
            {
                Series titulo = chartIngreso.Series.Add(titulos[i]);
                titulo.Label = VecIngresoCategoria[i].ToString();
                titulo.Points.Add(VecIngresoCategoria[i]);
            }

            // grafico Gasto
            chartGasto.Visible = true;
            string[] titulosGasto = { "INSUMOS", "SERVICIOS", "MATERIA PRIMA", "RRHH", "MAQUINARIA", "IMPUESTOS", "INVERSIONES" };
            int[] totalesGasto = new int[7];
            chartGasto.Titles.Add("Gastos por Categorías");
            for (int i = 0; i < VecGastoCategoria.Length; i++)
            {
                Series tituloGasto = chartGasto.Series.Add(titulosGasto[i]);
                tituloGasto.Label = VecGastoCategoria[i].ToString();
                tituloGasto.Points.Add(VecGastoCategoria[i]);
            }


            btnMostrar.Enabled = false;
        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngreso_KeyPress(object sender, KeyPressEventArgs e) //impedir letras
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; //borra la tecla ingresada
            }
        }

        private void txtGasto_KeyPress(object sender, KeyPressEventArgs e) //impedir letras
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; //borra la tecla ingresada
            }
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDia.SelectedIndex != -1)
            {
                txtIngreso.Enabled = true;
                txtGasto.Enabled = true;
            }
        }
    }
}

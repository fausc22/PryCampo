using Microsoft.Reporting.WebForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace PryCampo.CASTEX
{
    public partial class frmInformeCX : Form
    {
        public frmInformeCX()
        {
            InitializeComponent();
        }

        private void frmInformeCX_Load(object sender, EventArgs e)
        {
            

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            

            



            admConexion conexion = new admConexion();
            if(conexion.CrearConexion() == true)
            {

                //INGRESOS
                string sql = "SELECT id, tipo, precio, descripcion, fecha FROM uwu ORDER BY tipo ASC";
                MySqlDataAdapter DA = new MySqlDataAdapter(sql, conexion.oConexion);
                DA.Fill(dataSet1, "Ingresos");
                conexion.oConexion.Close();
                chIngresos.Titles.Clear();
                chIngresos.Series.Clear();
                chIngresos.ChartAreas.Clear();
                chIngresos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
                ChartArea areagrafico = new ChartArea();
                //areagrafico.Area3DStyle.Enable3D = true;
                chIngresos.ChartAreas.Add(areagrafico);
                Title titulo = new Title("Hola");
                titulo.Font = new Font("Tahoma", 18, FontStyle.Bold);
                chIngresos.Titles.Add(titulo);
                Series serie = new Series("Ingresos");
                serie.ChartType = SeriesChartType.Pie;
                serie.XValueMember = "Tipo";
                serie.YValueMembers = "Precio";
                serie.IsValueShownAsLabel = true;
                chIngresos.Series.Add(serie);
                chIngresos.DataSource = dataSet1;

                //GASTOS

            }
            
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            string Mes = "";
            string MesG = "";
            string MesR = "";
            if (optMes.Checked == true)
            {
                btnSelec.Enabled = true;
                if (cmbMes.Text == "ENERO")
                {
                    Mes = "ingresos_enero23";
                    MesG = "gastos_enero23";
                }
                else
                {
                    if (cmbMes.Text == "FEBRERO")
                    {
                        Mes = "ingresos_febrero23";
                        MesG = "gastos_febrero23";
                    }
                    else
                    {
                        if (cmbMes.Text == "MARZO")
                        {
                            Mes = "ingresos_marzo23";
                            MesG = "gastos_marzo2023";
                        }
                        else
                        {
                            if (cmbMes.Text == "ABRIL")
                            {
                                Mes = "ingresos_abril23";
                                MesG = "gastos_abril23";
                            }
                            else
                            {
                                if (cmbMes.Text == "MAYO")
                                {
                                    Mes = "ingresos_mayo23";
                                    MesG = "gastos_mayo23";
                                }
                                else
                                {
                                    if (cmbMes.Text == "JUNIO")
                                    {
                                        Mes = "ingresos_junio23";
                                        MesG = "gastos_junio23";
                                    }
                                    else
                                    {
                                        if (cmbMes.Text == "JULIO")
                                        {
                                            Mes = "ingresos_julio23";
                                            MesG = "gastos_julio23";
                                        }
                                        else
                                        {
                                            if (cmbMes.Text == "AGOSTO")
                                            {
                                                Mes = "ingresos_agosto23";
                                                MesG = "gastos_agosto23";
                                            }
                                            else
                                            {
                                                if (cmbMes.Text == "SEPTIEMBRE")
                                                {
                                                    Mes = "ingresos_septiembre23";
                                                    MesG = "gastos_septiembre23";
                                                }
                                                else
                                                {
                                                    if (cmbMes.Text == "OCTUBRE")
                                                    {
                                                        Mes = "ingresos_octubre23";
                                                        MesG = "gastos_octubre23";
                                                    }
                                                    else
                                                    {
                                                        if (cmbMes.Text == "NOVIEMBRE")
                                                        {
                                                            Mes = "ingresos_noviembre23";
                                                            MesG = "gastos_noviembre23";
                                                        }
                                                        else
                                                        {
                                                            if (cmbMes.Text == "DICIEMBRE")
                                                            {
                                                                Mes = "ingresos_diciembre23";
                                                                MesG = "gastos_diciembre23";
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


            }
            




            admConexion conexion = new admConexion();
            if (conexion.CrearConexion() == true)
            {

                //INGRESOS
                string sqlI = "SELECT id, tipo, precio, descripcion, fecha FROM " + Mes + " ORDER BY tipo ASC";
                MySqlDataAdapter DAI = new MySqlDataAdapter(sqlI, conexion.oConexion);
                DAI.Fill(dataSet1, "Ingresos");
                conexion.oConexion.Close();
                chIngresos.Titles.Clear();
                chIngresos.Series.Clear();
                chIngresos.ChartAreas.Clear();
                chIngresos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
                ChartArea areagrafico = new ChartArea();
                //areagrafico.Area3DStyle.Enable3D = true;
                chIngresos.ChartAreas.Add(areagrafico);
                Title titulo = new Title("Hola");
                titulo.Font = new Font("Tahoma", 18, FontStyle.Bold);
                chIngresos.Titles.Add(titulo);
                Series serie = new Series("Ingresos");
                serie.ChartType = SeriesChartType.Pie;
                serie.XValueMember = "Tipo";
                serie.YValueMembers = "Precio";
                serie.IsValueShownAsLabel = true;
                chIngresos.Series.Add(serie);
                chIngresos.DataSource = dataSet1;

                //GASTOS
                string sqlG = "SELECT id, tipo, precio, descripcion, fecha FROM " + MesG + " ORDER BY tipo ASC";
                MySqlDataAdapter DAG = new MySqlDataAdapter(sqlG, conexion.oConexion);
                DAG.Fill(dataSet1, "Gastos");
                conexion.oConexion.Close();
                chGastos.Titles.Clear();
                chGastos.Series.Clear();
                chGastos.ChartAreas.Clear();
                chGastos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
                ChartArea areagraficoG = new ChartArea();
                //areagrafico.Area3DStyle.Enable3D = true;
                chGastos.ChartAreas.Add(areagraficoG);
                Title tituloG = new Title("Hola");
                tituloG.Font = new Font("Tahoma", 18, FontStyle.Bold);
                chGastos.Titles.Add(tituloG);
                Series serieG = new Series("Gastos");
                serie.ChartType = SeriesChartType.Pie;
                serie.XValueMember = "Tipo";
                serie.YValueMembers = "Precio";
                serie.IsValueShownAsLabel = true;
                chGastos.Series.Add(serieG);
                chGastos.DataSource = dataSet1;




            }
        }
    }
}

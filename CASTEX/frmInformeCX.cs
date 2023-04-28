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
                string sql = "SELECT id, tipo, precio, descripcion, fecha FROM ingresos_mayo23 ORDER BY tipo ASC";
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

            }
            
        }
    }
}

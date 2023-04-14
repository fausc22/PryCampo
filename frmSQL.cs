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

namespace PryCampo
{
    public partial class frmSQL : Form
    {
        public frmSQL()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String passowrd = "251199";
            String DB = "mysql";


            //string para conexion
            String cadenaConexion = "Database=" + DB + "; Data Source=" + servidor + "; Port=" + puerto +  "; User Id= " + usuario + "; Password=" + passowrd; 

            MySqlConnection conexionDB = new MySqlConnection(cadenaConexion); //OBJETO QUE llama a la conexion
            MySqlDataReader reader = null; //abre el reader
            String data = null;
            try //try para prevenir errores
            {
                String consulta = "SHOW DATABASES"; //QUERY DE LA DATABASE  
                MySqlCommand comando = new MySqlCommand(consulta); //OBJETO COMANDO CON EL QUERY
                comando.Connection = conexionDB; // CONEXION REALIZADA CON EL OBJETO ANTERIOR
                conexionDB.Open(); // ABRE LA CONEXION
                reader = comando.ExecuteReader(); //SE EJECUTA LA CONSULTA Y CONTIENE LOS RESULTADOS

                while (reader.Read())
                {
                    data += reader.GetString(0) + "\n";   //toma la informacion del reader y la convierte en string
                }

                MessageBox.Show(data); //muestra el string con la informacion
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message); //agregamos un mensaje en caso de error 
            }
            finally
            {
                conexionDB.Close(); //cerramos la conexion si no se puede remediar el error
            }
        
        }
    }
}

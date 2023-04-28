using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCampo
{
    class admConexion
    {
        public MySqlConnection oConexion;
        public bool CrearConexion()
        {
            bool conectado = false;
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String passowrd = "251199";
            String DB = "campo_castex";


            //string para conexion
            String cadenaConexion = "Database=" + DB + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id= " + usuario + "; Password=" + passowrd;

            try
            {
                oConexion = new MySqlConnection(cadenaConexion);
                oConexion.Open();
                conectado = true; 
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conectado = false;

            }
            return conectado;
        }
    }
}

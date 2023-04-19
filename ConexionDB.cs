using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCampo
{
     class ConexionDB
    {
        public static MySqlConnection conexion()
        {
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String passowrd = "251199";
            String DB = "campo_castex";


            //string para conexion
            String cadenaConexion = "Database=" + DB + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id= " + usuario + "; Password=" + passowrd;

            try
            {
                MySqlConnection conexionDB = new MySqlConnection(cadenaConexion);

                return conexionDB;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;

            }
        }
    }
}

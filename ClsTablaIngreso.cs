using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryCampo
{
    class ClsTablaIngreso : ConexionDB
    {
        public List<Object> consulta(string dato)
        {
            string tabla = "ingresos_mayo23";
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql = "";

            if (dato == null)
            {
                sql = "SELECT tipo, precio, descripcion, precio FROM ingresos_mayo23 ORDER BY tipo ASC";
            }


            try
            {
                MySqlConnection conexionDB = new MySqlConnection();
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsIngreso NuevoIngreso = new ClsIngreso();
                    NuevoIngreso.Tipo = reader.GetString(0);
                    NuevoIngreso.Precio = decimal.Parse(reader.GetString(1));
                    NuevoIngreso.Descripcion = reader.GetString(2);
                    NuevoIngreso.Fecha = reader.GetString(3);
                    lista.Add(NuevoIngreso);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
             return lista;

        }
    }
}

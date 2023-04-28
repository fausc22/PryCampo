using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryCampo
{
    class ClsTablaIngreso : ConexionDB
    {


        public string Mes { get; set; }
        public decimal Ingresos { get; set; }


        public List<Object> consultaIngreso(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql = "";

            if (dato == null)
            {
                sql = "SELECT id, tipo, precio, descripcion, fecha FROM " + Mes + " ORDER BY tipo ASC";
            }

            try
            {
                MySqlConnection conexionDB = base.conexion();
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Productos _producto = new Productos();

                    _producto.Id = reader.GetInt32(0);
                    _producto.Tipo = reader.GetString(1);
                    _producto.Precio = decimal.Parse(reader.GetString(2));
                    _producto.Descripcion = reader.GetString(3);
                    _producto.Fecha = reader.GetString(4);

                    lista.Add(_producto);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;






        }

        public bool actualizarIngreso(Productos datos)
        {
            bool bandera = false;

            string sql = "UPDATE " + Mes + " SET tipo='" + datos.Tipo + "', precio='" + datos.Precio + "', descripcion='" + datos.Descripcion + "', fecha='" + datos.Fecha + "' WHERE id='" + datos.Id + "'";

            try
            {
                MySqlConnection conexionDB = base.conexion();
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }

            return bandera;
        }

        public bool eliminarIngreso(string id, string Mes)
        {
            bool bandera = false;

            string sql = "DELETE FROM " + Mes + "  WHERE id='" + id + "'";

            try
            {
                MySqlConnection conexionDB = base.conexion();
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }

            return bandera;




        }

        
    }
}

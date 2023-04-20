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
                sql = "SELECT tipo, precio, descripcion, fecha FROM " +Mes+ " ORDER BY tipo ASC";
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
                    
                    _producto.Tipo = reader.GetString(0);
                    _producto.Precio = decimal.Parse(reader.GetString(1));
                    _producto.Descripcion = reader.GetString(2);
                    _producto.Fecha = reader.GetString(3);
                    
                    lista.Add(_producto);
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

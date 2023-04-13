using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryCampo
{
    internal class ClsIngreso
    {
        public string Fecha { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
    
        public List<string> TipoIngreso { get; set; }
        public string NombreArchivo { get; set; }

        public bool GrabarIngreso(ClsIngreso NuevoIngreso)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
                sw.WriteLine(NuevoIngreso.Tipo + "," +
                    NuevoIngreso.Precio.ToString("#.00", CultureInfo.InvariantCulture) + "," +
                    NuevoIngreso.Descripcion + "," +
                    NuevoIngreso.Fecha);
                sw.Close();
                sw.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public bool GrabarTipo(ClsIngreso NuevoTipo)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
                
                sw.WriteLine(NuevoTipo.Tipo);
                sw.Close();
                sw.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public bool BorrarTipo(ClsIngreso NuevoTipo)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, false);

                sw.WriteLine(NuevoTipo.Tipo);
                sw.Close();
                sw.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public List<ClsIngreso> ObtenerIngresos()
        {
            List<ClsIngreso> ListaTipos = new List<ClsIngreso>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                    ClsIngreso TipoIngreso = new ClsIngreso();
                    TipoIngreso.Tipo = Linea.Split(',')[0];
                    TipoIngreso.Precio = decimal.Parse(Linea.Split(',')[1],CultureInfo.InvariantCulture);
                    TipoIngreso.Descripcion = Linea.Split(',')[2];
                    TipoIngreso.Fecha = Linea.Split(',')[3];
                    ListaTipos.Add(TipoIngreso);
                }
                sr.Close();
                sr.Dispose();
            }
            return ListaTipos;
        }

        

    }
}

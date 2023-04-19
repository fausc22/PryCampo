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

        

        

    }
}

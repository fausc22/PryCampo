using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryCampo
{
    internal class ClsGasto
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }

        public List<string> TipoGasto { get; set; }
    }
}

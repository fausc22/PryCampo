using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryCampo
{
    class Productos
    {
        private int id;
        private string fecha;
        private string tipo;
        private decimal precio;
        private string descripcion;
        private decimal ingresos;
        private decimal gastos;
        private decimal Resultados;

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        
        public decimal Precio { get => precio; set => precio = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Ingresos { get => ingresos; set => ingresos = value; }
        public decimal Gastos { get => gastos; set => gastos = value; }
        public decimal Resultados1 { get => Resultados; set => Resultados = value; }
        
    }
}

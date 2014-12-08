using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_venta.DTO
{
    public class CorteVentas
    {
        public string codigo { set; get; }
        public string producto { set; get; }
        public int cantidad { set; get; }
        public float total { set; get; }

        public CorteVentas() { }
        public CorteVentas( string codigo, string producto, int cantidad, float total) 
        {
            this.codigo = codigo;
            this.producto = producto;
            this.cantidad = cantidad;
            this.total = total;
        }
    }
}

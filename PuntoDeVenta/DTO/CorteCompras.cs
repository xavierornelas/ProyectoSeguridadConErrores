using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DTO
{
    public class CorteCompras
    {
        public string id { set; get; }
        public string producto { set; get; }
        public string proveedor { set; get; }
        public string cantidad { set; get; }
        public string costo { set; get; }
        public string tipo { set; get; }
        public string total { set; get; }

        public CorteCompras() 
        {
        }

        public CorteCompras(string id, string producto, string proveedor,string cantidad, string costo, string tipo,string total) 
        {
            this.id = id;
            this.producto = producto;
            this.proveedor = proveedor;
            this.cantidad = cantidad;
            this.costo = costo;
            this.tipo = tipo;
            this.total = total;
        }

    }
}

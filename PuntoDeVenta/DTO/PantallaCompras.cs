using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PantallaCompras
    {
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }
        public string proveedor { get; set; }

        public PantallaCompras() { }

        public PantallaCompras(string Codigo, string producto, int cantidad, float precio, string proveedor) 
        {
            this.Codigo = Codigo;
            this.Producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
            this.proveedor = proveedor;
        }
    }
}

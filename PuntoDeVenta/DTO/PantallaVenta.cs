using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_venta.DTO
{
    public class PantallaVenta
    {
        public string Codigo { get; set; }
        public string Cantidad { get; set; }
        public string Producto { get; set; }
        public string Precio { get; set; }

        public PantallaVenta() { }
        public PantallaVenta(string Cantidad, string Producto, string Precio) 
        {
            this.Cantidad=Cantidad;
            this.Producto = Producto;
            this.Precio = Precio;
        }
    }
}

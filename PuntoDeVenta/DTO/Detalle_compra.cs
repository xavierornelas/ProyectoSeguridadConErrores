using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DTO
{
    public class Detalle_compra
    {
        public string id_compra { set; get; }
        public string id_producto { set; get; }
        public int id_proveedor { set; get; }
        public int cantidad { set; get; }
        public float precio { set; get; }
        public float total { set; get; }
        public Detalle_compra() { }

        public Detalle_compra(string id_compra, string id_producto, int id_proveedor, int cantidad, float precio, float total) 
        {
            this.id_compra = id_compra;
            this.id_producto = id_producto;
            this.id_proveedor = id_proveedor;
            this.cantidad = cantidad;
            this.precio = precio;
            this.total = total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class Detalle
    {
       public string id_venta { get; set; }
       public string id_producto { get; set; }
       public int cantidad { get; set; }
       public float precio { get; set; }
       public float total { get; set; }
       public Detalle() { }
       public Detalle(string id_venta, string id_producto, int cantidad, float precio, float total) 
       {
           this.id_venta = id_venta;
           this.id_producto = id_producto;
           this.cantidad = cantidad;
           this.precio = precio;
           this.total = total;
       }
    }
}

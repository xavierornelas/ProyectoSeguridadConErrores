using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Productos
    {
        public string Id { get; set; }       
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; }

        

        public Productos()
        {
        }

        public Productos(string id, string nombre, float precio, int cantidad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;            
        }

    }
}

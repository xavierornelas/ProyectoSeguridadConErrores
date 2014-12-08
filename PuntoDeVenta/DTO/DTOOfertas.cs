using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTOOfertas
    {
        public string id { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }
        public string descripcion { get; set; }
        public string codigo { get; set; }

        public DTOOfertas()
        {

        }

        public DTOOfertas(string id, int cantidad, float precio, string descripcion, string codigo)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.precio = precio;
            this.descripcion = descripcion;
            this.codigo = codigo;

        }
    }
}

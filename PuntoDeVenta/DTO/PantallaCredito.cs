using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_venta.DTO
{
    public class PantallaCredito
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public float deuda { get; set; }

        public PantallaCredito() { }
        public PantallaCredito(int id_cliente, string nombre, float deuda) 
        {
            this.id_cliente = id_cliente;
            this.nombre = nombre;
            this.deuda = deuda;
        }
    }
}

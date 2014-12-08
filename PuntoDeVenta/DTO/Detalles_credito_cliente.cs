using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DTO
{
    public class Detalles_credito_cliente
    {
        public int id_cliente { set; get; }
        public string id_venta { set; get; }

        public Detalles_credito_cliente() { }
        public Detalles_credito_cliente(int id_cliente,string id_venta) 
        {
            this.id_cliente = id_cliente;
            this.id_venta = id_venta;
        }
    }
}

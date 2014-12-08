using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DTO
{
    public class Abonos
    {
        public int id_cliente { set; get; }
        public string fecha { set; get; }
        public float abono { set; get; }
        public Abonos() { }
        public Abonos(int id_cliente, string fecha, float abono) 
        {
            this.id_cliente = id_cliente;
            this.fecha = fecha;
            this.abono = abono;
        }

    }
}

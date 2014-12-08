using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Compras
    {
        public string id_compra { set; get; }
        public string fecha { set; get; }
        public string usuario { set; get; }
        public string tipo { set; get; }
        public string hora { set; get; }
        public float total { set; get; }

        public Compras()
        {

        }

        public Compras(string id_compra, string fecha, string usuario, string tipo, string hora, float total)
        {
            this.id_compra = id_compra;
            this.fecha = fecha;
            this.usuario = usuario;
            this.tipo = tipo;
            this.total = total;
            this.fecha = fecha;
            this.tipo = tipo;
        }
    }
}

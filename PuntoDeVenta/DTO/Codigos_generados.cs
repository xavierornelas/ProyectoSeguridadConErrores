using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Codigos_generados
    {
        public string codigo { set; get; }
        public string descripcion { set; get; }
        public string ruta { set; get; }

        public Codigos_generados() { }

        public Codigos_generados(string codigo, string descripcion, string ruta) 
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.ruta = ruta;
        }

    }
}

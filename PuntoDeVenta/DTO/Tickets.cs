using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Tickets
    {
        public int id { get; set; }
        public string mensaje { set; get; }
        public string nombreDeLaEmpresa { set; get; }
        public string direccionDeLaEmpresa { set; get; }
        public string municipio { set; get; }
        public string estado { set; get; }
        public string impresora { get; set; }
        public int tamanoFuenta { get; set; }

        public Tickets() { }
        public Tickets(int id, string nombreDeLaEmpresa, string direccionDeLaEmpresa, string municipio, string estado, string impresora,int tamanoFuenta, string mensaje) 
        {
            this.id = id;            
            this.nombreDeLaEmpresa = nombreDeLaEmpresa;
            this.direccionDeLaEmpresa = direccionDeLaEmpresa;
            this.municipio = municipio;
            this.estado = estado;
            this.impresora = impresora;
            this.tamanoFuenta = tamanoFuenta;
            this.mensaje = mensaje;
            
        }


    }
}

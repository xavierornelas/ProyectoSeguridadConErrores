using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Ventas
    {
        public string Id { get; set; }        
        public string Fecha { get; set; }
        public float Total { get; set; }
        public string Usuario { get; set; }
        public string Tipo { get; set; }
        public string Hora { get; set; }

        public Ventas() { }
        public Ventas(string Id, string Fecha, float Total, string Usuario,string Tipo,string Hora) 
        {
            this.Id = Id;
            this.Fecha = Fecha;
            this.Total = Total;
            this.Usuario = Usuario;
            this.Tipo = Tipo;
            this.Hora = Hora;
          
        }

        

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Rfc { get; set; }
       

        public Clientes() { }
        public Clientes(int Id, string Nombre, string Domicilio, string Ciudad, string Estado, string Rfc) 
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Domicilio = Domicilio;
            this.Ciudad = Ciudad;
            this.Estado = Estado;
            this.Rfc = Rfc;
           
        }
       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class Proveedores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }

        public Proveedores() { }
        public Proveedores(int Id, string Nombre, string Domicilio,string Ciudad, string Estado) 
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Domicilio = Domicilio;
            this.Ciudad = Ciudad;
            this.Estado = Estado;
        }

        
    }
}

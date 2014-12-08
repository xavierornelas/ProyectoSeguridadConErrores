using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class ProveedoresDeudas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Deuda { get; set; }

        public ProveedoresDeudas() { }
        
        public ProveedoresDeudas(int Id, string Nombre, float Deuda) 
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Deuda = Deuda;
        }
    }
}

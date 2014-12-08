using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Paquetes
    {
       public int Id { set; get; }
       public string nombre { set; get; }
       public string contrasenia { set; get; }
       public string activado { set; get; }

       public Paquetes() { }
       public Paquetes(int Id, string nombre, string contrasenia, string activado) 
       {
           this.Id = Id;
           this.nombre = nombre;
           this.contrasenia = contrasenia;
           this.activado = activado;
       }
    }
}

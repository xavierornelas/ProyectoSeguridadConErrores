using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DTO
{
   public class Correo
    {
       public int id_correo { set; get; }
       public string correo { set; get; }
       public int Default { set; get; }

       public Correo() { }

       public Correo(int id_correo, string correo, int Default) 
       {
           this.id_correo = id_correo;
           this.correo = correo;
           this.Default = Default;
       }
    }
}

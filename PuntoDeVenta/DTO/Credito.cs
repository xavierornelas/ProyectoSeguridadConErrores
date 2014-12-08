using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Credito
    {
        public int id_cliente { set; get; }
       
        public float deuda { set; get; }
        public Credito() { }
        public Credito(int id_cliente, float deuda) 
        {
            this.id_cliente = id_cliente;
           
            this.deuda = deuda;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DTO
{
    public class dto_clave_scaner
    {
        public dto_clave_scaner() { }
        public int id_usuario { set; get; }
        public string contrasenia { set; get; }
        public dto_clave_scaner(int id_usuario, string contrasenia) 
        {
            this.id_usuario = id_usuario;
            this.contrasenia = contrasenia;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Usuarios
    {
        public Usuarios()
        {
        }

        public Usuarios(int id, string nombre, string pass, string privilegios)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Contrasenia = pass;
            this.Privilegios = privilegios;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public string Privilegios { get; set; }
    }
}

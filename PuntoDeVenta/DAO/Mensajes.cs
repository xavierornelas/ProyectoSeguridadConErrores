using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.DAO
{
    public class Mensajes
    {
        public Mensajes() { }
        public void DebeLlenarTodosLosCampos() 
        {
            MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void EspaciosEnBlanco()
        {
            MessageBox.Show("Espacios en blanco al inio y/o fin de registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ContrasenaDiferente()
        {
            MessageBox.Show("Contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CaracteresInvalidos()
        {
            MessageBox.Show("Contraseñas debe de tener 7 caracteres, un numero y una letra mayuscula como mínimo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

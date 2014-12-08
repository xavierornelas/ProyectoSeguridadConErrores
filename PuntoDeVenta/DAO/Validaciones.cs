using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.DAO
{
    public class Validaciones
    {
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            //just letters and punctuation marks
            if (!char.IsControl(e.KeyChar)
        && char.IsDigit(e.KeyChar)
        )
            {
                e.Handled = true;
            }

            if ((char)e.KeyChar == '\'' || (char)e.KeyChar == '\"')
            {
                e.Handled = true;
            }
        }
        public bool CheckValid(string text)
        {
            char[] cha = new char[text.Length];
            char b, e;
            b = text.ToCharArray()[0];
            e = text.ToCharArray()[text.Length - 1];
            if (e == ' ' || b == ' ')
                return true;
            else
                return false;
        }

        public bool CheckPassword(string text)
        {
            bool dig = false;
            bool cap = false;
            char[] ch = text.ToCharArray();

            for(int i=0; i < text.Length; i++)
            {
                if (char.IsDigit(ch[i]))
                    dig = true;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(ch[i]))
                    cap = true;
            }

            return dig && cap;
        }

        public string LimpiarString(string text) 
        {
            string procesador = text;
                while (CheckValid(procesador))
                {
                    char b, e;
                    b = procesador.ToCharArray()[0];
                    e = procesador.ToCharArray()[procesador.Length - 1];
                    if (e == ' ')
                        procesador.Remove(procesador.Length - 1);

                    if (b == ' ')
                        procesador.Remove(0);
                }
            return procesador;          
        }
       
    }
}

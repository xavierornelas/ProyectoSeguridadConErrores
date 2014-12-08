using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using punto_venta;

namespace PuntoDeVenta
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Presentacion pre = new Presentacion();
            if (pre.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new login());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
            Tiempo.Enabled = true;
            Tiempo.Interval = 3000;
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {

        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Comercial_form : Form
    {
        public Comercial_form()
        {
            InitializeComponent();
            //linkLabel1.Text = "Da clic para mayor información";
            linkLabel1.Links.Add(0, 8, "www.facebook.com/cCeoOfficial");
            //Agrego los datos para los paquetes
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_contacto_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.cceo.com.mx");
            }
            catch { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Comercial_form_Load(object sender, EventArgs e)
        {

        }
    }
}

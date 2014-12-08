using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using PuntoDeVenta.DAO;

namespace punto_venta
{
    public partial class Nuevo_proveedor : Form
    {
        public Nuevo_proveedor()
        {
            InitializeComponent();
            nombre_textbox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nombre_textbox.Text.Equals(null)||domicilio_textBox.Text.Equals(null)||ciudad_textBox.Text.Equals(null)||estado_textBox.Text.Equals(null))
            {
                new Mensajes().DebeLlenarTodosLosCampos();
                nombre_textbox.Focus();
                nombre_textbox.SelectionStart = 0;
                nombre_textbox.SelectionLength = nombre_textbox.Text.Length;
            }
            else if (new Validaciones().LimpiarString(domicilio_textBox.Text).Equals(null) || new Validaciones().LimpiarString( ciudad_textBox.Text).Equals(null) || new Validaciones().LimpiarString( nombre_textbox.Text).Equals(null) || new Validaciones().LimpiarString(estado_textBox.Text).Equals(null) )
            {
                new Mensajes().DebeLlenarTodosLosCampos();
                nombre_textbox.Focus();
                nombre_textbox.SelectionStart = 0;
                nombre_textbox.SelectionLength = nombre_textbox.Text.Length;
            }
            else if (new DAOProveedores().GetProvider(new Validaciones().LimpiarString(nombre_textbox.Text)) != null)
            {
                MessageBox.Show("El nombre del proveedor está repetido.", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nombre_textbox.Focus();
                nombre_textbox.SelectionStart = 0;
                nombre_textbox.SelectionLength = nombre_textbox.Text.Length;
            }
            else
            {
                Proveedores prov = new Proveedores();
                prov.Nombre = this.nombre_textbox.Text;
                prov.Domicilio = this.domicilio_textBox.Text;
                prov.Ciudad = this.ciudad_textBox.Text;
                prov.Estado = this.estado_textBox.Text;

                new DAOProveedores().InsertProv(prov); ;

                this.Close();
            }
        }

        private void estado_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}

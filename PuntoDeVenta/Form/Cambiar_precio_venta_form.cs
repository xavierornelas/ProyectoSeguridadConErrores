using DAO;
using DTO;
using PuntoDeVenta.DAO;
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
    public partial class Cambiar_precio_venta_form : Form
    {
        Productos producto;
        public Cambiar_precio_venta_form(Productos producto)
        {
            InitializeComponent();
            Codigo_textbox.Text = producto.Id;
            producto_textBox.Text = producto.Nombre;
            precio_textBox.Text = Convert.ToString(producto.Precio);
            nuevo_precio_textBox.Focus();
            this.producto = producto;

        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            float precio=0;
            if (nuevo_precio_textBox.Text.Equals(null))
            {
                new Mensajes().DebeLlenarTodosLosCampos(); 
                nuevo_precio_textBox.Focus();
                nuevo_precio_textBox.SelectionStart = 0;
                nuevo_precio_textBox.SelectionLength = nuevo_precio_textBox.Text.Length;
            }
            else if (!float.TryParse(nuevo_precio_textBox.Text, out precio))
            {
                MessageBox.Show("Debe ingresar un número en el campo precio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nuevo_precio_textBox.Focus();
                nuevo_precio_textBox.SelectionStart = 0;
                nuevo_precio_textBox.SelectionLength = nuevo_precio_textBox.Text.Length; 
            }
            else 
            {
                if (MessageBox.Show("¿Está seguro de cambiar el precio de venta?", "Precio de venta",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
              == DialogResult.Yes) 
                {
                    producto.Precio = float.Parse(nuevo_precio_textBox.Text);
                    new DAOProductos().UpdateProducto(producto);
                    //Cerrar ventana actual
                    this.Close();
                    
                }
                
            }
           
        }

        private void nuevo_precio_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < nuevo_precio_textBox.Text.Length; i++)
            {
                if (nuevo_precio_textBox.Text[i] == '.')
                    IsDec = true;

                if (IsDec && e.KeyChar == '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;

                if (IsDec && nroDec++ >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }

            }
        }
    }
}

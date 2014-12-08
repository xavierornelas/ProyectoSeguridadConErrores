using DAO;
using DTO;
using punto_venta.DTO;
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
    public partial class modificar_producto_venta_form : Form
    {
        Usuarios UsuarioActual = null;
        public PantallaVenta producto = new PantallaVenta();
        PantallaVenta ProductoAnalizado = null;
        public modificar_producto_venta_form(Usuarios usuario,PantallaVenta ProductoIngresado)
        {
            InitializeComponent();
            UsuarioActual = usuario;
            ProductoAnalizado = ProductoIngresado;
            Codigo_textbox.Text = ProductoAnalizado.Codigo;
            producto_textBox.Text = ProductoAnalizado.Producto;
            cantidad_textBox.Text = ProductoAnalizado.Cantidad;
            total_textBox.Text = ProductoAnalizado.Precio;
            precio_textBox.Text = Convert.ToString(new DAOProductos().GetProducts(Codigo_textbox.Text).Precio);
        }

        private void Modificar_precio_Click(object sender, EventArgs e)
        {
            autorizacion_form form = new autorizacion_form();
            if (UsuarioActual.Privilegios.Equals("Administrador"))
            {
                precio_textBox.Enabled = true;
                precio_textBox.Focus();
                precio_textBox.SelectionStart = 0;
                precio_textBox.SelectionLength = precio_textBox.Text.Length;
            }

            else if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.ValorRetorno)
                {
                    precio_textBox.Enabled = true;
                    precio_textBox.Focus();
                    precio_textBox.SelectionStart = 0;
                    precio_textBox.SelectionLength = precio_textBox.Text.Length;
                }
            }
        }

        private void otorgar_descuento_button_Click(object sender, EventArgs e)
        {
            autorizacion_form form = new autorizacion_form();
            if (UsuarioActual.Privilegios.Equals("Administrador"))
            {
                descuento_textBox.Enabled = true;
                descuento_textBox.Focus();
                descuento_textBox.SelectionStart = 0;
                descuento_textBox.SelectionLength = descuento_textBox.Text.Length;
            }

            else if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.ValorRetorno)
                {
                    descuento_textBox.Enabled = true;
                    descuento_textBox.Focus();
                    descuento_textBox.SelectionStart = 0;
                    descuento_textBox.SelectionLength = descuento_textBox.Text.Length;
                }
            }
        }

        private void modificar_cantidad_button_Click(object sender, EventArgs e)
        {
            cantidad_textBox.Enabled = true;
            cantidad_textBox.Focus();
            cantidad_textBox.SelectionStart = 0;
            cantidad_textBox.SelectionLength = cantidad_textBox.Text.Length;
           
        }

        private void cantidad_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter) 
            {
                total_textBox.Text = Convert.ToString(float.Parse(precio_textBox.Text)*float.Parse(cantidad_textBox.Text));
                cantidad_textBox.Enabled = false;
            }
        }

        private void precio_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < precio_textBox.Text.Length; i++)
            {
                if (precio_textBox.Text[i] == '.')
                    IsDec = true;

                if (IsDec && e.KeyChar == '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;

                if (IsDec && nroDec++ >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }

            }
            if (e.KeyChar == (char)Keys.Enter) 
            {
                total_textBox.Text = Convert.ToString(float.Parse(cantidad_textBox.Text) * float.Parse(precio_textBox.Text));
                
                precio_textBox.Enabled = false;
            }
        }

        private void descuento_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < descuento_textBox.Text.Length; i++)
            {
                if (descuento_textBox.Text[i] == '.')
                    IsDec = true;

                if (IsDec && e.KeyChar == '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;

                if (IsDec && nroDec++ >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }

            }
            if (e.KeyChar == (char)Keys.Enter) 
            {
                float descuento = float.Parse(descuento_textBox.Text) / 100;
                precio_textBox.Text = Convert.ToString(float.Parse(precio_textBox.Text) - (float.Parse(precio_textBox.Text) * descuento));
                total_textBox.Text = Convert.ToString(float.Parse(cantidad_textBox.Text) * float.Parse(precio_textBox.Text));
                descuento_textBox.Enabled = false;
            }



        }

        private void cantidad_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            producto.Codigo = Codigo_textbox.Text;
            producto.Cantidad = cantidad_textBox.Text;
            producto.Producto = producto_textBox.Text;
            producto.Precio = total_textBox.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            producto = ProductoAnalizado;
            this.Close();
        }
    }
}

using DAO;
using DTO;
using LibPrintTicket;
using PuntoDeVenta.DAO;
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
    public partial class NuevoProducto_Form : Form
    {
        List<Credito> creditos = new List<Credito>();
        public NuevoProducto_Form(string codigo)
        {
            InitializeComponent();
            this.codigo_textbox.Text = codigo;
            this.codigo_textbox.Enabled = false;
            this.Descripcion_textbox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cantidad = 0;
            if (!float.TryParse(Precio_venta_textbox.Text, out cantidad))
            {
                MessageBox.Show("Debe de ingresar un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Precio_venta_textbox.Focus();
                Precio_venta_textbox.SelectionStart = 0;
                Precio_venta_textbox.SelectionLength = Precio_venta_textbox.Text.Length;
            }

            else if (this.Descripcion_textbox.Text == "" || this.Precio_venta_textbox.Text == "" || this.Descripcion_textbox.Text.Equals(" "))
            {
                new Mensajes().DebeLlenarTodosLosCampos();
                Descripcion_textbox.Focus();
                Descripcion_textbox.SelectionStart = 0;
                Descripcion_textbox.SelectionLength = codigo_textbox.Text.Length;
            }
            else if (this.Precio_venta_textbox.Text.Equals("0") || this.Precio_venta_textbox.Text.Equals("0.00"))
            {
                MessageBox.Show("El precio de venta no puede ser cero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Descripcion_textbox.Focus();
                Descripcion_textbox.SelectionStart = 0;
                Descripcion_textbox.SelectionLength = codigo_textbox.Text.Length;
            }
            else
            {
                Productos producto = new Productos(
                    this.codigo_textbox.Text,
                    this.Descripcion_textbox.Text,
                    float.Parse(this.Precio_venta_textbox.Text),
                    0
                    );

                new DAOProductos().Insertproductos(producto);
                this.Close();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            float cantidad = 0;
            if (!float.TryParse(Precio_venta_textbox.Text, out cantidad)) 
            {
                MessageBox.Show("Debe de ingresar un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Precio_venta_textbox.Focus();
                Precio_venta_textbox.SelectionStart = 0;
                Precio_venta_textbox.SelectionLength = Precio_venta_textbox.Text.Length;
            }
        }

        private void Precio_venta_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
               && e.KeyChar != '.'
               && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < Precio_venta_textbox.Text.Length; i++)
            {
                if (Precio_venta_textbox.Text[i] == '.')
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

using DAO;
using DTO;
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
    public partial class Buscador_form_nombre : Form
    {
        List<Productos> productos = new List<Productos>();
        public Buscador_form_nombre()
        {
            InitializeComponent();
            productos = new DAOProductos().GetProducts();
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach(Productos obj in productos)
            {
                data.Add(obj.Nombre);
            }
            nombre.AutoCompleteCustomSource = data;
        }

        private void Buscador_form_nombre_Load(object sender, EventArgs e)
        {

        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void nombre_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                bool encontrado = false;
                Codigo.Text = null;
                precio.Text = null;
                cantidad_textbox.Text = null;
                string nombrecito = nombre.Text;
                Productos productoEncontrado = null;
                foreach (Productos obj in productos)
                {
                    if (obj.Nombre.Equals(nombrecito))
                    {
                        productoEncontrado = obj;
                        encontrado = true;
                        break;
                    }
                }
                if (encontrado)
                {
                    Codigo.AppendText(productoEncontrado.Id.ToString());
                    precio.AppendText(Convert.ToString(productoEncontrado.Precio));
                    cantidad_textbox.AppendText(Convert.ToString(productoEncontrado.Cantidad));
                    
                }
                else
                {
                    Codigo.Text = null;
                    precio.Text = null;
                    cantidad_textbox.Text = null;
                    MessageBox.Show("Producto no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Buscar_por_nombre_Click(object sender, EventArgs e)
        {
            string nombrecito = nombre.Text;
            Codigo.Text = null;
            precio.Text = null;
            cantidad_textbox.Text = null;
            bool encontrado = false;
            Productos productoEncontrado = new Productos();
            foreach (Productos obj in productos)
            {
                if (obj.Nombre.Equals(nombrecito))
                {
                    productoEncontrado = obj;
                    encontrado = true;
                    break;
                }
            }
            if (encontrado)
            {
                Codigo.AppendText(productoEncontrado.Id.ToString());
                precio.AppendText(Convert.ToString(productoEncontrado.Precio));
                cantidad_textbox.AppendText(Convert.ToString(productoEncontrado.Cantidad));

                
            }
            else
            {
                Codigo.Text = null;
                precio.Text = null;
                cantidad_textbox.Text = null;
                MessageBox.Show("Producto no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Buscador_form : Form
    {
        List<Productos> productos = new List<Productos>();
        public Buscador_form()
        {
            InitializeComponent();
            productos = new DAOProductos().GetProducts();
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (Productos obj in productos)
            {
                data.Add(obj.Id.ToString());
            }
           
        }

        private void Buscador_form_Load(object sender, EventArgs e)
        {

        }

        private void Codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                bool encontrado = false;
                string codiguito = Codigo.Text;
                descripcion.Text = null;
                precio.Text = null;
                textBox1.Text = null;
                Productos producto = null;
                foreach (Productos tmp in productos)
                {
                    if (tmp.Id.Equals(codiguito))
                    {
                        producto = tmp;
                        encontrado = true;
                        break;
                    }

                }
                if (encontrado)
                {
                    descripcion.Text = producto.Nombre;
                    precio.Text = (Convert.ToString(producto.Precio));
                    textBox1.Text = (Convert.ToString(producto.Cantidad));
                }
                else
                {
                    descripcion.Text = null;
                    precio.Text = null;
                    textBox1.Text = null;
                    MessageBox.Show("Producto no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Buscar_por_codigo_Click(object sender, EventArgs e)
        {
                string codiguito = Codigo.Text;
                bool encontrado = false;
                descripcion.Text = null;
                precio.Text = null;
                textBox1.Text = null;
                Productos producto = new Productos();
                foreach (Productos tmp in productos)
                {
                    if (tmp.Id.Equals(codiguito))
                    {
                        producto = tmp;
                        encontrado = true;
                        break;
                    }

                }
                if (encontrado)
                {
                    descripcion.Text = producto.Nombre;
                    precio.Text = (Convert.ToString(producto.Precio));
                    textBox1.Text = (Convert.ToString(producto.Cantidad));
                }
                else
                {
                    descripcion.Text = null;
                    precio.Text = null;
                    textBox1.Text = null;

                    MessageBox.Show("Producto no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}

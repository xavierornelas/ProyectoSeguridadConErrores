using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using DTO;
using PuntoDeVenta.DAO;

namespace punto_venta
{
    public partial class Inventario_Form : Form
    {
        List<Productos> inv = null;
        Usuarios usuarioActual = new Usuarios();
        public string idProductSelected = null;
        Ventas_Form mensaje = new Ventas_Form();
        Paquetes paquete = new Paquetes();
        public Inventario_Form(Usuarios usuario,Paquetes paquete)
        {
            InitializeComponent();
            actualizaDGV();
            usuarioActual = usuario;
            this.paquete = paquete;
        }
        public Inventario_Form() 
        { 
        }       

        private void Datagridview_RowHeaderMouse(object sender, DataGridViewCellMouseEventArgs e)
        {
            idProductSelected = this.dataGridView_Inventario.Rows[e.RowIndex].Cells[0].Value.ToString();
            Modificar_Inv_Button.Enabled = true;
            Eliminar_Inv_Button.Enabled = true;
        }

        private void Guardar_Inv_Button_Click(object sender, EventArgs e)
        {
            mensaje.MostrarMensaje(this.paquete);
            //Validar si es un numero. 
            int cantidad = 0;
            float precio = 0;
            if(codigo_textbox.Text.Equals(null)||descripcion_textbox.Text.Equals(null)||cantidad_textbox.Text.Equals(null)||precio_textbox.Text.Equals(null))
            {
                new Mensajes().DebeLlenarTodosLosCampos();
                codigo_textbox.Focus();
            }
            else if (!int.TryParse(cantidad_textbox.Text, out cantidad))
            {
                MessageBox.Show("Debe ingresar un número entero en el campo cantidad.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cantidad_textbox.Focus();
                cantidad_textbox.SelectionStart = 0;
                cantidad_textbox.SelectionLength = cantidad_textbox.Text.Length;
            }
            else if (!float.TryParse(precio_textbox.Text, out precio))
            {
                MessageBox.Show("Debe ingresar un número en el campo precio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                precio_textbox.Focus();
                precio_textbox.SelectionStart = 0;
                precio_textbox.SelectionLength = precio_textbox.Text.Length;
            }
            else 
            {
                if (MessageBox.Show("¿Está seguro de modificar a este producto?", "Alerta",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
                {
                    if (int.Parse(cantidad_textbox.Text) < 0 || float.Parse(precio_textbox.Text) < 0)
                    {
                        MessageBox.Show("Éxiste un valor negativo", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Productos prod = new Productos();

                        prod.Id = codigo_textbox.Text;
                        prod.Nombre = descripcion_textbox.Text;
                        prod.Cantidad = int.Parse(cantidad_textbox.Text);
                        prod.Precio = float.Parse(precio_textbox.Text);

                        new DAOProductos().UpdateProducto(prod);
                        inv = new DAOProductos().GetProducts();
                        dataGridView_Inventario.DataSource = inv.ToArray();
                        Eliminar_Inv_Button.Enabled = false;
                        Modificar_Inv_Button.Enabled = false;
                        Guardar_Inv_Button.Enabled = false;
                        //codigo_textbox.Enabled = false;
                        codigo_textbox.Text = null;
                        descripcion_textbox.Text = null;
                        precio_textbox.Text = null;
                        cantidad_textbox.Text = null;
                        

                        actualizaDGV();
                    }


                }
            }
           
            
        }

        private void Modificar_Inv_Button_Click(object sender, EventArgs e)
        {
            if (new DAOOfertas().GetOferta(idProductSelected) == null)
            {
                mensaje.MostrarMensaje(this.paquete);
                Modificar_Inv_Button.Enabled = false;
                Eliminar_Inv_Button.Enabled = false;
                Guardar_Inv_Button.Enabled = true;
                mensaje.MostrarMensaje(this.paquete);

                Productos pro = new DAOProductos().GetProducts(idProductSelected);

                codigo_textbox.Text = Convert.ToString(pro.Id);

                descripcion_textbox.Text = pro.Nombre;
                cantidad_textbox.Text = Convert.ToString(pro.Cantidad);

                precio_textbox.Text = Convert.ToString(pro.Precio);
            }
            else 
            {
                MessageBox.Show("El código que seleccionó es una oferta, no puede modificarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                codigo_textbox.Text = null;
                descripcion_textbox.Text = null;
                precio_textbox.Text = null;
                cantidad_textbox.Text = null;
                codigo_textbox.Focus(); 
            }
            
                
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void actualizaDGV()
        {
            List<Productos> productos = new DAOProductos().GetProducts();
            this.dataGridView_Inventario.DataSource = productos.ToArray();
        }

        private void Eliminar_Inv_Button_Click(object sender, EventArgs e)
        {
            mensaje.MostrarMensaje(this.paquete);

            if (MessageBox.Show("¿Está seguro de eliminar a este producto?", "Alerta",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        == DialogResult.Yes)
            {
                new DAOProductos().DeleteProductos(idProductSelected);
                actualizaDGV();
                //codigo_textbox.Enabled = false;
            }
        }

        private void codigo_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo_textbox.Enabled = true;
        }

        private void codigo_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                mensaje.MostrarMensaje(this.paquete);
                descripcion_textbox.Text = null;
                cantidad_textbox.Text = null;
                precio_textbox.Text = null;
                inv = new DAOProductos().GetProducts();
                foreach (Productos temp in inv)
                {
                    if (temp.Id.Equals(codigo_textbox.Text))
                    {
                        descripcion_textbox.Text = temp.Nombre;
                        cantidad_textbox.Text = Convert.ToString(temp.Cantidad);
                        precio_textbox.Text = Convert.ToString(temp.Precio);
                        break;
                    }
                }
            }
            
            
            Guardar_Inv_Button.Enabled = true;
        }

        public void filtraNombre(string val)
        {
            List<Productos> productos = new DAOProductos().GetProducts();
            var query = from l in productos where l.Nombre.ToLower().StartsWith(val.ToLower()) select l;
            dataGridView_Inventario.DataSource = query.ToList();
        }

        private void descripcion_textbox_TextChanged(object sender, EventArgs e)
        {
            filtraNombre(this.descripcion_textbox.Text);
        }

        public void filtaId(string val)
        {
            List<Productos> productos = new DAOProductos().GetProducts();
            var query = from l in productos where l.Id.ToLower().StartsWith(val.ToLower()) select l;
            dataGridView_Inventario.DataSource = query.ToList();
        }
        private void codigo_textbox_TextChanged(object sender, EventArgs e)
        {
            filtaId(this.codigo_textbox.Text);
        }

        private void Inventario_Form_Activated(object sender, EventArgs e)
        {
            actualizaDGV();
        }

        private void cantidad_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
       && !char.IsDigit(e.KeyChar)
       )
            {
                e.Handled = true;
            }

            if ((char)e.KeyChar == '\'' || (char)e.KeyChar == '\"')
            {
                e.Handled = true;
            }
        }

        private void precio_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < precio_textbox.Text.Length; i++)
            {
                if (precio_textbox.Text[i] == '.')
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

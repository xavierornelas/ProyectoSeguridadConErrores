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
    public partial class devolucion_por_ticket_form : Form
    {
        Usuarios usuarioActual;
        List<Ventas> ventasTotales = new List<Ventas>();
        List<Detalle> ticket = new List<Detalle>();
        Detalle productoDetalle = new Detalle();
        public devolucion_por_ticket_form(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            clave_venta_textbox.Focus();
        }
        public devolucion_por_ticket_form(string codigo, Usuarios usuario) 
        {
            InitializeComponent();
            clave_venta_textbox.Text = codigo;
            usuarioActual = usuario;
            BusquedaDelTicket();

        }
        public void BusquedaDelTicket()
        {
            ticket = new DAODetalle().GetDetails(clave_venta_textbox.Text);
            ActualizarDataGrid(ticket); 
            //dataGridView1.DataSource = ticket.ToArray();
            Codigo_textbox.Enabled = true;
            Codigo_textbox.Focus();
            clave_venta_textbox.Enabled = false;
        }
        private void devolucion_por_ticket_form_Load(object sender, EventArgs e)
        {
           ventasTotales=new DAOVentas().GetVentas();
           AutoCompleteStringCollection data = new AutoCompleteStringCollection();
           foreach (Ventas obj in ventasTotales)
           {
               data.Add(obj.Id);
           }
           clave_venta_textbox.AutoCompleteCustomSource = data;
        }

        private void clave_venta_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Ventas venta = new Ventas();
                if (new DAOVentas().GetVentasXId(clave_venta_textbox.Text) != null)
                {
                    ticket = new DAODetalle().GetDetails(clave_venta_textbox.Text);
                    ActualizarDataGrid(ticket);
                    //dataGridView1.DataSource = ticket.ToArray();
                    Codigo_textbox.Enabled = true;
                    Codigo_textbox.Focus();
                    clave_venta_textbox.Enabled = false;
                }
                else 
                {
                    MessageBox.Show("Clave de venta incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clave_venta_textbox.Focus();
                    clave_venta_textbox.SelectionStart = 0;
                    clave_venta_textbox.SelectionLength = clave_venta_textbox.Text.Length;
                }
               
                
            }
        }

        private void Codigo_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                //Buscare el producto dentro de la lista de detalle
                bool productoEncontrado = false;
                foreach(Detalle temp in ticket)
                {
                    if(temp.id_producto.Equals(Codigo_textbox.Text))
                    {
                        productoEncontrado = true;
                        break;
                    }
                }
                if (productoEncontrado)
                {
                    Codigo_textbox.Enabled = false;
                    cantidad_textbox.Enabled = true;
                    cantidad_textbox.Focus();
                }
                else 
                {
                    MessageBox.Show("Producto no encontrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Codigo_textbox.Focus();
                    Codigo_textbox.SelectionStart = 0;
                    Codigo_textbox.SelectionLength = Codigo_textbox.Text.Length;
                }
            }
        }

        private void cantidad_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if(e.KeyChar==(char)Keys.Enter)
            {
                int cantidad = 0;
                if (!int.TryParse(cantidad_textbox.Text, out cantidad))
                {
                    MessageBox.Show("Debe ingresar un número entero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ObtenerCantidadProducto(Codigo_textbox.Text) == 0)
                    {
                        MessageBox.Show("Error en la busqueda de la cantidad del producto seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ObtenerCantidadProducto(Codigo_textbox.Text) < int.Parse(cantidad_textbox.Text))
                    {
                        MessageBox.Show("La cantidad ingresada es mayor a la vendida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ObtenerCantidadProducto(Codigo_textbox.Text) >= int.Parse(cantidad_textbox.Text))
                    {
                        //Se hace la devolucion del producto
                       
                        //Obtener el precio del producto e ingresarlo, al igual ingresarlo en la base de datos
                        
                        Detalle detalle = new Detalle();
                        detalle.id_producto = Codigo_textbox.Text;
                        detalle.id_venta = new Validaciones().LimpiarString(clave_venta_textbox.Text);
                        detalle.cantidad = ObtenerCantidadProducto(Codigo_textbox.Text)-int.Parse(cantidad_textbox.Text);
                        detalle.precio = productoDetalle.precio;
                        detalle.total = productoDetalle.precio * detalle.cantidad; 
                        new DAODetalle().ModificarDetalle(detalle);
                        List<Detalle> detalles = new List<Detalle>();
                        detalles = new DAODetalle().GetDetails(new Validaciones().LimpiarString(clave_venta_textbox.Text));
                        Ventas devolucion = new Ventas();

                        devolucion.Total = ObtenerTotalVenta(detalles);
                        new DAOVentas().ModificarVenta(devolucion);
                        new DAOProductos().Aumentarproductos(Codigo_textbox.Text, int.Parse(cantidad_textbox.Text));
                        MessageBox.Show("Devolución realizada con éxito.", "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BorrarTodo();

                    }
                }
            }
        }
        public float ObtenerTotalVenta(List<Detalle>productosVendidos) 
        {
            float suma = 0;
            foreach(Detalle det in productosVendidos)
            {
                suma = suma + det.total;
            }
            return suma;
        }
        public int ObtenerCantidadProducto(string codigo_producto) 
        {
            int cantidad = 0;
            foreach(Detalle temp in ticket)
            {
                if(temp.id_producto.Equals(codigo_producto))
                {
                    cantidad = temp.cantidad;
                    productoDetalle = temp;
                    break;
                }
            }
            return cantidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cantidad_textbox.Enabled = false;
            Codigo_textbox.Enabled = false;
            clave_venta_textbox.Enabled = true;
            dataGridView1.DataSource = null;
            clave_venta_textbox.Focus();
            clave_venta_textbox.Text = null;
            cantidad_textbox.Text = null;
            Codigo_textbox.Text = null;
        }

        private void finalizar_button_Click(object sender, EventArgs e)
        {
            devolucion_por_ticket_form devticket = new devolucion_por_ticket_form(usuarioActual);
            devticket.Hide();
        }

        private void devolver_button_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            if (!int.TryParse(cantidad_textbox.Text, out cantidad))
            {
                MessageBox.Show("Debes ingresar un número entero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ObtenerCantidadProducto(Codigo_textbox.Text) == 0)
                {
                    MessageBox.Show("Error en la busqueda de la cantidad del producto seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ObtenerCantidadProducto(Codigo_textbox.Text) < int.Parse(cantidad_textbox.Text))
                {
                    MessageBox.Show("La cantidad ingresada es mayor a la vendida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ObtenerCantidadProducto(Codigo_textbox.Text) >= int.Parse(cantidad_textbox.Text))
                {
                    //Se hace la devolucion del producto
                    Detalle detalle = new Detalle();
                    detalle.id_producto = Codigo_textbox.Text;
                    detalle.id_venta = new Validaciones().LimpiarString(clave_venta_textbox.Text);
                    detalle.cantidad = ObtenerCantidadProducto(Codigo_textbox.Text) - int.Parse(cantidad_textbox.Text);
                    detalle.precio = productoDetalle.precio;
                    detalle.total = productoDetalle.precio * detalle.cantidad;
                    new DAODetalle().ModificarDetalle(detalle);
                    List<Detalle> detalles = new List<Detalle>();
                    detalles = new DAODetalle().GetDetails(new Validaciones().LimpiarString(clave_venta_textbox.Text));
                    Ventas devolucion = new Ventas();

                    devolucion.Total = ObtenerTotalVenta(detalles);
                    new DAOVentas().ModificarVenta(devolucion);
                    
                    new DAOProductos().Aumentarproductos(Codigo_textbox.Text, int.Parse(cantidad_textbox.Text));
                    MessageBox.Show("Devolución realizada con éxito.", "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarTodo();

                }
            }
        }
        public void BorrarTodo() 
        {
            dataGridView1.DataSource = null;
            clearTable();
            Codigo_textbox.Text = null;
            cantidad_textbox.Text = null;
            clave_venta_textbox.Text = null;
            clave_venta_textbox.Enabled = true;
            Codigo_textbox.Enabled = false;
            cantidad_textbox.Enabled = false;
            ticket = null;
            ventasTotales = null;
        }
        private void cantidad_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               

            }
        }

        private void clave_venta_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clave_venta_textbox_Leave(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            if (new DAOVentas().GetVentasXId(clave_venta_textbox.Text) != null)
            {
                ticket = new DAODetalle().GetDetails(clave_venta_textbox.Text);
                ActualizarDataGrid(ticket);
                //dataGridView1.DataSource = ticket.ToArray();
                Codigo_textbox.Enabled = true;
                Codigo_textbox.Focus();
                clave_venta_textbox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Clave de venta incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clave_venta_textbox.Focus();
                clave_venta_textbox.SelectionStart = 0;
                clave_venta_textbox.SelectionLength = clave_venta_textbox.Text.Length;
            }
               
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            if (new DAOVentas().GetVentasXId(clave_venta_textbox.Text) != null)
            {
                ticket = new DAODetalle().GetDetails(clave_venta_textbox.Text);
                ActualizarDataGrid(ticket); 
                //dataGridView1.DataSource = ticket.ToArray();
                Codigo_textbox.Enabled = true;
                Codigo_textbox.Focus();
                clave_venta_textbox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Clave de venta incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clave_venta_textbox.Focus();
                clave_venta_textbox.SelectionStart = 0;
                clave_venta_textbox.SelectionLength = clave_venta_textbox.Text.Length;
            }
        }
        private void ActualizarDataGrid(List<Detalle> lista) 
        {
            clearTable();

            dataGridView1.DataSource = null;
            foreach (Detalle u in lista)
            {
                dataGridView1.Rows.Add(u.id_producto,new DAOProductos().GetProducts(u.id_producto).Nombre, u.cantidad,u.total);
            }
            //dataGridView_Clientes.DataSource = usuarios.ToArray();
        }
        private void clearTable()
        {
            if(dataGridView1.Rows.Count!=0)
            {
                while (dataGridView1.Rows.Count != 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }
        }
    }
}

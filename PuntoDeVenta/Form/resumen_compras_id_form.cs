using DAO;
using DTO;
using PuntoDeVenta.DAO;
using PuntoDeVenta.DTO;
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
    public partial class resumen_compras_id_form : Form
    {
        List<Detalle_compra> detalle = null;
        List<Compras> compra = null;
        Usuarios usuarioActual=null;
        
        public resumen_compras_id_form(Usuarios usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            dataGridView1.RowHeadersVisible = false;
        }
        public resumen_compras_id_form(string codigo,Usuarios usuarioActual)
        {
            InitializeComponent();
            clave_venta_textbox.Text = codigo;
            initTable(codigo);
            this.usuarioActual = usuarioActual;
            dataGridView1.RowHeadersVisible = false;
        }
        public void initTable(string codigo) 
        {
            dataGridView1.DataSource = null;
            detalle = new DAODetalle_compra().GetDetalle_Compras(codigo);
            foreach(Detalle_compra temp in detalle)
            {
                dataGridView1.Rows.Add(temp.id_producto,new DAOProductos().GetProducts(temp.id_producto).Nombre,new DAOProveedores().GetProvider(temp.id_proveedor).Nombre,temp.cantidad,temp.precio,temp.total);
            }
        }

        private void nueva_dev_button_Click(object sender, EventArgs e)
        {
            detalle = new DAODetalle_compra().GetDetalle_Compras(new Validaciones().LimpiarString(clave_venta_textbox.Text));
            if (detalle.Count == 0)
            {
                MessageBox.Show("Lo sentimos, no se encontró los detalles de la compra ingresada.", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                RemarcarCodigo();
            }
            else 
            {
                initTable(new Validaciones().LimpiarString(clave_venta_textbox.Text));
            }
        }
        public void RemarcarCodigo() 
        {
            clave_venta_textbox.Focus();
            clave_venta_textbox.SelectionStart = 0;
            clave_venta_textbox.SelectionLength = clave_venta_textbox.Text.Length;
        }

        private void resumen_compras_id_form_Load(object sender, EventArgs e)
        {
            compra = new DAOCompras().GetCompras();
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (Compras obj in compra)
            {
                data.Add(obj.id_compra);
            }
            clave_venta_textbox.AutoCompleteCustomSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(new Validaciones().LimpiarString(clave_venta_textbox.Text).Equals(null))
            {
                MessageBox.Show("Debe ingresar una clave de compra", "ERROR",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                RemarcarCodigo();
            }
            else if(detalle.Count==0)
            {
                MessageBox.Show("Debe realizar una busqueda.", "ERROR",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                RemarcarCodigo();
            }
            else
            {
                new DAOImpresion().ImprimirTicketCompra(new DAOCompras().GetCompra(clave_venta_textbox.Text), ConvertirAListaPantalla(detalle));
                RemarcarCodigo();
            }
           
        }
        public List<PantallaCompras> ConvertirAListaPantalla(List<Detalle_compra>lista) 
        {
            List<PantallaCompras>Pantalla= new List<PantallaCompras>();
            foreach(Detalle_compra temp in lista)
            {
                PantallaCompras obj = new PantallaCompras();
                obj.Codigo = temp.id_producto;
                obj.cantidad = temp.cantidad;
                obj.precio = temp.total;
                obj.Producto = new DAOProductos().GetProducts(temp.id_producto).Nombre;
                obj.proveedor = new DAOProveedores().GetProvider(temp.id_proveedor).Nombre;
                Pantalla.Add(obj);
            }
            return Pantalla;
        }
    }
}

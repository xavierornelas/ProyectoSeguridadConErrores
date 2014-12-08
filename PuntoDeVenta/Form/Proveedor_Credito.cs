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
    public partial class Proveedor_Credito_form_ : Form
    {
        List<Proveedores> proveedores = null;
        Usuarios usuarioActual = new Usuarios();
        Proveedores proveedorActual = new Proveedores();
        ProveedoresDeudas proveedorDeudaActual = new ProveedoresDeudas();
             
        public Proveedor_Credito_form_(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            hacer_pago_button.Enabled = false;
            
        }
       
        public Proveedor_Credito_form_() { }

        private void Credito_form_Load(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProveedoresDeudas deuda = new ProveedoresDeudas();
            hacer_pago_button.Enabled = true;
            
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Proveedores cust = row.DataBoundItem as Proveedores;
                if (cust != null)
                {
                    proveedorActual.Id = cust.Id;
                    proveedorActual.Nombre = cust.Nombre;
                }
            }
            proveedorDeudaActual = new DAOProveedores().SeleccionarDeudaProveedor(proveedorActual.Id);
            proveedor_textBox.Text = proveedorDeudaActual.Nombre;
            deuda_textbox.Text = Convert.ToString(proveedorDeudaActual.Deuda);
            if (proveedorDeudaActual.Nombre == null)
            {
                new DAOProveedores().CrearDeudaProveedor(proveedorActual);
                deuda_textbox.Text = "0";
                proveedor_textBox.Text = proveedorActual.Nombre;
                proveedorDeudaActual.Id = proveedorActual.Id;
            }
        }

        private void hacer_pago_button_Click(object sender, EventArgs e)
        {
            proveedorDeudaActual.Id = proveedorActual.Id;
            proveedorDeudaActual.Nombre = proveedor_textBox.Text;
            Hacer_Pago_Proveedor_form pago = new Hacer_Pago_Proveedor_form (proveedorDeudaActual);
            pago.ShowDialog();
            proveedor_textBox.Text = "";
            deuda_textbox.Text = "";
            hacer_pago_button.Enabled = false;
            
        }

        private void detalles_button_Click(object sender, EventArgs e)
        {
            proveedorDeudaActual.Id = proveedorActual.Id;
            proveedorDeudaActual.Nombre = proveedor_textBox.Text;
            Agregar_Deuda_Provedor deuda = new Agregar_Deuda_Provedor(proveedorDeudaActual);
            deuda.ShowDialog();
            proveedor_textBox.Text = "";
            deuda_textbox.Text = "";
            hacer_pago_button.Enabled = false;
            
        }

        private void actualizarDGV()
        {
            proveedores = new DAOProveedores().GetProvider();
            dataGridView1.DataSource = proveedores.ToArray();
        }

        private void Proveedor_Credito_form__Activated(object sender, EventArgs e)
        {
            actualizarDGV();
        }
    }
}

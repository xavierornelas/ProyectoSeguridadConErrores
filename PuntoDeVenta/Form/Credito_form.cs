using DAO;
using DTO;
using LibPrintTicket;
using punto_venta.DTO;
using PuntoDeVenta.DAO;
using PuntoDeVenta.DTO;
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
    public partial class Credito_form : Form
    {
        List<Clientes> clientes = null;
        List<Credito> credito = null;
        List<PantallaCredito> pantalla = null;
        Credito creditoGlobal = new Credito();
        Credito cliente = new Credito();
        Usuarios usuarioActual = new Usuarios();
        public int selectClienID = 0;

             
        public Credito_form(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }
        private void clearTable()
        {

            while (dataGridView1.Rows.Count != 1)
            {
                dataGridView1.Rows.RemoveAt(0);
            }

        }
        public Credito_form() 
        { 
            
        }

        private void Credito_form_Load(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private void hacer_pago_button_Click(object sender, EventArgs e)
        {
             float num =0;
                
            if (aportacion_textbox.Text.Equals("") || recibido_textbox.Text.Equals("") || recibido_textbox.Text.Equals(" ") || aportacion_textbox.Text.Equals(" "))
            {
                MessageBox.Show("Lo sentimos, debe de llenar todos los campos (Aportación y recibido).", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                aportacion_textbox.Enabled = false;
                recibido_textbox.Enabled = false;
                hacer_pago_button.Enabled = false;
                cliente_textbox.Text = null;
                deuda_textbox.Text = null;
                aportacion_textbox.Text = null;
                recibido_textbox.Text = null;
                cambio_textbox.Text = null;
                detalles_button.Enabled = false;
            }
            else if(!float.TryParse(aportacion_textbox.Text, out num) || !float.TryParse(recibido_textbox.Text, out num))
            {
                MessageBox.Show("Lo sentimos, debe ingresar números y no caracteres.", "Alerta",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                aportacion_textbox.Enabled = false;
                recibido_textbox.Enabled = false;
                hacer_pago_button.Enabled = false;
                cliente_textbox.Text = null;
                deuda_textbox.Text = null;
                aportacion_textbox.Text = null;
                recibido_textbox.Text = null;
                cambio_textbox.Text = null;
                detalles_button.Enabled = false;
            }
            else if(deuda_textbox.Text.Equals("0"))
            {
                MessageBox.Show("El cliente no tiene deuda.", "Alerta",
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                aportacion_textbox.Enabled = false;
                recibido_textbox.Enabled = false;
                hacer_pago_button.Enabled = false;
                cliente_textbox.Text = null;
                deuda_textbox.Text = null;
                aportacion_textbox.Text = null;
                recibido_textbox.Text = null;
                cambio_textbox.Text = null;
                detalles_button.Enabled = false;
            }
            else 
            {
                Credito cre = new DAOCredito().GetCredito(selectClienID);

                
                if (float.Parse(aportacion_textbox.Text) > cre.deuda)
                {
                    MessageBox.Show("Lo sentimos, debe de agregar una cantidad menor o igual a la deuda.", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    aportacion_textbox.Enabled = false;
                    recibido_textbox.Enabled = false;
                    hacer_pago_button.Enabled = false;
                    cliente_textbox.Text = null;
                    deuda_textbox.Text = null;
                    aportacion_textbox.Text = null;
                    recibido_textbox.Text = null;
                    cambio_textbox.Text = null;
                    detalles_button.Enabled = false;
                }
                else
                {
                    //Aqui agrego la parte de ventas y detalles
                    cre.deuda = cre.deuda - float.Parse(aportacion_textbox.Text);

                    new DAOCredito().DecrementarDeudaCliente(cre);
                    credito = new DAOCredito().GetCredito();
                    clientes = new DAOClientes().GetCustomer();
                    PantallaCredito recolectorPantalla = new PantallaCredito();
                    //Buscare los nombres de los clientes por medio del ID que tiene el credito
                    Ventas ventaCredito = new Ventas();
                    ventaCredito.Id = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
                    ventaCredito.Tipo = "Pago de crédito";
                    ventaCredito.Fecha = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(DateTime.Now));
                    ventaCredito.Hora = string.Format("{0:HH:mm:ss}", Convert.ToDateTime(DateTime.Now)); 
                    ventaCredito.Total = float.Parse(aportacion_textbox.Text);
                    //Agrego a Detalle
                    Detalle detalle = new Detalle();
                    detalle.id_venta = ventaCredito.Id;
                    detalle.id_producto = "ABONO";
                    detalle.cantidad = 1;
                    detalle.precio = float.Parse(aportacion_textbox.Text);
                    detalle.total = float.Parse(aportacion_textbox.Text);
                    new DAODetalle().InsertDetails(detalle);
                    //Agrego el abono
                    Abonos abono = new Abonos();
                    abono.id_cliente = cre.id_cliente;
                    abono.fecha = string.Format("{0:yyyy-MM-dd HH:mm:ss}", Convert.ToDateTime(DateTime.Now));
                    abono.abono = float.Parse(aportacion_textbox.Text);
                    new DAOAbonos().InsertAbono(abono);
                   // new DAOImpresion().ImprimirTicketCredito(recibido_textbox.Text,cambio_textbox.Text,aportacion_textbox.Text,usuarioActual.Nombre);
                    actualizarDGV();
                    aportacion_textbox.Enabled = false;
                    recibido_textbox.Enabled = false;
                    hacer_pago_button.Enabled = false;
                    cliente_textbox.Text = null;
                    deuda_textbox.Text = null;
                    aportacion_textbox.Text = null;
                    recibido_textbox.Text = null;
                    cambio_textbox.Text = null;
                    detalles_button.Enabled = false;
                }
            }
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].Cells[0].Value!=null)
            {
                selectClienID = (int)this.dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                float deuda = (float)this.dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                hacer_pago_button.Enabled = true;
                Clientes cliente = new DAOClientes().GetCustomer(selectClienID);
                cliente_textbox.Text = cliente.Nombre;
                deuda_textbox.Text = Convert.ToString(deuda);
                if(deuda!=0)
                {
                    aportacion_textbox.Enabled = true;
                    recibido_textbox.Enabled = true;
                }
                detalles_button.Enabled = true;
            }
            
            
        }

        private void recibido_textbox_TabIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void actualizarDGV()
        {
           
            pantalla = new List<PantallaCredito>();
            credito = new DAOCredito().GetCredito();
            clientes = new DAOClientes().GetCustomer();
            PantallaCredito recolectorPantalla = null;

            //Buscare los nombres de los clientes por medio del ID que tiene el credito

            foreach (Credito temp in credito)
            {
                foreach (Clientes cli in clientes)
                {
                    if (temp.id_cliente == cli.Id && cli != null)
                    {
                        recolectorPantalla = new PantallaCredito(temp.id_cliente, cli.Nombre, temp.deuda);
                        break;
                    }
                }
                if (recolectorPantalla != null)
                {
                    pantalla.Add(recolectorPantalla);
                }

            }

            dataGridView1.DataSource = pantalla.ToArray();
        }
       
        private void aportacion_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if(e.KeyChar==(char)Keys.Enter)
            {
                float num =0;
                if (!float.TryParse(aportacion_textbox.Text, out num))
                {
                    MessageBox.Show("Debe agregar un número", "Alerta",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                {
                    recibido_textbox.Focus();
                }
               
            }
        }

        private void recibido_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            float num = 0;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (recibido_textbox.Text.Equals(null))
                {
                    MessageBox.Show("Lo sentimos, debe de agregar lo que recibió", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!float.TryParse(recibido_textbox.Text, out num))
                {
                    MessageBox.Show("Debe agregar un número", "Alerta",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    float cambio = float.Parse(recibido_textbox.Text) - float.Parse(aportacion_textbox.Text);
                    cambio_textbox.Text = Convert.ToString(cambio);
                }
            }
        }

        private void detalles_button_Click(object sender, EventArgs e)
        {
            if (selectClienID != 0)
            {
                Detalle_credito_cliente frmDetalle = new Detalle_credito_cliente(selectClienID);
                frmDetalle.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Seleccione un cliente.", "Alerta",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            detalles_button.Enabled = false;
        }

        private void Credito_form_Activated(object sender, EventArgs e)
        {
            actualizarDGV();
        }
    }
}

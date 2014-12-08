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
    public partial class Agregar_Deuda_Cliente : Form
    {
        List<Clientes> clientes = null;
        string id_venta;
        Usuarios usuarioActual = new Usuarios();
        public Agregar_Deuda_Cliente(float cantidad, Usuarios usuario,string id_venta)
        {
            InitializeComponent();
            deuda_textbox.Text = Convert.ToString(cantidad);
            usuarioActual = usuario;
            this.id_venta = id_venta;
        }
        public Agregar_Deuda_Cliente(Usuarios usuario) { InitializeComponent(); }

        private void Agregar_Deuda_Cliente_Load(object sender, EventArgs e)
        {
            clientes = new DAOClientes().GetCustomer();
            foreach(Clientes temp in clientes)
            {
                cliente_combobox.Items.Add(temp.Id+" "+temp.Nombre);
            }
        }

        private void cliente_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            if (cliente_combobox.Text.Equals(""))
            {
                MessageBox.Show("Debes escoger un cliente", "Crédito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                string idCliente = null;
                string palabra = cliente_combobox.Text;
                for (int i = 0; i < palabra.Length;i++ )
                {
                    int id=0;
                    if (int.TryParse(palabra[i].ToString(),out id))
                    {
                        idCliente = idCliente + cliente_combobox.Text[i];
                    }
                    else
                        break;
                }
                Credito credito = new Credito();
                credito = new DAOCredito().GetCredito(int.Parse(idCliente));
                credito.deuda = credito.deuda + float.Parse(deuda_textbox.Text);
                new DAOCredito().IncrementarDeudaCliente(credito);
                Agregar_Deuda_Cliente formAgregarDeuda = new Agregar_Deuda_Cliente(usuarioActual);
                Detalles_credito_cliente detallito = new Detalles_credito_cliente();
                detallito.id_venta = this.id_venta;
                detallito.id_cliente = int.Parse(idCliente);
                new DAODetalles_credito_cliente().InsertDetalleCredito(detallito);
                this.Dispose();
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using DAO;
using DTO;
using PuntoDeVenta.DAO;


namespace punto_venta
{
    public partial class Clientes_Form : Form
    {
        List<Clientes> cli = null;
        Usuarios usuarioActual = new Usuarios();
        Clientes clienteGlobal = new Clientes();
        public int idClientSelected = 0;

        public Clientes_Form(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            Nombre_Clientes_TextBox.Focus();
        }
        public Clientes_Form() { }

        private void Agregar_Clientes_Button_Click(object sender, EventArgs e)
        {
            string nombre = Nombre_Clientes_TextBox.Text, dom = Dom_Clientes_TextBox.Text, cd = Cd_Clientes_textBox.Text,
                edo = Edo_Clientes_textBox.Text, rfc = Rfc_Clientes_textBox.Text;
            if ((nombre == "") || (dom == "") || (cd == "") || (edo == "") || (rfc == ""))
            {
                new Mensajes().DebeLlenarTodosLosCampos();
                Nombre_Clientes_TextBox.Focus();
                Nombre_Clientes_TextBox.SelectionStart = 0;
                Nombre_Clientes_TextBox.SelectionLength = Nombre_Clientes_TextBox.Text.Length;
            }
            else
            {
                Clientes temp = new Clientes();

                temp.Nombre = Nombre_Clientes_TextBox.Text;
                temp.Domicilio = Dom_Clientes_TextBox.Text;
                temp.Ciudad = Cd_Clientes_textBox.Text;
                temp.Estado = Edo_Clientes_textBox.Text;
                temp.Rfc = Rfc_Clientes_textBox.Text;                
                new DAOClientes().InsertCustomer(temp);

                cli = new DAOClientes().GetCustomer();

                Credito credito = new Credito();
                credito.id_cliente = cli[cli.Count - 1].Id;
                credito.deuda = 0;
                new DAOCredito().InsertCredito(credito);

                actualizaDGV();
                Nombre_Clientes_TextBox.Text = null;
                Dom_Clientes_TextBox.Text = null;
                Cd_Clientes_textBox.Text = null;
                Edo_Clientes_textBox.Text = null;
                Rfc_Clientes_textBox.Text = null;
                
            }
            
            
        }

        private void ActualizarClientes_button_Click(object sender, EventArgs e)
        {
            actualizaDGV();
        }

        private void Clientes_Form_Load(object sender, EventArgs e)
        {
            actualizaDGV();
        }

        private void Datagriedview_RowHeaderMouseClickç(object sender, DataGridViewCellMouseEventArgs e)
        {
            idClientSelected = (int)this.dataGridView_Clientes.Rows[e.RowIndex].Cells[0].Value;
            Modificar_Clientes_Button.Enabled = true;
            eliminar_button.Enabled = true;
            Agregar_Clientes_Button.Enabled = false;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar a este cliente?", "Alerta",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                Clientes clie = new DAOClientes().GetCustomer(idClientSelected);
                
                        Credito credito = new DAOCredito().GetCredito(idClientSelected);
                        bool bandera = true;
                        if (credito != null)
                        {
                            if (credito.deuda > 0)
                            {
                                if (MessageBox.Show("Este cliente aun tiene deuda, ¿Desea eliminarlo?", "Alerta",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                 == DialogResult.Yes)
                                {
                                    bandera = true;
                                    new DAOCredito().DeleteCredito(clie.Id);
                                }
                                else
                                {
                                    bandera = false;
                                }
                            }
                            
                        }
                        if (bandera)
                        {
                            new DAOClientes().DeleteCustomer(clie.Id);
                            new DAOCredito().DeleteCredito(clie.Id);

                        }
            }
            actualizaDGV();
            
            Agregar_Clientes_Button.Enabled = true;
            eliminar_button.Enabled = false;
            Modificar_Clientes_Button.Enabled = false;          

        }

        private void Modificar_Clientes_Button_Click(object sender, EventArgs e)
        {
            Clientes clie = new DAOClientes().GetCustomer(idClientSelected);

            Rfc_Clientes_textBox.Text = clie.Rfc;
            Nombre_Clientes_TextBox.Text = clie.Nombre;
            Dom_Clientes_TextBox.Text = clie.Domicilio;
            Cd_Clientes_textBox.Text = clie.Ciudad;
            Edo_Clientes_textBox.Text = clie.Estado;

            actualizaDGV();
            Guardar_button.Enabled = true;
            Modificar_Clientes_Button.Enabled = false;
            Agregar_Clientes_Button.Enabled = false;
            eliminar_button.Enabled = false;
           
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea modificar a este cliente?", "Alerta",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes) 
            {
                Clientes clie = new Clientes();

                clie.Id = idClientSelected;
                clie.Nombre = Nombre_Clientes_TextBox.Text;
                clie.Rfc = Rfc_Clientes_textBox.Text;
                clie.Domicilio = Dom_Clientes_TextBox.Text;
                clie.Ciudad = Cd_Clientes_textBox.Text;
                clie.Estado = Edo_Clientes_textBox.Text;

                new DAOClientes().ModifyCustomer(clie);

                actualizaDGV();
                Agregar_Clientes_Button.Enabled = true;
                eliminar_button.Enabled = false;
                Modificar_Clientes_Button.Enabled = false; 
                Guardar_button.Enabled = false;
                Nombre_Clientes_TextBox.Text = null;
                Dom_Clientes_TextBox.Text = null;
                Cd_Clientes_textBox.Text = null;
                Edo_Clientes_textBox.Text = null;
                Rfc_Clientes_textBox.Text = null;
            
            }
        }

        public void actualizaDGV()
        {
            List<Clientes> clientes = new DAOClientes().GetCustomer();
            this.dataGridView_Clientes.DataSource = clientes.ToArray();
        }

        private void Clientes_Form_Activated(object sender, EventArgs e)
        {
            actualizaDGV();
        }

       
    }
}

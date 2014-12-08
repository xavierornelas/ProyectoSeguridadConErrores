using DAO;
using DTO;
using LibPrintTicket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Configuracion : Form
    {
        
        Tickets ticket = new Tickets();
        public Configuracion()
        {
            InitializeComponent();
            //ticket=new DAOTicket().GetTicket();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                comboInstalledPrinters.Items.Add(pkInstalledPrinters);
            }

            ticket = new DAOTicket().GetTicket();
            if (ticket.id == 1)
            {
                nombre_empresa_textbox.Text = ticket.nombreDeLaEmpresa;
                fuente_textbox.Text = Convert.ToString(ticket.tamanoFuenta);
                direccion_empresa_textbox.Text = ticket.direccionDeLaEmpresa;
                municipio_texbox.Text = ticket.municipio;
                estado_textbox.Text = ticket.estado;
                comboInstalledPrinters.Text = ticket.impresora;
                mensaje_textBox.Text = ticket.mensaje;
                // fuente_textbox.Text = Convert.ToString(ticket.tamanoFuenta);              
                Agregar_button.Enabled = false;
                Modificar.Enabled = true;
                Agregar_button.Enabled = false;
                Modificar.Enabled = true;
                comboInstalledPrinters.Enabled = false;
                nombre_empresa_textbox.Enabled = false;
                direccion_empresa_textbox.Enabled = false;
                municipio_texbox.Enabled = false;
                estado_textbox.Enabled = false;
                mensaje_textBox.Enabled = false;
                fuente_textbox.Enabled = false;
            }
           
           
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string impresora = comboInstalledPrinters.Text, nombre = nombre_empresa_textbox.Text, dom = direccion_empresa_textbox.Text, municipio = municipio_texbox.Text,
                    edo = estado_textbox.Text;
           
                
               
           
                if ((nombre == "") || (dom == "") || (municipio == "") || (edo == "") || (impresora == "") || (fuente_textbox.Text.Equals("")))
                {
                    MessageBox.Show("Te falta ingresar un campo", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Tickets temp = new Tickets();
                    temp.id = 1;
                    temp.impresora = impresora;
                    temp.tamanoFuenta = int.Parse(fuente_textbox.Text);
                    temp.nombreDeLaEmpresa = nombre;
                    temp.direccionDeLaEmpresa = dom;
                    temp.municipio = municipio;
                    temp.estado = edo;
                    temp.mensaje = mensaje_textBox.Text;
                    new DAOTicket().ModifyTicket(temp);
                    
                    Modificar.Enabled = true;
                    guardar_button.Enabled = false;
                    imprimir_button.Enabled = true;

                    Agregar_button.Enabled = false;
                    Modificar.Enabled = true;
                    comboInstalledPrinters.Enabled = false;
                    nombre_empresa_textbox.Enabled = false;
                    direccion_empresa_textbox.Enabled = false;
                    municipio_texbox.Enabled = false;
                    estado_textbox.Enabled = false;
                    mensaje_textBox.Enabled = false;
                    fuente_textbox.Enabled = false;
                }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tickets tickets = new DAOTicket().GetTicket();
            if(tickets!=null)
            {
                if (Printing(tickets.impresora))
                {
                    Ticket ticket = new Ticket();                
                    ticket.FontSize = int.Parse(fuente_textbox.Text);
                    ticket.AddHeaderLine(nombre_empresa_textbox.Text);
                    ticket.AddHeaderLine("EXPEDIDO EN:");
                    ticket.AddHeaderLine(direccion_empresa_textbox.Text);
                    ticket.AddHeaderLine(municipio_texbox.Text + ", " + estado_textbox.Text);
                    ticket.AddSubHeaderLine("PRUEBA");
                    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());                
                    ticket.AddItem("10", "Cervezas", "$100");
                    ticket.AddItem("20", "Tequilas", "$1000");
                    ticket.AddItem("1", "Papas fritas", "$10");
                    ticket.AddTotal("Total", "1110");
                    ticket.AddTotal("", "");
                    ticket.AddTotal("RECIBIDO", "1200");
                    ticket.AddTotal("CAMBIO", "90");
                    ticket.AddTotal("", "");
                    ticket.AddFooterLine(mensaje_textBox.Text);
                    ticket.PrintTicket(comboInstalledPrinters.Text); //Nombre de la impresora de tickets
                }
                else 
                {
                    MessageBox.Show("Impresora invalida.");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar los campos.");
            }
            
            
        }
        public bool Printing(string printer)
        {
            bool resultado = false;            
                
                    
                    PrintDocument pd = new PrintDocument();
                   
                    // Specify the printer to use.
                    pd.PrinterSettings.PrinterName = printer;

                    if (pd.PrinterSettings.IsValid)
                    {

                        resultado= true;
                    }
                    else
                    {
                        resultado= false;
                    }
                
                    return resultado;      
            
         
        }
        private void Agregar_button_Click(object sender, EventArgs e)
        {
            string impresora = comboInstalledPrinters.Text, nombre = nombre_empresa_textbox.Text, dom = direccion_empresa_textbox.Text, municipio = municipio_texbox.Text,
                    edo = estado_textbox.Text;
            if ((nombre == "") || (dom == "") || (municipio == "") || (edo == "") || (impresora == "") || (fuente_textbox.Text.Equals("")))
            {
                MessageBox.Show("Te falta ingresar un campo", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tickets temp = new Tickets();
                temp.id = 1;
                temp.impresora = impresora;
                temp.tamanoFuenta = int.Parse(fuente_textbox.Text);
                temp.nombreDeLaEmpresa = nombre;
                temp.direccionDeLaEmpresa = dom;
                temp.municipio = municipio;
                temp.estado = edo;
                temp.mensaje = mensaje_textBox.Text;
                new DAOTicket().InsertTicket(temp);
               
                Agregar_button.Enabled = false;
                Modificar.Enabled = true;
                comboInstalledPrinters.Enabled = false;
                nombre_empresa_textbox.Enabled = false;
                direccion_empresa_textbox.Enabled = false;
                municipio_texbox.Enabled = false;
                estado_textbox.Enabled = false;
                mensaje_textBox.Enabled = false;
                fuente_textbox.Enabled = false;

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Modificar.Enabled = true;
            imprimir_button.Enabled = false;
            Agregar_button.Enabled = false;
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            guardar_button.Enabled = true;
            imprimir_button.Enabled = true;
            comboInstalledPrinters.Enabled = true;
            nombre_empresa_textbox.Enabled = true;
            direccion_empresa_textbox.Enabled = true;
            municipio_texbox.Enabled = true;
            estado_textbox.Enabled = true;
            mensaje_textBox.Enabled = true;
            fuente_textbox.Enabled = true;

        }

        private void fuente_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}

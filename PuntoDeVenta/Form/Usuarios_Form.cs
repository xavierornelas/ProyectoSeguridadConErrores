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
using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PuntoDeVenta.DAO;
using PuntoDeVenta.DTO;

namespace punto_venta
{
    public partial class Usuarios_Form : Form
    {
        List<Usuarios> usuarios = new List<Usuarios>();
        Usuarios UsuarioGlobal = new Usuarios();
        Usuarios usuarioActual = new Usuarios();
        int idUserSelected = 0;
        public Usuarios_Form(Usuarios usuario)
        {
            InitializeComponent();
            actualizarDGV();
            usuarioActual = usuario;
            nombre_textbox.Focus();
        }
        public Usuarios_Form() { }

        private void Usuarios_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_Clientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idUserSelected = (int)this.dataGridView_Clientes.Rows[e.RowIndex].Cells[0].Value;
            Agregar_usuarios_Button.Enabled = false;
            eliminar.Enabled = true;
            modificar_button1.Enabled = true;
            codigo_escaner_button.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Está seguro de eliminar a este usuario?", "Alerta",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                if (usuarioActual.Id == idUserSelected)
                {
                    MessageBox.Show("No puede eliminar su propio usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (usuarioActual.Privilegios.Equals("Empleado"))
                {
                    MessageBox.Show("No tiene permisos para borrar usuarios, contacte a su administrador.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    new DAOUsuarios().DeleteUsuario(idUserSelected);
                    actualizarDGV();
                    eliminar.Enabled = false;
                    modificar_button1.Enabled = true;
                    nombre_textbox.Text = null;
                    contrasena_textbox.Text = null;
                }
                    
                    
            }
                eliminar.Enabled = false;
                modificar_button1.Enabled = false;
                Agregar_usuarios_Button.Enabled = true;
                nombre_textbox.Focus();
            
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
         
           
        }

        private void Agregar_Clientes_Button_Click(object sender, EventArgs e)
        {
            string nombre = nombre_textbox.Text,contrasenia=contrasena_textbox.Text, privilegio= privilegios_combo.Text;
            
                          
                            Usuarios temp = new Usuarios();
                            temp.Id = darID(usuarios);
                            temp.Nombre = nombre;
                            temp.Contrasenia = contrasenia;
                            temp.Privilegios = privilegio;

                            new DAOUsuarios().InsertUser(temp);                          

                            new DAOClave_scaner().AsignarClave(new DAOUsuarios().GetUser(temp.Nombre));
                            actualizarDGV();
                            nombre_textbox.Text = null;
                            contrasena_textbox.Text = null;
                            rep_contrasena_textbox.Text = null;
                        
                    
                            
            
        }
        private int darID(List<Usuarios> lista)
        {
            int id = lista.Capacity;
            bool numeroDetectado = false, fuera = false;
            while (!fuera)
            {
                foreach (Usuarios temp in lista)
                {
                    if (temp.Id == id)
                    {
                        numeroDetectado = true;
                        break;
                    }
                }
                if (numeroDetectado)
                {
                    id++;
                    numeroDetectado = false;
                }
                else
                {
                    fuera = true;
                }
            }

            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios user = new DAOUsuarios().GetUser(idUserSelected);
            nombre_textbox.Text = user.Nombre;
            contrasena_textbox.Text = user.Contrasenia;
            privilegios_combo.Text = user.Privilegios;
                
            modificar_button1.Enabled = false;
            guardar_button.Enabled = true;
            eliminar.Enabled = false;
            Agregar_usuarios_Button.Enabled = false;

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea modificar a este usuario?", "Alerta",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes) 
            {
                Usuarios user = new DAOUsuarios().GetUser(idUserSelected);

                user.Nombre = nombre_textbox.Text;
                user.Privilegios = privilegios_combo.Text;
                user.Contrasenia = contrasena_textbox.Text;

                new DAOUsuarios().ModifyUser(user);
                actualizarDGV();
                guardar_button.Enabled = false;
                Agregar_usuarios_Button.Enabled = true;
                modificar_button1.Enabled = false;
                eliminar.Enabled = false;
                nombre_textbox.Text = null;
                contrasena_textbox.Text = null;
            }
        }

        private void pdf_button_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER,20,20,42,35);
            PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("c:\\Codigos generados\\test.pdf", FileMode.Create));
            
            doc.Open();
            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("logo.png");
            PNG.ScalePercent(25f);
            doc.Add(PNG);
            Paragraph paragraph = new Paragraph(10,"Lista de usuarios registrados en el sistema");
            doc.Add(paragraph);

            PdfPTable table = new PdfPTable(dataGridView_Clientes.Columns.Count);
            for (int j = 0; j < dataGridView_Clientes.Columns.Count;j++)
            {
                table.AddCell(new Phrase(dataGridView_Clientes.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;
            for (int i = 0; i < dataGridView_Clientes.Rows.Count;i++ )
            {
                for (int k = 0; k < dataGridView_Clientes.Columns.Count;k++ )
                {
                    if(dataGridView_Clientes[k,i].Value!=null)
                    {
                        table.AddCell(new Phrase(dataGridView_Clientes[k,i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            doc.Close();
            System.Diagnostics.Process.Start("c:\\Codigos generados\\test.pdf");

        }

        private void dataGridView_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void privilegios_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void actualizarDGV()
        {
            usuarios = new DAOUsuarios().GetUsers();
           /* foreach (Usuarios u in usuarios)
            {
                u.Contrasenia = new Crypting().EncryptKey(u.Contrasenia);
            }*/
            dataGridView_Clientes.DataSource = usuarios.ToArray();
        }

        private void codigo_escaner_button_Click(object sender, EventArgs e)
        {
            if(idUserSelected!=1 && idUserSelected!=2)
            {
                Mostrar_codigo_form ventana = new Mostrar_codigo_form(new DAOUsuarios().GetUser(idUserSelected));
                ventana.ShowDialog();
                codigo_escaner_button.Enabled = false;
                eliminar.Enabled = false;
                Agregar_usuarios_Button.Enabled = true;
                modificar_button1.Enabled = false;
                guardar_button.Enabled = false;
            }
            
        }

        private void nombre_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

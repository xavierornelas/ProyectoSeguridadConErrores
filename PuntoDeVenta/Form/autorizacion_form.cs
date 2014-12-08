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
    public partial class autorizacion_form : Form
    {
        public autorizacion_form()
        {
            InitializeComponent();
            clave_scanner_textBox.Focus();

        }
        public bool ValorRetorno { get; set; }
        

        private void autorizacion_form_Load(object sender, EventArgs e)
        {
            tabControl1.Select();
            clave_scanner_textBox.Focus();
            ValorRetorno = false;
        }
        public void RemarcarClaveScanner() 
        {
            clave_scanner_textBox.Focus();
            clave_scanner_textBox.SelectionStart = 0;
            clave_scanner_textBox.SelectionLength = clave_scanner_textBox.Text.Length;
        }
        private void clave_scanner_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if(e.KeyChar==(char)Keys.Enter)
            {
                dto_clave_scaner clave = null;
                clave = new DAOClave_scaner().Getclave_scaner(clave_scanner_textBox.Text);
                if (clave == null)
                {
                    //Muestro mensaje de que no existe clave para algun usuario
                    MessageBox.Show("No existe clave para algún usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RemarcarClaveScanner();
                }
                else 
                {
                    Usuarios usuario = null;
                    usuario=new DAOUsuarios().GetUser(clave.id_usuario);
                    if (usuario.Privilegios == "Empleado")
                    {
                        MessageBox.Show("No tiene privilegios para realizar la acción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RemarcarClaveScanner();
                    }
                    else 
                    {
                        DialogResult = DialogResult.OK;
                        ValorRetorno = true;
                        this.Close();
                    }
                }
            }
        }

        private void clave_scanner_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            RemarcarClaveScanner();
        }

        private void autorizacion_form_FormClosing(object sender, FormClosingEventArgs e)
        {
                 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(user_textBox.Text.Equals("")||user_textBox.Text.Equals(" "))
            {
                MessageBox.Show("Ingrese un usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RemarcarUsuario();
            }
            else if (Contra.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una contraseña.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RemarcarUsuario();
            }
            else 
            {
                Usuarios usuario = new DAOUsuarios().GetUser(user_textBox.Text,Contra.Text);
                if (usuario != null)
                {
                    if (usuario.Privilegios == "Administrador")
                    {
                        DialogResult = DialogResult.OK;

                        ValorRetorno = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No tiene privilegios para realizar la acción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RemarcarUsuario();
                    }
                }
                else 
                {
                    MessageBox.Show("Usuario o contraseña incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RemarcarUsuario();

                }
            }
        }
        public void RemarcarUsuario() 
        {
            user_textBox.Focus();
            user_textBox.SelectionStart = 0;
            user_textBox.SelectionLength = user_textBox.Text.Length;
        }

        private void Contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                if (user_textBox.Text.Equals("") || user_textBox.Text.Equals(" "))
                {
                    MessageBox.Show("Ingrese un usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RemarcarUsuario();
                }
                else if (Contra.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese una contraseña.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RemarcarUsuario();
                }
                else
                {
                    Usuarios usuario = new DAOUsuarios().GetUser(user_textBox.Text, Contra.Text);
                    if (usuario != null)
                    {
                        if (usuario.Privilegios == "Administrador")
                        {
                            ValorRetorno = true;
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No tiene privilegios para realizar la acción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            RemarcarUsuario();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RemarcarUsuario();

                    }
                }
            }
        }

        private void autorizacion_form_Activated(object sender, EventArgs e)
        {
            clave_scanner_textBox.Focus();
        }

        private void tabPage2_MouseClick(object sender, MouseEventArgs e)
        {
            user_textBox.Focus();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                clave_scanner_textBox.Focus();
            }
            else
            {
                user_textBox.Focus();
            }
        }

        private void user_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }

}

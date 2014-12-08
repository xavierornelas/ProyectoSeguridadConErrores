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
using System.Windows.Forms;

namespace punto_venta
{
    public partial class login : Form
    {
        Usuarios user = new Usuarios();
       // List<Usuarios> usuario = null;
       
        public login()
        {
            InitializeComponent();
            clave_scanner_textBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = user_textBox.Text, pass = Contra.Text;
            bool bandera = false;
            Usuarios datosUsuario = new DAOUsuarios().GetUser(user, pass);
            if (datosUsuario != null)
            {
                bandera = true;
                this.user = datosUsuario;
            }
            /* foreach(Usuarios objeto in usuario)
             {
                 if (user.Equals(objeto.Nombre) && pass.Equals(objeto.Contrasenia)) 
                 {
                     bandera = true;
                     this.user = objeto;
                 }
             }*/

            if (bandera)
            {
                Contenedor ventana = new Contenedor(this.user);
                this.Hide();
                ventana.Show();

            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Contra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string user = user_textBox.Text, pass = Contra.Text;
                bool bandera = false;
                Usuarios datosUsuario = new DAOUsuarios().GetUser(user, pass);
                if (datosUsuario != null)
                {
                    bandera = true;
                    this.user = datosUsuario;
                }
                /* foreach(Usuarios objeto in usuario)
                 {
                     if (user.Equals(objeto.Nombre) && pass.Equals(objeto.Contrasenia)) 
                     {
                         bandera = true;
                         this.user = objeto;
                     }
                 }*/

                if (bandera)
                {
                    Contenedor ventana = new Contenedor(this.user);
                    this.Hide();
                    ventana.Show();

                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void User_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string user = user_textBox.Text, pass = Contra.Text;
                bool bandera = false;
                Usuarios datosUsuario = new DAOUsuarios().GetUser(user, pass);
                if (datosUsuario != null)
                {
                    bandera = true;
                    this.user = datosUsuario;
                }
                /* foreach(Usuarios objeto in usuario)
                 {
                     if (user.Equals(objeto.Nombre) && pass.Equals(objeto.Contrasenia)) 
                     {
                         bandera = true;
                         this.user = objeto;
                     }
                 }*/

                if (bandera)
                {
                    Contenedor ventana = new Contenedor(this.user);
                    this.Hide();
                    ventana.Show();

                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void Contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void clave_scanner_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if(e.KeyChar==(char)Keys.Enter)
            {
                dto_clave_scaner clave = null;
                clave = new DAOClave_scaner().Getclave_scaner(clave_scanner_textBox.Text);
                if (clave!= null)
                {
                    Contenedor ventana = new Contenedor(new DAOUsuarios().GetUser(clave.id_usuario));
                    this.Hide();
                    ventana.Show();
                }
                else 
                {
                    MessageBox.Show("No existe clave.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RemarcarClave();
                }
            }
        }
        public void RemarcarClave() 
        {
            clave_scanner_textBox.Focus();
            clave_scanner_textBox.SelectionStart = 0;
            clave_scanner_textBox.SelectionLength = clave_scanner_textBox.Text.Length;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void login_Activated(object sender, EventArgs e)
        {
            clave_scanner_textBox.Focus();
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

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            clave_scanner_textBox.Focus();
        }

        private void tabPage2_MouseClick(object sender, MouseEventArgs e)
        {
            user_textBox.Focus();
        }

        private void user_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Contra_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}

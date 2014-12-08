using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Paquetes_form : Form
    {
        public Paquetes_form()
        {
            InitializeComponent();
            Paquetes paquete = new DAOPaquetes().GetPaqueteActivado();
            if (paquete != null)
            {
                label_version.Text = paquete.nombre;
            }
            else 
            {
                label_version.Text = "Limitado";
            }
           // Version ver = ApplicationDeployment.CurrentDeployment.CurrentVersion;
           // label4.Text = Convert.ToString(ver.Major + "." + ver.Minor + "." + ver.Build + "." + ver.Revision);
        }

        private void verificar_button_Click(object sender, EventArgs e)
        {
            if (new DAOPaquetes().VerificarPaqueteInstalado())
            {
                if (ExistePaquete(codigo_textbox.Text))
                {
                    new DAOPaquetes().ReactivarPaquete(codigo_textbox.Text);
                    MessageBox.Show("Clave correcta, el programa se reiniciará", "Activado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Paquetes paquete = new DAOPaquetes().GetPaquetePorClave(codigo_textbox.Text);
                    label_version.Text = paquete.nombre;
                    Application.Restart();
                }
                else 
                {
                    MessageBox.Show("Clave incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                if (ExistePaquete(codigo_textbox.Text))
                {
                    new DAOPaquetes().ActivarPaquete(codigo_textbox.Text);
                    MessageBox.Show("Clave correcta, el programa se reiniciará", "Activado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Paquetes paquete = new DAOPaquetes().GetPaquetePorClave(codigo_textbox.Text);
                    label_version.Text = paquete.nombre;
                    Application.Restart();
                }
                else 
                {
                    MessageBox.Show("Clave incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool ExistePaquete(string clave) 
        {
            bool existe = false;
            List<Paquetes> ListaDePaquetes = new DAOPaquetes().GetPaquetes();
            foreach(Paquetes temp in ListaDePaquetes)
            {
                if(temp.contrasenia.Equals(clave))
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }




    }
}

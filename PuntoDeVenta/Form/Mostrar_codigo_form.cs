using DTO;
using punto_venta.DAO;
using PuntoDeVenta.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Mostrar_codigo_form : Form
    {
        Usuarios usuario_actual;
        public Mostrar_codigo_form(Usuarios usuario)
        {
            InitializeComponent();
            usuario_actual = usuario;
            label1.Text = usuario.Nombre;
            label2.Text = usuario.Privilegios;
            if (new DAOClave_scaner().Getclave_scaner(usuario_actual.Id) != null)
            {
                string contrasenia = new DAOClave_scaner().Getclave_scaner(usuario.Id).contrasenia;
                label3.Text = contrasenia;
                textBox1.Text = contrasenia;
                MostrarImagen(contrasenia);
            }
            else 
            {
                //Debemos asignar un codigo y mostrarlo
                new DAOClave_scaner().AsignarClave(usuario_actual);
                string contrasenia = new DAOClave_scaner().Getclave_scaner(usuario.Id).contrasenia;
                label3.Text = contrasenia;
                textBox1.Text = contrasenia;
                MostrarImagen(contrasenia);
            }
           
        }
        public void MostrarImagen(string contrasenia) 
        {
            Code39 code = new Code39(contrasenia);
            string pathString2 = @"c:\Codigos generados";
            string nombreArchivo = Convert.ToString(usuario_actual.Nombre);
            if (!System.IO.File.Exists(pathString2))
            {
                System.IO.Directory.CreateDirectory(pathString2);
                //barcode.drawBarcode("c:\\Codigos generados" + "\\" + nombreArchivo + ".png");
                code.Paint().Save("c:\\Codigos generados" + "\\" + nombreArchivo + ".png", ImageFormat.Png);
                codigo_picture.ImageLocation = "c:\\Codigos generados" + "\\" + nombreArchivo + ".png";

            }
            else
            {
                //  barcode.drawBarcode("c:\\Codigos generados" + "\\" + nombreArchivo + ".png");
                code.Paint().Save("c:\\Codigos generados" + "\\" + nombreArchivo + ".png", ImageFormat.Png);
                codigo_picture.ImageLocation = "c:\\Codigos generados" + "\\" + nombreArchivo + ".png";

            }
        }
        private void guardar_Button_Click(object sender, EventArgs e)
        {
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                codigo_picture.Image.Save(guardarArchivo.FileName);
            }
        }

        private void Mostrar_codigo_form_Load(object sender, EventArgs e)
        {

        }
    }
}

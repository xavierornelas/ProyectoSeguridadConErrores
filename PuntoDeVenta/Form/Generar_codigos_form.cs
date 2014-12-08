
using DAO;
using DTO;
using punto_venta.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace punto_venta

{
    public partial class Generar_codigos_form : Form
    {
        Codigos_generados codigoActual = new Codigos_generados();
        List<Codigos_generados> codigosGenerados = null;
        Usuarios usuarioActual = new Usuarios();
        bool modificar = false;

        public Generar_codigos_form(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }
        public Generar_codigos_form() { }

        private void generar_codigo_button_Click(object sender, EventArgs e)
        {
            guardar_button.Enabled = true;
            modificar_button.Enabled = false;
            generar_codigo_button.Enabled = false;
            Random random = new Random();
            int codigo = random.Next(10000, 9999999);
            codigo_textbox.Text = Convert.ToString(codigo);
            Code39 code = new Code39(codigo_textbox.Text);
                
                // Create linear barcode object
               /* Linear barcode = new Linear();
                // Set barcode symbology type to Code-39
                barcode.Type = BarcodeType.CODE39;
                // Set barcode data to encode
                barcode.Data = codigo_textbox.Text;
                // Set barcode bar width (X dimension) in pixel
                barcode.X = 1;
                // Set barcode bar height (Y dimension) in pixel
                barcode.Y = 60;*/
                string pathString2 = @"c:\Codigos generados";                
                string nombreArchivo = Convert.ToString(codigo);
                if (!System.IO.File.Exists(pathString2))
                {
                    System.IO.Directory.CreateDirectory(pathString2);
                    //barcode.drawBarcode("c:\\Codigos generados" + "\\" + nombreArchivo + ".png");
                    code.Paint().Save("c:\\Codigos generados" + "\\" + nombreArchivo + ".png", ImageFormat.Png);
                    codigo_picture.ImageLocation = "c:\\Codigos generados" + "\\" + nombreArchivo + ".png";
                    codigoActual.ruta = "c:\\Codigos generados" + "\\" + nombreArchivo + ".png";
                }
                else 
                {
                  //  barcode.drawBarcode("c:\\Codigos generados" + "\\" + nombreArchivo + ".png");
                    code.Paint().Save("c:\\Codigos generados" + "\\" + nombreArchivo + ".png", ImageFormat.Png);
                    codigo_picture.ImageLocation = "c:\\Codigos generados" + "\\" + nombreArchivo + ".png";
                    codigoActual.ruta = "c:\\Codigos generados" + "\\" + nombreArchivo + ".png";
                }
                descripcion_textbox.Enabled = true;
                guardar_button.Enabled = true;
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if (!descripcion_textbox.Text.Equals(""))
            {
                if (!modificar)
                {
                    
                        codigoActual.codigo = codigo_textbox.Text;
                        codigoActual.descripcion = descripcion_textbox.Text;
                        Productos producto = new Productos();
                        producto.Id = codigo_textbox.Text;
                        producto.Nombre = descripcion_textbox.Text;
                        producto.Precio = 0;
                        producto.Cantidad = 0;
                        new DAOProductos().Insertproductos(producto);
                        new DAOCodigoGenerado().InsertCodigoGenerado(codigoActual);
                        descripcion_textbox.Enabled = false;
                        guardar_button.Enabled = false;
                }
                else
                {
                    codigoActual.codigo = codigo_textbox.Text;
                    codigoActual.descripcion = descripcion_textbox.Text;
                    new DAOCodigoGenerado().ModificarCodigo(codigoActual);
                    Productos producto = new Productos();
                    producto.Id = codigo_textbox.Text;
                    producto.Nombre = descripcion_textbox.Text;
                    producto.Precio = 0;
                    producto.Cantidad = 0;
                    new DAOProductos().Modifyproductos(producto);
                    descripcion_textbox.Enabled = false;
                    guardar_button.Enabled = false;
                }
                modificar = false;
                codigo_picture.ImageLocation = null;
                codigo_textbox.Text = null;
                descripcion_textbox.Text = null;
                modificar_button.Enabled = false;
                guardar_button.Enabled = false;
                generar_codigo_button.Enabled = true;

                codigosGenerados = new DAOCodigoGenerado().GetCodigo();
                dataGridView1.DataSource = codigosGenerados.ToArray();
            }
            else if (descripcion_textbox.Text.Equals(""))
            {
                MessageBox.Show("Falta agregar la descripción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Generar_codigos_form_Load(object sender, EventArgs e)
        {
            guardar_button.Enabled = false;
            modificar_button.Enabled = false;
            generar_codigo_button.Enabled = true;
            codigosGenerados = new DAOCodigoGenerado().GetCodigo();
            dataGridView1.DataSource = codigosGenerados.ToArray();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            modificar_button.Enabled = true;
            guardar_button.Enabled = false;
            generar_codigo_button.Enabled = false;

            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Codigos_generados cust = row.DataBoundItem as Codigos_generados;
                if (cust != null)
                {
                    codigoActual.codigo = cust.codigo;
                    codigoActual.descripcion = cust.descripcion;
                    codigoActual.ruta = cust.ruta;
                }
            }
        }

        private void modificar_button_Click(object sender, EventArgs e)
        {
            modificar = true;
            modificar_button.Enabled = false;
            guardar_button.Enabled = true;
            generar_codigo_button.Enabled = false;
            descripcion_textbox.Enabled = true;
            codigo_textbox.Text = codigoActual.codigo;
            descripcion_textbox.Text = codigoActual.descripcion;
        }

       
       

       
       
    }
}

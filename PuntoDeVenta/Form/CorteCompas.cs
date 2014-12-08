using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using PuntoDeVenta.DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PuntoDeVenta.DAO;

namespace punto_venta
{
    public partial class CorteCompas : Form
    {
        bool impresion = false;
        List<CorteCompras> PantallaListaProductos = new List<CorteCompras>();
        List<Compras> ListaProductosComprados=new List<Compras>();
        List<Productos> ListaDeProductos = new List<Productos>();
        List<Proveedores> ListaDeProveedores = new List<Proveedores>();
        
        Usuarios usuarioActual = new Usuarios();
        public CorteCompas(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (fecha1_picker.Value > fecha2Picker.Value)
            {
                MessageBox.Show("Debe escoger una fecha correcta.", "Alerta",
        MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else 
            {
               // string fecha1 = fecha1_picker.Value.ToShortDateString(), fecha2=fecha2Picker.Value.ToShortDateString();
                string fecha1 = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(fecha1_picker.Value));
                string fecha2 = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(fecha2Picker.Value));
                ListaProductosComprados = new DAOCompras().GetComprasCorte(fecha1,fecha2);
                ListaDeProveedores = new DAOProveedores().GetProvider();
                ListaDeProductos = new DAOProductos().GetProducts();
                foreach(Compras temp in ListaProductosComprados)
                {
                    List<Detalle_compra> ListaDetalle = new DAODetalle_compra().GetDetalle_Compras(temp.id_compra);
                    foreach(Detalle_compra detallit in ListaDetalle)
                    {
                        CorteCompras Corte = new CorteCompras();
                        Corte.id = Convert.ToString(detallit.id_compra);
                        Corte.tipo = temp.tipo;
                        Corte.cantidad = Convert.ToString(detallit.cantidad);
                        Corte.costo = Convert.ToString(detallit.precio);
                        Corte.total = Convert.ToString(detallit.total);
                        foreach (Proveedores proveedor in ListaDeProveedores)
                        {
                            if (detallit.id_proveedor == proveedor.Id)
                            {
                                Corte.proveedor = proveedor.Nombre;
                                break;
                            }
                        }
                        Corte.producto = new DAOProductos().GetProduct(detallit.id_producto).Nombre;
                        
                        PantallaListaProductos.Add(Corte);
                    }
                   
                }         
                
               
                dataGridView1.DataSource = PantallaListaProductos.ToArray();
                impresion = true;
            }
        }

        private void generarPDF_button_Click(object sender, EventArgs e)
        {
            string fecha = string.Format("{0:yyyy-MM-dd HH-mm-ss-fff}", Convert.ToDateTime(DateTime.Now));
            if (impresion)
            {

                //Realizo PDF
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 42, 35);
                string pathString2 = @"c:\PDF Generados";
                //Verifico si exite la carpeta PDF Generados
                if (!System.IO.File.Exists(pathString2))
                {
                    System.IO.Directory.CreateDirectory(pathString2);
                    PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("c:\\PDF Generados\\CorteComprasRango " + fecha + ".pdf", FileMode.Create));
                }
                else
                {
                    PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("c:\\PDF Generados\\CorteComprasRango " + fecha + ".pdf", FileMode.Create));
                }
                doc.Open();
                string rutaimg = Path.Combine(Application.StartupPath, "..\\..\\Resources\\logo.png");
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(rutaimg);
                PNG.ScalePercent(25f);
                doc.Add(PNG);
                Paragraph paragraph = new Paragraph(10, "Corte de ventas realizado por el usuario: " + usuarioActual.Nombre);
                doc.Add(paragraph);

                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
                }

                table.HeaderRows = 1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (dataGridView1[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                        }
                    }
                }
                doc.Add(table);
                doc.Close();
                System.Diagnostics.Process.Start("c:\\PDF Generados\\CorteComprasRango " + fecha + ".pdf");
                if (MessageBox.Show("¿Desea enviar corte al correo predeterminado?", "Cortes",
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                  == DialogResult.Yes)
                {
                    new DAOCorreo().CrearCorreoYMandarCompras("c:\\PDF Generados\\CorteComprasRango " + fecha + ".pdf", usuarioActual);
                }
                impresion = false;

            }
            else
            {
                MessageBox.Show("Debe realizar el corte.", "Cortes",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                impresion = false;
            }     
           
        }
      }
    }


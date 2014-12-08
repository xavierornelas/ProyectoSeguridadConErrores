using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LibPrintTicket;
using punto_venta.DAO;
using punto_venta.DTO;
using PuntoDeVenta.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Corte_por_rango_form : Form
    {
        bool impresion = false;
        List<CorteVentas> listaDeCortes = new List<CorteVentas>();       
        List<Detalle> listaDeProductosVendidos = new List<Detalle>();
        Usuarios usuarioActual = new Usuarios();
        float total = 0;
        public Corte_por_rango_form(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }
        public Corte_por_rango_form() { }

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
                listaDeProductosVendidos = new DAOCortes().GetCorte(fecha1, fecha2,1);
                //Filtramos los productos
                listaDeCortes = new Corte_por_dia_form().filtradoProductos(listaDeProductosVendidos);
                dataGridView1.DataSource = listaDeCortes.ToArray();
                total = totalDeTotales(listaDeCortes);
                total_label.Text = Convert.ToString(total);
                impresion = true;
            }
        }
        public float totalDeTotales(List<CorteVentas>lista) 
        {
            float total=0;
            foreach(CorteVentas temp in lista)
            {
                total = total + temp.total;
            }
            return total;
        }
        private void button2_Click(object sender, EventArgs e)
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
                    PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("c:\\PDF Generados\\CorteVentaRango " + fecha + ".pdf", FileMode.Create));
                }
                else
                {
                    PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("c:\\PDF Generados\\CorteVentaRango " + fecha + ".pdf", FileMode.Create));
                }
                doc.Open();
                string rutaimg = Path.Combine(Application.StartupPath, "Resources\\logo.png");
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(rutaimg);
                PNG.ScalePercent(25f);
                doc.Add(PNG);
                Paragraph paragraph = new Paragraph(10, "Corte de ventas realizado por el usuario: " + usuarioActual.Nombre);
                doc.Add(paragraph);
                Paragraph paragraph2 = new Paragraph(10, "Total: $" + total);
                doc.Add(paragraph2);
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
                System.Diagnostics.Process.Start("c:\\PDF Generados\\CorteVentaRango " + fecha + ".pdf");
                if (MessageBox.Show("¿Desea enviar corte al correo predeterminado?", "Cortes",
                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                   == DialogResult.Yes)
                {
                    new DAOCorreo().CrearCorreoYMandar("c:\\PDF Generados\\CorteVentaRango " + fecha + ".pdf", usuarioActual);
                }
                impresion = false;

            }
            else
            {
                MessageBox.Show("Debe de seleccionar un usuario.", "Cortes",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                impresion = false;
            }
        }

        private void Corte_por_rango_form_Load(object sender, EventArgs e)
        {

        }
    }
}

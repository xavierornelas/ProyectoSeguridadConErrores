using DAO;
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
    public partial class Corte_por_dia_form : Form
    {
        bool impresion = false;
        List<CorteVentas> listaDeCortes = new List<CorteVentas>();
        Usuarios usuarioActual = new Usuarios();
        List<Detalle> listaDeProductosVendidos = new List<Detalle>();
        List<Usuarios> listaUsuarios = null;
        float totalTodo = 0;
        public Corte_por_dia_form(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }
        public Corte_por_dia_form() { }

        

        private void Corte_por_dia_form_Load(object sender, EventArgs e)
        {
            listaUsuarios = new DAOUsuarios().GetUsers();
            foreach(Usuarios user in listaUsuarios)
            {
                usuarios_combobox.Items.Add(user.Nombre);
            }
            usuarios_combobox.Items.Add("Todos");
        }

        private void corteDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void realizar_corte_button_Click(object sender, EventArgs e)
        {
            if (usuarios_combobox.Text.Equals("")) 
            {
                MessageBox.Show("Debe de escoger un usuario.", "Alerta",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuarios_combobox.Text.Equals("Todos")) 
            {
                listaDeProductosVendidos = new DAOCortes().GetCorte(string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(DateTime.Now)));
                //Filtramos los productos
                listaDeCortes = filtradoProductos(listaDeProductosVendidos);
                dataGridView1.DataSource = listaDeCortes.ToArray();
                impresion = true;

                float total = sumaTotal(listaDeCortes);
                total_label.Text = Convert.ToString(total);
                totalTodo = total;
                
            }
            else
            {
                listaDeProductosVendidos = new DAOCortes().GetCorte(string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(DateTime.Now)), usuarios_combobox.Text);
                //Filtramos por productos
                listaDeCortes = filtradoProductos(listaDeProductosVendidos);
                dataGridView1.DataSource = listaDeCortes.ToArray();
                impresion = true;
                float total = sumaTotal(listaDeCortes);
                total_label.Text = Convert.ToString(total);
                totalTodo = total;
            }
        }

        public float sumaTotal(List<CorteVentas>lista) 
        {
            float sumaTotal = 0;
            foreach(CorteVentas temp in lista)
            {
                sumaTotal = temp.total + sumaTotal;
            }
            return sumaTotal;
        }

        public List<CorteVentas> filtradoProductos(List<Detalle>listaDeProductos) 
        {
            List<CorteVentas> productosCortados = new List<CorteVentas>();
            
            bool primeraVuelta = false;
            foreach(Detalle temp in listaDeProductos)
            {
                CorteVentas productoFiltrado = new CorteVentas();
                if (!primeraVuelta)
                {
                    productoFiltrado.codigo = temp.id_producto;
                    productosCortados.Add(productoFiltrado);
                    primeraVuelta = true;
                }
                else 
                {
                    bool productoAgregado = false;
                    foreach(CorteVentas corte in productosCortados)
                    {
                        if(corte.codigo==temp.id_producto)
                        {
                            productoAgregado = true;
                            break;
                        }
                    }
                    if (!productoAgregado) 
                    {
                        productoFiltrado.codigo = Convert.ToString(temp.id_producto);
                        productosCortados.Add(productoFiltrado);
                    }
                }

            }
            //Encuentro nombre de los productos de la lista productosCortados
            foreach(CorteVentas corteventas in productosCortados)
            {
                Productos producto = new Productos();
                producto = new DAOProductos().GetProducts(Convert.ToString(corteventas.codigo));
                corteventas.producto = producto.Nombre;
            }
            //Sumo cantidad de productos y precios
            foreach(CorteVentas filtro in productosCortados)
            {
                foreach(Detalle detalle in listaDeProductos)
                {
                    
                    if (filtro.codigo.Equals(detalle.id_producto)) 
                    {
                        filtro.cantidad = filtro.cantidad + detalle.cantidad;
                        filtro.total = filtro.total + detalle.total;
                    }
                }
            }
            return productosCortados;
        }

        private void imprimir_button_Click(object sender, EventArgs e)
        {
            string fecha = string.Format("{0:yyyy-MM-dd HH-mm-ss-fff}", Convert.ToDateTime(DateTime.Now));
            if (impresion)
            {
                new DAOImpresion().ImprimirTicketCorte(usuarioActual, usuarios_combobox.Text, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), total_label.Text, listaDeCortes);
                //Realizo PDF
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 42, 35);
                string pathString2 = @"c:\PDF Generados";
                //Verifico si exite la carpeta PDF Generados
                if (!System.IO.File.Exists(pathString2))
                {
                    System.IO.Directory.CreateDirectory(pathString2);
                    PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("c:\\PDF Generados\\CorteVenta "+fecha+".pdf", FileMode.Create));
                }
                else
                {
                    PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("c:\\PDF Generados\\CorteVenta "+fecha+".pdf", FileMode.Create));                    
                }
                doc.Open();
                string rutaimg = Path.Combine(Application.StartupPath, "Resources\\logo.png");
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(rutaimg);
                PNG.ScalePercent(25f);
                doc.Add(PNG);
                Paragraph paragraph = new Paragraph(10, "Corte de ventas realizado por el usuario: "+usuarioActual.Nombre);
                doc.Add(paragraph);
                Paragraph paragraph2 = new Paragraph(11, "Total: $" + totalTodo);
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
                System.Diagnostics.Process.Start("c:\\PDF Generados\\CorteVenta " + fecha + ".pdf");
                new DAOCorreo().CrearCorreoYMandar("c:\\PDF Generados\\CorteVenta " + fecha + ".pdf", usuarioActual);
                impresion = false;

            }
            else 
            {
                MessageBox.Show("Debe de seleccionar un usuario.", "Cortes",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                impresion = false;
            }
        }
    }
}

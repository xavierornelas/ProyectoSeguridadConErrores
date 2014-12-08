using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DAO;
using DTO;

namespace punto_venta
{
    public partial class Importar_Exportar_form : Form
    {
        
        public Importar_Exportar_form()
        {
            InitializeComponent();
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            string hoja = null;
            //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
            //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel.";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            //si al seleccionar el archivo damos Ok
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //el nombre del archivo sera asignado al textbox
                importar_textbox.Text = dialog.FileName;
                hoja = hoja_textbox.Text; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
                LLenarGrid(importar_textbox.Text, hoja); //se manda a llamar al metodo

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
            }  
        }
        private void LLenarGrid(string archivo, string hoja)
        {
            //declaramos las variables        
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dataGridView1.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void exportar_button_Click(object sender, EventArgs e)
        {
            List<Productos> productos = new List<Productos>();
            productos = new DAOProductos().GetProducts();
            dataGridView1.DataSource = productos.ToArray();
            DataGridView dt = new DataGridView();
            dt = dataGridView1;
            ExportarDataGridViewExcel(dt);
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if(hoja_textbox.Text.Equals(""))
            {
                MessageBox.Show("No hay hoja de Excel a buscar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(importar_textbox.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado un archivo.", "Éxito", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                timer1.Start();
                progressBar1.Minimum = 0;
                progressBar1.Maximum = this.dataGridView1.Rows.Count;
                progressBar1.Step = 10;
                for (i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    if (new DAOProductos().GetProducts(this.dataGridView1.Rows[i].Cells[0].Value.ToString())==null)
                    {
                        Productos producto = new Productos();
                        producto.Id = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        producto.Precio = float.Parse(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        if (int.Parse(this.dataGridView1.Rows[i].Cells[2].Value.ToString()) < 0)
                        {
                            producto.Cantidad = 0;
                        }
                        else 
                        {
                            producto.Cantidad = int.Parse(this.dataGridView1.Rows[i].Cells[2].Value.ToString());
                        }                        
                        producto.Nombre = this.dataGridView1.Rows[i].Cells[3].Value.ToString();

                        new DAOProductos().Insertproductos(producto);
                    }
                   
                    progressBar1.Value = i;
                }
                MessageBox.Show("Se ha importado con éxito la base de datos.", "Éxito", MessageBoxButtons.OK);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (progressBar1.Value == this.dataGridView1.Rows.Count)
                timer1.Stop();
        }

        private void hoja_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}

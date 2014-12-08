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
using PuntoDeVenta.DAO;
//using Microsoft.Office.Interop.Excel;

namespace punto_venta
{
    public partial class Proveedores_Form : Form
    {
        List<Proveedores> prov = null;
        Proveedores proveedorGlobal = new Proveedores();

        public Proveedores_Form()
        {
            InitializeComponent();
            prov = new DAOProveedores().GetProvider();
            
        }

        private void Agregar_Prov_Button_Click(object sender, EventArgs e)
        {
            if (new Validaciones().LimpiarString(domicilio_textBox.Text).Equals(null) || new Validaciones().LimpiarString(ciudad_textBox.Text).Equals(null) || new Validaciones().LimpiarString(nombre_textbox.Text).Equals(null) || new Validaciones().LimpiarString(estado_textBox.Text).Equals(null))
            {
                new Mensajes().DebeLlenarTodosLosCampos();
                nombre_textbox.Focus();
                nombre_textbox.SelectionStart = 0;
                nombre_textbox.SelectionLength = nombre_textbox.Text.Length;
            }
            else if (new DAOProveedores().GetProvider(new Validaciones().LimpiarString(nombre_textbox.Text))!=null)
            {
                MessageBox.Show("El nombre del proveedor está repetido.", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nombre_textbox.Focus();
                nombre_textbox.SelectionStart = 0;
                nombre_textbox.SelectionLength = nombre_textbox.Text.Length;
            }
            else 
            { 
                Proveedores proveedor = new Proveedores();
                proveedor.Id = darID(prov);
                proveedor.Nombre = nombre_textbox.Text;
                proveedor.Domicilio = domicilio_textBox.Text;
                proveedor.Ciudad = ciudad_textBox.Text;
                proveedor.Estado = estado_textBox.Text;
                new DAOProveedores().InsertProv(proveedor);
                prov = new DAOProveedores().GetProvider();
                dataGridView_Proveedores.DataSource = prov.ToArray();
                nombre_textbox.Text = null;
                domicilio_textBox.Text = null;
                estado_textBox.Text = null;
                ciudad_textBox.Text = null;
            }
        }

        private int darID(List<Proveedores> lista)
        {
            int id = lista.Capacity;
            bool numeroDetectado = false, fuera = false;
            while (!fuera)
            {
                foreach (Proveedores temp in lista)
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

        private void Proveedores_Form_Load(object sender, EventArgs e)
        {
            dataGridView_Proveedores.DataSource = prov.ToArray();
        }

        private void Actualizar_Prov_button_Click(object sender, EventArgs e)
        {
      
        }

        private void Datagridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Agregar_Prov_Button.Enabled = false;
            Modificar_Prov_Button.Enabled = true;
            Eliminar_Prov_Button.Enabled = true;
        }

        private void Eliminar_Prov_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar a este proveedor?", "Alerta",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in this.dataGridView_Proveedores.SelectedRows)
                {
                    Proveedores cust = row.DataBoundItem as Proveedores;
                    if (cust != null)
                    {
                        ProveedoresDeudas proveedor = new ProveedoresDeudas();
                        proveedor = new DAOProveedores().SeleccionarDeudaProveedor(cust.Id);
                        if (proveedor.Deuda > 0)
                        {
                            if (MessageBox.Show("Este proveedor aun le debe ¿Desea eliminarlo?", "Alerta",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                             == DialogResult.Yes)
                            {
                                new DAOProveedores().DeleteProveedores(cust.Id);
                                new DAOProveedores().DeleteCreditoProveedor(cust.Id);
                                
                                prov = new DAOProveedores().GetProvider();
                                dataGridView_Proveedores.DataSource = prov.ToArray();
                            }
                        }    
                        new DAOProveedores().DeleteProveedores(cust.Id);
                        prov = new DAOProveedores().GetProvider();
                        dataGridView_Proveedores.DataSource = prov.ToArray();
                        Agregar_Prov_Button.Enabled = true;
                        Modificar_Prov_Button.Enabled = false;
                        Eliminar_Prov_Button.Enabled = false;
                        
                    }
                }
                

            }
            
        }

        private void Guardar_prov_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de modificar a este proveedor?", "Alerta",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        == DialogResult.Yes)
            {
                proveedorGlobal.Nombre = nombre_textbox.Text;
                proveedorGlobal.Ciudad = ciudad_textBox.Text;
                proveedorGlobal.Domicilio = domicilio_textBox.Text;
                proveedorGlobal.Estado = estado_textBox.Text;
                new DAOProveedores().ModifyProv(proveedorGlobal);

                actualizarDGV();
            }          

            Agregar_Prov_Button.Enabled = true;
            Modificar_Prov_Button.Enabled = false;
            Eliminar_Prov_Button.Enabled = false;
            Guardar_prov_button.Enabled = false;
            nombre_textbox.Text = null;
            domicilio_textBox.Text = null;
            estado_textBox.Text = null;
            ciudad_textBox.Text = null;
        }

        private void Modificar_Prov_Button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView_Proveedores.SelectedRows)
            {
                Proveedores cust = row.DataBoundItem as Proveedores;
                if (cust != null)
                {
                    nombre_textbox.Text = cust.Nombre;
                    domicilio_textBox.Text = cust.Domicilio;
                    ciudad_textBox.Text = cust.Ciudad;
                    estado_textBox.Text = cust.Estado;
                    proveedorGlobal = cust;
                }
            }
            Guardar_prov_button.Enabled = true;
            Modificar_Prov_Button.Enabled = false;
            Eliminar_Prov_Button.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*
        private void crear_xls_button_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application wapp;
            Microsoft.Office.Interop.Excel.Worksheet wsheet;
            Microsoft.Office.Interop.Excel.Workbook wbook;
            wapp = new Microsoft.Office.Interop.Excel.Application();
            wapp.Visible = false;
            wbook = wapp.Workbooks.Add(true);
            wsheet = (Worksheet)wbook.ActiveSheet;

            if (dataGridView_Proveedores.RowCount == 0)
            {
                return;
            }
            try
            {
                for (int i = 0; i < this.dataGridView_Proveedores.Columns.Count; i++)
                {
                    wsheet.Cells[1, i + 1] = this.dataGridView_Proveedores.Columns[i].HeaderText;
                }

                for (int i = 0; i < this.dataGridView_Proveedores.Rows.Count; i++)
                {
                    DataGridViewRow row = this.dataGridView_Proveedores.Rows[i];
                    for (int j = 0; j < row.Cells.Count; j++)
                    {
                        DataGridViewCell cell = row.Cells[j];
                        try
                        {
                            wsheet.Cells[i + 2, j + 1] = (cell.Value == null) ? "" : cell.Value.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                wapp.Visible = true;
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            wapp.UserControl = true;

        }

        private void importar_button_Click(object sender, EventArgs e)
        {
            Proveedores_Subir_Excel archivo = new Proveedores_Subir_Excel();
            archivo.ShowDialog();
        }*/

        public void actualizarDGV()
        {
            List<Proveedores> prove = new DAOProveedores().GetProvider();
            dataGridView_Proveedores.DataSource = prove.ToArray();
        }

        private void Proveedores_Form_Activated(object sender, EventArgs e)
        {
            actualizarDGV();
        }
    }


}

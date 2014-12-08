using DAO;
using DTO;
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
    public partial class devoluciones_form : Form
    {
        Usuarios usuarioActual = new Usuarios();
        List<Usuarios> listaUsuarios = null;
        List<Ventas> VentasTotales = null;
        public devoluciones_form(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void devolver_button_Click(object sender, EventArgs e)
        {
            if (usuarios_combobox.Text.Equals(""))
            {
                MessageBox.Show("Debe de escoger un usuario.", "Alerta",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuarios_combobox.Text.Equals("Todos"))
            {
                VentasTotales = new DAOVentas().GetVentas(string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(fecha1_picker.Value)));
                dataGridView1.DataSource = VentasTotales.ToArray();
            }
            else
            {
                VentasTotales = new DAOVentas().GetVentas(string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(fecha1_picker.Value)), usuarios_combobox.Text);
                dataGridView1.DataSource = VentasTotales.ToArray();
            }
        }

        private void Código_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void regresar_button_Click(object sender, EventArgs e)
        {

        }

        private void cantidad_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void devoluciones_form_Load(object sender, EventArgs e)
        {
            listaUsuarios = new DAOUsuarios().GetUsers();
            foreach (Usuarios user in listaUsuarios)
            {
                usuarios_combobox.Items.Add(user.Nombre);
            }
            usuarios_combobox.Items.Add("Todos");
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((string)this.dataGridView1.Rows[e.RowIndex].Cells[4].Value!="Devolucion")
            {
                devolucion_por_ticket_form devticket = new devolucion_por_ticket_form((string)this.dataGridView1.Rows[e.RowIndex].Cells[0].Value, usuarioActual);
                devticket.ShowDialog();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

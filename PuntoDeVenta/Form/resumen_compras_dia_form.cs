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
    public partial class resumen_compras_dia_form : Form
    {
        Usuarios usuarioActual = new Usuarios();
        List<Usuarios> listaUsuarios = null;
        List<Compras> compras = null;
        public resumen_compras_dia_form(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void resumen_compras_dia_form_Load(object sender, EventArgs e)
        {
            listaUsuarios = new DAOUsuarios().GetUsers();
            foreach (Usuarios user in listaUsuarios)
            {
                usuarios_combobox.Items.Add(user.Nombre);
            }
            usuarios_combobox.Items.Add("Todos");
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            if (usuarios_combobox.Text.Equals(""))
            {
                MessageBox.Show("Debe de escoger un usuario.", "Alerta",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuarios_combobox.Text.Equals("Todos"))
            {
                compras = new DAOCompras().GetCompras(string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(fecha1_picker.Value)));
                dataGridView1.DataSource = compras.ToArray();
            }
            else
            {
                compras = new DAOCompras().GetCompras(string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(fecha1_picker.Value)), usuarios_combobox.Text);
                dataGridView1.DataSource = compras.ToArray();
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            resumen_compras_id_form devticket =new resumen_compras_id_form((string)this.dataGridView1.Rows[e.RowIndex].Cells[0].Value, usuarioActual);
            devticket.ShowDialog();
        }
    }
}

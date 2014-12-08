using DAO;
using DTO;
using PuntoDeVenta.DAO;
using PuntoDeVenta.DTO;
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
    public partial class Detalle_credito_cliente : Form
    {
        int id_cliente=0;
        List<Abonos> abonos = new List<Abonos>();
        List<Detalle> detalle = new List<Detalle>();
        public string id_venta=null;
        public string fecha=null;
        public Detalle_credito_cliente(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            id_venta = null;
            fecha = null;
        }

        private void Detalle_credito_cliente_Load(object sender, EventArgs e)
        {
            abonos = new DAOAbonos().GetAbonos(this.id_cliente);
            InicializarDGVAbonos();
            detalle = new DAODetalles_credito_cliente().ObtenerListaDetallesCredito(this.id_cliente);
            InicializarDGVProductos();        
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_venta = (string)this.dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }

        private void borrar_productos_button_Click(object sender, EventArgs e)
        {
            if (id_venta==null)
            {
                MessageBox.Show("Seleccione algún producto.", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                if (MessageBox.Show("¿Desea borrar este producto? Recuerde que se borraran todos los productos de la venta seleccionada.", "Alerta",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
                {
                    new DAODetalles_credito_cliente().DeleteDetalleCredito(this.id_cliente, id_venta);
                    actualizaDGVProductos();
                }
            }
            
        }
        private void clearTable()
        {
           
            if (dataGridView1.Rows.Count != 0)
            {
                int i = 0;
                for (i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    this.dataGridView1.Rows.RemoveAt(i);
                    
                }
            }
        }
        private void clearTableAbonos()
        {
           
            if (dataGridView2.Rows.Count != 0)
            {
                int i = 0;
                for (i = 0; i < this.dataGridView2.Rows.Count; i++)
                {
                    this.dataGridView2.Rows.RemoveAt(i);

                }
            }
        }
        public void InicializarDGVProductos() 
        {
            clearTable();

            dataGridView1.DataSource = null;
            foreach (Detalle u in detalle)
            {
                dataGridView1.Rows.Add(u.id_venta, new DAOProductos().GetProducts(u.id_producto).Nombre, u.cantidad, u.total);
            }
           
        }
        public void InicializarDGVAbonos()
        {
            clearTableAbonos();

            dataGridView2.DataSource = null;
            foreach (Abonos u in abonos)
            {
                dataGridView2.Rows.Add(u.fecha,u.abono);
            }

        }
        public void actualizaDGVProductos()
        {
            detalle = new DAODetalles_credito_cliente().ObtenerListaDetallesCredito(this.id_cliente);
            clearTable();
            
            foreach (Detalle u in detalle)
            {
                dataGridView1.Rows.Add(u.id_venta, new DAOProductos().GetProducts(u.id_producto).Nombre, u.cantidad, u.total);
            }
           
        }
        public void actualizaDGVAbonos()
        {
            abonos = new DAOAbonos().GetAbonos(this.id_cliente);
            clearTableAbonos();
            
            foreach (Abonos u in abonos)
            {
                dataGridView2.Rows.Add(u.fecha, u.abono);
            }
        }

        private void borrar_abonos_button_Click(object sender, EventArgs e)
        {
            if (fecha==null)
            {
                MessageBox.Show("Seleccione algún abono.", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  
            }
            else 
            {
                if (MessageBox.Show("¿Desea borrar este abono?", "Alerta",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                {
                    new DAOAbonos().DeleteAbono(fecha, this.id_cliente);
                    actualizaDGVAbonos();
                }
            }
           
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            fecha = (string)this.dataGridView2.Rows[e.RowIndex].Cells[0].Value;

        }
    }
}

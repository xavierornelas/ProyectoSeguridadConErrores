using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Principalito_form : Form
    {
        List<Productos> inv = null;
        public Principalito_form() { }
        Usuarios usuarioActual = new Usuarios();
        public Principalito_form(Usuarios datosUsuario)
        {
            InitializeComponent();
            label2.Text = datosUsuario.Nombre;
            usuarioActual = datosUsuario;           
            
            if (datosUsuario.Privilegios.Equals("Empleado")) 
            {
               
            }
            
            
        }

        private void Principalito_form_Load(object sender, EventArgs e)
        {
            inv = new DAOProductos().GetProducts();
            List<Productos> agotados = new List<Productos>();
            foreach (Productos productos in inv)
            {
                if (productos.Cantidad <= 10)
                {
                    agotados.Add(productos);
                }
            }
            dataGridView1.DataSource = agotados.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inv = new DAOProductos().GetProducts();
            List<Productos> agotados = new List<Productos>();
            foreach (Productos productos in inv)
            {
                if (productos.Cantidad <= 10)
                {
                    agotados.Add(productos);
                }
            }
            dataGridView1.DataSource = agotados.ToArray();
        }

    }
}

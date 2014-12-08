using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PuntoDeVenta.DAO;

namespace punto_venta
{
    public partial class Ofertas_form : Form
    {
        Usuarios usuarioActual = new Usuarios();
        List<DTOOfertas> ofertas = null;
        public string idOferta = null;

        public Ofertas_form(Usuarios usuario)
        {
            InitializeComponent();
            this.bttnModify.Enabled = false;
            this.btttnDel.Enabled = false;
            usuarioActual = usuario;

            ofertas = new DAOOfertas().GetOfertas();
            dataGridView1.DataSource = ofertas.ToArray();
        }
        public Ofertas_form() 
        { 
        }

        private void bttnNueva_Click(object sender, EventArgs e)
        {
            this.bttnAdd.Text = "Agregar";
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = true;
            this.textBox3.Enabled = true;
            this.textBox4.Enabled = true;
            this.textBox5.Enabled = true;
            this.bttnAdd.Enabled = true;
            this.bttnNueva.Enabled = false;
            this.panel1.Enabled = true;
        }


        private void bttnAdd_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            float num = 0;
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals("") || textBox1.Text.Equals(" ") || textBox2.Text.Equals(" ") || textBox3.Text.Equals(" ") || textBox4.Text.Equals(" ") || textBox5.Text.Equals(" "))
            {
                new Mensajes().DebeLlenarTodosLosCampos(); textBox1.Focus();
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.Text.Length;
            }
            else if (!float.TryParse(textBox4.Text, out num)||!int.TryParse(textBox3.Text,out cantidad))
            {
                MessageBox.Show("Cantidad y precio no deben contener caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                
                textBox3.SelectionStart = 0;
                textBox3.SelectionLength = textBox3.Text.Length;

            }
            else 
            {
                if (new DAOProductos().GetProducts(textBox5.Text) != null)
                {
                    if (this.bttnModify.Enabled)
                    {
                        DTOOfertas oferta = new DTOOfertas();
                        oferta.cantidad = int.Parse(this.textBox3.Text);
                        oferta.precio = float.Parse(this.textBox4.Text);
                        oferta.descripcion = this.textBox2.Text;
                        oferta.codigo = this.textBox5.Text;
                        oferta.id = this.textBox1.Text;

                        new DAOOfertas().ModifyOferta(oferta);
                    }
                    else
                    {
                        DTOOfertas oferta = new DTOOfertas();
                        oferta.cantidad = int.Parse(this.textBox3.Text);
                        oferta.precio = float.Parse(this.textBox4.Text);
                        oferta.descripcion = this.textBox2.Text;
                        oferta.codigo = this.textBox5.Text;
                        oferta.id = this.textBox1.Text;

                        new DAOOfertas().InsertOferta(oferta);

                    }

                    ofertas = new DAOOfertas().GetOfertas();
                    this.dataGridView1.DataSource = ofertas.ToArray();
                    this.bttnAdd.Enabled = false;
                    this.bttnModify.Enabled = false;
                    this.btttnDel.Enabled = false;
                    this.bttnNueva.Enabled = true;
                    this.textBox5.Text = null;
                    this.textBox1.Text = null;
                    this.textBox2.Text = null;
                    this.textBox3.Text = null;
                    this.textBox4.Text = null;
                    this.textBox1.Enabled = false;
                    this.textBox2.Enabled = false;
                    this.textBox3.Enabled = false;
                    this.textBox4.Enabled = false;
                    this.textBox5.Enabled = false;
                    this.panel1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El producto no exite.", "Producto no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Focus();
                    textBox5.SelectionStart = 0;
                    textBox5.SelectionLength = textBox5.Text.Length;
                }
            }
           
            

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idOferta = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.btttnDel.Enabled = true;
            this.bttnModify.Enabled = true;
        }

        private void bttnModify_Click(object sender, EventArgs e)
        {

            DTOOfertas oferta = new DAOOfertas().GetOferta(idOferta);

                this.textBox1.Text = oferta.id;
                this.textBox2.Text = oferta.descripcion;
                this.textBox3.Text = oferta.cantidad.ToString();
                this.textBox4.Text = oferta.precio.ToString();
                this.textBox5.Text = oferta.codigo;

         
            this.panel1.Enabled = true;
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = true;
            this.textBox3.Enabled = true;
            this.textBox4.Enabled = true;
            this.textBox5.Enabled = true;

            this.bttnAdd.Text = "Guardar";
            this.bttnAdd.Enabled = true;
            this.bttnNueva.Enabled = false;

        }

        private void btttnDel_Click(object sender, EventArgs e)
        {
            new DAOOfertas().DeleteCustomer(idOferta);
            ofertas = new DAOOfertas().GetOfertas();
            this.dataGridView1.DataSource = ofertas.ToArray();

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < textBox4.Text.Length; i++)
            {
                if (textBox4.Text[i] == '.')
                    IsDec = true;

                if (IsDec && e.KeyChar == '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;

                if (IsDec && nroDec++ >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }

            }
        }

    }
}

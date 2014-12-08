using DAO;
using DTO;
using LibPrintTicket;
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
    public partial class Hacer_Pago_Proveedor_form : Form
    {
        ProveedoresDeudas actual = new ProveedoresDeudas();
        ProveedoresDeudas proveedorDeudaActual = new ProveedoresDeudas();

        public Hacer_Pago_Proveedor_form(ProveedoresDeudas provedor)
        {
            InitializeComponent();
            proveedor_textbox.Text = provedor.Nombre;
            actual = provedor;
        }

        private void Pagar_button_Click(object sender, EventArgs e)
        {
            //Validar si es numero  
             float precio = 0;
            if(pago_textbox.Text.Equals(null))
            {
                MessageBox.Show("Debe ingresar el pago.", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pago_textbox.Focus();
                pago_textbox.SelectionStart = 0;
                pago_textbox.SelectionLength = pago_textbox.Text.Length;
            }
            else if (!float.TryParse(pago_textbox.Text, out precio))
            {
                MessageBox.Show("Debe ingresar un número en el campo pago.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pago_textbox.Focus();
                pago_textbox.SelectionStart = 0;
                pago_textbox.SelectionLength = pago_textbox.Text.Length;
            }           
            else
            {
                if ((actual.Deuda - Convert.ToInt32(pago_textbox.Text)) >= 0)
                {
                    actual.Deuda = (actual.Deuda - Convert.ToInt32(pago_textbox.Text));
                    new DAOProveedores().ModifyDeuda(actual);
                }
                else
                {
                    MessageBox.Show("Valor invalido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Dispose();
        }

        private void Hacer_pago_form_Load(object sender, EventArgs e)
        {

        }

        private void pago_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < pago_textbox.Text.Length; i++)
            {
                if (pago_textbox.Text[i] == '.')
                    IsDec = true;

                if (IsDec && e.KeyChar == '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;

                if (IsDec && nroDec++ >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }

            }
            //Validar si es numero  
            if(e.KeyChar==(char)Keys.Enter)
            {
                float precio = 0;
                if (pago_textbox.Text.Equals(null))
                {
                    MessageBox.Show("Debe ingresar el pago.", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pago_textbox.Focus();
                    pago_textbox.SelectionStart = 0;
                    pago_textbox.SelectionLength = pago_textbox.Text.Length;
                }
                else if (!float.TryParse(pago_textbox.Text, out precio))
                {
                    MessageBox.Show("Debe ingresar un número en el campo pago.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pago_textbox.Focus();
                    pago_textbox.SelectionStart = 0;
                    pago_textbox.SelectionLength = pago_textbox.Text.Length;
                }
                else
                {
                    if ((actual.Deuda - Convert.ToInt32(pago_textbox.Text)) >= 0)
                    {
                        actual.Deuda = (actual.Deuda - Convert.ToInt32(pago_textbox.Text));
                        new DAOProveedores().ModifyDeuda(actual);
                    }
                    else
                    {
                        MessageBox.Show("Valor invalido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Dispose();
            }
            }
            
    }
}

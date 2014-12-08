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
    public partial class correos_form : Form
    {
        int idselect = 0;
        public correos_form()
        {
            InitializeComponent();
            correo_textbox.Focus();
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            if (correo_textbox.Text.Equals(repite_correo_textBox.Text))
            {
                Correo correo = new Correo();
                correo.correo = correo_textbox.Text;
                if (new DAOCorreo().ObtenerCorreoPorDefault() == null)
                {
                    MessageBox.Show("Este correo será el predeterminado ya que no lo hay.", "Correo predeterminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    correo.Default = 1;
                    new DAOCorreo().InsertCorreo(correo);
                    new DAOCorreo().MandarCorreoPrueba(correo.correo);

                }
                else
                {
                    if (MessageBox.Show("¿Desea asignar este correo como predeterminado?", "Alerta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                    {
                        correo.Default = 1;
                        new DAOCorreo().QuitarCorreoPorDefault(new DAOCorreo().ObtenerCorreoPorDefault().id_correo);
                        new DAOCorreo().InsertCorreo(correo);
                        new DAOCorreo().MandarCorreoPrueba(correo.correo);
                    }
                    else
                    {
                        correo.Default = 0;
                        new DAOCorreo().InsertCorreo(correo);
                        new DAOCorreo().MandarCorreoPrueba(correo.correo);
                    }
                }
                correo_textbox.Text = null;
                repite_correo_textBox.Text = null;
                actualizaDGV();
            }
            else 
            {
                MessageBox.Show("Los correos electrónicos no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                repite_correo_textBox.Text = null;
                repite_correo_textBox.Enabled = false;
                correo_textbox.Focus();
                correo_textbox.SelectionStart = 0;
                correo_textbox.SelectionLength = correo_textbox.Text.Length;
            }
            repite_correo_textBox.Enabled = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            agregar_button.Enabled = false;
            modificar_button.Enabled = true;
            eliminar_button.Enabled = true;
            idselect = (int)this.dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            if (new DAOCorreo().GetCorreo(idselect).Default != 1)
            {
                if (MessageBox.Show("¿Desea eliminar la cuenta?", "Alerta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes) 
                {
                    new DAOCorreo().DeleteCorreo(idselect);
                    //Falta llenar otra vez la tabla
                    actualizaDGV();
                }
            }
            else 
            {
                MessageBox.Show("Si desea volver a recibir correos del corte debe asignar una cuenta predeterminada.", "Correo predeterminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Falta llenar otra vez la tabla
                new DAOCorreo().DeleteCorreo(idselect);
                actualizaDGV();
            }
            eliminar_button.Enabled = false;
            modificar_button.Enabled = false;
            agregar_button.Enabled = true;
            guardar_button.Enabled = false;
            correo_textbox.Focus();
            repite_correo_textBox.Enabled = false;
        }

        private void modificar_button_Click(object sender, EventArgs e)
        {
            correo_textbox.Enabled = true;
            //obtengo el correo desde la base de datos
            correo_textbox.Text = new DAOCorreo().GetCorreo(idselect).correo;
            modificar_button.Enabled = false;
            eliminar_button.Enabled = false;
            guardar_button.Enabled = true;
        }

        private void correo_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if (repite_correo_textBox.Equals(""))
            {
                MessageBox.Show("Repite el correo electrónico ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                repite_correo_textBox.Focus();
            }
            else 
            {
                if(correo_textbox.Text.Equals(repite_correo_textBox.Text))
                {
                    if (new DAOCorreo().ObtenerCorreoPorDefault() != null)
                    {
                        //Si es el correo predeterminado, preguntarle si desea que aun sea
                        if (new DAOCorreo().ObtenerCorreoPorDefault().id_correo == idselect)
                        {
                            if (MessageBox.Show("¿Desea que este correo siga siendo el predeterminado?", "Alerta",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                           == DialogResult.Yes)
                            {
                                Correo correo = new Correo();
                                correo.id_correo = idselect;
                                correo.correo = correo_textbox.Text;
                                correo.Default = 1;
                                new DAOCorreo().ModificarCorreo(correo);
                                new DAOCorreo().MandarCorreoPrueba(correo.correo);
                            }
                            else
                            {
                                Correo correo = new Correo();
                                correo.id_correo = idselect;
                                correo.correo = correo_textbox.Text;
                                correo.Default = 0;
                                new DAOCorreo().ModificarCorreo(correo);
                                MessageBox.Show("Si desea volver a recibir correos del corte debe asignar una cuenta predeterminada.", "Correo predeterminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                new DAOCorreo().MandarCorreoPrueba(correo.correo);
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("¿Desea establecer este correo como predeterminado?", "Alerta",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                           == DialogResult.Yes)
                            {
                                new DAOCorreo().QuitarCorreoPorDefault(new DAOCorreo().ObtenerCorreoPorDefault().id_correo);
                                Correo correo = new Correo();
                                correo.id_correo = idselect;
                                correo.correo = correo_textbox.Text;
                                correo.Default = 1;
                                new DAOCorreo().ModificarCorreo(correo);
                                new DAOCorreo().MandarCorreoPrueba(correo.correo);
                            }
                            else
                            {
                                Correo correo = new Correo();
                                correo.id_correo = idselect;
                                correo.correo = correo_textbox.Text;
                                correo.Default = 0;
                                new DAOCorreo().ModificarCorreo(correo);
                                new DAOCorreo().MandarCorreoPrueba(correo.correo);

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Este correo será el predeterminado ya que no lo hay.", "Correo predeterminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Correo correo = new Correo();
                        correo.id_correo = idselect;
                        correo.correo = correo_textbox.Text;
                        correo.Default = 1;
                        new DAOCorreo().ModificarCorreo(correo);
                        new DAOCorreo().MandarCorreoPrueba(correo.correo);
                    }
                }
                
                actualizaDGV();
                agregar_button.Enabled = true;
                modificar_button.Enabled = false;
                guardar_button.Enabled = false;
                eliminar_button.Enabled = false;
                correo_textbox.Text = null;
                repite_correo_textBox.Text = null;
                repite_correo_textBox.Enabled = false;
            }
        }

        private void correos_form_Load(object sender, EventArgs e)
        {
            actualizaDGV();
        }
        public void actualizaDGV()
        {
            List<Correo> correo = new DAOCorreo().GetCorreos();
            this.dataGridView1.DataSource = correo.ToArray();
        }

        private void correo_textbox_Leave(object sender, EventArgs e)
        {
            if (!correo_textbox.Text.Equals("")) 
            {
                //Verifico si tiene formato de correo electronico
                if (new DAOCorreo().IsValidEmail(correo_textbox.Text))
                {
                    repite_correo_textBox.Enabled = true;
                    repite_correo_textBox.Focus();
                }
                else
                {
                    MessageBox.Show("El texto ingresado no tiene formato de correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correo_textbox.Focus();
                    correo_textbox.SelectionStart = 0;
                    correo_textbox.SelectionLength = correo_textbox.Text.Length;
                }
            }
            
        }

        private void repite_correo_textBox_Leave(object sender, EventArgs e)
        {
            if(!repite_correo_textBox.Text.Equals(""))
            {
                 if (!correo_textbox.Text.Equals(repite_correo_textBox.Text))
                {
                    MessageBox.Show("Los correos electrónicos no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    repite_correo_textBox.Text = null;
                    repite_correo_textBox.Enabled = false;
                    correo_textbox.Focus();
                    correo_textbox.SelectionStart = 0;
                    correo_textbox.SelectionLength = correo_textbox.Text.Length;
                }
            }
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            modificar_button.Enabled = false;
            eliminar_button.Enabled = false;
            guardar_button.Enabled = false;
            agregar_button.Enabled = true;
            correo_textbox.Text = null;
            repite_correo_textBox.Text = null;
            correo_textbox.Focus();
        }

    }
}

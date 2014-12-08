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
//using InputKey;
using LibPrintTicket;
using OrnelasInput;
using punto_venta.DTO;
using PuntoDeVenta.DAO;

namespace punto_venta
{
    public partial class Ventas_Form : Form
    {
        List<Productos> productosDelInventario = new List<Productos>();
            
        List<Clientes> clientes = null;
        List<Detalle> ListaDeProductosVendidos = new List<Detalle>();
        List<PantallaVenta> pantalla = new List<PantallaVenta>();
        
        List<Ventas> ventasTotales = null;
        Ventas ventaActual = new Ventas();
        List<Usuarios> usuarios = null;
        Usuarios UsuarioActual = new Usuarios();
        Paquetes paquete=new Paquetes();
        string codigoBorrar = null;
        int cantidadBorrar = 0;
        int aux = 0;
        public Ventas_Form(Usuarios datosUsuarios, Paquetes paquete)
        {
            InitializeComponent();
            Usuario.Text = datosUsuarios.Nombre;
            UsuarioActual = datosUsuarios;
            ventasTotales = new DAOVentas().GetVentas();
            this.paquete = paquete;
            if (datosUsuarios.Privilegios.Equals("Empleado"))
            {
               
            }
            
        }
        public Ventas_Form() { InitializeComponent(); }

        

        private void Ventas_Form_Load(object sender, EventArgs e)
        {
            actualizarProductos();             
        }

        private void actualizarProductos()
        {
            productosDelInventario = new DAOProductos().GetProducts();
            clientes = new DAOClientes().GetCustomer();
            usuarios = new DAOUsuarios().GetUsers();
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (Productos obj in productosDelInventario)
            {
                data.Add(obj.Nombre);
            }
            Descripcion.AutoCompleteCustomSource = data;
        }

        private void ModPrecio_Vta_Button_Click(object sender, EventArgs e)
        {
            if (!Precio_Vta_TextBox.Text.Equals(""))
            {
                autorizacion_form form = new autorizacion_form();
                if (UsuarioActual.Privilegios.Equals("Administrador"))
                {
                        Precio_Vta_TextBox.Enabled = true;
                        Precio_Vta_TextBox.Focus();
                        Precio_Vta_TextBox.SelectionStart = 0;
                        Precio_Vta_TextBox.SelectionLength = Precio_Vta_TextBox.Text.Length;
                }
                   
                else if (form.ShowDialog() == DialogResult.OK)
                {
                    if (form.ValorRetorno)
                    {
                        Precio_Vta_TextBox.Enabled = true;
                        Precio_Vta_TextBox.Focus();
                        Precio_Vta_TextBox.SelectionStart = 0;
                        Precio_Vta_TextBox.SelectionLength = Precio_Vta_TextBox.Text.Length;
                    }
                }
            }
            else 
            {
                MessageBox.Show("Debes ingresar un código del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        

        private void Codigo_KeyUp(object sender, KeyEventArgs e)
        {
           
            
        }
        public bool codigoRepetido(List<PantallaVenta> list,string codigo) 
        {
            bool repetido = false;
            foreach(PantallaVenta temp in list)
            {
                if (codigo.Equals(temp.Codigo)) 
                {
                    repetido = true;
                }
            }
            return repetido;
        }
       
        private void Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            PantallaVenta agregarProductoPantalla = new PantallaVenta();

            if (e.KeyChar == (char)Keys.Enter)
            {
                MostrarMensaje(this.paquete);
                int cantidad = 0;
                if (!int.TryParse(Cantidad.Text, out cantidad))
                {
                    MessageBox.Show("Debes ingresar un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Codigo.Text.Equals(""))
                {
                    MessageBox.Show("Debes ingresar un código del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
                else 
                {
                    if (checarSoloCodigoOferta(Codigo.Text))
                    {
                        if (CantidadDisponibleOferta(Codigo.Text, int.Parse(Cantidad.Text)))
                        {
                            DTOOfertas oferta = new DAOOfertas().GetOferta(Codigo.Text);
                            Precio_Neto.Text = Convert.ToString(float.Parse(Cantidad.Text) * float.Parse(Precio_Vta_TextBox.Text));
                            if (codigoRepetido(pantalla, Codigo.Text))
                            {

                                foreach (Detalle temp in ListaDeProductosVendidos)
                                {
                                    if (temp.id_producto.Equals(Codigo.Text))
                                    {
                                        temp.cantidad = int.Parse(Cantidad.Text) + temp.cantidad;
                                        temp.total = float.Parse(Precio_Neto.Text) + temp.precio;
                                    }
                                }
                                agregarProductoPantalla.Codigo = Codigo.Text;
                                agregarProductoPantalla.Cantidad = Cantidad.Text;
                                agregarProductoPantalla.Producto = Descripcion.Text;
                                agregarProductoPantalla.Precio = Precio_Neto.Text;
                                pantalla.Add(agregarProductoPantalla);
                                dataGridView1.Columns.Clear();
                                dataGridView1.DataSource = pantalla.ToArray();
                                calculoTotal(pantalla);
                                BajarProductoOfertaCantidad(Codigo.Text, int.Parse(Cantidad.Text));
                                Codigo.Focus();
                            }
                            else
                            {


                                //Busco el precio del producto
                                Productos buscador = new Productos();
                                buscador = new DAOProductos().GetProducts(Codigo.Text);
                                Precio_Vta_TextBox.Text = Convert.ToString(buscador.Precio);
                                Precio_Neto.Text = Convert.ToString(float.Parse(Precio_Vta_TextBox.Text) * float.Parse(Cantidad.Text));
                                //Actualizarlo en lista de productosVendidos
                                foreach (Detalle temp in ListaDeProductosVendidos)
                                {
                                    if (temp.id_producto.Equals(Codigo.Text))
                                    {
                                        temp.cantidad = Convert.ToInt16(Cantidad.Text);
                                        temp.precio = float.Parse(Precio_Neto.Text);
                                    }
                                }
                                //
                                //Modifico el objeto pantalla para que se muestre
                                foreach (PantallaVenta temp in pantalla)
                                {
                                    if (temp.Codigo.Equals(Codigo.Text))
                                    {
                                        temp.Cantidad = Cantidad.Text;
                                        temp.Precio = Precio_Neto.Text;
                                        break;
                                    }
                                }

                                calculoTotal(pantalla);
                                dataGridView1.DataSource = pantalla.ToArray();
                                Codigo.Text = null;
                                Descripcion.Text = null;
                                Precio_Neto.Text = null;
                                Precio_Vta_TextBox.Text = null;
                                Cantidad.Text = null;
                                Codigo.TabIndex = 3;

                                Codigo.Focus();
                            }
                        }
                        else 
                        {
                            MessageBox.Show("No hay cantidad suficiente en el inventario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Codigo.SelectionStart = 0;
                            Codigo.SelectionLength = Codigo.Text.Length;
                            Descripcion.Text = null;
                            Cantidad.Text = null;
                            Precio_Vta_TextBox.Text = null;
                            Precio_Neto.Text = null;
                            Descripcion.Text = null;
                        }
                        
                    }
                    else
                    {
                        if (!CantidadDisponible(Codigo.Text, int.Parse(Cantidad.Text)))
                        {
                            MessageBox.Show("No hay cantidad suficiente en el inventario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Precio_Vta_TextBox.Text = null;
                            Precio_Neto.Text = null;
                            Cantidad.Text = null;
                            Codigo.Text = null;
                            Codigo.Focus();
                        }
                        else
                        {
                            if (Precio_Vta_TextBox.Text.Equals(""))
                            {
                                MessageBox.Show("Pasa el codigo por el escaner o da ENTER en la caja de texto del código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                Precio_Neto.Text = Convert.ToString(float.Parse(Cantidad.Text) * float.Parse(Precio_Vta_TextBox.Text));
                                if (codigoRepetido(pantalla, Codigo.Text))
                                {
                                    
                                    foreach (Detalle temp in ListaDeProductosVendidos)
                                    {
                                        if (temp.id_producto.Equals(Codigo.Text))
                                        {
                                            temp.cantidad = int.Parse(Cantidad.Text) + temp.cantidad;
                                            temp.total = float.Parse(Precio_Neto.Text) + temp.total;
                                        }
                                    }
                                    agregarProductoPantalla.Codigo = Codigo.Text;
                                    agregarProductoPantalla.Cantidad = Cantidad.Text;
                                    agregarProductoPantalla.Producto = Descripcion.Text;
                                    agregarProductoPantalla.Precio = Precio_Neto.Text;
                                    pantalla.Add(agregarProductoPantalla);
                                    dataGridView1.Columns.Clear();
                                    dataGridView1.DataSource = pantalla.ToArray();
                                    calculoTotal(pantalla);
                                    DisminuirInventario(Codigo.Text, int.Parse(Cantidad.Text));
                                    Codigo.Focus();
                                }
                                else
                                {
                                    //Borro textbox
                                    recibido_textbox.Text = null;
                                    Precio_Vta_TextBox.Text = null;
                                    Precio_Neto.Text = null;
                                    Descripcion.Text = null;
                                    //Hago la busqueda del nuevo producto            
                                    dataGridView1.Columns.Clear();
                                    //Busco el precio del producto
                                    Productos buscador = new Productos();
                                    buscador = new DAOProductos().GetProducts(Codigo.Text);
                                    Precio_Vta_TextBox.Text = Convert.ToString(buscador.Precio);
                                    Precio_Neto.Text = Convert.ToString(float.Parse(Precio_Vta_TextBox.Text) * float.Parse(Cantidad.Text));
                                    //Actualizarlo en lista de productosVendidos
                                    foreach (Detalle temp in ListaDeProductosVendidos)
                                    {
                                        if (temp.id_producto.Equals(Codigo.Text))
                                        {
                                            temp.cantidad = Convert.ToInt16(Cantidad.Text);
                                            temp.precio = float.Parse(Precio_Neto.Text);
                                        }
                                    }
                                    //
                                    //Modifico el objeto pantalla para que se muestre
                                    foreach (PantallaVenta temp in pantalla)
                                    {
                                        if (temp.Codigo.Equals(Codigo.Text))
                                        {
                                            temp.Cantidad = Cantidad.Text;
                                            temp.Precio = Precio_Neto.Text;
                                            break;
                                        }
                                    }
                                    DisminuirInventario(Codigo.Text, int.Parse(Cantidad.Text));
                                    calculoTotal(pantalla);
                                    dataGridView1.DataSource = pantalla.ToArray();
                                    Codigo.Text = null;
                                    Descripcion.Text = null;
                                    Precio_Neto.Text = null;
                                    Precio_Vta_TextBox.Text = null;
                                    Cantidad.Text = null;
                                    Codigo.TabIndex = 3;

                                    Codigo.Focus();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarMensaje(this.paquete);
            productosDelInventario = new DAOProductos().GetProducts();
            Descripcion.Enabled = true;
            ventasTotales = new DAOVentas().GetVentas();
            Codigo.Enabled = true;
            recibido_textbox.Enabled = true;
            Cantidad.Enabled = true;
            ventaActual = new Ventas();
            ventaActual.Id = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            ventaActual.Fecha = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(DateTime.Now));
            ventaActual.Hora = string.Format("{0:HH:mm:ss}", Convert.ToDateTime(DateTime.Now)); 
            Codigo.Focus();
            venderToolStripMenuItem.Enabled = true;
        }
     

        private void venderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MostrarMensaje(this.paquete);
            if (Total_Vta_TextBox.Text.Equals(""))
            {
                MessageBox.Show("Debes de registrar una venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                recibido_textbox.Enabled = true;
                recibido_textbox.BackColor = System.Drawing.Color.Red;
                recibido_textbox.Focus();
                agregar_a_credito.Enabled = true;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MostrarMensaje(this.paquete);
            aux=e.RowIndex;
            this.Quitar_producto.Enabled = true;             
            codigoBorrar= this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cantidadBorrar = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void Quitar_producto_Click(object sender, EventArgs e)
        {
            MostrarMensaje(this.paquete);
            this.Codigo.Focus();
            this.Quitar_producto.Enabled = false;
            this.Codigo.Text = null;
            this.Descripcion.Text = null;
            this.Cantidad.Text = null;
            this.Precio_Neto.Text = null;
            this.Precio_Vta_TextBox.Text = null;
            pantalla.RemoveAt(aux);
            dataGridView1.DataSource = pantalla.ToArray();
            Detalle detalle = new Detalle(); 
          
            //Busco y encuentro el numero donde esta guardado dicho codigo
            int cont = 0;
            foreach(Detalle temp in ListaDeProductosVendidos)
            {
                if(temp.id_producto.Equals(codigoBorrar))
                {
                    if (temp.cantidad == cantidadBorrar)
                    {
                        ListaDeProductosVendidos.RemoveAt(cont);
                        break;
                    }
                    else 
                    {
                        temp.cantidad = temp.cantidad - cantidadBorrar;
                        break;
                    }
                }
                cont++;
            }
         
            calculoTotal(pantalla);

            if (checarSoloCodigoOferta(codigoBorrar))
            {
                DTOOfertas oferta = new DAOOfertas().GetOferta(codigoBorrar);
                int cant = oferta.cantidad * cantidadBorrar;
                foreach(Productos prod in productosDelInventario)
                {
                    if(prod.Id.Equals(oferta.codigo))
                    {
                        prod.Cantidad = prod.Cantidad + cant;
                        break;
                    }
                }
            }
            else 
            {
                foreach (Productos temp in productosDelInventario)
                {                    
                    if (temp.Id.Equals(codigoBorrar))
                    {
                        temp.Cantidad = temp.Cantidad + cantidadBorrar;
                        break;
                    }
                }
            }
               
            
            
        }
        private void calculoTotal(List<PantallaVenta> lista) 
        {
            float total = 0;
            foreach(PantallaVenta temp in lista)
            {
                total = float.Parse(temp.Precio)+total;
            }
            Total_Vta_TextBox.Text = Convert.ToString(total);
        }


        private void agregar_a_credito_Click(object sender, EventArgs e)
        {
            MostrarMensaje(this.paquete);
            bool habilitado = false;
            usuarios = new DAOUsuarios().GetUsers();
            if (UsuarioActual.Privilegios.Equals("Administrador"))
            {
                //Precio_Vta_TextBox.Enabled = true;
                habilitado = true;
            }
            else
            {
                string contrasenia = InputDialog.mostrar("Por favor ingrese la contraseña de un administrador", "Advertencia", InputDialog.ACEPTAR_BOTON, InputDialog.MENSAJE_CON_CONTRASENIA);
                bool correcto = false;
                foreach (Usuarios temp in usuarios)
                {
                    if (contrasenia.Equals(temp.Contrasenia) && temp.Privilegios.Equals("Administrador"))
                    {
                        Precio_Vta_TextBox.Enabled = true;
                        correcto = true;
                        habilitado = true;
                        break;
                    }
                }
                if (!correcto)
                {
                    MessageBox.Show("Contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (habilitado)
            {
                if (Total_Vta_TextBox.Text.Equals(""))
                {
                    MessageBox.Show("Debe realizar una venta para dar crédito", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de mandar el importe a un crédito?", "Ventas",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
                    {
                        Agregar_Deuda_Cliente formDeuda = new Agregar_Deuda_Cliente(float.Parse(Total_Vta_TextBox.Text), UsuarioActual,ventaActual.Id);
                        formDeuda.ShowDialog();
                        if (new DAODetalles_credito_cliente().GetDetallesCredito(ventaActual.Id)!=null) 
                        {
                            Codigo.Text = null;
                            Cantidad.Text = null;
                            Precio_Neto.Text = null;
                            foreach (PantallaVenta temp in pantalla)
                            {
                                new DAOProductos().Modifyproductos(temp.Codigo, Convert.ToInt16(temp.Cantidad));
                            }
                            recibido_textbox.Enabled = false;
                            ventaActual.Total = 0;
                            ventaActual.Tipo = "Credito";
                            ventaActual.Usuario = Usuario.Text;

                            foreach (Detalle temp in ListaDeProductosVendidos)
                            {
                                ventaActual.Total = ventaActual.Total + temp.total;
                            }
                            new DAODetalle().InsertDetails(ListaDeProductosVendidos);
                            new DAOVentas().InsertVenta(ventaActual);

                            ListaDeProductosVendidos = null;
                            new DAOImpresion().ImprimirTicket(ventaActual, recibido_textbox.Text, cambio_textbox.Text, pantalla);
                            Codigo.Enabled = false;
                            Descripcion.Enabled = false;
                            Cantidad.Enabled = false;
                            Codigo.Text = null;
                            Cantidad.Text = null;
                            Descripcion.Text = null;
                            Total_Vta_TextBox.Text = null;
                            pantalla = null;
                            Precio_Neto.Text = null;
                            Precio_Vta_TextBox.Text = null;
                            recibido_textbox.Text = null;
                            Total_Vta_TextBox.Text = null;
                            cambio_textbox.Text = null;
                            dataGridView1.DataSource = null;
                            ventasTotales = null;
                            pantalla = new List<PantallaVenta>();
                            ListaDeProductosVendidos = new List<Detalle>();
                            ventasTotales = new List<Ventas>();
                            ventaActual = null;
                            recibido_textbox.BackColor = System.Drawing.Color.White;
                        }
                       
                    }
                }
            }
        }
       
        private void recibido_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < recibido_textbox.Text.Length; i++)
            {
                if (recibido_textbox.Text[i] == '.')
                    IsDec = true;

                if (IsDec && e.KeyChar == '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;

                if (IsDec && nroDec++ >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }

            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                MostrarMensaje(this.paquete);
                float cantidad = 0;
                if (!float.TryParse(recibido_textbox.Text, out cantidad))
                {
                    MessageBox.Show("Debes ingresar un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(float.Parse(Total_Vta_TextBox.Text)>float.Parse(recibido_textbox.Text))
                {
                    MessageBox.Show("Cantidad recibida es menor a la total", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //BAjo productos del verdadero inventario
                    foreach (PantallaVenta temp in pantalla)
                    {
                        if(checarSoloCodigoOferta(temp.Codigo))
                        {
                            DTOOfertas oferta = new DAOOfertas().GetOferta(temp.Codigo);
                            new DAOProductos().Modifyproductos(oferta.codigo,oferta.cantidad);
                        }
                        else
                        {
                            new DAOProductos().Modifyproductos(temp.Codigo, Convert.ToInt16(temp.Cantidad));
                        }
                    }
                    cambio_textbox.Text = Convert.ToString(float.Parse(recibido_textbox.Text) - float.Parse(Total_Vta_TextBox.Text));
                    recibido_textbox.Enabled = false;
                    ventaActual.Total = 0;
                    ventaActual.Tipo = "Efectivo";
                    ventaActual.Usuario = Usuario.Text;
                    
                    foreach (Detalle temp in ListaDeProductosVendidos)
                    {
                        ventaActual.Total = ventaActual.Total + temp.total;
                    }
                    new DAODetalle().InsertDetails(ListaDeProductosVendidos);
                    new DAOVentas().InsertVenta(ventaActual);
                    ListaDeProductosVendidos = null;
                    new DAOImpresion().ImprimirTicket(ventaActual,recibido_textbox.Text,cambio_textbox.Text,pantalla);
                    Codigo.Enabled = false;
                    Descripcion.Enabled = false;
                    Cantidad.Enabled = false;
                    
                    Codigo.Text = null;
                    Cantidad.Text = null;
                    Descripcion.Text = null;
                    Total_Vta_TextBox.Text = null;
                    pantalla = null;
                    Precio_Neto.Text = null;
                    Precio_Vta_TextBox.Text = null;
                    recibido_textbox.Text = null;
                    Total_Vta_TextBox.Text = null;
                    cambio_textbox.Text = null;
                    dataGridView1.DataSource = null;
                    ventasTotales = null;
                    pantalla = new List<PantallaVenta>();
                    ListaDeProductosVendidos = new List<Detalle>();
                    ventasTotales = new List<Ventas>();
                    ventaActual = null;
                    porcentaje_text_box.Text = null;
                    recibido_textbox.BackColor = System.Drawing.Color.White;
                    recibido_textbox.Enabled = false;
                    agregar_a_credito.Enabled = false;
                }
            }
        }

        private void Precio_Vta_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < Precio_Vta_TextBox.Text.Length; i++)
            {
                if (Precio_Vta_TextBox.Text[i] == '.')
                    IsDec = true;

                if (IsDec && e.KeyChar == '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;

                if (IsDec && nroDec++ >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }

            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                MostrarMensaje(this.paquete);
                float cantidad = 0;
                if (!float.TryParse(Precio_Vta_TextBox.Text, out cantidad))
                {
                    MessageBox.Show("Debes ingresar un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Precio_Neto.Text.Equals(""))
                    {
                        MessageBox.Show("Ingresa un producto con escaner o presionando ENTER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        porcentaje_text_box.Text = null;
                        porcentaje_text_box.Enabled = false;
                    }
                    else 
                    {
                        Precio_Neto.Text = Convert.ToString(float.Parse(Cantidad.Text) * float.Parse(Precio_Vta_TextBox.Text));
                        Precio_Vta_TextBox.Enabled = false;
                        //busco producto en la pantalla y ademas en la lista de Detalle

                        string codigoABuscar = Codigo.Text;

                        

                        
                        foreach (Detalle detalle in ListaDeProductosVendidos)
                        {
                            if (codigoABuscar.Equals(detalle.id_producto))
                            {
                                float diferencia = detalle.total- float.Parse(pantalla[pantalla.Count - 1].Precio);

                                detalle.total = diferencia + (float.Parse(Cantidad.Text) * float.Parse(Precio_Vta_TextBox.Text));
                                
                            }
                        }
                        pantalla[pantalla.Count - 1].Cantidad = Cantidad.Text;
                        pantalla[pantalla.Count - 1].Precio = Precio_Neto.Text;
                        calculoTotal(pantalla);
                        dataGridView1.DataSource = pantalla.ToArray();
                        Precio_Vta_TextBox.Enabled = false;
                        recibido_textbox.Enabled = false;
                        agregar_a_credito.Enabled = false;
                    }
                    
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public bool checarOferta(string id)
        {
            bool oferton = false;
           // bool ofertaDetectada = false;
            DTOOfertas oferta = new DAOOfertas().GetOferta(id);
            if (oferta!=null)
            {
                if (CantidadDisponible(oferta.codigo, oferta.cantidad))
                {
                    //this.Cantidad.Text = oferta.cantidad.ToString();
                   // this.Precio_Neto.Text = oferta.precio.ToString();
                    this.Precio_Vta_TextBox.Text = oferta.precio.ToString();
                    this.Descripcion.Text = oferta.descripcion;
                    // this.Codigo.Text = oferta.codigo;
                   
                    oferton = true;
                }
                else 
                {
                    MessageBox.Show("No hay producto disponible o no se ajusta el producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return oferton;
          
        }
        public bool checarSoloCodigoOferta(string id) 
        {
            bool oferton = false;
            DTOOfertas oferta = new DAOOfertas().GetOferta(id);
            if (oferta != null)
            {
                oferton = true;                
            }
            return oferton;
        }
        public void DisminuirInventario(string codigo,int cantidad) 
        {
            foreach(Productos temp in productosDelInventario)
            {
                if(temp.Id.Equals(codigo))
                {
                    temp.Cantidad = temp.Cantidad - cantidad;
                }
            }
        }
        public bool CantidadDisponibleOferta(string codigo, int cantidad) 
        {
            DTOOfertas oferta = new DAOOfertas().GetOferta(codigo);
            int cant = cantidad * oferta.cantidad;
            bool disponible = false;
            foreach(Productos temp in productosDelInventario)
            {
                if(temp.Id.Equals(oferta.codigo))
                {
                    if(temp.Cantidad>=cant)
                    {
                        disponible = true;
                        break;
                    }
                }
            }

            return disponible;
        }
        public bool CantidadDisponible(string codigo,int cantidad) 
        {
            bool disponible = false;
            foreach(Productos temp in productosDelInventario)
            {
                if (codigo.Equals(temp.Id)) 
                {
                    if (temp.Cantidad >= cantidad)
                    {
                        disponible=true;
                        break;
                    }                   
                }
            }
            return disponible;
        }

        private void Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                MostrarMensaje(this.paquete);
                string codigo = Codigo.Text;
                Productos productosInventario = new Productos();
                PantallaVenta agregarProductoPantalla = new PantallaVenta();
                productosInventario = new DAOProductos().GetProducts(codigo);
                if (productosInventario != null)
                {
                    if (checarOferta(Codigo.Text))
                    {
                        if (CantidadDisponibleOferta(Codigo.Text, 1))
                        {
                            DTOOfertas oferta = new DAOOfertas().GetOferta(Codigo.Text);
                            Descripcion.Text = oferta.descripcion;
                            Precio_Vta_TextBox.Text = Convert.ToString(oferta.precio);
                            if (codigoRepetido(pantalla, Codigo.Text))
                            {
                                Cantidad.Text = "1";
                                Precio_Neto.Text = Convert.ToString(float.Parse(Cantidad.Text) * float.Parse(Precio_Vta_TextBox.Text));
                                foreach (Detalle temp in ListaDeProductosVendidos)
                                {
                                    if (temp.id_producto.Equals(Codigo.Text))
                                    {
                                        temp.cantidad = int.Parse(Cantidad.Text) + temp.cantidad;
                                        temp.total = float.Parse(Precio_Neto.Text) + temp.precio;
                                    }
                                }
                                agregarProductoPantalla.Codigo = Codigo.Text;
                                agregarProductoPantalla.Cantidad = Cantidad.Text;
                                agregarProductoPantalla.Producto = Descripcion.Text;
                                agregarProductoPantalla.Precio = Precio_Neto.Text;
                                pantalla.Add(agregarProductoPantalla);
                                dataGridView1.Columns.Clear();
                                dataGridView1.DataSource = pantalla.ToArray();
                                calculoTotal(pantalla);
                                BajarProductoOferta(Codigo.Text);
                                Codigo.SelectionStart = 0;
                                Codigo.SelectionLength = Codigo.Text.Length;
                            }
                            else
                            {
                                Detalle productoVendido = new Detalle();
                                productoVendido.id_venta = ventaActual.Id;
                                
                                Cantidad.Text = "1";
                                Precio_Neto.Text = Convert.ToString(float.Parse(Cantidad.Text) * float.Parse(Precio_Vta_TextBox.Text));
                                agregarProductoPantalla.Codigo = Codigo.Text;
                                agregarProductoPantalla.Cantidad = Cantidad.Text;
                                agregarProductoPantalla.Producto = Descripcion.Text;
                                agregarProductoPantalla.Precio = Precio_Neto.Text;
                                pantalla.Add(agregarProductoPantalla);
                                dataGridView1.DataSource = pantalla.ToArray();
                                productoVendido.id_producto = productosInventario.Id;
                                productoVendido.cantidad = Convert.ToInt32(Cantidad.Text);
                                productoVendido.precio = float.Parse(Precio_Vta_TextBox.Text);
                                productoVendido.total = float.Parse(Precio_Neto.Text);
                                ListaDeProductosVendidos.Add(productoVendido);
                                calculoTotal(pantalla);
                                //Bajamos el inventario tomando en cuenta que es uuna oferta
                                BajarProductoOferta(Codigo.Text);
                                Codigo.SelectionStart = 0;
                                Codigo.SelectionLength = Codigo.Text.Length;
                            }
                        }
                        else 
                        {
                            MessageBox.Show("El producto agotado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Codigo.SelectionStart = 0;
                            Codigo.SelectionLength = Codigo.Text.Length;
                            Descripcion.Text = null;
                            Cantidad.Text = null;
                            Precio_Vta_TextBox.Text = null;
                            Precio_Neto.Text = null;
                            Descripcion.Text = null;
                            porcentaje_text_box.Text = null;
                        }
                    }
                    else
                    {
                        int cantidadEvaluar = 0;                                               
                        Cantidad.Text = "1";
                        cantidadEvaluar = int.Parse(Cantidad.Text);
                        
                        if (CantidadDisponible(Codigo.Text, cantidadEvaluar))
                        {
                            if (codigoRepetido(pantalla, Codigo.Text))
                            {                                
                                Descripcion.Text = productosInventario.Nombre;                               
                                Precio_Vta_TextBox.Text = productosInventario.Precio.ToString();
                                Precio_Neto.Text = Convert.ToString(float.Parse(Cantidad.Text) * float.Parse(Precio_Vta_TextBox.Text));
                                foreach (Detalle temp in ListaDeProductosVendidos)
                                {
                                    if (temp.id_producto.Equals(Codigo.Text))
                                    {
                                        temp.cantidad = int.Parse(Cantidad.Text) + temp.cantidad;
                                        temp.total = float.Parse(Precio_Neto.Text) + temp.total;
                                        
                                    }
                                }
                                agregarProductoPantalla.Codigo = Codigo.Text;
                                agregarProductoPantalla.Cantidad = Cantidad.Text;
                                agregarProductoPantalla.Producto = Descripcion.Text;
                                agregarProductoPantalla.Precio = Precio_Neto.Text;
                                pantalla.Add(agregarProductoPantalla);
                                dataGridView1.Columns.Clear();
                                dataGridView1.DataSource = pantalla.ToArray();
                                calculoTotal(pantalla);
                                DisminuirInventario(Codigo.Text, int.Parse(Cantidad.Text));
                                Codigo.SelectionStart = 0;
                                Codigo.SelectionLength = Codigo.Text.Length;
                            }
                            else
                            {
                                    Detalle productoVendido = new Detalle();
                                    productoVendido.id_venta = ventaActual.Id;                              
                                    Descripcion.Text = null;
                                    Precio_Neto.Text = null;
                                    Precio_Vta_TextBox.Text = null;
                                    Cantidad.Text = null;
                                    porcentaje_text_box.Text = null;
                                    Descripcion.AppendText(productosInventario.Nombre);
                                    Precio_Vta_TextBox.AppendText(Convert.ToString(productosInventario.Precio));
                                    Precio_Neto.AppendText(Convert.ToString(productosInventario.Precio));
                                    Cantidad.Text = "1";                               
                                    agregarProductoPantalla.Codigo = Codigo.Text;
                                    agregarProductoPantalla.Cantidad = Cantidad.Text;
                                    agregarProductoPantalla.Producto = Descripcion.Text;
                                    agregarProductoPantalla.Precio = Precio_Neto.Text;
                                    pantalla.Add(agregarProductoPantalla);
                                    dataGridView1.DataSource = pantalla.ToArray();
                                    productoVendido.id_producto = productosInventario.Id;
                                    productoVendido.cantidad = Convert.ToInt32(Cantidad.Text);
                                    productoVendido.precio = float.Parse(Precio_Vta_TextBox.Text);
                                    productoVendido.total = float.Parse(Precio_Neto.Text);
                                    ListaDeProductosVendidos.Add(productoVendido);
                                    Cantidad.TabIndex = 2;
                                    calculoTotal(pantalla);
                                    DisminuirInventario(Codigo.Text, int.Parse(Cantidad.Text));
                                    Codigo.SelectionStart = 0;
                                    Codigo.SelectionLength = Codigo.Text.Length;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El producto agotado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Codigo.SelectionStart = 0;
                            Codigo.SelectionLength = Codigo.Text.Length;
                            Descripcion.Text = null;
                            Cantidad.Text = null;
                            Precio_Vta_TextBox.Text = null;
                            Precio_Neto.Text = null;
                            Descripcion.Text = null;
                            porcentaje_text_box.Text = null;
                        }
                    }
                   
                }

                else
                {
                    MessageBox.Show("El producto no se encuentra en el inventario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Codigo.SelectionStart = 0;
                    Codigo.SelectionLength = Codigo.Text.Length;
                    Descripcion.Text = null;
                    Cantidad.Text = null;
                    Precio_Vta_TextBox.Text = null;
                    Precio_Neto.Text = null;
                    Descripcion.Text = null;
                    porcentaje_text_box.Text = null;
                }
            }
        }
        public void BajarProductoOferta(string codigoOferta) 
        {
            DTOOfertas oferta = new DAOOfertas().GetOferta(codigoOferta);
            DisminuirInventario(oferta.codigo,oferta.cantidad);
        }
        public void BajarProductoOfertaCantidad(string codigoOferta, int cantidad) 
        {
            DTOOfertas oferta = new DAOOfertas().GetOferta(codigoOferta);
            int cantidadQuitar = cantidad * oferta.cantidad;
            DisminuirInventario(oferta.codigo,cantidadQuitar);
        }
        private void devoluciones_button_Click(object sender, EventArgs e)
        {
            if (Codigo.Enabled)
            {
                MostrarMensaje(this.paquete);
                MessageBox.Show("Debe de cerrar la venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MostrarMensaje(this.paquete);
                if (MessageBox.Show("¿Desea hacer devolución por busqueda de ticket? (Recomendado)", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    devolucion_por_ticket_form devticket = new devolucion_por_ticket_form(UsuarioActual);
                    devticket.ShowDialog();
                    productosDelInventario = new DAOProductos().GetProducts();
                }
                else 
                {
                    devoluciones_form dev = new devoluciones_form(UsuarioActual);
                    dev.ShowDialog();
                    productosDelInventario = new DAOProductos().GetProducts();
                }
                
            }
        }

       

        private void Ventas_Form_Activated(object sender, EventArgs e)
        {
            actualizarProductos();
        }

        private void Descripcion_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                MostrarMensaje(this.paquete);
                productosDelInventario = new DAOProductos().GetProducts();
                
                    string nombre = Descripcion.Text;
                    // Productos prod = new DAOProductos().GetProduct(nombre);
                    foreach (Productos temp in productosDelInventario)
                    {
                        if (temp.Nombre.Equals(nombre))
                        {
                            Codigo.Text = temp.Id;
                            Codigo.Focus();
                            break;
                        }
                    }


                
            }
        }

        public void MostrarMensaje(Paquetes paquete) 
        {
            paquete = new DAOPaquetes().GetPaqueteActivado();
            if(paquete==null)
            {
                Random random = new Random();
                int x = random.Next(0,20);
                if(x==1)
                {
                    //Mostramos mensaje para adquirir paquete
                    Comercial_form comercial = new Comercial_form();
                    comercial.ShowDialog();
                }
                else if(x==2)
                {
                    Comercial2_form comercial = new Comercial2_form();
                    comercial.ShowDialog();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void porcentaje_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < porcentaje_text_box.Text.Length; i++)
            {
                if (porcentaje_text_box.Text[i] == '.')
                    IsDec = true;

                if (IsDec && e.KeyChar == '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;

                if (IsDec && nroDec++ >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }

            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                MostrarMensaje(this.paquete);
                float cantidad = 0;
                if (!float.TryParse(porcentaje_text_box.Text, out cantidad))
                {
                    MessageBox.Show("Debe ingresar un número.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Precio_Neto.Text.Equals(""))
                    {
                        MessageBox.Show("Ingrese un producto con escaner o presionando ENTER.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        porcentaje_text_box.Text = null;
                        porcentaje_text_box.Enabled = false;
                    }
                    else
                    {
                        float descuento = float.Parse(porcentaje_text_box.Text) / 100;
                        Precio_Vta_TextBox.Text = Convert.ToString(float.Parse(Precio_Vta_TextBox.Text) - (float.Parse(Precio_Vta_TextBox.Text) * descuento));
                        Precio_Neto.Text = Convert.ToString(float.Parse(Cantidad.Text) * float.Parse(Precio_Vta_TextBox.Text));
                        porcentaje_text_box.Enabled = false;
                        //busco producto en la pantalla y ademas en la lista de Detalle

                        string codigoABuscar = Codigo.Text;



                        foreach (Detalle detalle in ListaDeProductosVendidos)
                        {
                            if (codigoABuscar.Equals(detalle.id_producto))
                            {
                                float diferencia = detalle.total - float.Parse(pantalla[pantalla.Count - 1].Precio);

                                detalle.total = diferencia + (float.Parse(Cantidad.Text) * float.Parse(Precio_Vta_TextBox.Text));

                            }
                        }
                        pantalla[pantalla.Count - 1].Cantidad = Cantidad.Text;
                        pantalla[pantalla.Count - 1].Precio = Precio_Neto.Text;
                        calculoTotal(pantalla);
                       
                        dataGridView1.DataSource = pantalla.ToArray();
                        porcentaje_text_box.Enabled = false;
                    }
                    
                }
            }
        }

        private void cancelar_venta_button_Click(object sender, EventArgs e)
        {
            if(Codigo.Enabled && pantalla.Count!=0)
            {
                if (MessageBox.Show("¿Está seguro de cancelar la venta?", "Alerta",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                   == DialogResult.Yes) 
                {
                    Codigo.Enabled = false;
                    Descripcion.Enabled = false;
                    Cantidad.Enabled = false;
                    Codigo.Text = null;
                    Cantidad.Text = null;
                    Descripcion.Text = null;
                    Total_Vta_TextBox.Text = null;
                    pantalla = null;
                    Precio_Neto.Text = null;
                    Precio_Vta_TextBox.Text = null;
                    recibido_textbox.Text = null;
                    Total_Vta_TextBox.Text = null;
                    cambio_textbox.Text = null;
                    dataGridView1.DataSource = null;
                    ventasTotales = null;
                    pantalla = new List<PantallaVenta>();
                    ListaDeProductosVendidos = new List<Detalle>();
                    ventasTotales = new List<Ventas>();
                    ventaActual = null;
                    porcentaje_text_box.Text = null;
                    recibido_textbox.BackColor = System.Drawing.Color.White;
                }
                
            }
            else if(Codigo.Enabled && pantalla.Count==0)
            {
                Codigo.Enabled = false;
                Descripcion.Enabled = false;
                Cantidad.Enabled = false;
                Codigo.Text = null;
                Cantidad.Text = null;
                Descripcion.Text = null;
                Total_Vta_TextBox.Text = null;
                pantalla = null;
                Precio_Neto.Text = null;
                Precio_Vta_TextBox.Text = null;
                recibido_textbox.Text = null;
                Total_Vta_TextBox.Text = null;
                cambio_textbox.Text = null;
                dataGridView1.DataSource = null;
                ventasTotales = null;
                pantalla = new List<PantallaVenta>();
                ListaDeProductosVendidos = new List<Detalle>();
                ventasTotales = new List<Ventas>();
                ventaActual = null;
                porcentaje_text_box.Text = null;
                recibido_textbox.BackColor = System.Drawing.Color.White;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void descuento_button_Click(object sender, EventArgs e)
        {
           
           
            if (!Precio_Vta_TextBox.Text.Equals(""))
            {
                if (UsuarioActual.Privilegios.Equals("Administrador"))
                {
                        porcentaje_text_box.Enabled = true;
                        porcentaje_text_box.Focus();
                        porcentaje_text_box.SelectionStart = 0;
                        porcentaje_text_box.SelectionLength = porcentaje_text_box.Text.Length;
                }
                    
                else
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            porcentaje_text_box.Enabled = true;
                            porcentaje_text_box.Focus();
                            porcentaje_text_box.SelectionStart = 0;
                            porcentaje_text_box.SelectionLength = porcentaje_text_box.Text.Length;
                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("Debes ingresar un código del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Codigo_Enter(object sender, EventArgs e)
        {
            Remarcar();
        }

        public void Remarcar() 
        {
            Codigo.Focus();
            Codigo.SelectionStart = 0;
            Codigo.SelectionLength = Codigo.Text.Length;
        }

        private void Codigo_MouseClick(object sender, MouseEventArgs e)
        {
            Remarcar();
        }

        private void Ventas_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dataGridView1.DataSource!=null)
            {
                if (MessageBox.Show("Aún no cierra la venta ¿Está seguro de cerrar la ventana?", "Alerta",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                  == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else 
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PantallaVenta temp = pantalla.ElementAt(aux);
            modificar_producto_venta_form ventana = new modificar_producto_venta_form(UsuarioActual,temp);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                if (ObjetosPantallaIgual(temp,ventana.producto))
                {
                   
                    string codigoABuscar = temp.Codigo;
                    foreach (Detalle detalle in ListaDeProductosVendidos)
                    {
                        if (codigoABuscar.Equals(detalle.id_producto))
                        {
                            float diferencia = detalle.total - float.Parse(pantalla.ElementAt(aux).Precio);

                            detalle.total = diferencia + float.Parse(ventana.producto.Precio);
                            
                            detalle.cantidad = detalle.cantidad - int.Parse(pantalla.ElementAt(aux).Cantidad);
                            detalle.cantidad = detalle.cantidad + int.Parse(ventana.producto.Cantidad);

                        }
                    }
                    pantalla.ElementAt(aux).Cantidad = ventana.producto.Cantidad;
                    pantalla.ElementAt(aux).Precio = ventana.producto.Precio;
                    dataGridView1.DataSource = pantalla.ToArray();
                    calculoTotal(pantalla);
                    Quitar_producto.Enabled = false;
                }
            }
            
        }
        public bool ObjetosPantallaIgual(PantallaVenta Objeto,PantallaVenta ObjetoEnviado) 
        {
            bool igual = false;
            if (!Objeto.Precio.Equals(ObjetoEnviado.Precio))
            {
                igual = true;
            }
            else if(!Objeto.Cantidad.Equals(ObjetoEnviado.Precio))
            {
                igual = true;
            }
            return igual;
        }

        
        
    }
}

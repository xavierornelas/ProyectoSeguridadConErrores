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
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Compras_form : Form
    {
        Productos productoGlobal = new Productos();
        Usuarios usuarioActual = new Usuarios();
        List<Productos> productos = null;
        List<Proveedores> proveedores = new DAOProveedores().GetProvider();
        //int posicion = 0;
        Paquetes paquete = new Paquetes();
        Ventas_Form mensaje = new Ventas_Form();
        Compras compra = new Compras();
        List<PantallaCompras> pantallita = new List<PantallaCompras>();
        Proveedores prov = new Proveedores();
        int aux = 0;

        public Compras_form(Usuarios usuario, Paquetes paquete)
        {
            InitializeComponent();
            usuarioActual = usuario;
            productos = new DAOProductos().GetProducts();
            dataGridView1.DataSource = productos.ToArray();
            actualizaCombo();
            this.paquete = paquete;
        }

        public Compras_form() { }

        private void agregar_button_Click(object sender, EventArgs e)
        {
           /* this.panel1.Enabled = true;
            this.button3.Enabled = true;
            this.comboBox1.Enabled = true;
            this.button2.Enabled = true;
            this.Codigo_textbox.Enabled = true;
            this.precio_textbox.Enabled = true;
            this.Cantidad_textbox.Enabled = true;
            this.descripcion_textbox.Enabled = true;
            this.guardar_cambios_button.Enabled = true;*/
        }

        private void modificar_button_Click(object sender, EventArgs e)
        {
            mensaje.MostrarMensaje(this.paquete);
          /*  
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Productos cust = row.DataBoundItem as Productos;
                if (cust != null)
                {
                    Codigo_textbox.Text = Convert.ToString(cust.Id);
                    descripcion_textbox.Text = cust.Nombre;
                    Cantidad_textbox.Text = Convert.ToString(cust.Cantidad);
                    precio_textbox.Text = Convert.ToString(cust.Precio);
                    productoGlobal = cust;
                }
            }
            realizar_compras_button.Enabled = true;*/
        }

        public void actualizaDGV()
        {
            dataGridView1.DataSource = pantallita.ToArray();
        }

       /* private List<PantallaCompras> JuntarProductos(List<PantallaCompras> lista) 
        {
            List<PantallaCompras> NuevaLista = new List<PantallaCompras>();
            foreach()
            {
            }
        }*/
       
        private void guardar_cambios_button_Click(object sender, EventArgs e)
        {
            Detalle_compra detalle = new Detalle_compra();
            compra.tipo = "Contado";
            compra.total = ObtenerTotalCompra(pantallita);
            compra.usuario = usuarioActual.Nombre;

            InsertarCompra(compra);
            //Agrego los detalles
            InsertarDetallesCompras(pantallita);
            ActualizarInventario(pantallita);
            //Imprimir todo
            new DAOImpresion().ImprimirTicketCompra(compra, pantallita);
            //Instancio de nuevo compra
            BotonesDeCompra();
            BorrarTodo();
            InstanciarObjetos();
            venderToolStripMenuItem.Enabled = false;
            eliminar_button.Enabled = false;
        }
        public void BotonesDeCompra() 
        {
            realizar_compras_button.Enabled = false;
            agregar_button.Enabled = false;
            credito_button.Enabled = false;
            total_textBox.Text = null;
            total_textBox.BackColor = Color.White;
        }
        public void InstanciarObjetos() 
        {
            dataGridView1.DataSource = null;
            pantallita = new List<PantallaCompras>();
            compra = new Compras();
        }
        public void InsertarDetallesCompras(List<PantallaCompras>lista) 
        {
            foreach(PantallaCompras obj in lista)
            {
                Detalle_compra temp = new Detalle_compra();
                temp.id_compra = compra.id_compra;
                temp.id_producto = obj.Codigo;
                temp.id_proveedor = ObtenerIdProveedor(proveedores,obj.proveedor);
                temp.precio = float.Parse(precio_textbox.Text);
                temp.total = obj.precio;
                temp.cantidad = obj.cantidad;
                new DAODetalle_compra().InsertDetalle_Compra(temp);
            }
        }

        public void ActualizarInventario(List<PantallaCompras> productos)
        {
            foreach(PantallaCompras temp in productos)
            {
                Productos prod = new Productos();
                prod.Id = temp.Codigo;
                prod.Cantidad = temp.cantidad;
                prod.Nombre = GetProductoNombre(temp.Codigo);
                prod.Precio = temp.precio;

                new DAOProductos().Modifyproductos(prod);
            }
        }

        public string GetProductoNombre(string id)
        {
            List<Productos> prod = new DAOProductos().GetProducts();

            foreach(Productos temp in prod)
            {
                if (temp.Id.Equals(id))
                    return temp.Nombre;
            }

            return "";
        }
        public int ObtenerIdProveedor(List<Proveedores>lista,string proveedor) 
        {
            int id=0;
            foreach(Proveedores temp in lista)
            {
                if (temp.Nombre.Equals(proveedor)) 
                {
                    id = temp.Id;
                }
            }
            return id;
        }
        public void InsertarCompra(Compras obj) 
        {
            new DAOCompras().InsertCompra(obj);
        }
        public float ObtenerTotalCompra(List<PantallaCompras> lista) 
        {
            float resultado = 0;
            foreach(PantallaCompras temp in lista)
            {
                resultado = resultado + temp.precio;
            }
            return resultado;
        }
        public void BorrarCajasTexto() 
        {
            Codigo_textbox.Text = null;
            descripcion_textbox.Text = null;
            precio_textbox.Text = null;
            precio_vta_textBox.Text = null;
            Cantidad_textbox.Text = null;
            costo_total_textbox.Text = null;
            total_textBox.Text = null;
        }
       public void FocusProveedor()
       {
           if (proveedores.Count == 0)
           {
               nuevo_proveedor_button.Focus();
           }
           else 
           {
               comboBox1.Focus();
           }
       }
        private void Codigo_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Productos producto = new DAOProductos().GetProducts(new Validaciones().LimpiarString(Codigo_textbox.Text));
               
                    if (producto != null)
                    {
                        if (new DAOOfertas().GetOferta(producto.Id) == null)
                        {
                            BorrarCajasTexto();
                            Codigo_textbox.Text = producto.Id;
                            descripcion_textbox.Text = producto.Nombre;
                            precio_vta_textBox.Text = Convert.ToString(producto.Precio);
                            FocusProveedor();
                        }
                        else
                        {
                            MessageBox.Show("El código ingresado pertenece a una oferta, no puede utilizarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            remarcarCodigo();
                        }
                      
                    }
                    else
                    {
                        if (MessageBox.Show("El producto no se encuentra en el inventario, se abrirá una ventana para su registro.", "Nuevo producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {
                            NuevoProducto_Form frmNewProd = new NuevoProducto_Form(this.Codigo_textbox.Text);
                            frmNewProd.FormClosing += new FormClosingEventHandler(actualizar_textBox);
                            frmNewProd.ShowDialog();
                            FocusProveedor();
                        }
                        else
                        {
                            BorrarCajasTexto();
                        }

                    }
                  
               
               
            }
        }
        public void BorrarTodo() 
        {
            Codigo_textbox.Text = null;
            Codigo_textbox.Enabled = false;
            Cantidad_textbox.Text = null;
            Cantidad_textbox.Enabled = false;
            precio_textbox.Text = null;
            precio_textbox.Enabled = false;
            descripcion_textbox.Text = null;
            descripcion_textbox.Enabled = false;
            nuevo_proveedor_button.Enabled = false;
            comboBox1.Enabled = false;
            cambiar_precio_vta_button.Enabled = false;
            costo_total_textbox.Text = null;
            precio_vta_textBox.Text = null;
            comboBox1.SelectedText = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
           /* productos = new DAOProductos().GetProducts();
            this.Codigo_textbox.Text = productos[productos.Count - 1].Id;
            this.precio_textbox.Text = productos[productos.Count - 1].Precio.ToString();
            this.descripcion_textbox.Text = productos[productos.Count - 1].Nombre;
            actualizaCombo();*/
        }

        public void actualizaCombo()
        {
            this.comboBox1.Items.Clear();
            proveedores = new DAOProveedores().GetProvider();
            foreach (Proveedores p in proveedores)
            {
                //this.comboBox1.Items.Add(p.Id.ToString() + " " + p.Nombre);
                this.comboBox1.Items.Add(p.Nombre);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mensaje.MostrarMensaje(this.paquete);
            Nuevo_proveedor frmNewProv = new Nuevo_proveedor();
            frmNewProv.FormClosing += new FormClosingEventHandler(frmNewProv_Closing);
            frmNewProv.ShowDialog();
            Cantidad_textbox.Focus();
        }

        private void frmNewProv_Closing(object sender, EventArgs e)
        {
            actualizaCombo();
            this.comboBox1.SelectedIndex = this.comboBox1.Items.Count - 1;
            Cantidad_textbox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea mandar estos productos al crédito de cada proveedor? Si desea mandar solamente un solo producto debe terminar la compra y hacer una nueva.", "Compras",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
               == DialogResult.Yes)            
            {
                Detalle_compra detalle = new Detalle_compra();
                compra.tipo = "Crédito";
                compra.total = ObtenerTotalCompra(pantallita);
                compra.usuario = usuarioActual.Nombre;
                InsertarCompra(compra);
                ActualizarInventario(pantallita);
                InsertarDetallesCompras(pantallita);
                //Agregar a creditos
                //Crear funcion para agregar el credito
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++) 
                {
                    Proveedores temp = null;
                    
                    temp = new DAOProveedores().GetProvider(this.dataGridView1.Rows[i].Cells[4].Value.ToString());
                    ProveedoresDeudas deuda = new DAOProveedores().SeleccionarDeudaProveedor(temp.Id);
                    float resultado = deuda.Deuda + float.Parse(this.dataGridView1.Rows[i].Cells[3].Value.ToString());
                    new DAOProveedores().ModifyDeuda(new ProveedoresDeudas(temp.Id, temp.Nombre, resultado));
                }
                //Imprimir todo
                new DAOImpresion().ImprimirTicketCompra(compra, pantallita);
                //Instancio de nuevo compra
                BotonesDeCompra();
                BorrarTodo();
                InstanciarObjetos();
                eliminar_button.Enabled = false;

            }
        }
        public void AgregarCreditoProveedores() 
        {
        }
        public void InsertarDetalleCompra(Detalle_compra detallecompra) 
        {
            new DAODetalle_compra().InsertDetalle_Compra(detallecompra);
        }
        public void BorrarDetalleCompraBD() 
        {
            //new DAODetalle_compra().
        }

        public void actualizar_textBox(object sender, EventArgs e)
        {
           List<Productos> temp = new DAOProductos().GetProducts(); 
             
            if(temp.Count>productos.Count)
            {
                BorrarCajasTexto();
                this.Codigo_textbox.Text = temp[temp.Count - 1].Id;
                this.descripcion_textbox.Text = temp[temp.Count - 1].Nombre;
                this.precio_vta_textBox.Text = temp[temp.Count - 1].Precio.ToString();
                FocusProveedor();
            }

           
        }

        private void Compras_form_Load(object sender, EventArgs e)
        {
            Codigo_textbox.Focus();
            dataGridView1.DataSource = null;
           // productos = new DAOProductos().GetProducts();
            //dataGridView1.DataSource = productos.ToArray();
            //actualizaDGV();
        }

        private void actualizaInventario(string id, int cant)
        {
            Productos prod = new DAOProductos().GetProducts(id);
            prod.Cantidad = prod.Cantidad + cant;

            new DAOProductos().Modifyproductos(prod);
        }

        private void Codigo_textbox_Leave(object sender, EventArgs e)
        {
           
        }

        private void Cantidad_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        )
            {
                e.Handled = true;
            }

            if ((char)e.KeyChar == '\'' || (char)e.KeyChar == '\"')
            {
                e.Handled = true;
            }
        }

        private void precio_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) 
                && e.KeyChar != '.'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < precio_textbox.Text.Length; i++)
            {
                if (precio_textbox.Text[i] == '.')
                    IsDec = true;

                if (IsDec && e.KeyChar == '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;

                if (IsDec && nroDec++ >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    
                }

            }

           /* if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;*/
            if (e.KeyChar == (char)Keys.Enter)
            {
                int cantidad = 0;
                    float precio = 0;
                    if(Codigo_textbox.Text.Equals(null)||Cantidad_textbox.Text.Equals(null)||precio_textbox.Text.Equals(null)||comboBox1.Text.Equals(null))
                    {
                        new Mensajes().DebeLlenarTodosLosCampos(); Codigo_textbox.Focus();
                        Codigo_textbox.SelectionStart = 0;
                        Codigo_textbox.SelectionLength = Codigo_textbox.Text.Length;
                    }
                    else if(new DAOProductos().GetProducts(new Validaciones().LimpiarString(Codigo_textbox.Text))==null)
                    {
                       MessageBox.Show("El producto no existe, debe registrarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       Codigo_textbox.Focus();
                       Codigo_textbox.SelectionStart = 0;
                       Codigo_textbox.SelectionLength = Codigo_textbox.Text.Length;
                    }
                    else if (!int.TryParse(Cantidad_textbox.Text, out cantidad))
                    {
                        MessageBox.Show("Debe ingresar un número entero en el campo cantidad.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cantidad_textbox.Focus();
                        Cantidad_textbox.SelectionStart = 0;
                        Cantidad_textbox.SelectionLength = Cantidad_textbox.Text.Length;
                    }
                    else if(!float.TryParse(precio_textbox.Text, out precio))
                    {
                        MessageBox.Show("Debe ingresar un número en el campo precio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        precio_textbox.Focus();
                        precio_textbox.SelectionStart = 0;
                        precio_textbox.SelectionLength = precio_textbox.Text.Length;
                    }          
                    else
                    {
                        float resultado = float.Parse(Cantidad_textbox.Text) * float.Parse(precio_textbox.Text);
                        costo_total_textbox.Text = (float.Parse(Cantidad_textbox.Text) * float.Parse(precio_textbox.Text)).ToString();
                        PantallaCompras temp = new PantallaCompras();
                        temp.Codigo = Codigo_textbox.Text;
                        temp.Producto = descripcion_textbox.Text;
                        temp.proveedor = comboBox1.Text;
                        temp.cantidad = int.Parse(Cantidad_textbox.Text);
                        temp.precio = float.Parse(costo_total_textbox.Text);
                        temp.proveedor = comboBox1.Text;
                        AgregarPantalla(temp);
                       /* pantallita.Add(temp);
                        dataGridView1.Columns.Clear();
                        dataGridView1.DataSource = pantallita.ToArray();
                        actualizaDGV();
                        remarcarCodigo();*/
                    }
                 
            }
        }
        public void remarcarCodigo() 
        {
            Codigo_textbox.Focus();
            Codigo_textbox.SelectionStart = 0;
            Codigo_textbox.SelectionLength = Codigo_textbox.Text.Length;
        }
        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compra.id_compra = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            compra.fecha = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(DateTime.Now));
            compra.hora = string.Format("{0:HH:mm:ss}", Convert.ToDateTime(DateTime.Now)); 
            NuevaCompra();
            productos = new DAOProductos().GetProducts();
            venderToolStripMenuItem.Enabled = true;
            cancelarCompraActualToolStripMenuItem.Enabled = true;
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VerificarCompras())
            {
                realizar_compras_button.Enabled = true;
                credito_button.Enabled = true;
                realizar_compras_button.Focus();               
                total_textBox.BackColor = Color.Red;
                total_textBox.Text = Convert.ToString(ObtenerTotalCompra(pantallita));
            }
            else 
            {
                MessageBox.Show("No hay nada comprado, debe registrar una compra.", "Sin compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public bool VerificarCompras() 
        {
            bool bandera = false;
            if(pantallita.Count!=0)
            {
                bandera = true;
            }
            return bandera;
        }
        public void NuevaCompra() 
        {
            Codigo_textbox.Text = null;
            Codigo_textbox.Enabled = true;
            Cantidad_textbox.Text = null;
            Cantidad_textbox.Enabled = true;
            precio_textbox.Text = null;
            precio_textbox.Enabled = true;
            descripcion_textbox.Text = null;
            descripcion_textbox.Enabled = false;
            nuevo_proveedor_button.Enabled = true;
            comboBox1.Enabled = true;
            Codigo_textbox.Focus();
            cambiar_precio_vta_button.Enabled = true;
            agregar_button.Enabled = true;
        }
        public void actualizar_precio_venta(object sender, EventArgs e) 
        {
            Productos prod = new Productos();
            prod = new DAOProductos().GetProducts(Codigo_textbox.Text);
            precio_vta_textBox.Text = Convert.ToString(prod.Precio);
        }
        private void cambiar_precio_vta_button_Click(object sender, EventArgs e)
        {
            //Falta actualizar el precio de venta en caso de que haya cambiado
            string codigo=new DAOProductos().GetProducts(Codigo_textbox.Text).Nombre;
            if (!codigo.Equals(null))
            {
                Cambiar_precio_venta_form form = new Cambiar_precio_venta_form(new DAOProductos().GetProducts(Codigo_textbox.Text));
                form.FormClosing += new FormClosingEventHandler(actualizar_precio_venta);
                form.ShowDialog();
                FocusProveedor();
            }
            else 
            {
                MessageBox.Show("El producto no existe, debe registrarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        public void actualizar_nuevo_precio(object sender, EventArgs e) 
        {
            List<Productos> temp = new List<Productos>();

            if (BuscarEnListaProducto(Codigo_textbox.Text).Precio!=float.Parse(precio_textbox.Text))
            {
                precio_vta_textBox.Text = BuscarEnListaProducto(Codigo_textbox.Text).Precio.ToString();
            }
        }
        public Productos BuscarEnListaProducto(string codigo) 
        {
            Productos producto=null;
            producto = new DAOProductos().GetProducts(codigo);
            return producto;
        }
        private void agregar_button_Click_1(object sender, EventArgs e)
        {
            int cantidad = 0;
            float precio = 0;
            if (Codigo_textbox.Text.Equals(null) || Cantidad_textbox.Text.Equals(null) || precio_textbox.Text.Equals(null) || comboBox1.Text.Equals(null))
            {
                new Mensajes().DebeLlenarTodosLosCampos(); 
                Codigo_textbox.Focus();
                Codigo_textbox.SelectionStart = 0;
                Codigo_textbox.SelectionLength = Codigo_textbox.Text.Length;
            }
            else if (new DAOProductos().GetProducts(new Validaciones().LimpiarString(Codigo_textbox.Text)) == null)
            {
                MessageBox.Show("El producto no existe, debe registrarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Codigo_textbox.Focus();
                Codigo_textbox.SelectionStart = 0;
                Codigo_textbox.SelectionLength = Codigo_textbox.Text.Length;
            }
            else if (!int.TryParse(Cantidad_textbox.Text, out cantidad))
            {
                MessageBox.Show("Debe ingresar un número entero en el campo cantidad.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                Cantidad_textbox.SelectionStart = 0;
                Cantidad_textbox.SelectionLength = Cantidad_textbox.Text.Length;
            }
            else if (!float.TryParse(precio_textbox.Text, out precio))
            {
                MessageBox.Show("Debe ingresar un número en el campo precio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                precio_textbox.Focus();
                precio_textbox.SelectionStart = 0;
                precio_textbox.SelectionLength = precio_textbox.Text.Length;
            }
            else
            {
                float resultado = float.Parse(Cantidad_textbox.Text) * float.Parse(precio_textbox.Text);
                costo_total_textbox.Text = Convert.ToString(resultado);
                PantallaCompras temp = new PantallaCompras();
                temp.Codigo = Codigo_textbox.Text;
                temp.Producto = descripcion_textbox.Text;
                temp.proveedor = comboBox1.Text;
                temp.cantidad = int.Parse(Cantidad_textbox.Text);
                temp.precio = float.Parse(costo_total_textbox.Text);
                temp.proveedor = comboBox1.Text;
                AgregarPantalla(temp);
                /*pantallita.Add(temp);
                dataGridView1.Columns.Clear();
                actualizaDGV();                
                remarcarCodigo();*/
               
            }
          
        }


        private void AgregarPantalla(PantallaCompras comp) 
        {

            if (!repetido(comp))
            {
                pantallita.Add(comp);
                dataGridView1.Columns.Clear();
                actualizaDGV();
                remarcarCodigo();
            }
            else 
            {
                dataGridView1.Columns.Clear();
                actualizaDGV();
                remarcarCodigo();
            }
            
        }
        private bool repetido(PantallaCompras producto) 
        {
            bool repetido = false;
            foreach(PantallaCompras temp in pantallita)
            {
                if(temp.Codigo.Equals(producto.Codigo)&&temp.proveedor.Equals(producto.proveedor))
                {
                    temp.cantidad = producto.cantidad + temp.cantidad;
                    temp.precio = temp.precio + producto.precio;
                    repetido = true;
                    break;
                }
            }
            return repetido;
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            aux = e.RowIndex;
            eliminar_button.Enabled = true;
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de quitar el producto de la lista de compra?", "Compras",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                EliminarItemPantalla(aux);
                eliminar_button.Enabled = false;
                remarcarCodigo();
            }
            else 
            {
                eliminar_button.Enabled = false;
            }
            
        }
        public void EliminarItemPantalla(int fila)
        {
            pantallita.RemoveAt(fila);
            dataGridView1.DataSource = pantallita.ToArray();
           
        }

        private void Compras_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                if (MessageBox.Show("Aún no cierra la compra ¿Está seguro de cerrar la ventana?", "Alerta",
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

        private void Compras_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = null;
            pantallita = new List<PantallaCompras>();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            eliminar_button.Enabled = true;
        }

        private void cancelarCompraActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarTodo();
            pantallita = new List<PantallaCompras>();
            dataGridView1.DataSource = null;
            venderToolStripMenuItem.Enabled = false;
            cancelarCompraActualToolStripMenuItem.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prov = new DAOProveedores().GetProvider(ObtenerIdProveedor(proveedores, comboBox1.SelectedItem.ToString()));           
        }
    }
}

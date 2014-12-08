namespace punto_venta
{
    partial class Ventas_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas_Form));
            this.dataGridView1_Vta_Produc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Precio_Vta_TextBox = new System.Windows.Forms.TextBox();
            this.Modificar_precio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Total_Vta_TextBox = new System.Windows.Forms.TextBox();
            this.Detalles_Vta_Button = new System.Windows.Forms.Button();
            this.Mprin_vta_button = new System.Windows.Forms.Button();
            this.Quitar_producto = new System.Windows.Forms.Button();
            this.Vender_producto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Precio_Neto = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agregar_a_credito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.cambio_textbox = new System.Windows.Forms.TextBox();
            this.recibido_textbox = new System.Windows.Forms.TextBox();
            this.devoluciones_button = new System.Windows.Forms.Button();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.porcentaje_text_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelar_venta_button = new System.Windows.Forms.Button();
            this.descuento_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Vta_Produc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1_Vta_Produc
            // 
            this.dataGridView1_Vta_Produc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Vta_Produc.Location = new System.Drawing.Point(390, 787);
            this.dataGridView1_Vta_Produc.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1_Vta_Produc.Name = "dataGridView1_Vta_Produc";
            this.dataGridView1_Vta_Produc.Size = new System.Drawing.Size(744, 308);
            this.dataGridView1_Vta_Produc.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio C/U";
            // 
            // Precio_Vta_TextBox
            // 
            this.Precio_Vta_TextBox.Enabled = false;
            this.Precio_Vta_TextBox.Location = new System.Drawing.Point(698, 3);
            this.Precio_Vta_TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.Precio_Vta_TextBox.Name = "Precio_Vta_TextBox";
            this.Precio_Vta_TextBox.Size = new System.Drawing.Size(92, 31);
            this.Precio_Vta_TextBox.TabIndex = 5;
            this.Precio_Vta_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_Vta_TextBox_KeyPress);
            // 
            // Modificar_precio
            // 
            this.Modificar_precio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificar_precio.Location = new System.Drawing.Point(412, 42);
            this.Modificar_precio.Margin = new System.Windows.Forms.Padding(6);
            this.Modificar_precio.Name = "Modificar_precio";
            this.Modificar_precio.Size = new System.Drawing.Size(202, 66);
            this.Modificar_precio.TabIndex = 4;
            this.Modificar_precio.Text = "Modificar precio";
            this.Modificar_precio.UseVisualStyleBackColor = true;
            this.Modificar_precio.Click += new System.EventHandler(this.ModPrecio_Vta_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(716, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "TOTAL";
            // 
            // Total_Vta_TextBox
            // 
            this.Total_Vta_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Vta_TextBox.Location = new System.Drawing.Point(829, 114);
            this.Total_Vta_TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.Total_Vta_TextBox.Name = "Total_Vta_TextBox";
            this.Total_Vta_TextBox.ReadOnly = true;
            this.Total_Vta_TextBox.Size = new System.Drawing.Size(206, 44);
            this.Total_Vta_TextBox.TabIndex = 15;
            // 
            // Detalles_Vta_Button
            // 
            this.Detalles_Vta_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Detalles_Vta_Button.Location = new System.Drawing.Point(1420, 465);
            this.Detalles_Vta_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Detalles_Vta_Button.Name = "Detalles_Vta_Button";
            this.Detalles_Vta_Button.Size = new System.Drawing.Size(188, 119);
            this.Detalles_Vta_Button.TabIndex = 17;
            this.Detalles_Vta_Button.Text = "DETALLES VENTAS";
            this.Detalles_Vta_Button.UseCompatibleTextRendering = true;
            this.Detalles_Vta_Button.UseVisualStyleBackColor = true;
            // 
            // Mprin_vta_button
            // 
            this.Mprin_vta_button.Location = new System.Drawing.Point(1420, 356);
            this.Mprin_vta_button.Margin = new System.Windows.Forms.Padding(6);
            this.Mprin_vta_button.Name = "Mprin_vta_button";
            this.Mprin_vta_button.Size = new System.Drawing.Size(188, 94);
            this.Mprin_vta_button.TabIndex = 19;
            this.Mprin_vta_button.Text = "Menú Principal";
            this.Mprin_vta_button.UseVisualStyleBackColor = true;
            // 
            // Quitar_producto
            // 
            this.Quitar_producto.Enabled = false;
            this.Quitar_producto.Location = new System.Drawing.Point(18, 6);
            this.Quitar_producto.Margin = new System.Windows.Forms.Padding(6);
            this.Quitar_producto.Name = "Quitar_producto";
            this.Quitar_producto.Size = new System.Drawing.Size(150, 66);
            this.Quitar_producto.TabIndex = 7;
            this.Quitar_producto.Text = "QUITAR PRODUCTO";
            this.Quitar_producto.UseVisualStyleBackColor = true;
            this.Quitar_producto.Click += new System.EventHandler(this.Quitar_producto_Click);
            // 
            // Vender_producto
            // 
            this.Vender_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vender_producto.Enabled = false;
            this.Vender_producto.Location = new System.Drawing.Point(441, 7);
            this.Vender_producto.Margin = new System.Windows.Forms.Padding(6);
            this.Vender_producto.Name = "Vender_producto";
            this.Vender_producto.Size = new System.Drawing.Size(257, 151);
            this.Vender_producto.TabIndex = 27;
            this.Vender_producto.Text = "VENDER (F5)";
            this.Vender_producto.UseCompatibleTextRendering = true;
            this.Vender_producto.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(792, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Precio NETO";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Descripción";
            // 
            // Precio_Neto
            // 
            this.Precio_Neto.Location = new System.Drawing.Point(930, 3);
            this.Precio_Neto.Margin = new System.Windows.Forms.Padding(6);
            this.Precio_Neto.Name = "Precio_Neto";
            this.Precio_Neto.ReadOnly = true;
            this.Precio_Neto.Size = new System.Drawing.Size(108, 31);
            this.Precio_Neto.TabIndex = 26;
            // 
            // Codigo
            // 
            this.Codigo.Enabled = false;
            this.Codigo.Location = new System.Drawing.Point(97, 3);
            this.Codigo.MaxLength = 100;
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(268, 31);
            this.Codigo.TabIndex = 1;
            this.Codigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Codigo_MouseClick);
            this.Codigo.Enter += new System.EventHandler(this.Codigo_Enter);
            this.Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Codigo_KeyPress);
            this.Codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Codigo_KeyUp);
            // 
            // Cantidad
            // 
            this.Cantidad.Enabled = false;
            this.Cantidad.Location = new System.Drawing.Point(478, 3);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(95, 31);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1192, 341);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // agregar_a_credito
            // 
            this.agregar_a_credito.Enabled = false;
            this.agregar_a_credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_a_credito.Location = new System.Drawing.Point(1044, 114);
            this.agregar_a_credito.Name = "agregar_a_credito";
            this.agregar_a_credito.Size = new System.Drawing.Size(71, 44);
            this.agregar_a_credito.TabIndex = 9;
            this.agregar_a_credito.Text = "Crédito";
            this.agregar_a_credito.UseVisualStyleBackColor = true;
            this.agregar_a_credito.Click += new System.EventHandler(this.agregar_a_credito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Usuario: ";
            // 
            // Usuario
            // 
            this.Usuario.Enabled = false;
            this.Usuario.Location = new System.Drawing.Point(113, 123);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(319, 31);
            this.Usuario.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Recibido";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 33);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.venderToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.Enabled = false;
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.venderToolStripMenuItem.Text = "Vender";
            this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cambio";
            // 
            // cambio_textbox
            // 
            this.cambio_textbox.Enabled = false;
            this.cambio_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambio_textbox.Location = new System.Drawing.Point(829, 60);
            this.cambio_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.cambio_textbox.Name = "cambio_textbox";
            this.cambio_textbox.ReadOnly = true;
            this.cambio_textbox.Size = new System.Drawing.Size(206, 44);
            this.cambio_textbox.TabIndex = 45;
            // 
            // recibido_textbox
            // 
            this.recibido_textbox.Enabled = false;
            this.recibido_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recibido_textbox.Location = new System.Drawing.Point(826, 7);
            this.recibido_textbox.Name = "recibido_textbox";
            this.recibido_textbox.Size = new System.Drawing.Size(209, 44);
            this.recibido_textbox.TabIndex = 46;
            this.recibido_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recibido_textbox_KeyPress);
            // 
            // devoluciones_button
            // 
            this.devoluciones_button.Location = new System.Drawing.Point(807, 42);
            this.devoluciones_button.Margin = new System.Windows.Forms.Padding(6);
            this.devoluciones_button.Name = "devoluciones_button";
            this.devoluciones_button.Size = new System.Drawing.Size(185, 66);
            this.devoluciones_button.TabIndex = 47;
            this.devoluciones_button.Text = "Devoluciones";
            this.devoluciones_button.UseVisualStyleBackColor = true;
            this.devoluciones_button.Click += new System.EventHandler(this.devoluciones_button_Click);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Descripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Descripcion.Enabled = false;
            this.Descripcion.Location = new System.Drawing.Point(128, 60);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(275, 31);
            this.Descripcion.TabIndex = 3;
            this.Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Descripcion_KeyPress);
            this.Descripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Descripcion_KeyUp);
            // 
            // porcentaje_text_box
            // 
            this.porcentaje_text_box.Enabled = false;
            this.porcentaje_text_box.Location = new System.Drawing.Point(1047, 3);
            this.porcentaje_text_box.Name = "porcentaje_text_box";
            this.porcentaje_text_box.Size = new System.Drawing.Size(90, 31);
            this.porcentaje_text_box.TabIndex = 48;
            this.porcentaje_text_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.porcentaje_text_box_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1139, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "%";
            // 
            // cancelar_venta_button
            // 
            this.cancelar_venta_button.Location = new System.Drawing.Point(618, 42);
            this.cancelar_venta_button.Margin = new System.Windows.Forms.Padding(6);
            this.cancelar_venta_button.Name = "cancelar_venta_button";
            this.cancelar_venta_button.Size = new System.Drawing.Size(185, 66);
            this.cancelar_venta_button.TabIndex = 51;
            this.cancelar_venta_button.Text = "Cancelar venta";
            this.cancelar_venta_button.UseVisualStyleBackColor = true;
            this.cancelar_venta_button.Click += new System.EventHandler(this.cancelar_venta_button_Click);
            // 
            // descuento_button
            // 
            this.descuento_button.Location = new System.Drawing.Point(999, 42);
            this.descuento_button.Margin = new System.Windows.Forms.Padding(6);
            this.descuento_button.Name = "descuento_button";
            this.descuento_button.Size = new System.Drawing.Size(185, 66);
            this.descuento_button.TabIndex = 52;
            this.descuento_button.Text = "Descuento";
            this.descuento_button.UseVisualStyleBackColor = true;
            this.descuento_button.Click += new System.EventHandler(this.descuento_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Cantidad);
            this.panel1.Controls.Add(this.descuento_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cancelar_venta_button);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.devoluciones_button);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Codigo);
            this.panel1.Controls.Add(this.porcentaje_text_box);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Precio_Vta_TextBox);
            this.panel1.Controls.Add(this.Precio_Neto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Descripcion);
            this.panel1.Controls.Add(this.Modificar_precio);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 117);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Quitar_producto);
            this.panel2.Controls.Add(this.Usuario);
            this.panel2.Controls.Add(this.agregar_a_credito);
            this.panel2.Controls.Add(this.recibido_textbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cambio_textbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Vender_producto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Total_Vta_TextBox);
            this.panel2.Location = new System.Drawing.Point(6, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1198, 179);
            this.panel2.TabIndex = 54;
            // 
            // Ventas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1216, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Mprin_vta_button);
            this.Controls.Add(this.Detalles_Vta_Button);
            this.Controls.Add(this.dataGridView1_Vta_Produc);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ventas_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Ventas_Form_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ventas_Form_FormClosing);
            this.Load += new System.EventHandler(this.Ventas_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Vta_Produc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Vta_Produc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Precio_Vta_TextBox;
        private System.Windows.Forms.Button Modificar_precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Total_Vta_TextBox;
        private System.Windows.Forms.Button Detalles_Vta_Button;
        private System.Windows.Forms.Button Mprin_vta_button;
        private System.Windows.Forms.Button Quitar_producto;
        private System.Windows.Forms.Button Vender_producto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Precio_Neto;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button agregar_a_credito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cambio_textbox;
        private System.Windows.Forms.TextBox recibido_textbox;
        private System.Windows.Forms.Button devoluciones_button;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox porcentaje_text_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelar_venta_button;
        private System.Windows.Forms.Button descuento_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace punto_venta
{
    partial class Compras_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras_form));
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cantidad_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descripcion_textbox = new System.Windows.Forms.TextBox();
            this.realizar_compras_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.precio_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.costo_total_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.agregar_button = new System.Windows.Forms.Button();
            this.precio_vta_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cambiar_precio_vta_button = new System.Windows.Forms.Button();
            this.nuevo_proveedor_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.credito_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarCompraActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.total_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código";
            // 
            // Codigo_textbox
            // 
            this.Codigo_textbox.Enabled = false;
            this.Codigo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_textbox.Location = new System.Drawing.Point(80, 7);
            this.Codigo_textbox.MaxLength = 100;
            this.Codigo_textbox.Name = "Codigo_textbox";
            this.Codigo_textbox.Size = new System.Drawing.Size(208, 29);
            this.Codigo_textbox.TabIndex = 1;
            this.Codigo_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Codigo_textbox_KeyPress);
            this.Codigo_textbox.Leave += new System.EventHandler(this.Codigo_textbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cantidad";
            // 
            // Cantidad_textbox
            // 
            this.Cantidad_textbox.Enabled = false;
            this.Cantidad_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad_textbox.Location = new System.Drawing.Point(93, 87);
            this.Cantidad_textbox.Name = "Cantidad_textbox";
            this.Cantidad_textbox.Size = new System.Drawing.Size(97, 29);
            this.Cantidad_textbox.TabIndex = 4;
            this.Cantidad_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_textbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Descripción";
            // 
            // descripcion_textbox
            // 
            this.descripcion_textbox.Enabled = false;
            this.descripcion_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_textbox.Location = new System.Drawing.Point(410, 7);
            this.descripcion_textbox.Name = "descripcion_textbox";
            this.descripcion_textbox.Size = new System.Drawing.Size(318, 29);
            this.descripcion_textbox.TabIndex = 7;
            // 
            // realizar_compras_button
            // 
            this.realizar_compras_button.Enabled = false;
            this.realizar_compras_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizar_compras_button.Location = new System.Drawing.Point(852, 66);
            this.realizar_compras_button.Name = "realizar_compras_button";
            this.realizar_compras_button.Size = new System.Drawing.Size(145, 58);
            this.realizar_compras_button.TabIndex = 10;
            this.realizar_compras_button.Text = "Realizar compra";
            this.realizar_compras_button.UseVisualStyleBackColor = true;
            this.realizar_compras_button.Click += new System.EventHandler(this.guardar_cambios_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Costo Unitario";
            // 
            // precio_textbox
            // 
            this.precio_textbox.Enabled = false;
            this.precio_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_textbox.Location = new System.Drawing.Point(328, 87);
            this.precio_textbox.Name = "precio_textbox";
            this.precio_textbox.Size = new System.Drawing.Size(105, 29);
            this.precio_textbox.TabIndex = 5;
            this.precio_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_textbox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.eliminar_button);
            this.panel1.Controls.Add(this.costo_total_textbox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.agregar_button);
            this.panel1.Controls.Add(this.precio_vta_textBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cambiar_precio_vta_button);
            this.panel1.Controls.Add(this.nuevo_proveedor_button);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.precio_textbox);
            this.panel1.Controls.Add(this.Codigo_textbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Cantidad_textbox);
            this.panel1.Controls.Add(this.descripcion_textbox);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 126);
            this.panel1.TabIndex = 45;
            // 
            // eliminar_button
            // 
            this.eliminar_button.Enabled = false;
            this.eliminar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_button.Location = new System.Drawing.Point(616, 44);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(112, 37);
            this.eliminar_button.TabIndex = 48;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = true;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // costo_total_textbox
            // 
            this.costo_total_textbox.Enabled = false;
            this.costo_total_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo_total_textbox.Location = new System.Drawing.Point(520, 87);
            this.costo_total_textbox.Name = "costo_total_textbox";
            this.costo_total_textbox.Size = new System.Drawing.Size(90, 29);
            this.costo_total_textbox.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(439, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 46;
            this.label9.Text = "Costo total";
            // 
            // agregar_button
            // 
            this.agregar_button.Enabled = false;
            this.agregar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_button.Location = new System.Drawing.Point(616, 84);
            this.agregar_button.Name = "agregar_button";
            this.agregar_button.Size = new System.Drawing.Size(112, 37);
            this.agregar_button.TabIndex = 6;
            this.agregar_button.Text = "Agregar";
            this.agregar_button.UseVisualStyleBackColor = true;
            this.agregar_button.Click += new System.EventHandler(this.agregar_button_Click_1);
            // 
            // precio_vta_textBox
            // 
            this.precio_vta_textBox.Enabled = false;
            this.precio_vta_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_vta_textBox.Location = new System.Drawing.Point(734, 7);
            this.precio_vta_textBox.Name = "precio_vta_textBox";
            this.precio_vta_textBox.Size = new System.Drawing.Size(95, 29);
            this.precio_vta_textBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(738, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Precio de venta";
            // 
            // cambiar_precio_vta_button
            // 
            this.cambiar_precio_vta_button.Enabled = false;
            this.cambiar_precio_vta_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiar_precio_vta_button.Location = new System.Drawing.Point(734, 60);
            this.cambiar_precio_vta_button.Name = "cambiar_precio_vta_button";
            this.cambiar_precio_vta_button.Size = new System.Drawing.Size(95, 57);
            this.cambiar_precio_vta_button.TabIndex = 9;
            this.cambiar_precio_vta_button.Text = "Cambiar precio de venta";
            this.cambiar_precio_vta_button.UseVisualStyleBackColor = true;
            this.cambiar_precio_vta_button.Click += new System.EventHandler(this.cambiar_precio_vta_button_Click);
            // 
            // nuevo_proveedor_button
            // 
            this.nuevo_proveedor_button.Enabled = false;
            this.nuevo_proveedor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo_proveedor_button.Location = new System.Drawing.Point(446, 42);
            this.nuevo_proveedor_button.Name = "nuevo_proveedor_button";
            this.nuevo_proveedor_button.Size = new System.Drawing.Size(158, 40);
            this.nuevo_proveedor_button.TabIndex = 3;
            this.nuevo_proveedor_button.Text = "Nuevo proveedor";
            this.nuevo_proveedor_button.UseVisualStyleBackColor = true;
            this.nuevo_proveedor_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 32);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "Datos del Producto";
            // 
            // credito_button
            // 
            this.credito_button.Enabled = false;
            this.credito_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credito_button.Location = new System.Drawing.Point(852, 130);
            this.credito_button.Name = "credito_button";
            this.credito_button.Size = new System.Drawing.Size(145, 62);
            this.credito_button.TabIndex = 11;
            this.credito_button.Text = "Agregar a crédito";
            this.credito_button.UseVisualStyleBackColor = true;
            this.credito_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 33);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.venderToolStripMenuItem,
            this.cancelarCompraActualToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.ventasToolStripMenuItem.Text = "Compras";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva compra";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.Enabled = false;
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.venderToolStripMenuItem.Text = "Comprar";
            this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
            // 
            // cancelarCompraActualToolStripMenuItem
            // 
            this.cancelarCompraActualToolStripMenuItem.Enabled = false;
            this.cancelarCompraActualToolStripMenuItem.Name = "cancelarCompraActualToolStripMenuItem";
            this.cancelarCompraActualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.cancelarCompraActualToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.cancelarCompraActualToolStripMenuItem.Text = "Cancelar compra actual";
            this.cancelarCompraActualToolStripMenuItem.Click += new System.EventHandler(this.cancelarCompraActualToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(750, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Total";
            // 
            // total_textBox
            // 
            this.total_textBox.Enabled = false;
            this.total_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_textBox.Location = new System.Drawing.Point(807, 543);
            this.total_textBox.Name = "total_textBox";
            this.total_textBox.Size = new System.Drawing.Size(190, 29);
            this.total_textBox.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(985, 339);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // Compras_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.total_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.credito_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.realizar_compras_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Compras_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Compras_form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Compras_form_FormClosed);
            this.Load += new System.EventHandler(this.Compras_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Codigo_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cantidad_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripcion_textbox;
        private System.Windows.Forms.Button realizar_compras_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precio_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nuevo_proveedor_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button credito_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.TextBox precio_vta_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cambiar_precio_vta_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox total_textBox;
        private System.Windows.Forms.Button agregar_button;
        private System.Windows.Forms.TextBox costo_total_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem cancelarCompraActualToolStripMenuItem;
    }
}
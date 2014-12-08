namespace punto_venta
{
    partial class resumen_compras_id_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resumen_compras_id_form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producto_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_nombre_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.nueva_dev_button = new System.Windows.Forms.Button();
            this.clave_venta_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto_column,
            this.producto_nombre_column,
            this.proveedor_column,
            this.cantidad_column,
            this.precio_column,
            this.total_column});
            this.dataGridView1.Location = new System.Drawing.Point(10, 101);
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
            this.dataGridView1.Size = new System.Drawing.Size(653, 324);
            this.dataGridView1.TabIndex = 40;
            // 
            // producto_column
            // 
            this.producto_column.HeaderText = "Código producto";
            this.producto_column.Name = "producto_column";
            this.producto_column.ReadOnly = true;
            // 
            // producto_nombre_column
            // 
            this.producto_nombre_column.HeaderText = "Producto";
            this.producto_nombre_column.Name = "producto_nombre_column";
            this.producto_nombre_column.ReadOnly = true;
            // 
            // proveedor_column
            // 
            this.proveedor_column.HeaderText = "Proveedor";
            this.proveedor_column.Name = "proveedor_column";
            this.proveedor_column.ReadOnly = true;
            // 
            // cantidad_column
            // 
            this.cantidad_column.HeaderText = "Cantidad";
            this.cantidad_column.Name = "cantidad_column";
            this.cantidad_column.ReadOnly = true;
            // 
            // precio_column
            // 
            this.precio_column.HeaderText = "Precio";
            this.precio_column.Name = "precio_column";
            this.precio_column.ReadOnly = true;
            // 
            // total_column
            // 
            this.total_column.HeaderText = "Total";
            this.total_column.Name = "total_column";
            this.total_column.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.nueva_dev_button);
            this.panel1.Controls.Add(this.clave_venta_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 83);
            this.panel1.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(538, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nueva_dev_button
            // 
            this.nueva_dev_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueva_dev_button.Location = new System.Drawing.Point(538, 7);
            this.nueva_dev_button.Name = "nueva_dev_button";
            this.nueva_dev_button.Size = new System.Drawing.Size(104, 31);
            this.nueva_dev_button.TabIndex = 8;
            this.nueva_dev_button.Text = "Buscar";
            this.nueva_dev_button.UseVisualStyleBackColor = true;
            this.nueva_dev_button.Click += new System.EventHandler(this.nueva_dev_button_Click);
            // 
            // clave_venta_textbox
            // 
            this.clave_venta_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.clave_venta_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clave_venta_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_venta_textbox.Location = new System.Drawing.Point(202, 27);
            this.clave_venta_textbox.MaxLength = 30;
            this.clave_venta_textbox.Name = "clave_venta_textbox";
            this.clave_venta_textbox.Size = new System.Drawing.Size(330, 29);
            this.clave_venta_textbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave de compra";
            // 
            // resumen_compras_id_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 437);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "resumen_compras_id_form";
            this.Text = "Compra por id";
            this.Load += new System.EventHandler(this.resumen_compras_id_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nueva_dev_button;
        private System.Windows.Forms.TextBox clave_venta_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_nombre_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_column;
        private System.Windows.Forms.Button button2;
    }
}
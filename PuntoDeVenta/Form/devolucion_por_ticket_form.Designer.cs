namespace punto_venta
{
    partial class devolucion_por_ticket_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(devolucion_por_ticket_form));
            this.label2 = new System.Windows.Forms.Label();
            this.clave_venta_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscar_button = new System.Windows.Forms.Button();
            this.nueva_dev_button = new System.Windows.Forms.Button();
            this.finalizar_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.devolver_button = new System.Windows.Forms.Button();
            this.cantidad_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave de venta";
            // 
            // clave_venta_textbox
            // 
            this.clave_venta_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.clave_venta_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clave_venta_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_venta_textbox.Location = new System.Drawing.Point(202, 9);
            this.clave_venta_textbox.MaxLength = 30;
            this.clave_venta_textbox.Name = "clave_venta_textbox";
            this.clave_venta_textbox.Size = new System.Drawing.Size(330, 29);
            this.clave_venta_textbox.TabIndex = 1;
            this.clave_venta_textbox.TextChanged += new System.EventHandler(this.clave_venta_textbox_TextChanged);
            this.clave_venta_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clave_venta_textbox_KeyPress);
            this.clave_venta_textbox.Leave += new System.EventHandler(this.clave_venta_textbox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscar_button);
            this.panel1.Controls.Add(this.nueva_dev_button);
            this.panel1.Controls.Add(this.finalizar_button);
            this.panel1.Controls.Add(this.clave_venta_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.devolver_button);
            this.panel1.Controls.Add(this.cantidad_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Codigo_textbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 149);
            this.panel1.TabIndex = 5;
            // 
            // buscar_button
            // 
            this.buscar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_button.Location = new System.Drawing.Point(538, 5);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(109, 42);
            this.buscar_button.TabIndex = 2;
            this.buscar_button.Text = "Buscar";
            this.buscar_button.UseVisualStyleBackColor = true;
            this.buscar_button.Click += new System.EventHandler(this.buscar_button_Click);
            // 
            // nueva_dev_button
            // 
            this.nueva_dev_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueva_dev_button.Location = new System.Drawing.Point(538, 49);
            this.nueva_dev_button.Name = "nueva_dev_button";
            this.nueva_dev_button.Size = new System.Drawing.Size(109, 42);
            this.nueva_dev_button.TabIndex = 6;
            this.nueva_dev_button.Text = "Nueva devolución";
            this.nueva_dev_button.UseVisualStyleBackColor = true;
            this.nueva_dev_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalizar_button
            // 
            this.finalizar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizar_button.Location = new System.Drawing.Point(538, 97);
            this.finalizar_button.Name = "finalizar_button";
            this.finalizar_button.Size = new System.Drawing.Size(109, 42);
            this.finalizar_button.TabIndex = 7;
            this.finalizar_button.Text = "Finalizar";
            this.finalizar_button.UseVisualStyleBackColor = true;
            this.finalizar_button.Click += new System.EventHandler(this.finalizar_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // devolver_button
            // 
            this.devolver_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devolver_button.Location = new System.Drawing.Point(307, 97);
            this.devolver_button.Name = "devolver_button";
            this.devolver_button.Size = new System.Drawing.Size(109, 42);
            this.devolver_button.TabIndex = 5;
            this.devolver_button.Text = "Devolver";
            this.devolver_button.UseVisualStyleBackColor = true;
            this.devolver_button.Click += new System.EventHandler(this.devolver_button_Click);
            // 
            // cantidad_textbox
            // 
            this.cantidad_textbox.Enabled = false;
            this.cantidad_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_textbox.Location = new System.Drawing.Point(202, 103);
            this.cantidad_textbox.Name = "cantidad_textbox";
            this.cantidad_textbox.Size = new System.Drawing.Size(99, 29);
            this.cantidad_textbox.TabIndex = 3;
            this.cantidad_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_textbox_KeyPress);
            this.cantidad_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cantidad_textbox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código del producto";
            // 
            // Codigo_textbox
            // 
            this.Codigo_textbox.Enabled = false;
            this.Codigo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_textbox.Location = new System.Drawing.Point(202, 57);
            this.Codigo_textbox.MaxLength = 100;
            this.Codigo_textbox.Name = "Codigo_textbox";
            this.Codigo_textbox.Size = new System.Drawing.Size(330, 29);
            this.Codigo_textbox.TabIndex = 3;
            this.Codigo_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Codigo_textbox_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(653, 261);
            this.dataGridView1.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // devolucion_por_ticket_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "devolucion_por_ticket_form";
            this.Text = "Devolución por ticket";
            this.Load += new System.EventHandler(this.devolucion_por_ticket_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clave_venta_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nueva_dev_button;
        private System.Windows.Forms.Button finalizar_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button devolver_button;
        private System.Windows.Forms.TextBox cantidad_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Codigo_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buscar_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
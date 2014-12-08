namespace punto_venta
{
    partial class Proveedores_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores_Form));
            this.Agregar_Prov_Button = new System.Windows.Forms.Button();
            this.dataGridView_Proveedores = new System.Windows.Forms.DataGridView();
            this.Eliminar_Prov_Button = new System.Windows.Forms.Button();
            this.Modificar_Prov_Button = new System.Windows.Forms.Button();
            this.Guardar_prov_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.domicilio_textBox = new System.Windows.Forms.TextBox();
            this.ciudad_textBox = new System.Windows.Forms.TextBox();
            this.estado_textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proveedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregar_Prov_Button
            // 
            this.Agregar_Prov_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agregar_Prov_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_Prov_Button.Location = new System.Drawing.Point(12, 93);
            this.Agregar_Prov_Button.Name = "Agregar_Prov_Button";
            this.Agregar_Prov_Button.Size = new System.Drawing.Size(145, 45);
            this.Agregar_Prov_Button.TabIndex = 5;
            this.Agregar_Prov_Button.Text = "Agregar";
            this.Agregar_Prov_Button.UseVisualStyleBackColor = true;
            this.Agregar_Prov_Button.Click += new System.EventHandler(this.Agregar_Prov_Button_Click);
            // 
            // dataGridView_Proveedores
            // 
            this.dataGridView_Proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Proveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Proveedores.Location = new System.Drawing.Point(12, 144);
            this.dataGridView_Proveedores.Name = "dataGridView_Proveedores";
            this.dataGridView_Proveedores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Proveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Proveedores.Size = new System.Drawing.Size(974, 469);
            this.dataGridView_Proveedores.TabIndex = 15;
            this.dataGridView_Proveedores.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Datagridview_RowHeaderMouseClick);
            // 
            // Eliminar_Prov_Button
            // 
            this.Eliminar_Prov_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminar_Prov_Button.Enabled = false;
            this.Eliminar_Prov_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_Prov_Button.Location = new System.Drawing.Point(465, 93);
            this.Eliminar_Prov_Button.Name = "Eliminar_Prov_Button";
            this.Eliminar_Prov_Button.Size = new System.Drawing.Size(145, 45);
            this.Eliminar_Prov_Button.TabIndex = 8;
            this.Eliminar_Prov_Button.Text = "Eliminar";
            this.Eliminar_Prov_Button.UseVisualStyleBackColor = true;
            this.Eliminar_Prov_Button.Click += new System.EventHandler(this.Eliminar_Prov_Button_Click);
            // 
            // Modificar_Prov_Button
            // 
            this.Modificar_Prov_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificar_Prov_Button.Enabled = false;
            this.Modificar_Prov_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_Prov_Button.Location = new System.Drawing.Point(163, 93);
            this.Modificar_Prov_Button.Name = "Modificar_Prov_Button";
            this.Modificar_Prov_Button.Size = new System.Drawing.Size(145, 45);
            this.Modificar_Prov_Button.TabIndex = 6;
            this.Modificar_Prov_Button.Text = "Modificar";
            this.Modificar_Prov_Button.UseVisualStyleBackColor = true;
            this.Modificar_Prov_Button.Click += new System.EventHandler(this.Modificar_Prov_Button_Click);
            // 
            // Guardar_prov_button
            // 
            this.Guardar_prov_button.Enabled = false;
            this.Guardar_prov_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_prov_button.Location = new System.Drawing.Point(314, 93);
            this.Guardar_prov_button.Name = "Guardar_prov_button";
            this.Guardar_prov_button.Size = new System.Drawing.Size(145, 45);
            this.Guardar_prov_button.TabIndex = 7;
            this.Guardar_prov_button.Text = "Guardar";
            this.Guardar_prov_button.UseVisualStyleBackColor = true;
            this.Guardar_prov_button.Click += new System.EventHandler(this.Guardar_prov_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Domicilio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Estado";
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_textbox.Location = new System.Drawing.Point(88, 3);
            this.nombre_textbox.MaxLength = 100;
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.Size = new System.Drawing.Size(316, 26);
            this.nombre_textbox.TabIndex = 1;
            // 
            // domicilio_textBox
            // 
            this.domicilio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilio_textBox.Location = new System.Drawing.Point(503, 3);
            this.domicilio_textBox.MaxLength = 100;
            this.domicilio_textBox.Name = "domicilio_textBox";
            this.domicilio_textBox.Size = new System.Drawing.Size(266, 26);
            this.domicilio_textBox.TabIndex = 2;
            // 
            // ciudad_textBox
            // 
            this.ciudad_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad_textBox.Location = new System.Drawing.Point(88, 40);
            this.ciudad_textBox.MaxLength = 100;
            this.ciudad_textBox.Name = "ciudad_textBox";
            this.ciudad_textBox.Size = new System.Drawing.Size(316, 26);
            this.ciudad_textBox.TabIndex = 3;
            // 
            // estado_textBox
            // 
            this.estado_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_textBox.Location = new System.Drawing.Point(503, 40);
            this.estado_textBox.MaxLength = 100;
            this.estado_textBox.Name = "estado_textBox";
            this.estado_textBox.Size = new System.Drawing.Size(266, 26);
            this.estado_textBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.estado_textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.domicilio_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ciudad_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nombre_textbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 75);
            this.panel1.TabIndex = 30;
            // 
            // Proveedores_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Guardar_prov_button);
            this.Controls.Add(this.Modificar_Prov_Button);
            this.Controls.Add(this.Eliminar_Prov_Button);
            this.Controls.Add(this.Agregar_Prov_Button);
            this.Controls.Add(this.dataGridView_Proveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proveedores_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Activated += new System.EventHandler(this.Proveedores_Form_Activated);
            this.Load += new System.EventHandler(this.Proveedores_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Agregar_Prov_Button;
        private System.Windows.Forms.DataGridView dataGridView_Proveedores;
        private System.Windows.Forms.Button Eliminar_Prov_Button;
        private System.Windows.Forms.Button Modificar_Prov_Button;
        private System.Windows.Forms.Button Guardar_prov_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.TextBox domicilio_textBox;
        private System.Windows.Forms.TextBox ciudad_textBox;
        private System.Windows.Forms.TextBox estado_textBox;
        private System.Windows.Forms.Panel panel1;
    }
}
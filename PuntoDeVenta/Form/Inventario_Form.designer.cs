namespace punto_venta
{
    partial class Inventario_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario_Form));
            this.dataGridView_Inventario = new System.Windows.Forms.DataGridView();
            this.Eliminar_Inv_Button = new System.Windows.Forms.Button();
            this.Modificar_Inv_Button = new System.Windows.Forms.Button();
            this.Guardar_Inv_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.codigo_textbox = new System.Windows.Forms.TextBox();
            this.descripcion_textbox = new System.Windows.Forms.TextBox();
            this.cantidad_textbox = new System.Windows.Forms.TextBox();
            this.precio_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Inventario
            // 
            this.dataGridView_Inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Inventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Inventario.Location = new System.Drawing.Point(12, 87);
            this.dataGridView_Inventario.Name = "dataGridView_Inventario";
            this.dataGridView_Inventario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Inventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Inventario.Size = new System.Drawing.Size(906, 416);
            this.dataGridView_Inventario.TabIndex = 11;
            this.dataGridView_Inventario.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Datagridview_RowHeaderMouse);
            // 
            // Eliminar_Inv_Button
            // 
            this.Eliminar_Inv_Button.Enabled = false;
            this.Eliminar_Inv_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_Inv_Button.Location = new System.Drawing.Point(696, 12);
            this.Eliminar_Inv_Button.Name = "Eliminar_Inv_Button";
            this.Eliminar_Inv_Button.Size = new System.Drawing.Size(108, 69);
            this.Eliminar_Inv_Button.TabIndex = 18;
            this.Eliminar_Inv_Button.Text = "Eliminar";
            this.Eliminar_Inv_Button.UseVisualStyleBackColor = true;
            this.Eliminar_Inv_Button.Click += new System.EventHandler(this.Eliminar_Inv_Button_Click);
            // 
            // Modificar_Inv_Button
            // 
            this.Modificar_Inv_Button.Enabled = false;
            this.Modificar_Inv_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_Inv_Button.Location = new System.Drawing.Point(582, 12);
            this.Modificar_Inv_Button.Name = "Modificar_Inv_Button";
            this.Modificar_Inv_Button.Size = new System.Drawing.Size(108, 69);
            this.Modificar_Inv_Button.TabIndex = 19;
            this.Modificar_Inv_Button.Text = "Modificar";
            this.Modificar_Inv_Button.UseVisualStyleBackColor = true;
            this.Modificar_Inv_Button.Click += new System.EventHandler(this.Modificar_Inv_Button_Click);
            // 
            // Guardar_Inv_Button
            // 
            this.Guardar_Inv_Button.Enabled = false;
            this.Guardar_Inv_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_Inv_Button.Location = new System.Drawing.Point(810, 12);
            this.Guardar_Inv_Button.Name = "Guardar_Inv_Button";
            this.Guardar_Inv_Button.Size = new System.Drawing.Size(108, 69);
            this.Guardar_Inv_Button.TabIndex = 22;
            this.Guardar_Inv_Button.Text = "Guardar cambios";
            this.Guardar_Inv_Button.UseVisualStyleBackColor = true;
            this.Guardar_Inv_Button.Click += new System.EventHandler(this.Guardar_Inv_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Precio";
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_textbox.Location = new System.Drawing.Point(97, 61);
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.Size = new System.Drawing.Size(252, 26);
            this.nombre_textbox.TabIndex = 1;
            // 
            // codigo_textbox
            // 
            this.codigo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_textbox.Location = new System.Drawing.Point(119, 3);
            this.codigo_textbox.MaxLength = 100;
            this.codigo_textbox.Name = "codigo_textbox";
            this.codigo_textbox.Size = new System.Drawing.Size(235, 26);
            this.codigo_textbox.TabIndex = 35;
            this.codigo_textbox.TextChanged += new System.EventHandler(this.codigo_textbox_TextChanged);
            this.codigo_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_textbox_KeyPress);
            this.codigo_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codigo_textbox_KeyUp);
            // 
            // descripcion_textbox
            // 
            this.descripcion_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_textbox.Location = new System.Drawing.Point(119, 35);
            this.descripcion_textbox.MaxLength = 100;
            this.descripcion_textbox.Name = "descripcion_textbox";
            this.descripcion_textbox.Size = new System.Drawing.Size(235, 26);
            this.descripcion_textbox.TabIndex = 36;
            this.descripcion_textbox.TextChanged += new System.EventHandler(this.descripcion_textbox_TextChanged);
            // 
            // cantidad_textbox
            // 
            this.cantidad_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_textbox.Location = new System.Drawing.Point(454, 3);
            this.cantidad_textbox.Name = "cantidad_textbox";
            this.cantidad_textbox.Size = new System.Drawing.Size(98, 26);
            this.cantidad_textbox.TabIndex = 37;
            this.cantidad_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_textbox_KeyPress);
            // 
            // precio_textbox
            // 
            this.precio_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_textbox.Location = new System.Drawing.Point(454, 35);
            this.precio_textbox.Name = "precio_textbox";
            this.precio_textbox.Size = new System.Drawing.Size(98, 26);
            this.precio_textbox.TabIndex = 38;
            this.precio_textbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.precio_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_textbox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.precio_textbox);
            this.panel1.Controls.Add(this.codigo_textbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cantidad_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.descripcion_textbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 69);
            this.panel1.TabIndex = 39;
            // 
            // Inventario_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Guardar_Inv_Button);
            this.Controls.Add(this.Modificar_Inv_Button);
            this.Controls.Add(this.Eliminar_Inv_Button);
            this.Controls.Add(this.dataGridView_Inventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventario_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Activated += new System.EventHandler(this.Inventario_Form_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Inventario;
        private System.Windows.Forms.Button Eliminar_Inv_Button;
        private System.Windows.Forms.Button Modificar_Inv_Button;
        private System.Windows.Forms.Button Guardar_Inv_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.TextBox codigo_textbox;
        private System.Windows.Forms.TextBox descripcion_textbox;
        private System.Windows.Forms.TextBox cantidad_textbox;
        private System.Windows.Forms.TextBox precio_textbox;
        private System.Windows.Forms.Panel panel1;
    }
}
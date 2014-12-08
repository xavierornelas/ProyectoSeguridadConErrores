namespace punto_venta
{
    partial class Clientes_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes_Form));
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.Agregar_Clientes_Button = new System.Windows.Forms.Button();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.Modificar_Clientes_Button = new System.Windows.Forms.Button();
            this.Rfc_Clientes_textBox = new System.Windows.Forms.TextBox();
            this.Edo_Clientes_textBox = new System.Windows.Forms.TextBox();
            this.Cd_Clientes_textBox = new System.Windows.Forms.TextBox();
            this.Dom_Clientes_TextBox = new System.Windows.Forms.TextBox();
            this.Nombre_Clientes_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Clientes
            // 
            this.dataGridView_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Clientes.Location = new System.Drawing.Point(12, 143);
            this.dataGridView_Clientes.Name = "dataGridView_Clientes";
            this.dataGridView_Clientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Clientes.Size = new System.Drawing.Size(1007, 341);
            this.dataGridView_Clientes.TabIndex = 12;
            this.dataGridView_Clientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Datagriedview_RowHeaderMouseClickç);
            // 
            // Agregar_Clientes_Button
            // 
            this.Agregar_Clientes_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_Clientes_Button.Location = new System.Drawing.Point(12, 92);
            this.Agregar_Clientes_Button.Name = "Agregar_Clientes_Button";
            this.Agregar_Clientes_Button.Size = new System.Drawing.Size(145, 45);
            this.Agregar_Clientes_Button.TabIndex = 8;
            this.Agregar_Clientes_Button.Text = "Agregar";
            this.Agregar_Clientes_Button.UseVisualStyleBackColor = true;
            this.Agregar_Clientes_Button.Click += new System.EventHandler(this.Agregar_Clientes_Button_Click);
            // 
            // eliminar_button
            // 
            this.eliminar_button.Enabled = false;
            this.eliminar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_button.Location = new System.Drawing.Point(465, 92);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(145, 45);
            this.eliminar_button.TabIndex = 11;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = true;
            this.eliminar_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modificar_Clientes_Button
            // 
            this.Modificar_Clientes_Button.Enabled = false;
            this.Modificar_Clientes_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_Clientes_Button.Location = new System.Drawing.Point(163, 92);
            this.Modificar_Clientes_Button.Name = "Modificar_Clientes_Button";
            this.Modificar_Clientes_Button.Size = new System.Drawing.Size(145, 45);
            this.Modificar_Clientes_Button.TabIndex = 9;
            this.Modificar_Clientes_Button.Text = "Modificar";
            this.Modificar_Clientes_Button.UseVisualStyleBackColor = true;
            this.Modificar_Clientes_Button.Click += new System.EventHandler(this.Modificar_Clientes_Button_Click);
            // 
            // Rfc_Clientes_textBox
            // 
            this.Rfc_Clientes_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rfc_Clientes_textBox.Location = new System.Drawing.Point(88, 35);
            this.Rfc_Clientes_textBox.MaxLength = 13;
            this.Rfc_Clientes_textBox.Name = "Rfc_Clientes_textBox";
            this.Rfc_Clientes_textBox.Size = new System.Drawing.Size(171, 26);
            this.Rfc_Clientes_textBox.TabIndex = 4;
            // 
            // Edo_Clientes_textBox
            // 
            this.Edo_Clientes_textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Coahuila",
            "Colima",
            "Distrito Federal",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Mechoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatan",
            "Zacatecas"});
            this.Edo_Clientes_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Edo_Clientes_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Edo_Clientes_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edo_Clientes_textBox.Location = new System.Drawing.Point(627, 37);
            this.Edo_Clientes_textBox.MaxLength = 100;
            this.Edo_Clientes_textBox.Name = "Edo_Clientes_textBox";
            this.Edo_Clientes_textBox.Size = new System.Drawing.Size(223, 26);
            this.Edo_Clientes_textBox.TabIndex = 6;
            // 
            // Cd_Clientes_textBox
            // 
            this.Cd_Clientes_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cd_Clientes_textBox.Location = new System.Drawing.Point(341, 35);
            this.Cd_Clientes_textBox.MaxLength = 100;
            this.Cd_Clientes_textBox.Name = "Cd_Clientes_textBox";
            this.Cd_Clientes_textBox.Size = new System.Drawing.Size(204, 26);
            this.Cd_Clientes_textBox.TabIndex = 5;
            // 
            // Dom_Clientes_TextBox
            // 
            this.Dom_Clientes_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dom_Clientes_TextBox.Location = new System.Drawing.Point(551, 5);
            this.Dom_Clientes_TextBox.MaxLength = 100;
            this.Dom_Clientes_TextBox.Name = "Dom_Clientes_TextBox";
            this.Dom_Clientes_TextBox.Size = new System.Drawing.Size(299, 26);
            this.Dom_Clientes_TextBox.TabIndex = 3;
            // 
            // Nombre_Clientes_TextBox
            // 
            this.Nombre_Clientes_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Clientes_TextBox.Location = new System.Drawing.Point(88, 3);
            this.Nombre_Clientes_TextBox.MaxLength = 100;
            this.Nombre_Clientes_TextBox.Name = "Nombre_Clientes_TextBox";
            this.Nombre_Clientes_TextBox.Size = new System.Drawing.Size(364, 26);
            this.Nombre_Clientes_TextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Domicilio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // Guardar_button
            // 
            this.Guardar_button.Enabled = false;
            this.Guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_button.Location = new System.Drawing.Point(314, 92);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(145, 45);
            this.Guardar_button.TabIndex = 10;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "RFC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Rfc_Clientes_textBox);
            this.panel1.Controls.Add(this.Dom_Clientes_TextBox);
            this.panel1.Controls.Add(this.Edo_Clientes_textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Cd_Clientes_textBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Nombre_Clientes_TextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 74);
            this.panel1.TabIndex = 36;
            // 
            // Clientes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Modificar_Clientes_Button);
            this.Controls.Add(this.eliminar_button);
            this.Controls.Add(this.Agregar_Clientes_Button);
            this.Controls.Add(this.dataGridView_Clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Clientes_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Activated += new System.EventHandler(this.Clientes_Form_Activated);
            this.Load += new System.EventHandler(this.Clientes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Clientes;
        private System.Windows.Forms.Button Agregar_Clientes_Button;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.Button Modificar_Clientes_Button;
        private System.Windows.Forms.TextBox Rfc_Clientes_textBox;
        private System.Windows.Forms.TextBox Edo_Clientes_textBox;
        private System.Windows.Forms.TextBox Cd_Clientes_textBox;
        private System.Windows.Forms.TextBox Dom_Clientes_TextBox;
        private System.Windows.Forms.TextBox Nombre_Clientes_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace punto_venta
{
    partial class Usuarios_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios_Form));
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.Agregar_usuarios_Button = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar_button1 = new System.Windows.Forms.Button();
            this.privilegios_combo = new System.Windows.Forms.ComboBox();
            this.contrasena_textbox = new System.Windows.Forms.TextBox();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guardar_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rep_contrasena_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codigo_escaner_button = new System.Windows.Forms.Button();
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
            this.dataGridView_Clientes.Location = new System.Drawing.Point(12, 141);
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
            this.dataGridView_Clientes.Size = new System.Drawing.Size(1036, 344);
            this.dataGridView_Clientes.TabIndex = 13;
            this.dataGridView_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Clientes_CellContentClick);
            this.dataGridView_Clientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Clientes_RowHeaderMouseClick);
            // 
            // Agregar_usuarios_Button
            // 
            this.Agregar_usuarios_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_usuarios_Button.Location = new System.Drawing.Point(12, 90);
            this.Agregar_usuarios_Button.Name = "Agregar_usuarios_Button";
            this.Agregar_usuarios_Button.Size = new System.Drawing.Size(145, 45);
            this.Agregar_usuarios_Button.TabIndex = 4;
            this.Agregar_usuarios_Button.Text = "Agregar";
            this.Agregar_usuarios_Button.UseVisualStyleBackColor = true;
            this.Agregar_usuarios_Button.Click += new System.EventHandler(this.Agregar_Clientes_Button_Click);
            // 
            // eliminar
            // 
            this.eliminar.Enabled = false;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(465, 90);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(145, 45);
            this.eliminar.TabIndex = 7;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // modificar_button1
            // 
            this.modificar_button1.Enabled = false;
            this.modificar_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_button1.Location = new System.Drawing.Point(163, 90);
            this.modificar_button1.Name = "modificar_button1";
            this.modificar_button1.Size = new System.Drawing.Size(145, 45);
            this.modificar_button1.TabIndex = 5;
            this.modificar_button1.Text = "Modificar";
            this.modificar_button1.UseVisualStyleBackColor = true;
            this.modificar_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // privilegios_combo
            // 
            this.privilegios_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegios_combo.FormattingEnabled = true;
            this.privilegios_combo.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.privilegios_combo.Location = new System.Drawing.Point(104, 35);
            this.privilegios_combo.Name = "privilegios_combo";
            this.privilegios_combo.Size = new System.Drawing.Size(252, 28);
            this.privilegios_combo.TabIndex = 2;
            this.privilegios_combo.SelectedIndexChanged += new System.EventHandler(this.privilegios_combo_SelectedIndexChanged);
            // 
            // contrasena_textbox
            // 
            this.contrasena_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena_textbox.Location = new System.Drawing.Point(534, 3);
            this.contrasena_textbox.MaxLength = 100;
            this.contrasena_textbox.Name = "contrasena_textbox";
            this.contrasena_textbox.PasswordChar = '*';
            this.contrasena_textbox.Size = new System.Drawing.Size(272, 26);
            this.contrasena_textbox.TabIndex = 3;
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_textbox.Location = new System.Drawing.Point(104, 3);
            this.nombre_textbox.MaxLength = 100;
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.Size = new System.Drawing.Size(252, 26);
            this.nombre_textbox.TabIndex = 1;
            this.nombre_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_textbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Privilegios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // guardar_button
            // 
            this.guardar_button.Enabled = false;
            this.guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_button.Location = new System.Drawing.Point(314, 90);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(145, 45);
            this.guardar_button.TabIndex = 6;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rep_contrasena_textbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nombre_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.privilegios_combo);
            this.panel1.Controls.Add(this.contrasena_textbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 72);
            this.panel1.TabIndex = 34;
            // 
            // rep_contrasena_textbox
            // 
            this.rep_contrasena_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rep_contrasena_textbox.Location = new System.Drawing.Point(534, 34);
            this.rep_contrasena_textbox.MaxLength = 100;
            this.rep_contrasena_textbox.Name = "rep_contrasena_textbox";
            this.rep_contrasena_textbox.PasswordChar = '*';
            this.rep_contrasena_textbox.Size = new System.Drawing.Size(272, 26);
            this.rep_contrasena_textbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Repetir Contraseña";
            // 
            // codigo_escaner_button
            // 
            this.codigo_escaner_button.Enabled = false;
            this.codigo_escaner_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_escaner_button.Location = new System.Drawing.Point(616, 90);
            this.codigo_escaner_button.Name = "codigo_escaner_button";
            this.codigo_escaner_button.Size = new System.Drawing.Size(145, 45);
            this.codigo_escaner_button.TabIndex = 35;
            this.codigo_escaner_button.Text = "Código de escáner";
            this.codigo_escaner_button.UseVisualStyleBackColor = true;
            this.codigo_escaner_button.Click += new System.EventHandler(this.codigo_escaner_button_Click);
            // 
            // Usuarios_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 497);
            this.Controls.Add(this.codigo_escaner_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guardar_button);
            this.Controls.Add(this.modificar_button1);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.Agregar_usuarios_Button);
            this.Controls.Add(this.dataGridView_Clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Clientes;
        private System.Windows.Forms.Button Agregar_usuarios_Button;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button modificar_button1;
        private System.Windows.Forms.ComboBox privilegios_combo;
        private System.Windows.Forms.TextBox contrasena_textbox;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox rep_contrasena_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button codigo_escaner_button;
    }
}
namespace punto_venta
{
    partial class correos_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(correos_form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.correo_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.repite_correo_textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.guardar_button = new System.Windows.Forms.Button();
            this.modificar_button = new System.Windows.Forms.Button();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.agregar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(588, 204);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // correo_textbox
            // 
            this.correo_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.correo_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.correo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_textbox.Location = new System.Drawing.Point(153, 3);
            this.correo_textbox.MaxLength = 100;
            this.correo_textbox.Name = "correo_textbox";
            this.correo_textbox.Size = new System.Drawing.Size(423, 29);
            this.correo_textbox.TabIndex = 1;
            this.correo_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correo_textbox_KeyPress);
            this.correo_textbox.Leave += new System.EventHandler(this.correo_textbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Repite el correo";
            // 
            // repite_correo_textBox
            // 
            this.repite_correo_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.repite_correo_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.repite_correo_textBox.Enabled = false;
            this.repite_correo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repite_correo_textBox.Location = new System.Drawing.Point(153, 38);
            this.repite_correo_textBox.MaxLength = 100;
            this.repite_correo_textBox.Name = "repite_correo_textBox";
            this.repite_correo_textBox.Size = new System.Drawing.Size(423, 29);
            this.repite_correo_textBox.TabIndex = 2;
            this.repite_correo_textBox.Leave += new System.EventHandler(this.repite_correo_textBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cancelar_button);
            this.panel1.Controls.Add(this.guardar_button);
            this.panel1.Controls.Add(this.modificar_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.repite_correo_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.eliminar_button);
            this.panel1.Controls.Add(this.correo_textbox);
            this.panel1.Controls.Add(this.agregar_button);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 126);
            this.panel1.TabIndex = 44;
            // 
            // cancelar_button
            // 
            this.cancelar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_button.Location = new System.Drawing.Point(467, 73);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(109, 42);
            this.cancelar_button.TabIndex = 43;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // guardar_button
            // 
            this.guardar_button.Enabled = false;
            this.guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_button.Location = new System.Drawing.Point(122, 73);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(109, 42);
            this.guardar_button.TabIndex = 4;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // modificar_button
            // 
            this.modificar_button.Enabled = false;
            this.modificar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_button.Location = new System.Drawing.Point(237, 73);
            this.modificar_button.Name = "modificar_button";
            this.modificar_button.Size = new System.Drawing.Size(109, 42);
            this.modificar_button.TabIndex = 5;
            this.modificar_button.Text = "Modificar";
            this.modificar_button.UseVisualStyleBackColor = true;
            this.modificar_button.Click += new System.EventHandler(this.modificar_button_Click);
            // 
            // eliminar_button
            // 
            this.eliminar_button.Enabled = false;
            this.eliminar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_button.Location = new System.Drawing.Point(352, 73);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(109, 42);
            this.eliminar_button.TabIndex = 6;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = true;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // agregar_button
            // 
            this.agregar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_button.Location = new System.Drawing.Point(7, 73);
            this.agregar_button.Name = "agregar_button";
            this.agregar_button.Size = new System.Drawing.Size(109, 42);
            this.agregar_button.TabIndex = 3;
            this.agregar_button.Text = "Agregar";
            this.agregar_button.UseVisualStyleBackColor = true;
            this.agregar_button.Click += new System.EventHandler(this.agregar_button_Click);
            // 
            // correos_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "correos_form";
            this.Text = "Correos";
            this.Load += new System.EventHandler(this.correos_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox correo_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repite_correo_textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Button modificar_button;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.Button agregar_button;
        private System.Windows.Forms.Button cancelar_button;
    }
}
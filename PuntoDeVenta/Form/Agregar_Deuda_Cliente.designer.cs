namespace punto_venta
{
    partial class Agregar_Deuda_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Deuda_Cliente));
            this.cliente_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deuda_textbox = new System.Windows.Forms.TextBox();
            this.agregar_button = new System.Windows.Forms.Button();
            this.idCliente_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cliente_combobox
            // 
            this.cliente_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_combobox.FormattingEnabled = true;
            this.cliente_combobox.Location = new System.Drawing.Point(77, 12);
            this.cliente_combobox.Name = "cliente_combobox";
            this.cliente_combobox.Size = new System.Drawing.Size(274, 32);
            this.cliente_combobox.TabIndex = 0;
            this.cliente_combobox.SelectedIndexChanged += new System.EventHandler(this.cliente_combobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deuda";
            // 
            // deuda_textbox
            // 
            this.deuda_textbox.Enabled = false;
            this.deuda_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deuda_textbox.Location = new System.Drawing.Point(77, 68);
            this.deuda_textbox.Name = "deuda_textbox";
            this.deuda_textbox.Size = new System.Drawing.Size(274, 29);
            this.deuda_textbox.TabIndex = 3;
            // 
            // agregar_button
            // 
            this.agregar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_button.Location = new System.Drawing.Point(139, 103);
            this.agregar_button.Name = "agregar_button";
            this.agregar_button.Size = new System.Drawing.Size(90, 38);
            this.agregar_button.TabIndex = 4;
            this.agregar_button.Text = "Agregar";
            this.agregar_button.UseVisualStyleBackColor = true;
            this.agregar_button.Click += new System.EventHandler(this.agregar_button_Click);
            // 
            // idCliente_label
            // 
            this.idCliente_label.AutoSize = true;
            this.idCliente_label.Location = new System.Drawing.Point(344, 35);
            this.idCliente_label.Name = "idCliente_label";
            this.idCliente_label.Size = new System.Drawing.Size(10, 13);
            this.idCliente_label.TabIndex = 5;
            this.idCliente_label.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cliente_combobox);
            this.panel1.Controls.Add(this.agregar_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.deuda_textbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 159);
            this.panel1.TabIndex = 6;
            // 
            // Agregar_Deuda_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 183);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idCliente_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_Deuda_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar deuda a cliente";
            this.Load += new System.EventHandler(this.Agregar_Deuda_Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cliente_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deuda_textbox;
        private System.Windows.Forms.Button agregar_button;
        private System.Windows.Forms.Label idCliente_label;
        private System.Windows.Forms.Panel panel1;
    }
}
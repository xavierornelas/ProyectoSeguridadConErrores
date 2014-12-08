namespace punto_venta
{
    partial class Agregar_Deuda_Provedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Deuda_Provedor));
            this.Cliente = new System.Windows.Forms.Label();
            this.proveedor_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pago_textbox = new System.Windows.Forms.TextBox();
            this.Pagar_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(3, 6);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(98, 24);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Proveedor";
            // 
            // proveedor_textbox
            // 
            this.proveedor_textbox.Enabled = false;
            this.proveedor_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedor_textbox.Location = new System.Drawing.Point(107, 3);
            this.proveedor_textbox.Name = "proveedor_textbox";
            this.proveedor_textbox.Size = new System.Drawing.Size(189, 29);
            this.proveedor_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pago";
            // 
            // pago_textbox
            // 
            this.pago_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pago_textbox.Location = new System.Drawing.Point(107, 38);
            this.pago_textbox.Name = "pago_textbox";
            this.pago_textbox.Size = new System.Drawing.Size(189, 29);
            this.pago_textbox.TabIndex = 3;
            this.pago_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pago_textbox_KeyPress);
            // 
            // Pagar_button
            // 
            this.Pagar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pagar_button.Location = new System.Drawing.Point(107, 73);
            this.Pagar_button.Name = "Pagar_button";
            this.Pagar_button.Size = new System.Drawing.Size(97, 34);
            this.Pagar_button.TabIndex = 4;
            this.Pagar_button.Text = "Pagar";
            this.Pagar_button.UseVisualStyleBackColor = true;
            this.Pagar_button.Click += new System.EventHandler(this.Pagar_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Cliente);
            this.panel1.Controls.Add(this.Pagar_button);
            this.panel1.Controls.Add(this.proveedor_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pago_textbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 121);
            this.panel1.TabIndex = 5;
            // 
            // Agregar_Deuda_Provedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 144);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agregar_Deuda_Provedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Credito";
            this.Load += new System.EventHandler(this.Hacer_pago_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.TextBox proveedor_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pago_textbox;
        private System.Windows.Forms.Button Pagar_button;
        private System.Windows.Forms.Panel panel1;
    }
}
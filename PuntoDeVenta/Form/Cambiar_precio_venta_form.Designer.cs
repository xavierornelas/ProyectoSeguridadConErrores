namespace punto_venta
{
    partial class Cambiar_precio_venta_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cambiar_precio_venta_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Codigo_textbox = new System.Windows.Forms.TextBox();
            this.producto_textBox = new System.Windows.Forms.TextBox();
            this.nuevo_precio_textBox = new System.Windows.Forms.TextBox();
            this.agregar_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.precio_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nuevo precio";
            // 
            // Codigo_textbox
            // 
            this.Codigo_textbox.Enabled = false;
            this.Codigo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_textbox.Location = new System.Drawing.Point(189, 22);
            this.Codigo_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Codigo_textbox.Name = "Codigo_textbox";
            this.Codigo_textbox.Size = new System.Drawing.Size(341, 34);
            this.Codigo_textbox.TabIndex = 1;
            // 
            // producto_textBox
            // 
            this.producto_textBox.Enabled = false;
            this.producto_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto_textBox.Location = new System.Drawing.Point(189, 73);
            this.producto_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.producto_textBox.Name = "producto_textBox";
            this.producto_textBox.Size = new System.Drawing.Size(341, 34);
            this.producto_textBox.TabIndex = 2;
            // 
            // nuevo_precio_textBox
            // 
            this.nuevo_precio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo_precio_textBox.Location = new System.Drawing.Point(189, 159);
            this.nuevo_precio_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuevo_precio_textBox.Name = "nuevo_precio_textBox";
            this.nuevo_precio_textBox.Size = new System.Drawing.Size(168, 34);
            this.nuevo_precio_textBox.TabIndex = 4;
            this.nuevo_precio_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuevo_precio_textBox_KeyPress);
            // 
            // agregar_button
            // 
            this.agregar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_button.Location = new System.Drawing.Point(367, 116);
            this.agregar_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agregar_button.Name = "agregar_button";
            this.agregar_button.Size = new System.Drawing.Size(169, 84);
            this.agregar_button.TabIndex = 5;
            this.agregar_button.Text = "Guardar";
            this.agregar_button.UseVisualStyleBackColor = true;
            this.agregar_button.Click += new System.EventHandler(this.agregar_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Precio";
            // 
            // precio_textBox
            // 
            this.precio_textBox.Enabled = false;
            this.precio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_textBox.Location = new System.Drawing.Point(189, 116);
            this.precio_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precio_textBox.Name = "precio_textBox";
            this.precio_textBox.Size = new System.Drawing.Size(168, 34);
            this.precio_textBox.TabIndex = 3;
            // 
            // Cambiar_precio_venta_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 214);
            this.Controls.Add(this.precio_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agregar_button);
            this.Controls.Add(this.nuevo_precio_textBox);
            this.Controls.Add(this.producto_textBox);
            this.Controls.Add(this.Codigo_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cambiar_precio_venta_form";
            this.Text = "Cambio precio de venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Codigo_textbox;
        private System.Windows.Forms.TextBox producto_textBox;
        private System.Windows.Forms.TextBox nuevo_precio_textBox;
        private System.Windows.Forms.Button agregar_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precio_textBox;
    }
}
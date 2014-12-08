namespace punto_venta
{
    partial class Nuevo_proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_proveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.domicilio_textBox = new System.Windows.Forms.TextBox();
            this.ciudad_textBox = new System.Windows.Forms.TextBox();
            this.estado_textBox = new System.Windows.Forms.TextBox();
            this.agregar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_textbox.Location = new System.Drawing.Point(105, 6);
            this.nombre_textbox.MaxLength = 100;
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.Size = new System.Drawing.Size(314, 29);
            this.nombre_textbox.TabIndex = 4;
            // 
            // domicilio_textBox
            // 
            this.domicilio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilio_textBox.Location = new System.Drawing.Point(105, 41);
            this.domicilio_textBox.MaxLength = 100;
            this.domicilio_textBox.Name = "domicilio_textBox";
            this.domicilio_textBox.Size = new System.Drawing.Size(314, 29);
            this.domicilio_textBox.TabIndex = 5;
            // 
            // ciudad_textBox
            // 
            this.ciudad_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad_textBox.Location = new System.Drawing.Point(105, 76);
            this.ciudad_textBox.MaxLength = 100;
            this.ciudad_textBox.Name = "ciudad_textBox";
            this.ciudad_textBox.Size = new System.Drawing.Size(314, 29);
            this.ciudad_textBox.TabIndex = 6;
            // 
            // estado_textBox
            // 
            this.estado_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_textBox.Location = new System.Drawing.Point(105, 111);
            this.estado_textBox.MaxLength = 100;
            this.estado_textBox.Name = "estado_textBox";
            this.estado_textBox.Size = new System.Drawing.Size(314, 29);
            this.estado_textBox.TabIndex = 7;
            this.estado_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estado_textBox_KeyPress);
            // 
            // agregar_button
            // 
            this.agregar_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.agregar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_button.Location = new System.Drawing.Point(157, 153);
            this.agregar_button.Name = "agregar_button";
            this.agregar_button.Size = new System.Drawing.Size(115, 37);
            this.agregar_button.TabIndex = 8;
            this.agregar_button.Text = "Agregar";
            this.agregar_button.UseVisualStyleBackColor = true;
            this.agregar_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nuevo_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 202);
            this.ControlBox = false;
            this.Controls.Add(this.agregar_button);
            this.Controls.Add(this.estado_textBox);
            this.Controls.Add(this.ciudad_textBox);
            this.Controls.Add(this.domicilio_textBox);
            this.Controls.Add(this.nombre_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nuevo_proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.TextBox domicilio_textBox;
        private System.Windows.Forms.TextBox ciudad_textBox;
        private System.Windows.Forms.TextBox estado_textBox;
        private System.Windows.Forms.Button agregar_button;
    }
}
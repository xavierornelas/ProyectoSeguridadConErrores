namespace punto_venta
{
    partial class Mostrar_codigo_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_codigo_form));
            this.codigo_picture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guardar_Button = new System.Windows.Forms.Button();
            this.guardarArchivo = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.codigo_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo_picture
            // 
            this.codigo_picture.BackColor = System.Drawing.Color.White;
            this.codigo_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigo_picture.Location = new System.Drawing.Point(12, 12);
            this.codigo_picture.Name = "codigo_picture";
            this.codigo_picture.Size = new System.Drawing.Size(246, 132);
            this.codigo_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.codigo_picture.TabIndex = 37;
            this.codigo_picture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Usuario";
            // 
            // guardar_Button
            // 
            this.guardar_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_Button.Location = new System.Drawing.Point(63, 150);
            this.guardar_Button.Name = "guardar_Button";
            this.guardar_Button.Size = new System.Drawing.Size(145, 45);
            this.guardar_Button.TabIndex = 40;
            this.guardar_Button.Text = "Guardar";
            this.guardar_Button.UseVisualStyleBackColor = true;
            this.guardar_Button.Click += new System.EventHandler(this.guardar_Button_Click);
            // 
            // guardarArchivo
            // 
            this.guardarArchivo.Filter = "jpeges|*.jpg|mapas de bits|*.bmp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Clave";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 42;
            // 
            // Mostrar_codigo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 203);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guardar_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo_picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mostrar_codigo_form";
            this.Text = "Código del usuario";
            this.Load += new System.EventHandler(this.Mostrar_codigo_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codigo_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox codigo_picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardar_Button;
        private System.Windows.Forms.SaveFileDialog guardarArchivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}
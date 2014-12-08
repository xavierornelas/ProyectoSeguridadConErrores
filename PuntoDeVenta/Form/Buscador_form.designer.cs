namespace punto_venta
{
    partial class Buscador_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador_form));
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Buscar_por_codigo = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por código";
            // 
            // Codigo
            // 
            this.Codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(120, 7);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(245, 29);
            this.Codigo.TabIndex = 2;
            this.Codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Codigo_KeyUp);
            // 
            // Buscar_por_codigo
            // 
            this.Buscar_por_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_por_codigo.Location = new System.Drawing.Point(371, 9);
            this.Buscar_por_codigo.Name = "Buscar_por_codigo";
            this.Buscar_por_codigo.Size = new System.Drawing.Size(78, 29);
            this.Buscar_por_codigo.TabIndex = 3;
            this.Buscar_por_codigo.Text = "Buscar";
            this.Buscar_por_codigo.UseVisualStyleBackColor = true;
            this.Buscar_por_codigo.Click += new System.EventHandler(this.Buscar_por_codigo_Click);
            // 
            // precio
            // 
            this.precio.Enabled = false;
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(120, 130);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(94, 47);
            this.precio.TabIndex = 18;
            // 
            // descripcion
            // 
            this.descripcion.Enabled = false;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(120, 42);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(245, 29);
            this.descripcion.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "PRECIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripción";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(120, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 47);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cantidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.precio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Codigo);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Buscar_por_codigo);
            this.panel1.Controls.Add(this.descripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 196);
            this.panel1.TabIndex = 21;
            // 
            // Buscador_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 220);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Buscador_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de productos por codigo";
            this.Load += new System.EventHandler(this.Buscador_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Button Buscar_por_codigo;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
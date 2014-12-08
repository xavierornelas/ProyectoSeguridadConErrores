namespace punto_venta
{
    partial class Buscador_form_nombre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador_form_nombre));
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Buscar_por_nombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.cantidad_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(141, 3);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(220, 29);
            this.nombre.TabIndex = 5;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            this.nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nombre_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Por descripión";
            // 
            // Buscar_por_nombre
            // 
            this.Buscar_por_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_por_nombre.Location = new System.Drawing.Point(380, 12);
            this.Buscar_por_nombre.Name = "Buscar_por_nombre";
            this.Buscar_por_nombre.Size = new System.Drawing.Size(78, 29);
            this.Buscar_por_nombre.TabIndex = 6;
            this.Buscar_por_nombre.Text = "Buscar";
            this.Buscar_por_nombre.UseVisualStyleBackColor = true;
            this.Buscar_por_nombre.Click += new System.EventHandler(this.Buscar_por_nombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "PRECIO";
            // 
            // Codigo
            // 
            this.Codigo.Enabled = false;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(141, 38);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(220, 29);
            this.Codigo.TabIndex = 10;
            // 
            // precio
            // 
            this.precio.Enabled = false;
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(141, 108);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(94, 47);
            this.precio.TabIndex = 12;
            // 
            // cantidad_textbox
            // 
            this.cantidad_textbox.Enabled = false;
            this.cantidad_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_textbox.Location = new System.Drawing.Point(141, 73);
            this.cantidad_textbox.Name = "cantidad_textbox";
            this.cantidad_textbox.Size = new System.Drawing.Size(220, 29);
            this.cantidad_textbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.precio);
            this.panel1.Controls.Add(this.cantidad_textbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.Codigo);
            this.panel1.Controls.Add(this.Buscar_por_nombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 174);
            this.panel1.TabIndex = 15;
            // 
            // Buscador_form_nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 199);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Buscador_form_nombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador por nombre";
            this.Load += new System.EventHandler(this.Buscador_form_nombre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buscar_por_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox cantidad_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}
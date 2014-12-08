namespace punto_venta
{
    partial class Paquetes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paquetes_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_version = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.verificar_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codigo_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label_version);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.verificar_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.codigo_textbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 163);
            this.panel1.TabIndex = 40;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.Location = new System.Drawing.Point(169, 111);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(60, 24);
            this.label_version.TabIndex = 38;
            this.label_version.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tu licencia es: ";
            // 
            // verificar_button
            // 
            this.verificar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificar_button.Location = new System.Drawing.Point(220, 55);
            this.verificar_button.Name = "verificar_button";
            this.verificar_button.Size = new System.Drawing.Size(167, 34);
            this.verificar_button.TabIndex = 36;
            this.verificar_button.Text = "Verificar";
            this.verificar_button.UseVisualStyleBackColor = true;
            this.verificar_button.Click += new System.EventHandler(this.verificar_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código";
            // 
            // codigo_textbox
            // 
            this.codigo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_textbox.Location = new System.Drawing.Point(80, 23);
            this.codigo_textbox.MaxLength = 100;
            this.codigo_textbox.Name = "codigo_textbox";
            this.codigo_textbox.PasswordChar = '*';
            this.codigo_textbox.Size = new System.Drawing.Size(449, 26);
            this.codigo_textbox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Versión: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "label3";
            // 
            // Paquetes_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 185);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paquetes_form";
            this.Text = "Paquetes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigo_textbox;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verificar_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
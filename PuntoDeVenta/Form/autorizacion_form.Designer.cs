namespace punto_venta
{
    partial class autorizacion_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autorizacion_form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clave_scanner_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autorizar_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Contra = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 263);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clave_scanner_textBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clave escanner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clave_scanner_textBox
            // 
            this.clave_scanner_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_scanner_textBox.Location = new System.Drawing.Point(21, 76);
            this.clave_scanner_textBox.MaxLength = 100;
            this.clave_scanner_textBox.Name = "clave_scanner_textBox";
            this.clave_scanner_textBox.PasswordChar = '*';
            this.clave_scanner_textBox.Size = new System.Drawing.Size(286, 29);
            this.clave_scanner_textBox.TabIndex = 2;
            this.clave_scanner_textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clave_scanner_textBox_MouseClick);
            this.clave_scanner_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clave_scanner_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clave de escáner";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.user_textBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.autorizar_button);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Contra);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuario y contraseña";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPage2_MouseClick);
            // 
            // user_textBox
            // 
            this.user_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_textBox.Location = new System.Drawing.Point(36, 52);
            this.user_textBox.MaxLength = 100;
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(251, 29);
            this.user_textBox.TabIndex = 3;
            this.user_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // autorizar_button
            // 
            this.autorizar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorizar_button.Location = new System.Drawing.Point(116, 159);
            this.autorizar_button.Name = "autorizar_button";
            this.autorizar_button.Size = new System.Drawing.Size(75, 35);
            this.autorizar_button.TabIndex = 5;
            this.autorizar_button.Text = "Autorizar";
            this.autorizar_button.UseVisualStyleBackColor = true;
            this.autorizar_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // Contra
            // 
            this.Contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contra.Location = new System.Drawing.Point(36, 124);
            this.Contra.MaxLength = 100;
            this.Contra.Name = "Contra";
            this.Contra.PasswordChar = '*';
            this.Contra.Size = new System.Drawing.Size(251, 29);
            this.Contra.TabIndex = 4;
            this.Contra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contra_KeyPress);
            // 
            // autorizacion_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 289);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "autorizacion_form";
            this.Text = "Autorización";
            this.Activated += new System.EventHandler(this.autorizacion_form_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.autorizacion_form_FormClosing);
            this.Load += new System.EventHandler(this.autorizacion_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox clave_scanner_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button autorizar_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contra;
    }
}
namespace punto_venta
{
    partial class Corte_por_rango_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corte_por_rango_form));
            this.fecha1_picker = new System.Windows.Forms.DateTimePicker();
            this.fecha2Picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.realizar_corte_button = new System.Windows.Forms.Button();
            this.generarPDF_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.total_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fecha1_picker
            // 
            this.fecha1_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha1_picker.Location = new System.Drawing.Point(88, 3);
            this.fecha1_picker.Name = "fecha1_picker";
            this.fecha1_picker.Size = new System.Drawing.Size(376, 29);
            this.fecha1_picker.TabIndex = 0;
            // 
            // fecha2Picker
            // 
            this.fecha2Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha2Picker.Location = new System.Drawing.Point(88, 38);
            this.fecha2Picker.Name = "fecha2Picker";
            this.fecha2Picker.Size = new System.Drawing.Size(376, 29);
            this.fecha2Picker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha 2";
            // 
            // realizar_corte_button
            // 
            this.realizar_corte_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizar_corte_button.Location = new System.Drawing.Point(496, 12);
            this.realizar_corte_button.Name = "realizar_corte_button";
            this.realizar_corte_button.Size = new System.Drawing.Size(145, 80);
            this.realizar_corte_button.TabIndex = 4;
            this.realizar_corte_button.Text = "Realizar corte";
            this.realizar_corte_button.UseVisualStyleBackColor = true;
            this.realizar_corte_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // generarPDF_button
            // 
            this.generarPDF_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarPDF_button.Location = new System.Drawing.Point(647, 12);
            this.generarPDF_button.Name = "generarPDF_button";
            this.generarPDF_button.Size = new System.Drawing.Size(144, 80);
            this.generarPDF_button.TabIndex = 5;
            this.generarPDF_button.Text = "Generar PDF";
            this.generarPDF_button.UseVisualStyleBackColor = true;
            this.generarPDF_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(779, 262);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fecha1_picker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fecha2Picker);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 80);
            this.panel1.TabIndex = 7;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(13, 112);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(10, 13);
            this.total_label.TabIndex = 8;
            this.total_label.Text = "-";
            // 
            // Corte_por_rango_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 405);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generarPDF_button);
            this.Controls.Add(this.realizar_corte_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Corte_por_rango_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corte por rango";
            this.Load += new System.EventHandler(this.Corte_por_rango_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha1_picker;
        private System.Windows.Forms.DateTimePicker fecha2Picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button realizar_corte_button;
        private System.Windows.Forms.Button generarPDF_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label total_label;

    }
}
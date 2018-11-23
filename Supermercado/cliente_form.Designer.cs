namespace Supermercado
{
    partial class cliente_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomc_text = new System.Windows.Forms.TextBox();
            this.apec_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cedc_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dirc_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telc_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente";
            // 
            // nomc_text
            // 
            this.nomc_text.Location = new System.Drawing.Point(39, 67);
            this.nomc_text.Name = "nomc_text";
            this.nomc_text.Size = new System.Drawing.Size(100, 20);
            this.nomc_text.TabIndex = 1;
            // 
            // apec_text
            // 
            this.apec_text.Location = new System.Drawing.Point(39, 133);
            this.apec_text.Name = "apec_text";
            this.apec_text.Size = new System.Drawing.Size(100, 20);
            this.apec_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido Cliente";
            // 
            // cedc_text
            // 
            this.cedc_text.Location = new System.Drawing.Point(39, 202);
            this.cedc_text.Name = "cedc_text";
            this.cedc_text.Size = new System.Drawing.Size(100, 20);
            this.cedc_text.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cedula Cliente";
            // 
            // dirc_text
            // 
            this.dirc_text.Location = new System.Drawing.Point(215, 67);
            this.dirc_text.Name = "dirc_text";
            this.dirc_text.Size = new System.Drawing.Size(100, 20);
            this.dirc_text.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion Cliente";
            // 
            // telc_text
            // 
            this.telc_text.Location = new System.Drawing.Point(212, 133);
            this.telc_text.Name = "telc_text";
            this.telc_text.Size = new System.Drawing.Size(100, 20);
            this.telc_text.TabIndex = 9;
            this.telc_text.TextChanged += new System.EventHandler(this.telc_text_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cliente_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telc_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dirc_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cedc_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apec_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomc_text);
            this.Controls.Add(this.label1);
            this.Name = "cliente_form";
            this.Text = "cliente_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomc_text;
        private System.Windows.Forms.TextBox apec_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cedc_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dirc_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telc_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}
namespace Supermercado
{
    partial class producto_form
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
            this.nombrePd_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.valorPd_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombrePd_text
            // 
            this.nombrePd_text.Location = new System.Drawing.Point(134, 52);
            this.nombrePd_text.Name = "nombrePd_text";
            this.nombrePd_text.Size = new System.Drawing.Size(100, 20);
            this.nombrePd_text.TabIndex = 1;
            this.nombrePd_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // valorPd_text
            // 
            this.valorPd_text.Location = new System.Drawing.Point(134, 113);
            this.valorPd_text.Name = "valorPd_text";
            this.valorPd_text.Size = new System.Drawing.Size(100, 20);
            this.valorPd_text.TabIndex = 3;
            this.valorPd_text.TextChanged += new System.EventHandler(this.valorPd_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Costo del producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // producto_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valorPd_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombrePd_text);
            this.Controls.Add(this.label1);
            this.Name = "producto_form";
            this.Text = "producto_form";
            this.Load += new System.EventHandler(this.producto_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombrePd_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox valorPd_text;
        private System.Windows.Forms.Label label2;
    }
}
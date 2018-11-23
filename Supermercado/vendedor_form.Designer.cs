namespace Supermercado
{
    partial class vendedor_form
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
            this.nomven_txt = new System.Windows.Forms.TextBox();
            this.apeven_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cedven_txt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Vendedor";
            // 
            // nomven_txt
            // 
            this.nomven_txt.Location = new System.Drawing.Point(129, 42);
            this.nomven_txt.Name = "nomven_txt";
            this.nomven_txt.Size = new System.Drawing.Size(100, 20);
            this.nomven_txt.TabIndex = 1;
            // 
            // apeven_txt
            // 
            this.apeven_txt.Location = new System.Drawing.Point(129, 93);
            this.apeven_txt.Name = "apeven_txt";
            this.apeven_txt.Size = new System.Drawing.Size(100, 20);
            this.apeven_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido del Vendedor";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // cedven_txt
            // 
            this.cedven_txt.AutoSize = true;
            this.cedven_txt.Location = new System.Drawing.Point(126, 134);
            this.cedven_txt.Name = "cedven_txt";
            this.cedven_txt.Size = new System.Drawing.Size(106, 13);
            this.cedven_txt.TabIndex = 4;
            this.cedven_txt.Text = "Cedula del Vendedor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vendedor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cedven_txt);
            this.Controls.Add(this.apeven_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomven_txt);
            this.Controls.Add(this.label1);
            this.Name = "vendedor_form";
            this.Text = "vendedor_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomven_txt;
        private System.Windows.Forms.TextBox apeven_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label cedven_txt;
        private System.Windows.Forms.Button button1;
    }
}
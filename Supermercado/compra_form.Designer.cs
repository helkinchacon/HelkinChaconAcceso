namespace Supermercado
{
    partial class compra_form
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
            this.idpdcm_txt = new System.Windows.Forms.TextBox();
            this.nompdcm_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantcm_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valcm_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.feccm_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "idProducto";
            // 
            // idpdcm_txt
            // 
            this.idpdcm_txt.Location = new System.Drawing.Point(12, 55);
            this.idpdcm_txt.Name = "idpdcm_txt";
            this.idpdcm_txt.Size = new System.Drawing.Size(100, 20);
            this.idpdcm_txt.TabIndex = 1;
            // 
            // nompdcm_txt
            // 
            this.nompdcm_txt.Location = new System.Drawing.Point(12, 107);
            this.nompdcm_txt.Name = "nompdcm_txt";
            this.nompdcm_txt.Size = new System.Drawing.Size(100, 20);
            this.nompdcm_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "id del Proovedor";
            // 
            // cantcm_txt
            // 
            this.cantcm_txt.Location = new System.Drawing.Point(12, 163);
            this.cantcm_txt.Name = "cantcm_txt";
            this.cantcm_txt.Size = new System.Drawing.Size(100, 20);
            this.cantcm_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad de la Compra";
            // 
            // valcm_txt
            // 
            this.valcm_txt.Location = new System.Drawing.Point(232, 55);
            this.valcm_txt.Name = "valcm_txt";
            this.valcm_txt.Size = new System.Drawing.Size(100, 20);
            this.valcm_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor de la Compra";
            // 
            // feccm_txt
            // 
            this.feccm_txt.Location = new System.Drawing.Point(232, 107);
            this.feccm_txt.Name = "feccm_txt";
            this.feccm_txt.Size = new System.Drawing.Size(100, 20);
            this.feccm_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de la Compra";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // compra_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.feccm_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valcm_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantcm_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nompdcm_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idpdcm_txt);
            this.Controls.Add(this.label1);
            this.Name = "compra_form";
            this.Text = "compra_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idpdcm_txt;
        private System.Windows.Forms.TextBox nompdcm_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantcm_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valcm_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox feccm_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}
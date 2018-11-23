namespace Supermercado
{
    partial class venta_form
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
            this.idpdvn_txt = new System.Windows.Forms.TextBox();
            this.idvevn_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idclivn_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valvn_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fecvn_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cantvn_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del Producto";
            // 
            // idpdvn_txt
            // 
            this.idpdvn_txt.Location = new System.Drawing.Point(12, 59);
            this.idpdvn_txt.Name = "idpdvn_txt";
            this.idpdvn_txt.Size = new System.Drawing.Size(100, 20);
            this.idpdvn_txt.TabIndex = 1;
            // 
            // idvevn_txt
            // 
            this.idvevn_txt.Location = new System.Drawing.Point(15, 127);
            this.idvevn_txt.Name = "idvevn_txt";
            this.idvevn_txt.Size = new System.Drawing.Size(100, 20);
            this.idvevn_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id del vendedor";
            // 
            // idclivn_txt
            // 
            this.idclivn_txt.Location = new System.Drawing.Point(15, 201);
            this.idclivn_txt.Name = "idclivn_txt";
            this.idclivn_txt.Size = new System.Drawing.Size(100, 20);
            this.idclivn_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "id del Cliente";
            // 
            // valvn_txt
            // 
            this.valvn_txt.Location = new System.Drawing.Point(228, 59);
            this.valvn_txt.Name = "valvn_txt";
            this.valvn_txt.Size = new System.Drawing.Size(100, 20);
            this.valvn_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor de la Venta";
            // 
            // fecvn_txt
            // 
            this.fecvn_txt.Location = new System.Drawing.Point(228, 127);
            this.fecvn_txt.Name = "fecvn_txt";
            this.fecvn_txt.Size = new System.Drawing.Size(100, 20);
            this.fecvn_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "FechaVenta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cantvn_txt
            // 
            this.cantvn_txt.Location = new System.Drawing.Point(225, 201);
            this.cantvn_txt.Name = "cantvn_txt";
            this.cantvn_txt.Size = new System.Drawing.Size(100, 20);
            this.cantvn_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad venta";
            // 
            // venta_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 276);
            this.Controls.Add(this.cantvn_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fecvn_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valvn_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idclivn_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idvevn_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idpdvn_txt);
            this.Controls.Add(this.label1);
            this.Name = "venta_form";
            this.Text = "venta_form";
            this.Load += new System.EventHandler(this.venta_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idpdvn_txt;
        private System.Windows.Forms.TextBox idvevn_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idclivn_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valvn_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fecvn_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cantvn_txt;
        private System.Windows.Forms.Label label6;
    }
}
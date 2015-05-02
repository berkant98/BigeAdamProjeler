namespace Döngüler_Faktöriyel
{
    partial class Form1
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFaktoriyelHesapla = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(69, 67);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(202, 20);
            this.txtDeger.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(439, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnFaktoriyelHesapla
            // 
            this.btnFaktoriyelHesapla.Location = new System.Drawing.Point(101, 119);
            this.btnFaktoriyelHesapla.Name = "btnFaktoriyelHesapla";
            this.btnFaktoriyelHesapla.Size = new System.Drawing.Size(123, 55);
            this.btnFaktoriyelHesapla.TabIndex = 3;
            this.btnFaktoriyelHesapla.Text = "Faktöriyel Hesapla";
            this.btnFaktoriyelHesapla.UseVisualStyleBackColor = true;
            this.btnFaktoriyelHesapla.Click += new System.EventHandler(this.btnFaktoriyelHesapla_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(101, 180);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(123, 61);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "While";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(101, 247);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(123, 53);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Do";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 366);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnFaktoriyelHesapla);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFaktoriyelHesapla;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}


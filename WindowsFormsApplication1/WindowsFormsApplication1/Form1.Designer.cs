namespace WindowsFormsApplication1
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
            this.btnTumListe = new System.Windows.Forms.Button();
            this.btnTekSayilar = new System.Windows.Forms.Button();
            this.btnCiftSayilar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTumListe
            // 
            this.btnTumListe.Location = new System.Drawing.Point(26, 12);
            this.btnTumListe.Name = "btnTumListe";
            this.btnTumListe.Size = new System.Drawing.Size(118, 42);
            this.btnTumListe.TabIndex = 0;
            this.btnTumListe.Text = "Tüm Listeyi Göster";
            this.btnTumListe.UseVisualStyleBackColor = true;
            this.btnTumListe.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTekSayilar
            // 
            this.btnTekSayilar.Location = new System.Drawing.Point(26, 60);
            this.btnTekSayilar.Name = "btnTekSayilar";
            this.btnTekSayilar.Size = new System.Drawing.Size(118, 48);
            this.btnTekSayilar.TabIndex = 1;
            this.btnTekSayilar.Text = "Tek Sayılar";
            this.btnTekSayilar.UseVisualStyleBackColor = true;
            this.btnTekSayilar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCiftSayilar
            // 
            this.btnCiftSayilar.Location = new System.Drawing.Point(26, 114);
            this.btnCiftSayilar.Name = "btnCiftSayilar";
            this.btnCiftSayilar.Size = new System.Drawing.Size(118, 47);
            this.btnCiftSayilar.TabIndex = 2;
            this.btnCiftSayilar.Text = "Çift Sayılar";
            this.btnCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "2\'ye Bölünenler";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(173, 18);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(154, 199);
            this.lbListe.TabIndex = 4;
            this.lbListe.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 383);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCiftSayilar);
            this.Controls.Add(this.btnTekSayilar);
            this.Controls.Add(this.btnTumListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTumListe;
        private System.Windows.Forms.Button btnTekSayilar;
        private System.Windows.Forms.Button btnCiftSayilar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbListe;
    }
}


namespace WindowsFormsApplication4
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
            this.cbKoltukTipi = new System.Windows.Forms.ComboBox();
            this.lbKoltukTipi = new System.Windows.Forms.Label();
            this.btnKoltuklarıYerlestir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKoltukTipi
            // 
            this.cbKoltukTipi.FormattingEnabled = true;
            this.cbKoltukTipi.Items.AddRange(new object[] {
            "Pencere",
            "Koridor"});
            this.cbKoltukTipi.Location = new System.Drawing.Point(290, 242);
            this.cbKoltukTipi.Name = "cbKoltukTipi";
            this.cbKoltukTipi.Size = new System.Drawing.Size(121, 21);
            this.cbKoltukTipi.TabIndex = 0;
            // 
            // lbKoltukTipi
            // 
            this.lbKoltukTipi.AutoSize = true;
            this.lbKoltukTipi.Location = new System.Drawing.Point(287, 215);
            this.lbKoltukTipi.Name = "lbKoltukTipi";
            this.lbKoltukTipi.Size = new System.Drawing.Size(57, 13);
            this.lbKoltukTipi.TabIndex = 1;
            this.lbKoltukTipi.Text = "Koltuk Tipi";
            // 
            // btnKoltuklarıYerlestir
            // 
            this.btnKoltuklarıYerlestir.Location = new System.Drawing.Point(290, 78);
            this.btnKoltuklarıYerlestir.Name = "btnKoltuklarıYerlestir";
            this.btnKoltuklarıYerlestir.Size = new System.Drawing.Size(75, 23);
            this.btnKoltuklarıYerlestir.TabIndex = 2;
            this.btnKoltuklarıYerlestir.Text = "button1";
            this.btnKoltuklarıYerlestir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 400);
            this.Controls.Add(this.btnKoltuklarıYerlestir);
            this.Controls.Add(this.lbKoltukTipi);
            this.Controls.Add(this.cbKoltukTipi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKoltukTipi;
        private System.Windows.Forms.Label lbKoltukTipi;
        private System.Windows.Forms.Button btnKoltuklarıYerlestir;
    }
}


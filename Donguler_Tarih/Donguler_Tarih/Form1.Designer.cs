namespace Donguler_Tarih
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
            this.lblGun = new System.Windows.Forms.Label();
            this.cbGun = new System.Windows.Forms.ComboBox();
            this.cbAy = new System.Windows.Forms.ComboBox();
            this.cbYil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(12, 29);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(27, 13);
            this.lblGun.TabIndex = 0;
            this.lblGun.Text = "Gün";
            // 
            // cbGun
            // 
            this.cbGun.FormattingEnabled = true;
            this.cbGun.Location = new System.Drawing.Point(12, 45);
            this.cbGun.Name = "cbGun";
            this.cbGun.Size = new System.Drawing.Size(45, 21);
            this.cbGun.TabIndex = 1;
            this.cbGun.SelectedIndexChanged += new System.EventHandler(this.cbGun_SelectedIndexChanged);
            // 
            // cbAy
            // 
            this.cbAy.FormattingEnabled = true;
            this.cbAy.Location = new System.Drawing.Point(73, 45);
            this.cbAy.Name = "cbAy";
            this.cbAy.Size = new System.Drawing.Size(40, 21);
            this.cbAy.TabIndex = 2;
            // 
            // cbYil
            // 
            this.cbYil.FormattingEnabled = true;
            this.cbYil.Location = new System.Drawing.Point(140, 45);
            this.cbYil.Name = "cbYil";
            this.cbYil.Size = new System.Drawing.Size(77, 21);
            this.cbYil.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yıl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYil);
            this.Controls.Add(this.cbAy);
            this.Controls.Add(this.cbGun);
            this.Controls.Add(this.lblGun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.ComboBox cbGun;
        private System.Windows.Forms.ComboBox cbAy;
        private System.Windows.Forms.ComboBox cbYil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}


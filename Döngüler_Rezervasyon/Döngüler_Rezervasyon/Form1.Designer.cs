namespace Döngüler_Rezervasyon
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.nmrcUpDwn1 = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwn2 = new System.Windows.Forms.NumericUpDown();
            this.lbl2 = new System.Windows.Forms.Label();
            this.bttn1 = new System.Windows.Forms.Button();
            this.scAnaPanel = new System.Windows.Forms.SplitContainer();
            this.pnlSecenekler = new System.Windows.Forms.Panel();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.lbl3 = new System.Windows.Forms.Label();
            this.rbHicbiri = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scAnaPanel)).BeginInit();
            this.scAnaPanel.Panel1.SuspendLayout();
            this.scAnaPanel.Panel2.SuspendLayout();
            this.scAnaPanel.SuspendLayout();
            this.pnlSecenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(11, 6);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(117, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Yan Yana Koltuk Sayısı";
            // 
            // nmrcUpDwn1
            // 
            this.nmrcUpDwn1.Location = new System.Drawing.Point(164, 4);
            this.nmrcUpDwn1.Name = "nmrcUpDwn1";
            this.nmrcUpDwn1.Size = new System.Drawing.Size(120, 20);
            this.nmrcUpDwn1.TabIndex = 1;
            // 
            // nmrcUpDwn2
            // 
            this.nmrcUpDwn2.Location = new System.Drawing.Point(164, 27);
            this.nmrcUpDwn2.Name = "nmrcUpDwn2";
            this.nmrcUpDwn2.Size = new System.Drawing.Size(120, 20);
            this.nmrcUpDwn2.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(11, 29);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(128, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Arka Arkaya Koltuk Sayısı";
            // 
            // bttn1
            // 
            this.bttn1.Location = new System.Drawing.Point(299, 4);
            this.bttn1.Name = "bttn1";
            this.bttn1.Size = new System.Drawing.Size(118, 46);
            this.bttn1.TabIndex = 4;
            this.bttn1.Text = "Koltukları Yerleştir";
            this.bttn1.UseVisualStyleBackColor = true;
            this.bttn1.Click += new System.EventHandler(this.bttn1_Click);
            // 
            // scAnaPanel
            // 
            this.scAnaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scAnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scAnaPanel.Location = new System.Drawing.Point(0, 0);
            this.scAnaPanel.Name = "scAnaPanel";
            this.scAnaPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scAnaPanel.Panel1
            // 
            this.scAnaPanel.Panel1.Controls.Add(this.bttn1);
            this.scAnaPanel.Panel1.Controls.Add(this.lbl1);
            this.scAnaPanel.Panel1.Controls.Add(this.nmrcUpDwn1);
            this.scAnaPanel.Panel1.Controls.Add(this.nmrcUpDwn2);
            this.scAnaPanel.Panel1.Controls.Add(this.lbl2);
            // 
            // scAnaPanel.Panel2
            // 
            this.scAnaPanel.Panel2.Controls.Add(this.pnlSecenekler);
            this.scAnaPanel.Size = new System.Drawing.Size(482, 412);
            this.scAnaPanel.SplitterDistance = 55;
            this.scAnaPanel.TabIndex = 5;
            // 
            // pnlSecenekler
            // 
            this.pnlSecenekler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecenekler.Controls.Add(this.rbHicbiri);
            this.pnlSecenekler.Controls.Add(this.lbl3);
            this.pnlSecenekler.Controls.Add(this.rbKadin);
            this.pnlSecenekler.Controls.Add(this.rbErkek);
            this.pnlSecenekler.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSecenekler.Location = new System.Drawing.Point(280, 0);
            this.pnlSecenekler.Name = "pnlSecenekler";
            this.pnlSecenekler.Size = new System.Drawing.Size(200, 351);
            this.pnlSecenekler.TabIndex = 0;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Checked = true;
            this.rbErkek.ForeColor = System.Drawing.Color.Black;
            this.rbErkek.Location = new System.Drawing.Point(31, 16);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 0;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(31, 39);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 1;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(28, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(43, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Cinsiyet";
            // 
            // rbHicbiri
            // 
            this.rbHicbiri.AutoSize = true;
            this.rbHicbiri.Location = new System.Drawing.Point(31, 63);
            this.rbHicbiri.Name = "rbHicbiri";
            this.rbHicbiri.Size = new System.Drawing.Size(54, 17);
            this.rbHicbiri.TabIndex = 3;
            this.rbHicbiri.Text = "Hiçbiri";
            this.rbHicbiri.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 412);
            this.Controls.Add(this.scAnaPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwn2)).EndInit();
            this.scAnaPanel.Panel1.ResumeLayout(false);
            this.scAnaPanel.Panel1.PerformLayout();
            this.scAnaPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scAnaPanel)).EndInit();
            this.scAnaPanel.ResumeLayout(false);
            this.pnlSecenekler.ResumeLayout(false);
            this.pnlSecenekler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.NumericUpDown nmrcUpDwn1;
        private System.Windows.Forms.NumericUpDown nmrcUpDwn2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button bttn1;
        private System.Windows.Forms.SplitContainer scAnaPanel;
        private System.Windows.Forms.Panel pnlSecenekler;
        private System.Windows.Forms.RadioButton rbHicbiri;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
    }
}


﻿namespace Döngüler_while
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
            this.components = new System.ComponentModel.Container();
            this.btnRastgeleSayi = new System.Windows.Forms.Button();
            this.lblRastgeleSayi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrWhile = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRastgeleSayi
            // 
            this.btnRastgeleSayi.Location = new System.Drawing.Point(23, 12);
            this.btnRastgeleSayi.Name = "btnRastgeleSayi";
            this.btnRastgeleSayi.Size = new System.Drawing.Size(120, 36);
            this.btnRastgeleSayi.TabIndex = 0;
            this.btnRastgeleSayi.Text = "Rastgele Sayı Bul";
            this.btnRastgeleSayi.UseVisualStyleBackColor = true;
            this.btnRastgeleSayi.Click += new System.EventHandler(this.btnRastgeleSayi_Click);
            // 
            // lblRastgeleSayi
            // 
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "                                     ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRastgeleSayi);
            this.Controls.Add(this.btnRastgeleSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRastgeleSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrWhile;
    }
}


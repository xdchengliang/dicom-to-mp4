﻿namespace cs_proj05_dicom2mov
{
    partial class ProgressWindow
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.popuplabel = new System.Windows.Forms.Label();
            this.popupprogtext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(268, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // popuplabel
            // 
            this.popuplabel.AutoSize = true;
            this.popuplabel.Location = new System.Drawing.Point(15, 35);
            this.popuplabel.Name = "popuplabel";
            this.popuplabel.Size = new System.Drawing.Size(29, 13);
            this.popuplabel.TabIndex = 1;
            this.popuplabel.Text = "label";
            this.popuplabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // popupprogtext
            // 
            this.popupprogtext.AutoSize = true;
            this.popupprogtext.Location = new System.Drawing.Point(15, 48);
            this.popupprogtext.Name = "popupprogtext";
            this.popupprogtext.Size = new System.Drawing.Size(45, 13);
            this.popupprogtext.TabIndex = 3;
            this.popupprogtext.Text = "progtext";
            // 
            // ProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 73);
            this.Controls.Add(this.popupprogtext);
            this.Controls.Add(this.popuplabel);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressWindow";
            this.Load += new System.EventHandler(this.ProgressWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label popuplabel;
        private System.Windows.Forms.Label popupprogtext;

        

    }
}
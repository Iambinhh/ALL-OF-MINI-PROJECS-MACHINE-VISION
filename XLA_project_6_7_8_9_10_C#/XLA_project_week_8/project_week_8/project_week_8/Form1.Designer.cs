﻿namespace project_week_8
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
            this.pictureBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxHue = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxSaturation = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxValue = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxHSV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHSV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHinhGoc
            // 
            this.pictureBoxHinhGoc.Location = new System.Drawing.Point(12, 29);
            this.pictureBoxHinhGoc.Name = "pictureBoxHinhGoc";
            this.pictureBoxHinhGoc.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinhGoc.TabIndex = 0;
            this.pictureBoxHinhGoc.TabStop = false;
            this.pictureBoxHinhGoc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HINH GOC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "HINH HUE";
            // 
            // pictureBoxHue
            // 
            this.pictureBoxHue.Location = new System.Drawing.Point(15, 397);
            this.pictureBoxHue.Name = "pictureBoxHue";
            this.pictureBoxHue.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxHue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHue.TabIndex = 2;
            this.pictureBoxHue.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(340, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "HINH SATURATION";
            // 
            // pictureBoxSaturation
            // 
            this.pictureBoxSaturation.Location = new System.Drawing.Point(340, 397);
            this.pictureBoxSaturation.Name = "pictureBoxSaturation";
            this.pictureBoxSaturation.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxSaturation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSaturation.TabIndex = 4;
            this.pictureBoxSaturation.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(671, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "HINH VALUE";
            // 
            // pictureBoxValue
            // 
            this.pictureBoxValue.Location = new System.Drawing.Point(671, 397);
            this.pictureBoxValue.Name = "pictureBoxValue";
            this.pictureBoxValue.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxValue.TabIndex = 6;
            this.pictureBoxValue.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(989, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "HINH HSV";
            // 
            // pictureBoxHSV
            // 
            this.pictureBoxHSV.Location = new System.Drawing.Point(989, 397);
            this.pictureBoxHSV.Name = "pictureBoxHSV";
            this.pictureBoxHSV.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHSV.TabIndex = 8;
            this.pictureBoxHSV.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 725);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxHSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxSaturation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxHue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxHue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxSaturation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxHSV;
    }
}


namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNguong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.pictureBoxDetection = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBar_DuongBien = new System.Windows.Forms.HScrollBar();
            this.Nguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetection)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Threshold";
            // 
            // tbNguong
            // 
            this.tbNguong.Location = new System.Drawing.Point(121, 330);
            this.tbNguong.Name = "tbNguong";
            this.tbNguong.Size = new System.Drawing.Size(151, 22);
            this.tbNguong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(-10, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "DECTECTION EDGE IN GRAYCOLOR";
            // 
            // pictureBoxHinhGoc
            // 
            this.pictureBoxHinhGoc.Location = new System.Drawing.Point(403, 171);
            this.pictureBoxHinhGoc.Name = "pictureBoxHinhGoc";
            this.pictureBoxHinhGoc.Size = new System.Drawing.Size(422, 364);
            this.pictureBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinhGoc.TabIndex = 8;
            this.pictureBoxHinhGoc.TabStop = false;
            // 
            // pictureBoxDetection
            // 
            this.pictureBoxDetection.Location = new System.Drawing.Point(897, 171);
            this.pictureBoxDetection.Name = "pictureBoxDetection";
            this.pictureBoxDetection.Size = new System.Drawing.Size(417, 364);
            this.pictureBoxDetection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetection.TabIndex = 9;
            this.pictureBoxDetection.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(378, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "RAW RGB IMAGE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(870, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "IMAGE AFTER DETECTION";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(74, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "DETECTION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar_DuongBien
            // 
            this.hScrollBar_DuongBien.Location = new System.Drawing.Point(9, 551);
            this.hScrollBar_DuongBien.Name = "hScrollBar_DuongBien";
            this.hScrollBar_DuongBien.Size = new System.Drawing.Size(331, 34);
            this.hScrollBar_DuongBien.TabIndex = 13;
            // 
            // Nguong
            // 
            this.Nguong.AutoSize = true;
            this.Nguong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nguong.Location = new System.Drawing.Point(5, 515);
            this.Nguong.Name = "Nguong";
            this.Nguong.Size = new System.Drawing.Size(93, 20);
            this.Nguong.TabIndex = 14;
            this.Nguong.Text = "Threshold: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 704);
            this.Controls.Add(this.Nguong);
            this.Controls.Add(this.hScrollBar_DuongBien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBoxDetection);
            this.Controls.Add(this.pictureBoxHinhGoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNguong);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNguong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxHinhGoc;
        private System.Windows.Forms.PictureBox pictureBoxDetection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar hScrollBar_DuongBien;
        private System.Windows.Forms.Label Nguong;
    }
}


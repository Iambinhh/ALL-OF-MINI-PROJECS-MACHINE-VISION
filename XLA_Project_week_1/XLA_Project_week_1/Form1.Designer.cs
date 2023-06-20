namespace XLA_Project_week_1
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
            this.image1 = new Emgu.CV.UI.ImageBox();
            this.lblAnhthunhat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(12, 36);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(476, 265);
            this.image1.TabIndex = 2;
            this.image1.TabStop = false;
            // 
            // lblAnhthunhat
            // 
            this.lblAnhthunhat.AutoSize = true;
            this.lblAnhthunhat.Location = new System.Drawing.Point(243, 333);
            this.lblAnhthunhat.Name = "lblAnhthunhat";
            this.lblAnhthunhat.Size = new System.Drawing.Size(89, 17);
            this.lblAnhthunhat.TabIndex = 3;
            this.lblAnhthunhat.Text = "Ảnh thứ nhất";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnhthunhat);
            this.Controls.Add(this.image1);
            this.Name = "Form1";
            this.Text = "Hiển thị ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox image1;
        private System.Windows.Forms.Label lblAnhthunhat;
    }
}


namespace project_11
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
            this.pictureBoxHinhgoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxHinhLamMo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhLamMo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHinhgoc
            // 
            this.pictureBoxHinhgoc.Location = new System.Drawing.Point(12, 75);
            this.pictureBoxHinhgoc.Name = "pictureBoxHinhgoc";
            this.pictureBoxHinhgoc.Size = new System.Drawing.Size(512, 512);
            this.pictureBoxHinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinhgoc.TabIndex = 0;
            this.pictureBoxHinhgoc.TabStop = false;
            this.pictureBoxHinhgoc.Click += new System.EventHandler(this.pictureBoxHinhgoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HINH RGB GOC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(713, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "HINH DUOC LAM MO";
            // 
            // pictureBoxHinhLamMo
            // 
            this.pictureBoxHinhLamMo.Location = new System.Drawing.Point(716, 75);
            this.pictureBoxHinhLamMo.Name = "pictureBoxHinhLamMo";
            this.pictureBoxHinhLamMo.Size = new System.Drawing.Size(512, 512);
            this.pictureBoxHinhLamMo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinhLamMo.TabIndex = 2;
            this.pictureBoxHinhLamMo.TabStop = false;
            this.pictureBoxHinhLamMo.Click += new System.EventHandler(this.pictureBoxHinhLamMo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 725);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxHinhLamMo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHinhgoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhLamMo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHinhgoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxHinhLamMo;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //tao bien chua duong dan anh RGB
            string file_hinh = @"C:\Users\Admin\Downloads\HOC TAP\KI_1_NAM_3\XU LY ANH\Anh-gai-toc-ngan-Taihinhanh-Vn (5).jpg";
            //tao bien chua bitmap
            Bitmap hinhgoc = new Bitmap(file_hinh);
            //hien thi hinh anh goc trong pixBox_original
            pictureBox_original.Image = hinhgoc;
            //khai bao 3 hinh bitmap de chua 3 hinh kenh Red, Blue, Green
            Bitmap red = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap green = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap blue = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Do moi hinh la mot ma tran 2 chieu nen su dung 2 vong for de quet tat ca diem anh
            for (int x=0; x<hinhgoc.Width;x++)
                for(int y=0;y<hinhgoc.Height;y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);//getting 4 values: red, green, blue and transparent
                    byte R = pixel.R;// value of red
                    byte G = pixel.G;//value of green   
                    byte B = pixel.B;//value of blue
                    byte A = pixel.A;//value of transparent
                    //setting value of pixels for sucessive R,G,R 
                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));




                }
            //Hien thi tren 3 hinh mau R. G, B
            pictureBox_red.Image = red;
            pictureBox_green.Image = green;
            pictureBox_blue.Image = blue;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

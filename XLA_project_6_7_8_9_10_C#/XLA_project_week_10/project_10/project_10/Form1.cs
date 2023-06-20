using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinhgoc = new Bitmap(@"C: \Users\Admin\Pictures\JET_1.jpg");
            pictureBoxHinhgoc.Image = Hinhgoc;
            //Using convert fucntion from RGB to YCbCr
            List<Bitmap> YCbCr = ChuyendoiRGBsangYCbCr(Hinhgoc);
            pictureBoxKenhY.Image = YCbCr[0];
            pictureBoxKenhCb.Image = YCbCr[1];
            pictureBoxKenhCr.Image = YCbCr[2];
            pictureBoxYCrCb.Image = YCbCr[3];

        }
        public List<Bitmap> ChuyendoiRGBsangYCbCr(Bitmap Hinhgoc)
        {
            //Creating the LIST for containing all of images after converting  YCbCr
            List<Bitmap> YCbCr = new List<Bitmap>();
            //Creating the bitmap for Y,Cb,Cr
            Bitmap Y_channel = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Cb_channel = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Cr_channel = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            //This is HSI image (combining three channels Y,Cb,Cr)
            Bitmap YCbCr_img = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Height; y++)
                {   //Getting values
                    Color pixel = Hinhgoc.GetPixel(x, y);

                    //Before that, we used byte datatype, but in this case, we use double because in calcuting, 
                    //the results is backed with double datatype
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //For Formula in book, we will get
                    //Formula for calculating Y,Cb,Cr
                    double Y = 16 + (65.738 / 256) * R + (129.057 / 256) * G + (25.064 / 256) * B;
                    double Cb = 128 - (37.945 / 156) * R - (74.494 / 256) * G + (112.439 / 256) * B;
                    double Cr = 128 + (112.439 / 256) * R - (94.154 / 256) * G - (18.285 / 256) * B;






                    //ep kieu du lieu byte vao khi set pixel cho no
                    Y_channel.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    Cb_channel.SetPixel(x, y, Color.FromArgb((byte)(Cb), (byte)(Cb), (byte)(Cb)));//tinh toan
                    //thi van phai nhan cho 255, neu H-S-I la cac kenh riengle voi nhau
                    Cr_channel.SetPixel(x, y, Color.FromArgb((byte)Cr, (byte)Cr, (byte)Cr));
                    //Voi phan hien thi HSI thi chung ta khong can phai nhan them cho 255
                    YCbCr_img.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Cb, (byte)Cr));








                }
            //Add all of elemnets into HSI list
            YCbCr.Add(Y_channel);
            YCbCr.Add(Cb_channel);
            YCbCr.Add(Cr_channel);
            YCbCr.Add(YCbCr_img);
            //Back to the result from HSI values
            return YCbCr;
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHinhgoc_Click(object sender, EventArgs e)
        {

        }
    }
}

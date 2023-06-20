using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_week_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinhgoc = new Bitmap(@"C:\Users\Admin\Downloads\HOC TAP\KI_2_NAM_3\XU LY ANH\USING C#\XLA_project_week_9\ao_dai.jpg");
            pictureBoxHinhGoc.Image = Hinhgoc;
            //Using convert fucntion from GB to HSI
            List<Bitmap> HSI = ChuyendoiRGBsangHSV(Hinhgoc);
            pictureBoxKenhX.Image = HSI[0];
            pictureBoxKenhY.Image = HSI[1];
            pictureBoxKenhZ.Image = HSI[2];
            pictureBoxXYZ.Image = HSI[3];

        }
        public List<Bitmap> ChuyendoiRGBsangHSV(Bitmap Hinhgoc)
        {
            //Creating the LIST for containing all of images after converting
            List<Bitmap> XYZ = new List<Bitmap>();
            //Creating the bitmap for HUE,SATURATION and INTENSITY
            Bitmap channel_X = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap channel_Y = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap channel_Z= new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            //This is HSI image (combining three channels H-S-I)
            Bitmap XYZ_img = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

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
                    //Formula for calculating Theta in Hue
                    double X = 0.4124564 * R + 0.3575761 * G + 0.1804375 * B;
                    double Y= 0.2126729*R+0.7151522*G+0.0721750 * B;
                    double Z = 0.0193339 * R + 0.1191920 * G + 0.9503041 * B;



                    
                  

                    //ep kieu du lieu byte vao khi set pixel cho no
                    channel_X.SetPixel(x, y, Color.FromArgb((byte)X, (byte)X, (byte)X));
                    channel_Y.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));//tinh toan
                    //thi van phai nhan cho 255, neu H-S-I la cac kenh riengle voi nhau
                    channel_Z.SetPixel(x, y, Color.FromArgb((byte)Z, (byte)Z, (byte)Z));
                    //Voi phan hien thi HSI thi chung ta khong can phai nhan them cho 255
                    XYZ_img.SetPixel(x, y, Color.FromArgb((byte)x, (byte)y, (byte)Z));








                }
            //Add all of elemnets into HSI list
            XYZ.Add(channel_X);
            XYZ.Add(channel_Y);
            XYZ.Add(channel_Z);
            XYZ.Add(XYZ_img);
            //Back to the result from HSI values
            return XYZ;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

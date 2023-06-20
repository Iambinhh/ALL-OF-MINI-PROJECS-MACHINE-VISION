using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinhgoc = new Bitmap(@"C:\Users\Admin\Downloads\HOC TAP\KI_2_NAM_3\XU LY ANH\USING C#\XLA_project_week_7\ao_dai.jpg");
            pictureBoxHinhGoc.Image = Hinhgoc;
            //Using convert fucntion from GB to HSI
            List<Bitmap> HSI = ChuyendoiRGBsangHSI(Hinhgoc);
            pictureBoxHue.Image = HSI[0];
            pictureBoxSaturation.Image = HSI[1];
            pictureBoxIntensity.Image = HSI[2];
            pictureBoxHSI.Image = HSI[3];

            
        }
        public List<Bitmap> ChuyendoiRGBsangHSI(Bitmap Hinhgoc)
        {
            //Creating the LIST for containing all of images after converting
            List<Bitmap> HSI = new List<Bitmap>();
            //Creating the bitmap for HUE,SATURATION and INTENSITY
            Bitmap Hue = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Saturation = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Intensity = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            //This is HSI image (combining three channels H-S-I)
            Bitmap HSI_img = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

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
                    double t1 = 1 / 2 * ((R - G) + (R - B));//phan tu cua cong thuc
                    double t2 = Math.Sqrt((R - G) * (R - G) + (R - B) * (G - B)) ;//phan mau cua cong thuc
                    double theta = Math.Acos(t1 / t2);//ket qua tra ra la radiant
                    double H = 0;
                    //Conditions for putting Hue values
                    if (B <= G)
                    {
                        H = theta;
                    }
                    if (B>G)
                    { H = 2 * Math.PI - theta; }

                    H = H * 180 / Math.PI;
                    //Formula for calculating Saturation
                    double S = 1 - (3 / (R + G + B))*Math.Min(R,Math.Min(G,B));
                    //Converting range values from [0;1] to [0;255] by multiply with 255
                    //S = S * 255;
                    //Formula for calulating in Intensity
                    double I =  (R + G + B)/3;
                   
                    
                    //ep kieu du lieu byte vao khi set pixel cho no
                    Hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    Saturation.SetPixel(x, y, Color.FromArgb((byte)(S*255), (byte)(S * 255), (byte)(S * 255)));//tinh toan
                    //thi van phai nhan cho 255, neu H-S-I la cac kenh riengle voi nhau
                    Intensity.SetPixel(x, y, Color.FromArgb((byte)I, (byte)I, (byte)I));
                    //Voi phan hien thi HSI thi chung ta khong can phai nhan them cho 255
                    HSI_img.SetPixel(x, y, Color.FromArgb((byte)H, (byte)S, (byte)I));


                        





                }
            //Add all of elemnets into HSI list
            HSI.Add(Hue);
            HSI.Add(Saturation);
            HSI.Add(Intensity);
            HSI.Add(HSI_img);
            //Back to the result from HSI values
            return HSI;
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

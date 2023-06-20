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
    public partial class picBoxoriginal : Form
    {
        public picBoxoriginal()
        {
            InitializeComponent();
            //Save the paty of the picture
            Bitmap Hinhgoc = new Bitmap(@"C: \Users\Admin\Downloads\HOC TAP\KI_2_NAM_3\XU LY ANH\USING C#\XLA_project_week_3\ao_dai.jpg");
            //Show the picture on pictureBox1
            pictureBox1.Image = Hinhgoc;

            //Show the modify image on pictureBox2
            pictureBox2.Image = ChuyenRGBsamgxamAverage(Hinhgoc);


            //Show the modify image on pictureBox3
            pictureBox3.Image = ChuyenRGBsangxamLightness(Hinhgoc);

            //Show the modify image on pictureBox4
            pictureBox4.Image = ChuyenRGBsamgxamLuminance(Hinhgoc);

        }
        //Create the 
        public Bitmap ChuyenRGBsangxamLightness(Bitmap Hinhgoc)

        {
            Bitmap Muc_xam_lightness = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Height; y++)
                {
                    //Taking values on pixel
                    Color pixel = Hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Calcaulate value of grayscale at (x,y position)
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte gray = (byte) ((max + min) / 2);

                    //Attach the value of grayscale on the portrait 
                    Muc_xam_lightness.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }






            return Muc_xam_lightness;
        }

        public Bitmap ChuyenRGBsamgxamAverage(Bitmap Hinhgoc)
        {
            Bitmap Muc_xam_Average = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Height; y++)
                {
                    //Taking values on pixel
                    Color pixel = Hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Calcalate value of grayscale at (x,y position)
                    byte gray = (byte)((R + G + B) / 3);
                    //Attach the value of grayscale on the portrait 
                    Muc_xam_Average.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return Muc_xam_Average;
        }


        public Bitmap ChuyenRGBsamgxamLuminance(Bitmap Hinhgoc)
        {
            Bitmap Muc_xam_Luminance = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Height; y++)
                {
                    //Taking values on pixel
                    Color pixel = Hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Calcaulate value of grayscale at (x,y position)
                    byte gray = (byte)(0.2126*R+0.7152*G+0.0722*B);
                    //Attach the value of grayscale on the portrait 
                    Muc_xam_Luminance.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return Muc_xam_Luminance;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

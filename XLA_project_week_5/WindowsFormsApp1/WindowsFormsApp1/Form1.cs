using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

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
            //pictureBox2.Image = ChuyenRGBsamgxamAverage(Hinhgoc);


            //Show the modify image on pictureBox3\

            Bitmap Muc_xam_lightness = ChuyenRGBsangxamLightness(Hinhgoc);
            pictureBox3.Image = Muc_xam_lightness;

            //Show the modify image on pictureBox4
            //pictureBox4.Image = ChuyenRGBsamgxamLuminance(Hinhgoc);

            //calculated histogram 
            double[] histogram = Cal_histogram(Muc_xam_lightness);

            //Convert the datatype
            PointPairList points = ChuyendoiHistogram(histogram);

            //Drawing histogram and showing
            Graph_Histogram.GraphPane = BieudoHistogram(points);
            Graph_Histogram.Refresh();

        }
       
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

        //public Bitmap ChuyenRGBsamgxamAverage(Bitmap Hinhgoc)
        //{
        //    Bitmap Muc_xam_Average = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
        //    for (int x = 0; x < Hinhgoc.Width; x++)
        //        for (int y = 0; y < Hinhgoc.Height; y++)
        //        {
        //            //Taking values on pixel
        //            Color pixel = Hinhgoc.GetPixel(x, y);
        //            byte R = pixel.R;
        //            byte G = pixel.G;
        //            byte B = pixel.B;
        //
        //            //Calcaulate value of grayscale at (x,y position)
        //            byte gray = (byte)((R + G + B) / 3);
        //            //Attach the value of grayscale on the portrait 
        //           Muc_xam_Average.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
        //
        //        }
        //    return Muc_xam_Average;
     //   }


    //    public Bitmap ChuyenRGBsamgxamLuminance(Bitmap Hinhgoc)
    //    {
    //        Bitmap Muc_xam_Luminance = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
    //        for (int x = 0; x < Hinhgoc.Width; x++)
    //            for (int y = 0; y < Hinhgoc.Height; y++)
    //            {
    //                //Taking values on pixel
    //                Color pixel = Hinhgoc.GetPixel(x, y);
    //                byte R = pixel.R;
    //                byte G = pixel.G;
    //                byte B = pixel.B;
    //
    //                //Calcaulate value of grayscale at (x,y position)
    //                byte gray = (byte)(0.2126*R+0.7152*G+0.0722*B);
    //                //Attach the value of grayscale on the portrait 
    //                Muc_xam_Luminance.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
    //
    //            }
    //        return Muc_xam_Luminance;
    //    }

        //Calculated histogrram of gray scale


        //Calculated the histogram of gray scaleCal_histogram
        public double[] Cal_histogram(Bitmap Muc_xam_lightness)
        {
            //Each pixel has value from 0-255 so we4 declare an array has 256 items which contain the numbers of pixels 
            //has the same value gray of pic. we should use doulbe datatype cause the amount of pixel maybe numorous, depend of 
            //dimension of pic.
            double[] histogram = new double[256];

            for (int x = 0; x < Muc_xam_lightness.Width; x++)
                for (int y = 0; y < Muc_xam_lightness.Height; y++)
                {
                    Color color = Muc_xam_lightness.GetPixel(x, y);
                    //Gia tri gray tinh ra cung chinh la phan tu thu gray co trong mang histogram
                    //da khai bao se tang so dem cua phan tu thu gray len 1
                    byte gray = color.R; //In grayscale, value of channel R likely channel G or channel B


                    histogram[gray]++;

                }
            return histogram;

                    

        
        }

        PointPairList ChuyendoiHistogram(double[] histogram)
        {
            //PointPairList is a datatype for drawing points graph
            PointPairList points = new PointPairList();
            for (int i = 0; i < histogram.Length; i++)
            {
                //i represent for axes horizental. from 0-255
                //histogram[i] represent for vertically, is a num of pixel with the same grayscale
                points.Add(i, histogram[i]);

            }
            return points;
        }

        //Establish the graph in Zedgraph
        public GraphPane BieudoHistogram(PointPairList histogram)
        {
            //GraphPane is a object graph in ZedGraph
            GraphPane gp = new GraphPane();
            gp.Title.Text = "The histogram Graph"; //Name of graph
            gp.Rect = new Rectangle(0, 0, 650,450); //portrait of graph

            //Establish X-axis
            gp.XAxis.Title.Text = "The value of grayscale of pixels";
            gp.XAxis.Scale.Min = 0;
            gp.XAxis.Scale.Max = 255;
            gp.XAxis.Scale.MajorStep = 5;
            gp.XAxis.Scale.MinorStep = 1;
            //Establish Y-axis
            gp.YAxis.Title.Text = "The nums of pixels with the same grayscale";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 15000;
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;

            //Bar Graph for performing Histogram
            gp.AddBar("Histogram", histogram, Color.OrangeRed);
            return gp;

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

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

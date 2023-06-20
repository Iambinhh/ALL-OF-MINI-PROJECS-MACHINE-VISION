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


            //calculated histogram 
            double[,] histogram = Cal_histogram(Hinhgoc);

            //Convert the datatype
            List<PointPairList> points = ChuyendoiHistogram(histogram);

            //Drawing histogram and showing
            Graph_Histogram.GraphPane = BieudoHistogram(points);
            Graph_Histogram.Refresh();

        }
       
        
        //Calculated the histogram of gray scaleCal_histogram
        public double[,] Cal_histogram(Bitmap bmp)
        {
            
            //we use two dimension array for containing the info from histogram for R,G,B channels
            //3: num of channels
            //256: from 0 to 255
            double[,] histogram = new double[3,256];

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color color = bmp.GetPixel(x, y);
                    
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;   


                    histogram[0,R]++;//histogram of red channel

                    histogram[1, G]++;//histogram of green channel

                    histogram[2, B]++;//histogram of blue channel
                }
            return histogram;// return a two dimension array of RGB

                    

        
        }

        List<PointPairList> ChuyendoiHistogram(double[,] histogram)
        {
            //PointPairList is a datatype for drawing graph
            //USing the array dont need to declare the nums of items
            List<PointPairList> points = new List<PointPairList>();
            PointPairList redPoints = new PointPairList();//convert histogram red channel 
            PointPairList greenPoints = new PointPairList();//______green channel
            PointPairList bluePoints = new PointPairList();//_______blue channel


            for (int i = 0; i < 256; i++)
            {
                //i represent for axes horizental. from 0-255
                //histogram[i] represent for vertically, is a num of pixel with the same grayscale
                redPoints.Add(i,histogram[0,i]);//convert for R channel
                greenPoints.Add(i, histogram[1, i]);//convert for G channel
                bluePoints.Add(i, histogram[2, i]);//convert for B channel
                    

            }

            //After looping for, the info histogram is conveyed to R,G,B channels
            //Conveying success, Adding to array "points" for returning value
            points.Add(redPoints);
            points.Add(greenPoints);
            points.Add(bluePoints);

            return points;
        }

        //Establish the graph in Zedgraph
        public GraphPane BieudoHistogram(List<PointPairList> histogram)
        {
            //GraphPane is a object graph in ZedGraph
            GraphPane gp = new GraphPane();
            gp.Title.Text = "The Histogram Graph"; //Name of graph
            gp.Rect = new Rectangle(0, 0, 650,450); //portrait of graph

            //Establish X-axis
            gp.XAxis.Title.Text = "The value of RGB of pixels";
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
            gp.AddBar("Histogram", histogram[0], Color.Red);
            gp.AddBar("Histogram", histogram[1], Color.Green);
            gp.AddBar("Histogram", histogram[2], Color.Blue);
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

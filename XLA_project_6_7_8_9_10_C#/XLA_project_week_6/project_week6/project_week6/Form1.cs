using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_week6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // save the picturebox
            Bitmap Hinhgoc = new Bitmap(@"C:\Users\Admin\Downloads\HOC TAP\KI_2_NAM_3\XU LY ANH\USING C#\XLA_project_week_6\ao_dai.jpg");
            //Hien thi hinh tren PictureBox
            pictureBoxHinhGoc.Image = Hinhgoc;

            //Declaring the convert function from RGB to CMYK
            List<Bitmap> CMYK = ChuyendoiRBGsangCKMY(Hinhgoc);



            //Showing all channels convert from RGB to CMYK
            pictureBoxCyan.Image = CMYK[0];
            pictureBoxMagneta.Image = CMYK[1];
            pictureBoxYellow.Image = CMYK[2];
            pictureBoxBlack.Image = CMYK[3];


        }
        public List<Bitmap> ChuyendoiRBGsangCKMY(Bitmap Hinhgoc)
        {
            //*Co ban vi su tao nen cac mau sac trong CMKY do su ket hop cua 2 trong 3 mau R,G,B :
            //* R va G tao thanh mau Yellow => set kenh mau B=0
            //* G va B tao nen mau Cyan(xanh lam) => set kenh mau R=0
            //* R ba B tao nen mau Magneta(tim) => set kenh mau G=0
           
            //tao mot list de chua 4 kenh mau C, K, Y, M
            //In C#.net, List type is special cause it needn't declare the dimension
                List<Bitmap> CMYK = new List<Bitmap>();

            //Each channel in space color CMYK is shown by one bit map
            //With 4 bitmaps, nothing info is ccontained, just dimensios in bitmap equal to dimensions in original for calculating 
            //processing in each pixels
            Bitmap Cyan = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Magneta = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Yellow = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Black= new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            //Scanning all pixels in the orginal picture
            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Height; y++)
                {
                //taking values in each pixel
                    Color pixel = Hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;// comply the byte data in R,G and B
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //Setting Cyan color by combinning two colors Gren and Blue
                    Cyan.SetPixel(x, y, Color.FromArgb(0, G, B));

                    //Setting Magneta color by combinning two colors Red and Blue
                    Magneta.SetPixel(x, y, Color.FromArgb(R, 0, B));

                    //Setting Yellow color by combinning two colors Gren and Red
                    Yellow.SetPixel(x, y, Color.FromArgb(R, G, 0));

                    //Setting Black color for taking the Minimum for RED, GREEN and BLUE
                    byte K = Math.Min(R, Math.Min(G, B));
                    Black.SetPixel(x, y, Color.FromArgb(K, K, K));




                }

            //Adding channels into list CMKY
            //Do List la kieu du lieu mang(Array) khong can biet truoc kich thuoc nen don gian chung ta chi can them cac elements
            //vao ma khong can quan tam den viec nay co lam tran kich thuoc cua mang hay khong
            CMYK.Add(Cyan);
            CMYK.Add(Magneta);
            CMYK.Add(Yellow);
            CMYK.Add(Black);
            //Tra lai gia tri cho ham cua mang
            return CMYK;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMagneta_Click(object sender, EventArgs e)
        {

        }
    }
}

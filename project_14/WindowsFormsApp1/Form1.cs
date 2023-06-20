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
        //load hình cô gái Lena từ đường dẫn 
        Bitmap HinhGoc = new Bitmap(@"C:\Users\Admin\Downloads\HOC TAP\KI_2_NAM_3\XU LY ANH\USING C#\project_14\Lena_316x316.jpg");
        public Form1()
        {
            InitializeComponent();
            //hien thi anh goc len picturebox
            pictureBoxHinhGoc.Image = HinhGoc;
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Bitmap ChuyenRGBsangXamAverage(Bitmap HinhGoc)
        {
            Bitmap Hinhmucxam = new Bitmap(HinhGoc.Width, HinhGoc.Height);//tao bitmap chua anh mau xam
            for (int x = 0; x <= HinhGoc.Width; x++)
                for (int y = 0; y <= HinhGoc.Height; y++)
                {
                    Color pixel = HinhGoc.GetPixel(x, y);
                    Byte R = pixel.R;
                    Byte G = pixel.G;
                    Byte B = pixel.B;
                    Byte gray = (Byte) ((R + G + B) / 3);

                    Hinhmucxam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                     
                }
            return Hinhmucxam;
        }

        public Bitmap NhanDienDuongBienAnhXam(Bitmap Hinhxam,int Nguong)
        {
            int[,] Sx =
            {
                { -1,-2,-1},
                { 0, 0, 0},
                { 1, 2, 1}
            };
            int[,] Sy =
            {
                { -1, 0, 1},
                { -2, 0, 2},
                { -1, 0, 1}
            };
            Bitmap Anhduongbien = new Bitmap(Hinhxam.Width, Hinhxam.Height);
            
            for (int a = 1; a <= Hinhxam.Width-1; a++)
                for (int b = 1; b <= Hinhxam.Height-1; b++)
                {
                    int gx = 0, gy = 0;
                    for (int i = a - 1; i <= a + 1; i++)
                        for (int j = b - 1; i <= b + 1; j++)
                        {
                            Color pixel_1 = Hinhxam.GetPixel(i,j);
                            int Gr = pixel_1.R;
                            gx += Gr * Sx[(i - a + 1), (j - b + 1)];
                            gy += Gr * Sy[(i - a + 1), (j - b + 1)];






                        }
                    int Mag = Math.Abs(gx) + Math.Abs(gy);
                    if (Mag < Nguong)
                        { Anhduongbien.SetPixel(a, b, Color.FromArgb(0, 0, 0)); }
                    else
                        {
                            Anhduongbien.SetPixel(a, b, Color.FromArgb(255, 255, 255));
                        }


                }

            return Anhduongbien;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu từ các textbox và chuyển từ kiểu kí tự sang số 
            int Nguong = Convert.ToInt16(tbNguong.Text);
            //byte Nguong = (byte)hScrollBar_DuongBien.Value;
            //hien thi gia tri nguong
            
            //lblNguong.Text = Nguong.ToString();
            Bitmap Hinhmucxam = ChuyenRGBsangXamAverage(HinhGoc);
            Bitmap Hinhduongbien = NhanDienDuongBienAnhXam(Hinhmucxam, Nguong);
            pictureBoxDetection.Image = Hinhduongbien;




        }
    }
}

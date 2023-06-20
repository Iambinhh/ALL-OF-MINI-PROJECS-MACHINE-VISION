using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinhgoc = new Bitmap(@"C:\Users\Admin\Downloads\HOC TAP\KI_2_NAM_3\XU LY ANH\USING C#\XLA_project_11\3x3\Lena_316x316.jpg");
            //Hiện ảnh gốc lên cửa sô
            pictureBoxHinhgoc.Image = Hinhgoc;
            //Hiện ảnh đã làm mờ lên cửa s
            Bitmap SmoothImage = ColorImageSmoothing3x3(Hinhgoc);
            pictureBoxHinhLamMo.Image = SmoothImage;


                

            
        }
        public Bitmap ColorImageSmoothing3x3(Bitmap Hinhgoc)
        {
            //Tao ra mot bit map nham de chua anh 
            Bitmap SmoothImage = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            //Chay 2 vong lap for, chu y ta nen bo qua vien ngoai cua anh de cho de lap trinh nen ta chi quet tu x=1,widdth-1,
            //y=1 toi height-1
            for (int x = 1; x < Hinhgoc.Width - 1; x++)
                for (int y = 1; y < Hinhgoc.Height-1; y++)
                {
                    //các biến này dùng để chứa các giá trị cộng dồn của các điểm ảnh nằm trong mặt nạ nên phải khai báo theo kiểu
                    // int để có thể chứa được các giá trị cộng dồn của các pixel

                    int Rs = 0, Gs = 0, Bs = 0;
                    // quet diem anh trong mat na
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y- 1; j <= y + 1; j++)
                        {
                            //Lấy các giá trị điểm ảnh tại vị trí (i,j)
                            Color color = Hinhgoc.GetPixel(i,j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;


                            //Cộng dồn các giá trịc của điểm ảnh

                            Rs += R;
                            Gs += G;
                            Bs += B;

                            
                            


                        }
                    //Kết thúc quét và cộng dồn điểm ảnh trong mặt nạ, ta tính trung bình cộng theo mỗi kênh theo công thức 6.6.2

                    byte K = 3 * 3;
                    Rs = (int)(Rs / K) ;
                    Gs = (int)(Gs / K) ;
                    Bs = (int)(Bs / K) ;
                    //Set các điểm ảnh đã làm mượt (làm mờ) vào bitmap
                    SmoothImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));

                 

                }
            return SmoothImage;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHinhgoc_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHinhLamMo_Click(object sender, EventArgs e)
        {

        }
    }
}

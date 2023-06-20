using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;


namespace XLA_Project_week_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image<Bgr, byte> hinhhienthi = new Image<Bgr, byte>(@"C:\Users\Admin\Downloads\HOC TAP\KI_1_NAM_3\XU LY ANH\gai-dep.jpg");
            image1.Image = hinhhienthi;

        }
    }
}

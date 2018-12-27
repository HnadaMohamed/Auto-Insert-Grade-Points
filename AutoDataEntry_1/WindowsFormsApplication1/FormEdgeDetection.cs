using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WindowsFormsApplication1
{
    public partial class FormEdgeDetection : Form
    {
         Image<Bgra, byte> ImgInput;
        public FormEdgeDetection()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImgInput = new Image<Bgra, byte>(ofd.FileName);
                pictureBox1.Image = ImgInput.Bitmap;
            }
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImgInput == null)
            {
                return;
            }

            Image<Gray, byte> _imgCanny = new Image<Gray, byte>(ImgInput.Width, ImgInput.Height, new Gray(0));
            _imgCanny = ImgInput.Canny(Convert.ToInt32( texx.Text), Convert.ToInt32(texty.Text));
            pictureBox2.Image = _imgCanny.Bitmap;
            _imgCanny.Bitmap.Save(@"D:\hnada20\students\hnada20.png");
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImgInput == null)
            {
                return;
            }

            Image<Gray, byte> _imgGray = ImgInput.Convert<Gray, byte>();
            Image<Gray, float> _imgSobel = new Image<Gray, float>(ImgInput.Width, ImgInput.Height, new Gray(0));

            _imgSobel = _imgGray.Sobel(1, 1, 3);
            pictureBox2.Image = _imgSobel.Bitmap;
        }
        public static Bitmap sobel(Image<Bgra, byte> ImgInput )
        {

            Image<Gray, byte> _imgGray = ImgInput.Convert<Gray, byte>();
            Image<Gray, float> _imgSobel = new Image<Gray, float>(ImgInput.Width, ImgInput.Height, new Gray(0));

            _imgSobel = _imgGray.Sobel(1, 1, 3);
            return _imgSobel.Bitmap;
        }


        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImgInput == null)
            {
                return;
            }

            Image<Gray, byte> _imgGray = ImgInput.Convert<Gray, byte>();
            Image<Gray, float> _imgLaplacian = new Image<Gray, float>(ImgInput.Width, ImgInput.Height, new Gray(0));

            _imgLaplacian = _imgGray.Laplace(Convert.ToInt16(texx.Text));
            pictureBox2.Image = _imgLaplacian.Bitmap;
            _imgLaplacian.Bitmap.Save(@"D:\hnada20\students\hnada20.png");
        }

        private void FormEdgeDetection_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

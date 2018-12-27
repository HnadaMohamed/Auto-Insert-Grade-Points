#region Copyright (c), Some Rights Reserved
/*##########################################################################
 * 
 * NeuralDemo.cs
 * -------------------------------------------------------------------------
 * By
 * Murat FIRAT, June 2007
 * 
 * -------------------------------------------------------------------------
 * Description:
 * NeuralDemo.cs implements the interface that uses backpropagation classes.
 * 
 * -------------------------------------------------------------------------
 * Notes:
 * To train the B.P.N. Network there must be a folder [in the same directory
 * of the .exe ] named "PATTERNS" which contains one image for each pattern.
 * (For example, [for english alfhabet] in "PATTERNS" directory 
 * there must be images, namely 0.bmp, 1.bmp, 2.bmp ... Z.bmp 
 * 
 * Sep. 2007:
 * I have removed some of drawing panel's features (scroll bars etc..) to 
 * make the app more understandable and simplified some other code.
 * 
 * -------------------------------------------------------------------------
 ###########################################################################*/
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using System.Configuration;
using System.Threading;

using Emgu.CV;
using Emgu.CV.Structure;
using WindowsFormsApplication1;
using AForge.Imaging;
using AForge.Math.Geometry;
using AForge;
using SkewCorrectionNS;

namespace WindowsFormsApplication1
{
    public partial class NeuralDemo : Form
    {
        //Neural Network Object With Output Type String
       
        string s;
        

        public NeuralDemo()
        {
            InitializeComponent();
            




        }
        
        private void buttonStop_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

       
        

      
		private void NeuralDemo_Load(object sender, EventArgs e)
		{

		}
        Image<Bgra, byte> ImgInput;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                ImgInput = new Image<Bgra, byte>(of.FileName);
                pictureBox1.ImageLocation = of.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                path.Text = of.FileName;

            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = ImgInput.Bitmap;
            //ImgInput.Bitmap.Save(Path.ChangeExtension(@"D:\hnada20\", String.Format("{0}.bmp", 8)));
 //**           Bitmap[,] chunkedImages = Class2.splitImage(path.Text, Convert.ToInt32(getrows.Text), Convert.ToInt32(getcols.Text), @"D:\hnada20\students\");
            //pictureBox1.Image = chunkedImages[0, 0];
           
           /*
            
            */
        }

        private void calc_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(path.Text);
            String s =Class2.whiteper(b);
            path.Text = s;
        }

        private void filltre_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Class2.filltre(path.Text);
            
        }

        private void calc_note_Click(object sender, EventArgs e)
        {
    /*        Bitmap[,] chunkedImages = Class2.splitImage(path.Text, Convert.ToInt32(getrows.Text), Convert.ToInt32(getcols.Text), @"D:\hnada20\");


            int[] table = Class2.giveMeTable(chunkedImages);
            // Finding max

            int max,imax=0;
            
            max = table[0];
            for (int i =0; i < table.Length; i++)
            {
                

                if (max < table[i])
                {
                    imax = i;
                    max = table[i];
                }
            }
            textnote.Text = imax+1+"";
            pictnote.Image = chunkedImages[0, imax];


    */



       



        }

        private void cropNote_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ImgInput.Bitmap;
 //**           Bitmap chunkedImagesbareq = Class2.takebarcode(path.Text);
//**            pictureBox3.Image = chunkedImagesbareq;
    //**          Bitmap chunkedImagesnote = Class2.takenotes(path.Text);
  //**          pictureBox4.Image = chunkedImagesnote;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void edgeDetect_Click(object sender, EventArgs e)
        {
            path.Text=Detect(path.Text);
            //pictureBox1.Load(path.Text);
            
        }
        private void corectScan_Click(object sender, EventArgs e)
        {
            path.Text =ProcessFile(path.Text);
            pictureBox1.Load(path.Text);
        }


        //******detect rect and save them
        public  String Detect(String path)
        {
            // Open your image
            
            Bitmap image = (Bitmap)Bitmap.FromFile(path);

            // locating objects
            BlobCounter blobCounter = new BlobCounter();

            blobCounter.FilterBlobs = true;
            blobCounter.MinHeight = 5;
            blobCounter.MinWidth = 5;

            blobCounter.ProcessImage(image);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            // check for rectangles
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            int i = 0;
            int t = 0;
            foreach (var blob in blobs)
            {

                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blob);
                List<IntPoint> cornerPoints;

                // use the shape checker to extract the corner points
                if (shapeChecker.IsQuadrilateral(edgePoints, out cornerPoints))
                {
                    // only do things if the corners form a rectangle
                    if (shapeChecker.CheckPolygonSubType(cornerPoints) == PolygonSubType.Rectangle)
                    {
                        
                        // here i use the graphics class to draw an overlay, but you
                        // could also just use the cornerPoints list to calculate your
                        // x, y, width, height values.
                         s+=" / "+blobs[i].Rectangle.Height;
                        
                          if(blobs[i].Rectangle.Height<170 && blobs[i].Rectangle.Height > 100)
                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
                            Class2.takepart2(image,t, blobs[i].Rectangle.Width, blobs[i].Rectangle.Height, blobs[i].Rectangle.X, blobs[i].Rectangle.Y);
                            t++;
                        }



                        List<System.Drawing.Point> Points = new List<System.Drawing.Point>();
                        foreach (var point in cornerPoints)
                        {
                            Points.Add(new System.Drawing.Point(point.X, point.Y));
                        }

                        Graphics g = Graphics.FromImage(image);
                        g.DrawPolygon(new Pen(Color.Red, 2.0f), Points.ToArray());
                        
                        image.Save(@"D:\hnada20\edgelast.png");
                        
                    }
                }
                i++;
            }
            return s; //@"D:\hnada20\edgelast.png";
        }

        //*******************corect file form 
        private String ProcessFile(string filePath)
        {
            var img = (Bitmap)System.Drawing.Image.FromFile(filePath);
            pictureBox1.Image = (Bitmap)img.Clone();

            //create strips
            var stripCount = 10;

            var compact = new Compact(img, stripCount);

            //find rotation angle
            var stripX1 = 2;//take 3-rd strip
            var stripX2 = 6;//take 7-th strip

            var angle = SkewCalculator.FindRotateAngle(compact, stripX1, stripX2);
            angle = (angle * 180 / Math.PI);//to degrees

            Text = "Angle: " + angle.ToString("0.00");

            //rotate
            var rotated = Rotator.Rotate(img, angle);
            pictureBox1.Image = rotated;
            rotated.Save(@"D:\hnada20\hh.png");
            return @"D:\hnada20\hh.png";
        }

        private void pbLeft_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(20, Color.Black)))
                for (int i = 0; i < 1000; i += 30)
                    e.Graphics.DrawLine(pen, 0, i, 1000, i);
        }

        private void threshold_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(path.Text);
            Class2.filltrelast(b);
            //Class2.thresholding(path.Text).Save(@"D:\hnada20\threshold.BMP");
          
        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
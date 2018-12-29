using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.IO;
using AForge;
using System.Linq;
using System.Text;
using AForge.Imaging.Filters;
using AForge.Imaging;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing.Imaging;
using AForge.Math.Geometry;
using SkewCorrectionNS;
using MessagingToolkit.QRCode.Codec.Data;
/// <summary>
/// Class qui contient tous les fonction de  traitement 
/// Auteur : ASUS - Hnada Mohamed 
/// </summary>
namespace WindowsFormsApplication1
{
    public class Class2
    {
        

        //fontion de decoupage des image par ligne et colonne passe en paramettre
        public static Bitmap[,] splitImage(Bitmap b, int rows, int cols, String foldername)
        {
            if (rows == 46)
            {
                b = addblack(b);
            }
            //System.Drawing.Image img = System.Drawing.Image.FromFile(filepath);
            Image<Gray, byte> ImgInput = new Image<Gray, byte>(b);
            //System.Drawing.Image img = FormEdgeDetection.sobel(ImgInput);
            Image<Gray, byte> _imgCanny = new Image<Gray, byte>(ImgInput.Width, ImgInput.Height, new Gray(0));
            _imgCanny = ImgInput.Canny(100, 500);
            System.Drawing.Image img = _imgCanny.Bitmap;
            //For the number of rows and columns of the grid to be displayed
            //For height and width of the small image chunks
            int chunkHeight, chunkWidth;
            //To store all the small image chunks in bitmap format in this list
            Bitmap[,] chunkedImages = new Bitmap[rows, cols];
            //convert bitmap to black and white
            //Bitmap bitmap=ConvertToBlackAndWhite(bitmap1);
            //image.setImageBitmap(bitmap);
            //Bitmap scaledBitmap = Bitmap.createScaledBitmap(bitmap, bitmap.getWidth(), bitmap.getHeight(), true);
            chunkHeight = img.Height / rows;
            chunkWidth = img.Width / cols;
            CreateIfMissing(foldername);
            //xCoord and yCoord are the pixel positions of the image chunks
            //int yCoord = 0;
            int z = 1;
            int a = 44;
            int xcord = 0;

            for (int x = 0; x < rows; x++)
            {
                //int xCoord = 0;
                for (int y = 0; y < cols; y++)
                {
                    if (y > 2)
                    {
                        if (y > 5)
                        {
                            a = 1000;
                        }
                        if (y > 12)
                        {
                            a = 44;
                        }
                        if (y > 26)
                        {
                            a = 1000;
                        }
                        if (y > 28)
                        {
                            a = -44;
                        }
                        if (y > 35)
                        {
                            a = 44;
                        }
                        xcord += chunkWidth / a;
                    }
                    // Rectangle rect = new Rectangle(xCoord, yCoord, chunkWidth, chunkHeight);
                    chunkedImages[x, y] = new Bitmap(chunkWidth, chunkHeight);
                    Graphics g = Graphics.FromImage(chunkedImages[x, y]);
                    g.DrawImage(img, new Rectangle(0, 0, chunkWidth, chunkHeight), new Rectangle(y * chunkWidth + xcord, x * chunkHeight, chunkWidth, chunkHeight), GraphicsUnit.Pixel);
                    //g.DrawImage(img, new Rectangle(0, 0, chunkWidth, chunkHeight), new Rectangle(y * chunkWidth, x * chunkHeight, chunkWidth, chunkHeight), GraphicsUnit.Pixel);
                    g.Dispose();
                    chunkedImages[x, y].Save(foldername + "0" + z + ".bmp");
                    z++;
                    //xCoord += chunkWidth+(chunkWidth/10) * z;
                }
                //yCoord += chunkHeight;
            }
            b = null;
            return chunkedImages;
        }


        //Creer le dossier s'il nexist pas 
        public static void CreateIfMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }

        //decouperle Qrcode d'etudiant 
        static int a = 0;
        public static Bitmap takebarcode(Bitmap b)
        {
            System.Drawing.Image img = b;
            Bitmap chunkedImages = new Bitmap(25 * (img.Width / 300), img.Height);
            Graphics g = Graphics.FromImage(chunkedImages);
            g.DrawImage(img, new Rectangle(0, 0, 25 * (img.Width / 300), img.Height), new Rectangle(0, 0, 25 * (img.Width / 300), img.Height), GraphicsUnit.Pixel);
            //g.DrawImage(img, new Rectangle(0, 0, b.Width-(4*b.Width/24), b.Height), new Rectangle(b.Width - (4 * b.Width / 24), b.Height, b.Width - (4 * b.Width / 24), b.Height), GraphicsUnit.Pixel);
            g.Dispose();
            CreateIfMissing(@"D:\hnada20\students\");
            chunkedImages.Save(@"D:\hnada20\students\" + String.Format("{0}.bmp", a));
            a++;
            return chunkedImages;
        }


        //decouper la partie des cercle cocher  
        public static Bitmap takenotes(Bitmap b)
        {
            Bitmap br = new Bitmap(2317, 168);
            Graphics gr = Graphics.FromImage(br);
            gr.DrawImage(b, 0, 0, 2317, 168);
            gr.Dispose();
            b = br;
            System.Drawing.Image img = b;
            Bitmap chunkedImages = new Bitmap(349 * (img.Width / 350), 3 * img.Height / 10);

            Graphics g = Graphics.FromImage(chunkedImages);
            g.DrawImage(img, new Rectangle(0, 0, 349 * (img.Width / 350), 3 * img.Height / 10), new Rectangle(31 * (img.Width / 350), 6 * img.Height / 10, 349 * (img.Width / 350), 3 * img.Height / 10), GraphicsUnit.Pixel);
            //g.DrawImage(img, new Rectangle(0, 0, b.Width-(4*b.Width/24), b.Height), new Rectangle(b.Width - (4 * b.Width / 24), b.Height, b.Width - (4 * b.Width / 24), b.Height), GraphicsUnit.Pixel);
            g.Dispose();
            CreateIfMissing(@"D:\hnada20\students\");
            chunkedImages.Save(@"D:\hnada20\students\" + String.Format("{0}.bmp", "Note"));
            return chunkedImages;
        }

        //*******Used in the old methode ****
        //Extract the red edge from the bitmap given (Using in Detect function)  
        public static Bitmap takepart2(Bitmap b, int t, int width, int heigth, int x, int y)
        {
            System.Drawing.Image img = b;
            Bitmap chunkedImages = new Bitmap(width, heigth);
            Graphics g = Graphics.FromImage(chunkedImages);
            g.DrawImage(img, new Rectangle(0, 0, width, heigth), new Rectangle(x, y, width, heigth), GraphicsUnit.Pixel);
            //g.DrawImage(img, new Rectangle(0, 0, b.Width-(4*b.Width/24), b.Height), new Rectangle(b.Width - (4 * b.Width / 24), b.Height, b.Width - (4 * b.Width / 24), b.Height), GraphicsUnit.Pixel);
            g.Dispose();
            //CreateIfMissing(@"D:\hnada20\students\");
            //chunkedImages.Save( @"D:\hnada20\students\"+ String.Format("{0}.bmp", t));


            return chunkedImages;
        }



        //comptet les noire et blanc pixel --Test--
        public static String whiteper(Bitmap b)
        {
            int whiteColor = 0;
            int blackColor = 0;
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    Color color = b.GetPixel(x, y);

                    if (color.ToArgb() == Color.White.ToArgb())
                    {
                        whiteColor++;
                    }

                    else
                    if (color.ToArgb() == Color.Black.ToArgb())
                    {
                        blackColor++;
                    }
                }

            }
            return "Black :" + blackColor + "    White : " + whiteColor;

        }


        //donner le nbr des pixel blanche  
        public static int whiteOnly(Bitmap b)
        {
            int whiteColor = 0;
            int blackColor = 0;
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    Color color = b.GetPixel(x, y);

                    if (color.ToArgb() == Color.White.ToArgb())
                    {
                        whiteColor++;
                    }

                    else
                    if (color.ToArgb() == Color.Black.ToArgb())
                    {
                        blackColor++;
                    }
                }

            }
            return whiteColor;

        }
        
        //le filtre qui transforme la foto on noire et blanc 
        public static Bitmap filltre(String path)
        {

            Image<Gray, byte> ImgInput = new Image<Gray, byte>(path);
            Image<Gray, byte> _imgCanny = new Image<Gray, byte>(ImgInput.Width, ImgInput.Height, new Gray(0));
            _imgCanny = ImgInput.Canny(20, 50);
            //_imgCanny.Save(Path.ChangeExtension(@"D:\hnada20\", String.Format("{0}.bmp", "filtre")));
            return _imgCanny.Bitmap;

        }

        //Thresholding filtre  --Test--
        public static Bitmap thresholding(String path)
        {
            Image<Gray, byte> ImgInput = new Image<Gray, byte>(path);
            Image<Gray, byte> ImgBinary = new Image<Gray, byte>(ImgInput.Width, ImgInput.Height, new Gray(0));
            CvInvoke.AdaptiveThreshold(ImgInput, ImgBinary, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.ToZero, 5, 0.0);
            return ImgBinary.Bitmap;

        }


        //prend la table des cercle decouper et compter le nbr des pixel blanche  
        public static int[] giveMeTable(Bitmap[] bitmabs)
        {
            int[] table = new int[46];

            for (int x = 0; x < bitmabs.Length; x++)
            {
                table[x] = whiteOnly(bitmabs[x]);
            }
            return table;
        }

        //Fitre pour netoyer l'image --Test--

        public static void filltrelast(Bitmap b)
        {
            //enarmas
            Bitmap bitmap = AForge.Imaging.Image.Clone(b, PixelFormat.Format32bppArgb);

            //blackAndWhite

            FiltersSequence seq = new FiltersSequence();
            seq.Add(Grayscale.CommonAlgorithms.BT709);  //First add  GrayScaling filter
            seq.Add(new OtsuThreshold()); //Then add binarization(thresholding) filter
            bitmap = seq.Apply(bitmap); // Apply filters on source image

            //blackAndWhite
            bitmap = AForge.Imaging.Image.Clone(bitmap, PixelFormat.Format32bppArgb);
            // lock image
            BitmapData bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, bitmap.PixelFormat);
            // step 1 - turn background to black
            ColorFiltering colorFilter = new ColorFiltering();
            colorFilter.Red = new IntRange(0, 64);
            colorFilter.Green = new IntRange(0, 64);
            colorFilter.Blue = new IntRange(0, 64);
            colorFilter.FillOutsideRange = false;
            colorFilter.ApplyInPlace(bitmapData);
            //bitmap.Save(@"D:\hnada20\filtrelast.png");
            //return bitmap;

        }

        //Aforge function Detect the Rectagles based on the Heigth --Test--
        public static List<Bitmap> Detect(Bitmap b)
        {
            // Open your image
            List<Bitmap> list_rect_etudiant = new List<Bitmap>();
            Bitmap image = addblack(b);
            image.Save(@"D:\hnada20\students\moreblack.png");


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
                        //**                        s += " / " + blobs[i].Rectangle.Height;

                        if (blobs[i].Rectangle.Height < 170 && blobs[i].Rectangle.Height > 100)
                        {

                            list_rect_etudiant.Add(Class2.takepart2(image, t, blobs[i].Rectangle.Width, blobs[i].Rectangle.Height, blobs[i].Rectangle.X, blobs[i].Rectangle.Y));
                            t++;
                        }


                        /*
                        List<System.Drawing.Point> Points = new List<System.Drawing.Point>();
                        foreach (var point in cornerPoints)
                        {
                            Points.Add(new System.Drawing.Point(point.X, point.Y));
                        }

                        Graphics g = Graphics.FromImage(image);
                        g.DrawPolygon(new Pen(Color.Red, 2.0f), Points.ToArray());
                        */
                        //image.Save(@"D:\hnada20\edgelast.png");

                    }
                }
                i++;
            }
            return list_rect_etudiant;
        }


        //Blob Detection fonction --Test--
        public static Bitmap BlobDetection(Bitmap _bitmapSourceImage)
        {
            Grayscale _grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap _bitmapGreyImage = _grayscale.Apply(_bitmapSourceImage);

            //create a edge detector instance
            DifferenceEdgeDetector _differeceEdgeDetector = new DifferenceEdgeDetector();
            Bitmap _bitmapEdgeImage = _differeceEdgeDetector.Apply(_bitmapGreyImage);

            Threshold _threshold = new Threshold(40);
            Bitmap _bitmapBinaryImage = _threshold.Apply(_bitmapEdgeImage);

            //Create a instance of blob counter algorithm
            BlobCounter _blobCounter = new BlobCounter();
            //Configure Filter
            _blobCounter.MinWidth = 5;
            _blobCounter.MinHeight = 5;
            _blobCounter.FilterBlobs = true;

            _blobCounter.ProcessImage(_bitmapBinaryImage);
            Blob[] _blobPoints = _blobCounter.GetObjectsInformation();

            Graphics _g = Graphics.FromImage(_bitmapSourceImage);

            SimpleShapeChecker _shapeChecker = new SimpleShapeChecker();
            for (int i = 0; i < _blobPoints.Length; i++)
            {
                List<IntPoint> _edgePoint = _blobCounter.GetBlobsEdgePoints(_blobPoints[i]);
                List<IntPoint> _corners = null;
                AForge.Point _center;
                float _radius;
                if (_shapeChecker.IsQuadrilateral(_edgePoint, out _corners))
                {
                    //MessageBox.Show(""+_shapeChecker.CheckShapeType(_edgePoint));
                    System.Drawing.Font _font = new System.Drawing.Font("Segoe UI", 16);
                    System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.PaleGreen);
                    System.Drawing.Point[] _coordinates = ToPointsArray(_corners);
                    if (_coordinates.Length == 4)
                    {

                        int _x = _coordinates[0].X;
                        int _y = _coordinates[0].Y;
                        Pen _pen = new Pen(Color.Brown);
                        string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                        _g.DrawString(_shapeString, _font, _brush, _x, _y);
                        _g.DrawPolygon(_pen, ToPointsArray(_corners));
                    }
                }
                if (_shapeChecker.IsCircle(_edgePoint, out _center, out _radius))
                {
                    string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                    System.Drawing.Font _font = new System.Drawing.Font("Segoe UI", 16);
                    System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.Chocolate);
                    Pen _pen = new Pen(Color.GreenYellow);
                    int x = (int)_center.X;
                    int y = (int)_center.Y;
                    _g.DrawString(_shapeString, _font, _brush, x, y);
                    _g.DrawEllipse(_pen, (float)(_center.X - _radius),
                                         (float)(_center.Y - _radius),
                                         (float)(_radius * 2),
                                         (float)(_radius * 2));
                }
                if (_shapeChecker.IsTriangle(_edgePoint, out _corners))
                {
                    string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                    System.Drawing.Font _font = new System.Drawing.Font("Segoe UI", 16);
                    System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.Brown);
                    Pen _pen = new Pen(Color.GreenYellow);
                    int x = (int)_center.X;
                    int y = (int)_center.Y;
                    _g.DrawString(_shapeString, _font, _brush, x, y);
                    _g.DrawPolygon(_pen, ToPointsArray(_corners));
                }

            }
            return _bitmapSourceImage;
        }

        public static System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new System.Drawing.Point(points[i].X, points[i].Y);
            }

            return array;
        }







        //return le indicedu maximum  
        public static int max(Bitmap[] b)
        {
            int[] table = Class2.giveMeTable(b);
            // Finding max
            int max, imax = 0;
            max = table[0];
            for (int i = 0; i < table.Length; i++)
            {

                if (max < table[i])
                {
                    imax = i;
                    max = table[i];
                }
            }
            return imax;
        }

        //retourn le indice du maximun avec des condition  --Test-- : on cas ou il ya deux case cocker --> OO OXOOOOXOOO OOOOOOOOOO OOOOOOOOOO OOOOOOOOOO 
        public static int maxnew(Bitmap[] b)
        {
            int[] table = Class2.giveMeTable(b);
            // Finding max
            int max, imax = 0;
            max = table[0];
            for (int i = 0; i < table.Length; i++)
            {

                if (max < table[i])
                {
                    imax = i;
                    max = table[i];

                }
            }

            for (int i = 0; i < table.Length; i++)
            {

                if (Math.Abs(max - table[i]) < 50 && max != table[i])
                {
                    imax = -1;
                }
            }


            return imax;
        }


        //Correction de image scanner  --Test--
        public static Bitmap ProcessFile(Bitmap b)
        {
            var img = b;


            //create strips
            var stripCount = 10;

            var compact = new Compact(img, stripCount);

            //find rotation angle
            var stripX1 = 2;//take 3-rd strip
            var stripX2 = 6;//take 7-th strip

            var angle = SkewCalculator.FindRotateAngle(compact, stripX1, stripX2);
            angle = (angle * 180 / Math.PI);//to degrees

            //Text = "Angle: " + angle.ToString("0.00");

            //rotate
            var rotated = Rotator.Rotate(img, angle);


            return rotated;
        }

        private void pbLeft_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(20, Color.Black)))
                for (int i = 0; i < 1000; i += 30)
                    e.Graphics.DrawLine(pen, 0, i, 1000, i);
        }





        //Addmore Black : Netoyage de image pour bien detecter les rectangle 
        public static Bitmap addblack(Bitmap bitm)
        {
            double contrast = Convert.ToDouble(1000);
            Bitmap b7 = bitm;
            /*
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j,
            Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            Bitmap b  = (Bitmap)bmap.Clone();
            pictureshow.Image = b;
            b.Save(@"D:\hnada20\students\inverse.png");
            */



            Bitmap temp = (Bitmap)b7;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (contrast < -100) contrast = -100;
            if (contrast > 100) contrast = 100;
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    double pR = c.R / 255.0;
                    pR -= 0.5;
                    pR *= contrast;
                    pR += 0.5;
                    pR *= 255;
                    if (pR < 0) pR = 0;
                    if (pR > 255) pR = 255;

                    double pG = c.G / 255.0;
                    pG -= 0.5;
                    pG *= contrast;
                    pG += 0.5;
                    pG *= 255;
                    if (pG < 0) pG = 0;
                    if (pG > 255) pG = 255;

                    double pB = c.B / 255.0;
                    pB -= 0.5;
                    pB *= contrast;
                    pB += 0.5;
                    pB *= 255;
                    if (pB < 0) pB = 0;
                    if (pB > 255) pB = 255;

                    bmap.SetPixel(i, j,
            Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }
            b7 = (Bitmap)bmap.Clone();
            //pictureshow.Image = b7;
            return b7;
            //path.Text = @"D:\hnada20\students\inverse.png";

        }

        //Decouper les image et retourne les ilage reel
        public static List<Bitmap> splitImageorg(Bitmap b, int rows, int cols, String foldername)
        {
            //System.Drawing.Image img = System.Drawing.Image.FromFile(filepath);

            System.Drawing.Image img = b;
            //For the number of rows and columns of the grid to be displayed
            //For height and width of the small image chunks
            int chunkHeight, chunkWidth;
            //To store all the small image chunks in bitmap format in this list
            List<Bitmap> chunkedImages = new List<Bitmap>();
            //convert bitmap to black and white
            //Bitmap bitmap=ConvertToBlackAndWhite(bitmap1);
            //image.setImageBitmap(bitmap);
            //Bitmap scaledBitmap = Bitmap.createScaledBitmap(bitmap, bitmap.getWidth(), bitmap.getHeight(), true);
            chunkHeight = img.Height / rows;
            chunkWidth = img.Width / cols;
            CreateIfMissing(foldername);
            //xCoord and yCoord are the pixel positions of the image chunks
            //int yCoord = 0;
            int z = 1;
            //int a = 5;
            int xcord = (chunkWidth / 46) / 15;
            int h = 0;
            for (int x = 0; x < rows; x++)
            {
                //int xCoord = 0;
                for (int y = 0; y < cols; y++)
                {
                    if (x == 4)
                    {
                        h += chunkHeight / 20;
                    }
                    // Rectangle rect = new Rectangle(xCoord, yCoord, chunkWidth, chunkHeight);
                    chunkedImages.Add(new Bitmap(chunkWidth, chunkHeight));
                    Graphics g = Graphics.FromImage(chunkedImages[x]);
                    g.DrawImage(img, new Rectangle(0, 0, chunkWidth, chunkHeight), new Rectangle(y * chunkWidth + xcord, x * chunkHeight + h, chunkWidth, chunkHeight), GraphicsUnit.Pixel);
                    //g.DrawImage(img, new Rectangle(0, 0, chunkWidth, chunkHeight), new Rectangle(y * chunkWidth, x * chunkHeight, chunkWidth, chunkHeight), GraphicsUnit.Pixel);
                    g.Dispose();
                    chunkedImages[x].Save(foldername + "0" + z + ".bmp");
                    z++;
                    //xCoord += chunkWidth+(chunkWidth/10) * z;
                }
                //yCoord += chunkHeight;
            }
            return chunkedImages;
        }


        //Detecter le principal rectangle a traiter
        public static Bitmap BlobDetectiontest(Bitmap _bitmapSourceImage)
        {




            Bitmap bg = _bitmapSourceImage;
            _bitmapSourceImage = Class2.addblack(_bitmapSourceImage);
            Grayscale _grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap _bitmapGreyImage = _grayscale.Apply(_bitmapSourceImage);
            Bitmap b = null;
            //create a edge detector instance
            DifferenceEdgeDetector _differeceEdgeDetector = new DifferenceEdgeDetector();
            Bitmap _bitmapEdgeImage = _differeceEdgeDetector.Apply(_bitmapGreyImage);

            Threshold _threshold = new Threshold(40);
            Bitmap _bitmapBinaryImage = _threshold.Apply(_bitmapEdgeImage);

            //Create a instance of blob counter algorithm
            BlobCounter _blobCounter = new BlobCounter();
            //Configure Filter
            _blobCounter.MinWidth = _bitmapSourceImage.Width / 2;
            _blobCounter.MinHeight = _bitmapSourceImage.Height / 2;
            _blobCounter.FilterBlobs = true;

            _blobCounter.ProcessImage(_bitmapBinaryImage);
            Blob[] _blobPoints = _blobCounter.GetObjectsInformation();
            Blob reserve = null;
            Graphics _g = Graphics.FromImage(_bitmapSourceImage);

            SimpleShapeChecker _shapeChecker = new SimpleShapeChecker();

            List<IntPoint> _cornersnew = new List<IntPoint>(); ;
            for (int i = 0; i < _blobPoints.Length; i++)
            {
                List<IntPoint> _edgePoint = _blobCounter.GetBlobsEdgePoints(_blobPoints[i]);

                List<IntPoint> _corners = null;

                if (_shapeChecker.IsQuadrilateral(_edgePoint, out _corners))
                {
                    //MessageBox.Show(""+_shapeChecker.CheckShapeType(_edgePoint));
                    System.Drawing.Font _font = new System.Drawing.Font("Segoe UI", 16);
                    System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.PaleGreen);
                    System.Drawing.Point[] _coordinates = ToPointsArray(_corners);
                    if (_coordinates.Length == 4)
                    {
                        if (_cornersnew.Count != 0 && _cornersnew[0].Y < _corners[0].Y)
                        {

                            QuadrilateralTransformation filter = new QuadrilateralTransformation(new List<IntPoint>() { _cornersnew[1], _cornersnew[2], _cornersnew[3], _cornersnew[0] }, _blobPoints[i].Rectangle.Width, _blobPoints[i].Rectangle.Height);
                            b = filter.Apply(bg);


                        }
                        else if (_cornersnew.Count != 0 && _cornersnew[0].Y > _corners[0].Y)
                        {

                            QuadrilateralTransformation filter = new QuadrilateralTransformation(new List<IntPoint>() { _corners[1], _corners[2], _corners[3], _corners[0] }, _blobPoints[i].Rectangle.Width, _blobPoints[i].Rectangle.Height);
                            b = filter.Apply(bg);

                        }
                        else
                        {
                            reserve = _blobPoints[i];
                            _cornersnew = _corners;

                        }


                        //int _x = _coordinates[0].X;
                        //int _y = _coordinates[0].Y;
                        //Pen _pen = new Pen(Color.Brown);
                        //string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                        ////_g.DrawString(_shapeString, _font, _brush, _x, _y);
                        ////_g.DrawPolygon(_pen, ToPointsArray(_corners));




                        //i2.Save(@"D:\hnada20\students\ljadiid.png");





                        //b = Class2.takepart2(bg, 100, _blobPoints[i].Rectangle.Width, _blobPoints[i].Rectangle.Height, _blobPoints[i].Rectangle.X, _blobPoints[i].Rectangle.Y);

                        //b.Save(@"D:\hnada20\students\rect.png");


                    }
                }

            }
            if (_cornersnew.Count == 1)
            {
                QuadrilateralTransformation filter = new QuadrilateralTransformation(new List<IntPoint>() { _cornersnew[1], _cornersnew[2], _cornersnew[3], _cornersnew[0] }, reserve.Rectangle.Width, reserve.Rectangle.Height);
                b = filter.Apply(bg);
            }
            return b;
        }


        
        //Directory info : traiter les fichier d un dossier 
        public static List<String> Directoryinfo(String dir, String dirdes)
        {
            List<String> paths = new List<String>();
            // Specify the directories you want to manipulate.
            DirectoryInfo di = new DirectoryInfo(dir);
            try
            {
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    int z = 0;
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                        fi.MoveTo(dirdes + "\\" + "IMG" + z + day + ".png");
                        paths.Add(dirdes + "\\" + "IMG" + z + day + ".png");
                        z++;
                    }
                   // MessageBox.Show(paths[0] + "");


                }




            }
            catch (Exception e)
            {
               MessageBox.Show("Directory Empty!!!!"+ e.Message);
            }

            return paths;

        }

        //solution pour eviter l'utilisation du image reel par le system -- si on travaille par l'image original on ne peux pas la supprimer si application et ouvert alors on travaille avec une copie de l'image  
        public static System.Drawing.Image GetCopyImage(string path)
        {
            using (System.Drawing.Image im = System.Drawing.Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }



        //Copie de fonction d raitement Principal 
        public static void StartOperation()
        {



            List<String> paths = new List<String>();
            String ProcessForlder = @"D:\hnada20\Process\";
            String ScannerForlder = @"D:\hnada20\Scanner\";
            String ErrorForlder = @"D:\hnada20\Error\";
            String DoneForlder = @"D:\hnada20\Done\";
            Class2.CreateIfMissing(ProcessForlder);
            Class2.CreateIfMissing(ScannerForlder);
            Class2.CreateIfMissing(ErrorForlder);
            Class2.CreateIfMissing(DoneForlder);
            System.Drawing.Image im = null;
            paths = Class2.Directoryinfo(ScannerForlder, ProcessForlder);
            foreach (String s in paths)
            {
                String[] notes = new String[14];
                String[] Qretudiant = new String[14];
                try
                {
                    im = Class2.GetCopyImage(s);
                    Bitmap p1 = (Bitmap)im;
                    p1 = Class2.ProcessFile(p1);
                    p1 = Class2.BlobDetectiontest(p1);
                    //p1.Save(@"D:\hnada20\students\rect3.png");
                    List<Bitmap> list_rect_etudiant = Class2.splitImageorg(p1, 14, 1, @"D:\hnada20\students\");

                    if (list_rect_etudiant.Count != 0)
                    {//start if 

                        List<Bitmap> list_qrcode = new List<Bitmap>();
                        List<Bitmap> list_rect_etudiant_Note = new List<Bitmap>();
                        foreach (Bitmap b in list_rect_etudiant)
                        {
                            Bitmap b_B_W;

                            Image<Gray, byte> ImgInput = new Image<Gray, byte>(b);
                            Image<Gray, byte> _imgCanny = new Image<Gray, byte>(ImgInput.Width, ImgInput.Height, new Gray(0));
                            b_B_W = ImgInput.Canny(100, 500).Bitmap;

                            if (Class2.whiteOnly(b_B_W) > 1000)
                            {
                                list_rect_etudiant_Note.Add(Class2.takenotes(b));
                                list_qrcode.Add(Class2.takebarcode(b));
                            }
                        }
                        int z = 0;
                        foreach (Bitmap b in list_rect_etudiant_Note)
                        {
                            //b.Save(@"D:\hnada20\students\" + z + ".png");
                            Bitmap[,] chunkedImages = Class2.splitImage(b, 1, 46, @"D:\hnada20\" + "note" + z + "\\");
                            Bitmap[] Ad = new Bitmap[2];
                            Bitmap[] N3 = new Bitmap[10];
                            Bitmap[] N1 = new Bitmap[10];
                            Bitmap[] N2 = new Bitmap[10];
                            Bitmap[] N4 = new Bitmap[10];

                            int a = 0;
                            int a1 = 0;
                            int a2 = 0;
                            int a3 = 0;
                            int a4 = 0;

                            for (int i = 0; i < chunkedImages.Length; i++)
                            {
                                if (i == 0 || i == 1)
                                {
                                    Ad[a] = chunkedImages[0, i];
                                    a++;
                                }
                                if (i > 2 && i < 13)
                                {
                                    N1[a1] = chunkedImages[0, i];
                                    a1++;
                                }
                                if (i > 13 && i < 24)
                                {
                                    N2[a2] = chunkedImages[0, i];
                                    a2++;
                                }
                                if (i > 24 && i < 35)
                                {
                                    N3[a3] = chunkedImages[0, i];
                                    a3++;
                                }
                                if (i > 35)
                                {
                                    N4[a4] = chunkedImages[0, i];
                                    a4++;
                                }
                            }
                            String note = "";
                            if (Class2.maxnew(Ad) != -1)
                            {
                                if (Class2.maxnew(Ad) == 0)
                                {
                                    note += "A  ";
                                }
                                else
                                {
                                    note += "D  ";
                                }
                            }
                            else
                            {
                                String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                                list_rect_etudiant[z].Save(ErrorForlder + "\\IMG" + z + day + ".png");
                                continue;
                            }
                            note += Class2.max(N1).ToString();
                            note += Class2.max(N2).ToString();
                            note += ",";
                            note += Class2.max(N3).ToString();
                            note += Class2.max(N4).ToString();

                            notes[z] = note;
                            z++;
                        }
                        z = 0;
                        foreach (Bitmap b1 in list_qrcode)
                        {
                            MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                            Qretudiant[z] = decoder.Decode(new QRCodeBitmapImage(b1 as Bitmap));
                            z++;
                        }
                        //Qrlist.Items.Clear();
                        foreach (String i in Qretudiant)
                        {
                            if (i != null)
                            {

                                // Qrlist.Items.Add(i);
                            }

                        }
                        //listNote.Items.Clear();
                        foreach (String i in notes)
                        {
                            if (i != null)
                            {
                                // listNote.Items.Add(i);
                            }
                        }
                    }//end if
                }
                catch (Exception e8)
                {
                    MessageBox.Show(" form 1 try catch"+e8.Message+"test");
                    String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                    im.Save(ErrorForlder + "\\IMG" + day + ".png");
                }


                //copy to other folder
                FileInfo fi = new FileInfo(s);
                fi.CopyTo(Path.Combine(DoneForlder, fi.Name), true);
                fi.Delete();



            }

        }



        //Triagle Detection
         public static Bitmap BlobDetection1(Bitmap _bitmapSourceImage)
        {
            Grayscale _grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap _bitmapGreyImage = _grayscale.Apply(_bitmapSourceImage);

            //create a edge detector instance
            DifferenceEdgeDetector _differeceEdgeDetector = new DifferenceEdgeDetector();
            Bitmap _bitmapEdgeImage = _differeceEdgeDetector.Apply(_bitmapGreyImage);

            Threshold _threshold = new Threshold(40);
            Bitmap _bitmapBinaryImage = _threshold.Apply(_bitmapEdgeImage);

            //Create a instance of blob counter algorithm
            BlobCounter _blobCounter = new BlobCounter();
            //Configure Filter
            _blobCounter.MinWidth = 5;
            _blobCounter.MinHeight = 5;
            _blobCounter.FilterBlobs = true;

            _blobCounter.ProcessImage(_bitmapBinaryImage);
            Blob[] _blobPoints = _blobCounter.GetObjectsInformation();

            Graphics _g = Graphics.FromImage(_bitmapSourceImage);

            SimpleShapeChecker _shapeChecker = new SimpleShapeChecker();
            for (int i = 0; i < _blobPoints.Length; i++)
            {
                List<IntPoint> _edgePoint = _blobCounter.GetBlobsEdgePoints(_blobPoints[i]);
                List<IntPoint> _corners = null;
                AForge.Point _center;
                float _radius;
                int z = 1;
                if (_shapeChecker.IsCircle(_edgePoint, out _center, out _radius)&& z==0)
                {
                    string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                    System.Drawing.Font _font = new System.Drawing.Font("Segoe UI", 16);
                    System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.Chocolate);
                    Pen _pen = new Pen(Color.GreenYellow);
                    int x = (int)_center.X;
                    int y = (int)_center.Y;
                    _g.DrawString(_shapeString, _font, _brush, x, y);
                    _g.DrawEllipse(_pen, (float)(_center.X - _radius),
                                         (float)(_center.Y - _radius),
                                         (float)(_radius * 2),
                                         (float)(_radius * 2));
                }
                if (_shapeChecker.IsTriangle(_edgePoint, out _corners))
                {
                    string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                    System.Drawing.Font _font = new System.Drawing.Font("Segoe UI", 16);
                    System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.Brown);
                    Pen _pen = new Pen(Color.GreenYellow);
                    int x = (int)_center.X;
                    int y = (int)_center.Y;
                    _g.DrawString(_shapeString, _font, _brush, x, y);
                    _g.DrawPolygon(_pen, ToPointsArray(_corners));

                    if (_corners[0].Y < _bitmapSourceImage.Height / 3)
                    {
                        MessageBox.Show("true");
                    }
                    else
                    {
                        MessageBox.Show("false");
                    }
                }

            }
            return _bitmapSourceImage;
        }





        //****************************************************************************************************************Test En Cours****************















        //--Test En cours -- 
        static string Qretudiant = "";
        public static void qrcode_principale(Bitmap bitmap)
        {

            Bitmap bitmap1 = bitmap;
            int t = 0;

            BlobCounter blobCounter = fct_for_retation_qrcode(bitmap, 0);

            Blob[] blobs = blobCounter.GetObjectsInformation();

            // step 3 - check objects' type and highlight
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();

            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);

                List<IntPoint> corners;

                // is triangle 
                if (shapeChecker.IsConvexPolygon(edgePoints, out corners))
                {
                    // get sub-type
                    PolygonSubType subType = shapeChecker.CheckPolygonSubType(corners);

                    if (subType != PolygonSubType.Unknown && corners.Count == 4)
                    {
                        if (blobs[i].Rectangle.Width < 0.1210 * bitmap1.Width && blobs[i].Rectangle.Width > 0.1028 * bitmap1.Width)
                        {
                            Bitmap chunkedImages = new Bitmap(blobs[i].Rectangle.Width, blobs[i].Rectangle.Height);

                            Graphics g10 = Graphics.FromImage(chunkedImages);
                            g10.DrawImage(bitmap, new Rectangle(0, 0, blobs[i].Rectangle.Width, blobs[i].Rectangle.Height), new Rectangle(blobs[i].Rectangle.X, blobs[i].Rectangle.Y, blobs[i].Rectangle.Width, blobs[i].Rectangle.Height), GraphicsUnit.Pixel);
                            //g.DrawImage(img, new Rectangle(0, 0, b.Width-(4*b.Width/24), b.Height), new Rectangle(b.Width - (4 * b.Width / 24), b.Height, b.Width - (4 * b.Width / 24), b.Height), GraphicsUnit.Pixel);
                            g10.Dispose();
                            CreateIfMissing(@"D:\samran20\students\");

                            MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                            Qretudiant = decoder.Decode(new QRCodeBitmapImage(chunkedImages as Bitmap));

                            //Qretudiant=Qretudiant.Replace(';','_');

                            chunkedImages.Save(@"D:\samran20\students\" + String.Format("{0}.bmp", Qretudiant));
                            t++;
                        }

                    }
                }

            }

        }

        public static BlobCounter fct_for_retation_qrcode(Bitmap bitmap, int x)
        {


            bitmap = AForge.Imaging.Image.Clone(bitmap, PixelFormat.Format32bppArgb);

            if (x == 1)
            {
                //blackAndWhite
                FiltersSequence seq = new FiltersSequence();
                seq.Add(Grayscale.CommonAlgorithms.BT709);  //First add  GrayScaling filter
                seq.Add(new OtsuThreshold()); //Then add binarization(thresholding) filter
                bitmap = seq.Apply(bitmap); // Apply filters on source image
                                            //blackAndWhite

                bitmap = AForge.Imaging.Image.Clone(bitmap, PixelFormat.Format32bppArgb);
            }

            // lock image
            BitmapData bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, bitmap.PixelFormat);

            // step 1 - turn background to black
            ColorFiltering colorFilter = new ColorFiltering();

            colorFilter.Red = new IntRange(0, 64);
            colorFilter.Green = new IntRange(0, 64);
            colorFilter.Blue = new IntRange(0, 64);
            colorFilter.FillOutsideRange = false;

            colorFilter.ApplyInPlace(bitmapData);

            // step 2 - locating objects
            BlobCounter blobCounter = new BlobCounter();

            blobCounter.FilterBlobs = true;
            if (x == 0)
            {
                blobCounter.MinHeight = 50;
                blobCounter.MinHeight = 50;

            }
            else if (x == 1)
            {
                blobCounter.MinHeight = 20;
                blobCounter.MinHeight = 20;

                blobCounter.MaxHeight = 80;
                blobCounter.MaxWidth = 80;
            }


            blobCounter.ProcessImage(bitmapData);

            bitmap.UnlockBits(bitmapData);


            return blobCounter;
        }

        public static Bitmap verifier_retation(Bitmap bitmap)
        {

            Bitmap bitmap1 = bitmap;

            //Bitmap bitmap = bmp;
            BlobCounter blobCounter = fct_for_retation_qrcode(bitmap, 1);

            Blob[] blobs = blobCounter.GetObjectsInformation();

            int som_y = 0;

            // step 3 - check objects' type and highlight
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();

            Graphics g = Graphics.FromImage(bitmap);

            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);

                List<IntPoint> corners;

                // is triangle 
                if (shapeChecker.IsConvexPolygon(edgePoints, out corners))
                {
                    // get sub-type
                    PolygonSubType subType = shapeChecker.CheckPolygonSubType(corners);

                    if (subType != PolygonSubType.Unknown)
                    {
                        if (corners.Count == 3)
                        {
                            /* Bitmap chunkedImages = new Bitmap(blobs[i].Rectangle.Width, blobs[i].Rectangle.Height);

                             Graphics g10 = Graphics.FromImage(chunkedImages);
                             g10.DrawImage(bitmap, new Rectangle(0, 0, blobs[i].Rectangle.Width, blobs[i].Rectangle.Height), new Rectangle(blobs[i].Rectangle.X, blobs[i].Rectangle.Y, blobs[i].Rectangle.Width, blobs[i].Rectangle.Height), GraphicsUnit.Pixel);
                             //g.DrawImage(img, new Rectangle(0, 0, b.Width-(4*b.Width/24), b.Height), new Rectangle(b.Width - (4 * b.Width / 24), b.Height, b.Width - (4 * b.Width / 24), b.Height), GraphicsUnit.Pixel);
                             g10.Dispose();
                             CreateIfMissing(@"D:\samran20\students\");

                             chunkedImages.Save(@"D:\samran20\students\" + String.Format("{0}-{1}.bmp", blobs[i].Rectangle.X, blobs[i].Rectangle.Y));
                             t++;*/
                            // MessageBox.Show("bien1");

                            for (int j = 0; j < 2; j++)
                                som_y += corners[j].Y;



                            // MessageBox.Show("bien2"+ som_y + " "+bitmap.Height);

                        }

                    }

                }

            }


            if (som_y > bitmap.Height)
            {
                bitmap1.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }

            return bitmap1;

        }




    }

    

    


}

﻿using Emgu.CV;
using Emgu.CV.Structure;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.Globalization;
using MetroFramework;
using System.IO;
using System.Threading;
using Tesseract;
/// <summary>
/// Form Pour tester les nouvelle ligne de code
/// le resultat du traitement sera afficher dans deux list box 
/// Auteur : ASUS - Hnada Mohamed 
/// </summary>
namespace WindowsFormsApplication1
{
    public partial class Form2 : MetroForm
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Design Part 
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroThemeStyle.Dark;
        }

        private void Proccess_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //var img = new Bitmap(openFileDialog.FileName);
                textBox1.Text = openFileDialog.FileName;
                //Bitmap[,] chunkedImages = Class2.splitImage(img, 1, 48, @"D:\hnada20\" + "note" + 0 + "\\");
            }

            //StartOperation();





        }

        public static String GetText(Bitmap b)
        {
            var img = b;
            var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
            var page = ocr.Process(img);
            String s = page.GetText();

            return s;
        }
        public int s;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            
        }

       
        


        


        public void StartOperation()
        {
            
           /* 

            List<String> paths = new List<String>();
            String ProcessForlder= @"D:\hnada20\Process\";
            String ScannerForlder = @"D:\hnada20\Scanner\";
            String ErrorForlder=@"D:\hnada20\Error\";
            String DoneForlder= @"D:\hnada20\Done\";
            Class2.CreateIfMissing(ProcessForlder);
            Class2.CreateIfMissing(ScannerForlder);
            Class2.CreateIfMissing(ErrorForlder);
            Class2.CreateIfMissing(DoneForlder);
            Image im=null;
            paths = Class2.Directoryinfo(ScannerForlder, ProcessForlder);
            foreach (String s in paths)
            {
                String[] notes = new String[14];
                String[] Qretudiant = new String[14];
                
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
                                list_rect_etudiant[z].Save(ErrorForlder+"\\IMG"+ z+day +".png");
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

                                Qrlist.Items.Add(i);
                            }

                        }
                        //listNote.Items.Clear();
                        foreach (String i in notes)
                        {
                            if (i != null)
                            {
                                listNote.Items.Add(i);
                            }
                        }
                    }//end if
                
                


                //copy to other folder
                FileInfo fi = new FileInfo(s);
                fi.CopyTo(Path.Combine(DoneForlder, fi.Name), true);
                fi.Delete();



            }
*/
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string ocrtext = textBox1.Text;
            
            textBox2.Text = ocrtext.Replace(" ", "");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Image b = Class2.GetCopyImage(textBox1.Text);
            Bitmap b1 = Class2.BlobDetectiontest((Bitmap)b);
            pictureBox1.Image = b1;
            textBox1.Text = b1.Height.ToString();
           textBox2.Text= s.ToString();
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Image b = Class2.GetCopyImage(textBox1.Text);
            String b1= null;
            

                b1 = Class2.GetText((Bitmap)b);
            
            
            
            //textBox1.Text = b1.Height.ToString();
            textBox2.Text = b1;
            timer1.Stop();
        }
    }
}

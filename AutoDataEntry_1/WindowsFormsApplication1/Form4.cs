using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

using MetroFramework.Forms;
using MetroFramework.Components;
using System.Globalization;
using MetroFramework;

using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        List<String> paths = new List<string>();

        public Form4( String Message,Color color,List<String> paths)
        {
            InitializeComponent();
            this.BackColor = color;
            message.Text = Message;
            this.paths = paths;
            
        }
        
        String[] notes = new String[15];
        String[] Qretudiant = new String[15];
        private void Form4_Load(object sender, EventArgs e)
        {
           this.Top = 30;
           this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width-30;

            StartOperation();

            this.Close();






        }




        public void StartOperation()
        {
            int progress = 0;

            //List<String> paths = new List<String>();
            //paths = Class2.Directoryinfo(@"D:\hnada20\dirtest", @"D:\hnada20\dirtest_final");
            message.Text = progress + "/" + paths.Count();
            foreach (String s in paths)
            {
                progress++;
                Bitmap p1 = new Bitmap(s);
                p1 = Class2.ProcessFile(p1);
                p1 = Class2.BlobDetectiontest(p1);
                //p1.Save(@"D:\hnada20\students\rect3.png");
                List<Bitmap> list_rect_etudiant = Class2.splitImageorg(p1, 14, 1, @"D:\hnada20\students\");
                try
                {
                    if (list_rect_etudiant.Count != 0)
                    {//start if 

                        List<Bitmap> list_qrcode = new List<Bitmap>();
                        List<Bitmap> list_rect_etudiant_Note = new List<Bitmap>();
                        foreach (Bitmap b in list_rect_etudiant)
                        {
                            list_rect_etudiant_Note.Add(Class2.takenotes(b));
                            list_qrcode.Add(Class2.takebarcode(b));
                        }
                        int z = 0;
                        foreach (Bitmap b in list_rect_etudiant_Note)
                        {
                            //b.Save(@"D:\hnada20\students\" + z + ".png");
                            Bitmap[,] chunkedImages = Class2.splitImage(b, 1, Convert.ToInt32(46), @"D:\hnada20\" + "note" + z + "\\");
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
                                note += "*  ";
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
                        //write result to database
                        //***********************************
                        
                        
                    }//end if
                }
                catch (Exception e8)
                {
                    MessageBox.Show(e8.Message);
                }

                message.Text = progress + "/" + paths.Count();
                //copy to other folder
                FileInfo fi = new FileInfo(s);
                fi.CopyTo(Path.Combine(@"D:\hnada20\dirtest1", fi.Name), true);




            }

        }








    }
}

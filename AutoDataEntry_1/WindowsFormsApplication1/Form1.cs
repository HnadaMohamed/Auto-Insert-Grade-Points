using Emgu.CV;
using Emgu.CV.Structure;
using MessagingToolkit.QRCode.Codec.Data;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        int H, M, S;
        Thread th7;


        /// *****************************************************************************************************************************
        //*******************************************************************************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            //connection
            DatabaseManager.OpenConnection();

            //theme
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroThemeStyle.Dark;
            this.FormBorderStyle = FormBorderStyle.None;

            //timer
            H = 0;
            M = 0;
            S = 0;
            timer1.Start();

            //***********
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("Done", "10");
            chart1.Series["s1"].Points.AddXY("Errors", "10");
            chart1.Series["s1"].Points.AddXY("Rest", "50");



            //****process files 

            th7 = new Thread(start);
            th7.SetApartmentState(ApartmentState.STA);
            th7.Start();





        }
        public void start()
        {
            StartOperation();
            

        }




        String ProcessForlder = @"D:\hnada20\Process\";
        String ScannerForlder = @"D:\hnada20\Scanner\";
        String ErrorForlder = @"D:\hnada20\Error\";
        String DoneForlder = @"D:\hnada20\Done\";
        private void timer1_Tick(object sender, EventArgs e)
        {
            S++;
            

            DirectoryInfo process = new DirectoryInfo(ProcessForlder);
            int p = 0;
            foreach (FileInfo fi in process.GetFiles())
            {
                p++;
            }
            
            if (p==0 )
            {
                if (!th7.IsAlive )
                {
                    th7 = new Thread(start);
                    th7.SetApartmentState(ApartmentState.STA);
                    th7.Start();
                }
                
            }






            if (S > 10)
            {
                DirectoryInfo donef = new DirectoryInfo(DoneForlder);
                int d = 0;
                foreach (FileInfo fi in donef.GetFiles())
                {
                    d++;
                }
                Progressbar2.Value = d;

                DirectoryInfo errorf = new DirectoryInfo(ErrorForlder);
                int er = 0;
                foreach (FileInfo fi in errorf.GetFiles())
                {
                    er++;
                }
                Progressbar1.Value = er;
            }
            if (S > 60)
            {
                M++;
                

                S = 0;
            }

            if (M >= 60)
            {
                
                M = 0;
                S = 0;
                H++;
            }

            munites.Text = M.ToString();
            seconds.Text = S.ToString();
            hours.Text = H.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (menuslider.Width < 100)
            {
                menuslider.Width = 200;
            }
            else
            {
                menuslider.Width = 0;
            }


        }

        private void menuslider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void StartOperation()
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
            Image im = null;
            paths = Class2.Directoryinfo(ScannerForlder, ProcessForlder);
            foreach (String s in paths)
            {
                String[] notes = new String[14];
                String[] Qretudiant = new String[14];
                try
                {
                    im = Class2.GetCopyImage(s);
                    im = Class2.verifier_retation((Bitmap)im);
                    Bitmap p1 = (Bitmap)im;
                    p1 = Class2.ProcessFile(p1);
                    p1 = Class2.BlobDetectiontest(p1);
                    //p1.Save(@"D:\hnada20\students\rect3.png");
                    List<Bitmap> list_rect_etudiant = Class2.splitImageorg(p1, 14, 1, @"D:\hnada20\students\");

                    if (list_rect_etudiant.Count != 0)
                    {//start if 

                        List<Bitmap> list_qrcode = new List<Bitmap>();
                        List<Bitmap> list_rect_etudiant_Note = new List<Bitmap>();



                        //TODO :
                        /*
                         *  create class etudiant 
                         *  insert in list<etudiant>
                         * 
                         * 
                         * 
                         * 
                         * 
                         * 
                         * */
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
                        MySqlCommand mysqlComm = new MySqlCommand();
                        for (int  i=0;i< Qretudiant.Length;i++)
                        {


                            String sql = "insert into note values(" + i + ",'" + notes[i] + "','" + Qretudiant[i] + "')";
                            MessageBox.Show(sql);
                            mysqlComm.Connection = DatabaseManager.cnx;
                            mysqlComm.CommandText = sql;
                            mysqlComm.ExecuteNonQuery();


                        }
                      
                    }//end if
                }
                catch (Exception e8)
                {
                    MessageBox.Show(" form 1 try catch "+e8.Message);
                    String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                    im.Save(ErrorForlder + "\\IMG" + day + ".png");
                }


                //copy to other folder
                FileInfo fi = new FileInfo(s);
                fi.CopyTo(Path.Combine(DoneForlder, fi.Name), true);
                fi.Delete();



            }












        }
    }
}

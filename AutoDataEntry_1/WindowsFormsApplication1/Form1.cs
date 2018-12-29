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
/// <summary>
/// Form Principal de traitement de l'image 
/// 
/// Auteur : ASUS - Hnada Mohamed 
/// </summary>
namespace WindowsFormsApplication1
{

    public partial class Form1 : MetroForm
    {
        //Ces dossier sont creer pour le traitment des image 
        String ProcessForlder = @"D:\hnada20\Process\";                 //Dossier pendant le Traitement    
        String ScannerForlder = @"D:\hnada20\Scanner\";                 //Dossier a Scanner 
        String ErrorForlder = @"D:\hnada20\Error\";                     //Dossier Pour les erreur
        String DoneForlder = @"D:\hnada20\Done\";                       //Dossier des image bien traiter 

        int H, M, S;                                                    //timer element 
        Thread th7;                                                     //Thread Pour le traitement des image :pour que le traitement ne bloque pas UI


        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //connection Mysql
            DatabaseManager.OpenConnection();

            //Design
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroThemeStyle.Dark;
            this.FormBorderStyle = FormBorderStyle.None;

            //timer
            H = 0;
            M = 0;
            S = 0;
            timer1.Start();

            //LiveChat -Test-
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("Done", "10");
            chart1.Series["s1"].Points.AddXY("Errors", "10");
            chart1.Series["s1"].Points.AddXY("Rest", "50");



            // Start Thread de traitemnt La premiere fois
            th7 = new Thread(start);
            th7.SetApartmentState(ApartmentState.STA);
            th7.Start();
        }

        public void start()
        {
            //Fonction Principal De traitement de l'image 
            StartOperation();
        }




        //Usage du Timer pour Tester si il ya des image dans le dossier du Scanner lorsqu'on termine de traiter les image du dossier Du traitement
    
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





            // On prent le nbr des image dans chaque dossier pour aclualiser UI pour que Utilisateur suis le Traitement Complet 
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
        //Button du Slider menu --En Test --
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
           
            //Creation des dossiers de traitement 
            Class2.CreateIfMissing(ProcessForlder);
            Class2.CreateIfMissing(ScannerForlder);
            Class2.CreateIfMissing(ErrorForlder);
            Class2.CreateIfMissing(DoneForlder);
            //image virtuelle 
            Image im = null;

            //remplire la list paths par les lien des image dans le dossier du scanner et le deplacer vers le dossier de traitement 
            paths = Class2.Directoryinfo(ScannerForlder, ProcessForlder);

            //traitment image par image 
            foreach (String s in paths)
            {
                String[] notes = new String[14];                //list pour stockage des note 
                String[] Qretudiant = new String[14];           //list de stockage des valeur de Qrcode

                try
                {

                    im = Class2.GetCopyImage(s);                //travailler avec une copy de l'image reel

                    Class2.qrcode_principal((Bitmap)im);
                    //MessageBox.Show("sssssss");
                    //im = Class2.verifier_retation((Bitmap)im);  //corection de orientation de l"image 
                    Bitmap p1 = (Bitmap)im;
                    //p1 = Class2.ProcessFile(p1);
                    p1 = Class2.BlobDetectiontest(p1);          //Detection du rectangle principal 
                    
                    //stocker la lest des rectangle de chaque etudiant 
                    List<Bitmap> list_rect_etudiant = Class2.splitImageorg(p1, 14, 1, @"D:\hnada20\students\");


                    //Commencer le traitement de chaque etudiant 
                    if (list_rect_etudiant.Count != 0)
                    {

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
                        
                        MySqlCommand mysqlComm = new MySqlCommand();
                        for (int  i=0;i< Qretudiant.Length;i++)
                        {


                            String sql = "insert into note values(" + i + ",'" + notes[i] + "','" + Qretudiant[i] + "')";
                            MessageBox.Show(sql);
                            mysqlComm.Connection = DatabaseManager.cnx;
                            mysqlComm.CommandText = sql;
                            mysqlComm.ExecuteNonQuery();


                        }
                      
                    }
                }
                catch (Exception e8)
                {
                    //on cas de erreur dans le try on copier l'image dans le dossier "Erreur"
                    MessageBox.Show(" form 1 try catch "+e8.Message);
                    String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                    im.Save(ErrorForlder + "\\IMG" + day + ".png");
                }

                // A la fin de traitment de chaque image en la copier dans le dossier "Done" et la supprimer du dossier du traitement 
                FileInfo fi = new FileInfo(s);
                fi.CopyTo(Path.Combine(DoneForlder, fi.Name), true);
                fi.Delete();
            }

        }
    }
}

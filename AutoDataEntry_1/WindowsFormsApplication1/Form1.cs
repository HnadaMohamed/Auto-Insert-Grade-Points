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
using System.Runtime.InteropServices;
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
        

        int H, M, S;                                                    //timer element 
        Thread thread_traitment;                                                     //Thread Pour le traitement des image :pour que le traitement ne bloque pas UI


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
            timer2.Start();
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

            DirectoryInfo scanner = new DirectoryInfo(ParametreClass.ScannerForlder);
            int scan = 0;
            foreach (FileInfo fi in scanner.GetFiles())
            {
                scan++;
            }


            DirectoryInfo process = new DirectoryInfo(ParametreClass.ProcessForlder);
            int p = 0;

            foreach (FileInfo fi in process.GetFiles())
            {
                p++;
            }
            
            if (p==0 )
            {
                if (!thread_traitment.IsAlive )                                 
                {
                    Startbutton.Enabled = true;
                    if (scan==0)
                    {
                        label_button_traitement.Text = "Traitement Terminer.";
                        Startbutton.Enabled = false;
                    }else
                    {
                        label_button_traitement.Text = "Vous Avez "+ scan+" Fichier a Traiter !!!";
                         Startbutton.Enabled = true;
                    }
                   
                    
                }
                
            }





            // On prent le nbr des image dans chaque dossier pour actualiser UI pour que Utilisateur suis le Traitement Complet 
            if (S > 10)
            {
                DirectoryInfo err = new DirectoryInfo(ParametreClass.ErrorForlder);
                int d = 0;
                foreach (FileInfo fi in err.GetFiles())
                {
                    d++;
                }
                Progressbarerreur.Value = d;

                DirectoryInfo done = new DirectoryInfo(ParametreClass.DoneForlder);
                int er = 0;
                foreach (FileInfo fi in done.GetFiles())
                {
                    er++;
                }
                Progressbartraiter.Value = er;
                //Progressbarerreur.animationSpeed = 0;

                DirectoryInfo pross = new DirectoryInfo(ParametreClass.ProcessForlder);
                int dn = 0;
                foreach (FileInfo fi in pross.GetFiles())
                {
                    dn++;
                }
              Progressbarencours.Value = dn;


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
               
            


        }

        private void menuslider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_correction_Click(object sender, EventArgs e)
        {

            Form_enregistrement_manuel f = new Form_enregistrement_manuel();
            f.ShowDialog();
        }
        //button de demarage
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            label_button_traitement.Text = "Traitement En Cours......";
            // Start Thread de traitemnt La premiere fois
            thread_traitment = new Thread(start);
            thread_traitment.SetApartmentState(ApartmentState.STA);
            thread_traitment.Start();
            Startbutton.Enabled = false;

        }
        int s = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
           

            
            
            
                
            
                DirectoryInfo scanner = new DirectoryInfo(ParametreClass.ScannerForlder);
                int scan = 0;
                foreach (FileInfo fi in scanner.GetFiles())
                {
                    scan++;
                }

                if (scan == 0)
                {
                    label_button_traitement.Text = "Aucun Fichier A Traiter.";
                    Startbutton.Enabled = false;
                }
                else
                {
                    label_button_traitement.Text = "Vous Avez " + scan + " Fichier a Traiter !!!";
                    Startbutton.Enabled = true;
                }

            
            
                DirectoryInfo err = new DirectoryInfo(ParametreClass.ErrorForlder);
                int d = 0;
                foreach (FileInfo fi in err.GetFiles())
                {
                    d++;
                }
                Progressbarerreur.Value = d;
                

                DirectoryInfo done = new DirectoryInfo(ParametreClass.DoneForlder);
                int er = 0;
                foreach (FileInfo fi in done.GetFiles())
                {
                    er++;
                }
                Progressbartraiter.Value = er;
               

                DirectoryInfo pross = new DirectoryInfo(ParametreClass.ProcessForlder);
                int dn = 0;
                foreach (FileInfo fi in pross.GetFiles())
                {
                    dn++;
                }
                Progressbarencours.Value = dn;
               

            


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_button_traitement_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void StartOperation()
        {

            String QrCode_principale = null;
            String Personnel_id;
            String UniteMatiere_id;
            String type_id;
            String periode_id;
            string examen_id_form1="";
            List<String> paths = new List<String>();

            //Creation des dossiers de traitement 
            Class2.CreateIfMissing(ParametreClass.ProcessForlder);
            Class2.CreateIfMissing(ParametreClass.ScannerForlder);
            Class2.CreateIfMissing(ParametreClass.ErrorForlder);
            Class2.CreateIfMissing(ParametreClass.DoneForlder);
            //image virtuelle 
            Image im = null;

            //remplire la list paths par les lien des image dans le dossier du scanner et le deplacer vers le dossier de traitement 
            paths = Class2.Directoryinfo(ParametreClass.ScannerForlder, ParametreClass.ProcessForlder);

            //traitment image par image 
            foreach (String s in paths)
            {
                im = Class2.GetCopyImage(s);                //travailler avec une copy de l'image reel

                try
                {
                    //extraction des donner du QRcode principal
                    QrCode_principale = Class2.qrcode_principal((Bitmap)im);

                    /*String[] id_champs = QrCode_principale.Split(';');
                    Personnel_id = id_champs[0];
                    UniteMatiere_id = id_champs[1];
                    type_id = id_champs[2];
                    periode_id = id_champs[3];*/

                    


                }
                catch (Exception Qr)
                {
                    //on cas de erreur dans le try on copier l'image dans le dossier "Erreur"
                    MessageBox.Show(" Erreur a la lecture du Qrcode principal :" + Qr.Message);
                    String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                    im.Save(ParametreClass.ErrorForlder + "\\Qr_Problem" + day + ".png");
                    FileInfo fi1 = new FileInfo(s);
                    fi1.Delete();
                    continue;

                }

                try
                {
                    examen_id_form1 = DatabaseManager.find_examen_id(QrCode_principale);
                    //MessageBox.Show(examen_id_form1);
                }
                catch
                {
                    //MessageBox.Show(examen_id_form1);
                }

                //im = Class2.verifier_retation((Bitmap)im);  //corection de orientation de l"image 
                Bitmap p = (Bitmap)im;

                Bitmap p1 = null;
                p1 = Class2.BlobDetectiontest(p);          //Detection du rectangle principal 

                //save rectangle principal 
                p1.Save(@"D:\hnada20\students\rectangle_principale.png");

                ///resize rectangle principale
                Bitmap br = new Bitmap(2200, 2324);
                Graphics gr = Graphics.FromImage(br);
                gr.DrawImage(p1, 0, 0, 2200, 2324);
                gr.Dispose();
                p1 = br;

                p1.Save(@"D:\hnada20\students\rectangle_principale_apres.png");

                //en cas de problem dans la detection du rectangle des notes 
                if (p1 == null)
                {
                    //on cas de erreur  on copier l'image dans le dossier "Erreur"
                    MessageBox.Show(" Erreur dans la detaction de rectangle des notes ");
                    String day = DateTime.Now.ToString("yyyy-MM-dd");
                    im.Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + ";" + day+ ";rectangle_principale_apres" + ".png");
                    FileInfo fi1 = new FileInfo(s);
                    fi1.Delete();
                    continue;
                }

                //stocker la lest des rectangle de chaque etudiant 
                List<Bitmap> list_rect_etudiant = Class2.splitImageorg(p1, 14, 1, @"D:\hnada20\students\");


                //Commencer le traitement de chaque etudiant 
                if (list_rect_etudiant.Count != 0)
                {
                    //list des image a traiter pour chaque etudinat

                    List<Bitmap> list_qrcode = new List<Bitmap>();
                    List<Bitmap> list_rect_etudiant_Note = new List<Bitmap>();

                    //remplissage des list des image a traiter pour chaque etudinat
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

                    Examen_inscription_note examen_inscription_note;
                    List<Examen_inscription_note> list_examen_inscription_note = new List<Examen_inscription_note>();
                    String note = "";
                    String Qrcode = "";
                    for (int i = 0; i < list_rect_etudiant_Note.Count ; i++)
                    {
                        Qrcode = "";
                        note = "";

                        
                        Bitmap[,] chunkedImages = Class2.splitImage(list_rect_etudiant_Note[i], 1, 48, @"D:\hnada20\" + "note" + i + "\\");
                        Bitmap[] Ad = new Bitmap[2];
                        Bitmap[] N100 = new Bitmap[1];
                        Bitmap[] N1 = new Bitmap[10];
                        Bitmap[] N2 = new Bitmap[10];
                        Bitmap[] N3 = new Bitmap[10];
                        Bitmap[] N4 = new Bitmap[10];

                        int a = 0;
                        int a1 = 0;
                        int a2 = 0;
                        int a3 = 0;
                        int a4 = 0;

                        for (int k = 0; k < chunkedImages.Length; k++)
                        {
                            if (k == 0 || k == 1)
                            {
                                Ad[a] = chunkedImages[0, k];
                                a++;
                            }
                            if (k == 3)
                            {
                                N100[0] = chunkedImages[0, k];

                            }
                            if (k > 4 && k < 15)
                            {
                                N1[a1] = chunkedImages[0, k];
                                a1++;
                            }
                            if (k > 15 && k < 26)
                            {
                                N2[a2] = chunkedImages[0, k];
                                a2++;
                            }
                            if (k > 26 && k < 37)
                            {
                                N3[a3] = chunkedImages[0, k];
                                a3++;
                            }
                            if (k > 37)
                            {
                                N4[a4] = chunkedImages[0, k];
                                a4++;
                            }
                        }
                        //*********************************************
                        int Situation = 0;

                        if (Class2.maxnew(Ad, 2) == 0)
                        {
                            //absent
                            Situation = -1;

                        }
                        else if (Class2.maxnew(Ad, 2) == 1)
                        {
                            //disp
                            Situation = -2;

                        }
                        else if (Class2.maxnew(Ad, 2) == -1)
                        {
                            //present
                            Situation = 0;

                        }
                        else
                        {
                            //les A & D sont cocher ---> save in Erreur Dossier.
                            //TODO: nom = information du etudiant.
                            String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                            list_rect_etudiant[i].Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + "; " + day + ";Note" + ".png");
                            continue;
                        }

                        /// TODO : tester sur les valeur de retour de la fonction maxnew1
                        /// 



                        int help100 = int.Parse(Class2.maxnew100(N100, N1, 1).ToString());
                        int helpN1 = int.Parse(Class2.maxnew1(N1, 10).ToString());
                        int helpN2 = int.Parse(Class2.maxnew1(N2, 10).ToString());
                        int helpN3 = int.Parse(Class2.maxnew1(N3, 10).ToString());
                        int helpN4 = int.Parse(Class2.maxnew1(N4, 10).ToString());
                        // MessageBox.Show(Qrcode+"/"+Situation +" / " + help100 + " / " + helpN1 + " / " + helpN2 + " / " + helpN3 + " / " + helpN4);
                        //si tous les note sont vide
                        if (help100 == -1 && helpN1 == -1 && helpN2 == -1 && helpN3 == -1 && helpN4 == -1)
                        {
                            if (Situation == 0)     //ligne vide
                            {
                                //TODO: nom = information du etudiant.
                                String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                                list_rect_etudiant[i].Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + ";" + day + ";Note" + ".png");
                                continue;
                            }
                            else if (Situation == -1 || Situation == -2)
                            {
                                //note += -1;

                                try
                                {
                                    //TODO:Remplacer catsh par simple if ()

                                    Qrcode = Class2.GetText(list_qrcode[i] as Bitmap);
                                    //MessageBox.Show(Qrcode);
                                    int io;

                                    if (!int.TryParse(Qrcode, out io))
                                    {
                                        MessageBox.Show("" + Qrcode + "");
                                        //le Qrcode n'est pas bient Decoder ---> save in Erreur Folder.
                                        String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                                        list_rect_etudiant[i].Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + ";" + day + ";Qrcode" + ".png");
                                        continue;
                                    }

                                    examen_inscription_note = new Examen_inscription_note(int.Parse(Qrcode), int.Parse(examen_id_form1), Double.Parse(Situation.ToString()));
                                    //MessageBox.Show("" + Qrcode + "     " + DatabaseManager.find_examen_id(QrCode_principale)+" /"+ Double.Parse(note));
                                    list_examen_inscription_note.Add(examen_inscription_note);

                                }
                                catch (Exception er)
                                {
                                    MessageBox.Show(er.Message);
                                }

                                continue;
                            }
                        }

                        // si une des note est contient 2 case cocher
                        else if (helpN1 == -2 || helpN1 == -2 || helpN2 == -2 || helpN3 == -2 || helpN4 == -2)
                        {
                            //TODO: nom = information du etudiant.
                            String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                            list_rect_etudiant[i].Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + ";" + day + ";Note" + ".png");
                            continue;
                        }
                        else
                        {
                            if (helpN1 == -1)
                            {
                                note += 0;
                            }
                            else
                            {
                                note += helpN1;
                            }
                            //**
                            if (helpN2 == -1)
                            {
                                note += 0;
                            }
                            else
                            {
                                note += helpN2;
                            }
                            //**vergule
                            note += ",";
                            //**
                            if (helpN3 == -1)
                            {
                                note += 0;
                            }
                            else
                            {
                                note += helpN3;
                            }
                            //**
                            if (helpN4 == -1)
                            {
                                note += 0;
                            }
                            else
                            {
                                note += helpN4;
                            }

                            if (help100 == 100)
                            {
                                note = (100 + Double.Parse(note)).ToString();
                            }

                        }

                        //case de 0 dans tous les note + absent
                        if (Situation == -1 && note == "00,00")
                        {
                            //note = "-1";

                            //TODO: nom = information du etudiant.
                            String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                            list_rect_etudiant[i].Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + ";" + day + ";Note"  + ".png");
                            continue;
                        }
                        //case de 0 dans tous les note + disp
                        else if (Situation == -2 && note == "00,00")
                        {
                            //note = "-2";

                            //TODO: nom = information du etudiant.
                            String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                            list_rect_etudiant[i].Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + ";" + day + ";Note" + ".png");
                            continue;
                        }
                        //une note est existe + absent
                        else if (Situation == -1 && note != "00,00")
                        {
                            //TODO: nom = information du etudiant.
                            String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                            list_rect_etudiant[i].Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + ";" + day + ";Note" + ".png");
                            continue;
                        }
                        //une note est exist + disp
                        else if (Situation == -2 && note != "00,00")
                        {
                            //TODO: nom = information du etudiant.
                            String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                            list_rect_etudiant[i].Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + ";" + day + ";Note" + ".png");
                            continue;
                        }


                        try
                        {

                            //TODO:Remplacer catsh par simple if ()

                            Qrcode = Class2.GetText(list_qrcode[i] as Bitmap);
                            //MessageBox.Show(Qrcode);
                            int io;

                            if (!int.TryParse(Qrcode, out io))
                            {
                                MessageBox.Show("" + Qrcode + "");
                                //le Qrcode n'est pas bient Decoder ---> save in Erreur Folder.
                                String day = DateTime.Now.ToString("yyyyMMddTHHmmss");
                                list_rect_etudiant[i].Save(ParametreClass.ErrorForlder + "\\" + QrCode_principale + ";" + day+";Qrcode" + ".png");
                                continue;
                            }

                            examen_inscription_note = new Examen_inscription_note(int.Parse(Qrcode), int.Parse(examen_id_form1), Double.Parse(note));
                            //MessageBox.Show("" + Qrcode + "     " + DatabaseManager.find_examen_id(QrCode_principale)+" /"+ Double.Parse(note));
                            list_examen_inscription_note.Add(examen_inscription_note);
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show(er.Message);
                        }
                    }
                    if (list_examen_inscription_note.Count != 0)
                    {
                        foreach(var item in list_examen_inscription_note) {
                            DatabaseManager.insert_note(item.inscription_id.ToString(), item.moyenne.ToString(), item.examen_id.ToString() );
                        }

                        //DatabaseManager.insert_note_list(list_examen_inscription_note);
                    }
                    
                }
                // A la fin de traitment de chaque image en la copier dans le dossier "Done" et la supprimer du dossier du traitement 
                FileInfo fi = new FileInfo(s);
                fi.CopyTo(Path.Combine(ParametreClass.DoneForlder, fi.Name), true);
                fi.Delete();
            }

        }








    }
}

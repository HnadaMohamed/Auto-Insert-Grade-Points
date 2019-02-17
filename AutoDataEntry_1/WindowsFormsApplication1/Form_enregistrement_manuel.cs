//ajouter radiobutton Disponser
//modififer la note pour l absent et disponser


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework;
using System.Threading;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form_enregistrement_manuel : MetroForm
    {
        public Form_enregistrement_manuel()
        {
            InitializeComponent();
        }

        MySqlCommand mysqlComm;
        MySqlDataReader dr;
        string sql, inscription_id = "", moyenne = "", examen_id = "";
        int cp_pictures = 0;
        string[] id_champs;
        List<String> paths = new List<String>();
        List<String> paths_delete = new List<String>();


        private void radioButton_Absent_Present_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Absent.Checked)
            {
                label_etudiantnote.Visible = false;
                textBox_Note_Etud.Visible = false;
            }

            if (radioButton_Present.Checked) {

                label_etudiantnote.Visible = true;
                textBox_Note_Etud.Visible = true;
            }
        }

        private void Form_enregistrement_manuel_Load(object sender, EventArgs e)
        {
            //Design Part 
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroThemeStyle.Dark;

            DatabaseManager.OpenConnection();

            get_pictures();

            label_nb_feuille.Text = "Il Vous Reste " + paths.Count+" feuilles " ;

            if (paths.Count != 0)
            {
                pictureBox1.Image = Image.FromFile(paths[0]);

                //remplir textBox_NumEtud par inscription_id
                Bitmap b = Class2.takebarcode((new Bitmap(paths[0])));
                textBox_NumEtud.Text = inscription_id = Class2.GetText(b);

                //MessageBox.Show(paths[0]);
            }
            else
            {
                //panel2.Visible = false;
            }

           
            radioButton_Present.Checked = true;
            checkBox_Message.Checked = true;
        }
        public void get_pictures()
        {

            DirectoryInfo di = new DirectoryInfo(@"D:\hnada20\Error\");
            try
            {
                if (di.Exists)
                {
                    Class2.CreateIfMissing(@"D:\hnada20\Error_seconde\");
                    // MessageBox.Show("Dossier est Exists !");

                    foreach (FileInfo fi in di.GetFiles())
                    {
                        fi.CopyTo(Path.Combine(@"D:\hnada20\Error_seconde\", fi.Name), true);
                        paths.Add(@"D:\hnada20\Error_seconde\" + fi.Name);
                        paths_delete.Add(@"D:\hnada20\Error\" + fi.Name);

                        // MessageBox.Show(paths[0]);

                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Dossier Des erreurs n'existe pas !" ,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

  
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_Message.Checked)
                    if (MessageBox.Show("voulez-vous vraiment Insérer ?", "insertion", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;


                if (((textBox_NumEtud.Text == "" || textBox_Note_Etud.Text == "") && radioButton_Present.Checked) || (textBox_NumEtud.Text == "" && radioButton_Absent.Checked))
                {
                    MessageBox.Show("Merci de saisir les champs");
                    return;
                }

                string verifier_note = insert_note();

                if (paths.Count != 0 && verifier_note == "1")
                {

                    //MessageBox.Show(paths[0] + "s/1");

                    paths.RemoveAt(0);

                    FileInfo fi = new FileInfo(paths_delete[0]);
                    fi.Delete();
                    paths_delete.RemoveAt(0);

                    label_nb_feuille.Text = "Nombre des feuilles : " + paths.Count;

                    if (paths.Count != 0)
                    {
                        //MessageBox.Show(paths[0] + "s/2");
                        pictureBox1.Image = Image.FromFile(paths[0]);

                        //remplir textBox_NumEtud par inscription_id
                        Bitmap b = Class2.takebarcode((new Bitmap(paths[0])));
                        textBox_NumEtud.Text = inscription_id = Class2.GetText(b);
                        //MessageBox.Show(textBox_NumEtud.Text);
                    }
                    else
                    {
                        string filePath = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources");
                        pictureBox1.Image = Image.FromFile(filePath + @"\vide.png");
                        panel2.Visible = false;
                    }


                    initialise();

                }
            }
            catch
            {

            }
             


        }
        public void initialise()
        {
            //textBox_NumEtud.Text = "";
            textBox_Note_Etud.Text = "";
            textBox_NumEtud.Focus();
        }
        private void find_inscription_id()
        {
            try
            {

                //Bitmap b =  Class2.takebarcode((new Bitmap(paths[0])));
                //inscription_id = Class2.GetText(b);

                //MessageBox.Show(Qrcode);
                int io;

                if (!int.TryParse(inscription_id, out io))
                {
                    MessageBox.Show("examen : " + inscription_id + " ,false");

                    inscription_id = "rien";
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

        }

        private void find_examen_id()
        {
            FileInfo fi = new FileInfo(paths[0]);
            string name_image = fi.Name;

            MessageBox.Show("name file : " + name_image);

            //string name_image = "119;195;555;528;526;12/02/2018";

            //id_champs = name_image.Split(';');

            try
            {
                examen_id = DatabaseManager.find_examen_id(name_image);

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }


        }


        private string insert_note()
        {
            try
            {
                //find_inscription_id();
                moyenne = textBox_Note_Etud.Text;
                inscription_id = textBox_NumEtud.Text;
                find_examen_id();


                try
                {
                    Double d = Double.Parse(moyenne.Replace('.',','));
                }
                catch
                {
                    MessageBox.Show("La moyenne est incorrect .", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0";
                }

                try
                {
                    int i = int.Parse(inscription_id);
                }
                catch
                {
                    MessageBox.Show("Numéro d'Etudient est incorrect .", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0";
                }

                if (examen_id == "rien")
                {
                    MessageBox.Show("L'examen n'existe pas .", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return"0";
                }

                DatabaseManager.insert_note(inscription_id, moyenne, examen_id);

                sql = "";
                inscription_id = "";
                moyenne = "";
                examen_id = "";

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());

            }


            return "1";

        }
        

        private void Form_enregistrement_manuel_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* foreach (var path in paths_delete)
            {
                FileInfo fi = new FileInfo(path);
                fi.Delete();
            }*/


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        //foreach (var path in paths_delete)
        //    {
        //         FileInfo fi = new FileInfo(path);
        //fi.Delete();
        //    }
       

        
        private void button_verifier_num_etud_Click(object sender, EventArgs e)
        {
            //select id from inscription where etudiants_id in (select id from etudiants where numetu like 'F130252531')
            find_examen_id();
        }


        //        sql = "select id from inscription where etudiants_id in (select id from etudiants where numetu like '" + textBox_NumEtud.Text + "')";
        //                mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
        //        dr = mysqlComm.ExecuteReader();

        //                if (dr.Read())
        //                {
        //                    textBox_verifer_num_etu.Text = dr["id"].ToString();
        //        inscription_id = dr["id"].ToString();
        //    }
        //                else
        //                {
        //                    textBox_verifer_num_etu.Text = "rien";
        //                    inscription_id = "rien";
        //                }

        //dr.Close();
        //                dr = null;




//        //sql = "SELECT * FROM `examen` where Personnel_id = " + id_champs[0] + " and UniteMatiere_id =" + id_champs[1] + " and type_id = " + id_champs[2] + " and periode_id = " + id_champs[3];
//        sql = "SELECT * FROM `examen` where Personnel_id = 206 and UniteMatiere_id = 804 and type_id = 528 and periode_id = 526";
//                mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
//        dr = mysqlComm.ExecuteReader();

//                if (dr.Read())
//                {
//                    textBox_verifer_num_etu.Text = dr["id"].ToString();
//        examen_id = dr["id"].ToString();
//    }
//                else
//                {
//                    examen_id = "rien";
//                }

//dr.Close();
//                dr = null;

//                if (examen_id == "rien")
//                {
//                    MessageBox.Show("examen = rien");

//                    insert_examen(id_champs);
//                    //find_examen_id();
//                }                
    }
}

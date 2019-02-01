using MetroFramework;
using MetroFramework.Forms;
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
/// <summary>
/// Form De Début Contient le login pour passe a la form Principal de traitement de l'image
/// Auteur : ASUS - Hnada Mohamed 
/// </summary>
namespace WindowsFormsApplication1
{
    public partial class Form3 :MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Design Part
            this.StyleManager = metroStyleManager;
            metroStyleManager.Theme = MetroThemeStyle.Dark;
            this.FormBorderStyle = FormBorderStyle.None;

            loginform.Visible = false;

            //open connection
            DatabaseManager.OpenConnection();

            //copy process folder in scanner folder 
            DirectoryInfo process = new DirectoryInfo(ParametreClass.ProcessForlder);

            foreach (FileInfo fi in process.GetFiles())
            {

                fi.CopyTo(Path.Combine(ParametreClass.ScannerForlder, fi.Name), true);
                fi.Delete();
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            loginform.Visible = true;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Show();
            const int workFactor = 13;//12
            //const string password = "123456";// Password123";
            string password = textpassword.Text;
            //var passwordHash = "$2y$13$83kw95skwt8g0gsw0gow0u62iaJPXKT.bpFcCllzYTF6ZDxa/oWwe";
            var passwordHash = DatabaseManager.get_password(textLogin.Text);



            /*var options = new CryptSharp.CrypterOptions
            {
                { CryptSharp.CrypterOption.Rounds, workFactor },
                { CryptSharp.CrypterOption.Variant, CryptSharp.BlowfishCrypterVariant.Corrected }
            };*/
            if (passwordHash != "")
            {
                var matches = passwordHash == CryptSharp.Crypter.Blowfish.Crypt(password, passwordHash);
                MessageBox.Show("Matches?: " + matches);

                if (matches)
                {
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (!matches)
                {
                    MessageBox.Show("Mot de passe est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Authentification est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = true;
            panel_settings.Height = 350;
        }


        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = false;
        }
    }
}

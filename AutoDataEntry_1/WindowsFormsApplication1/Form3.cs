using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.StyleManager = metroStyleManager;
            //metroStyleManager.Theme =  MetroThemeStyle.Dark ;
            metroStyleManager.Theme = MetroThemeStyle.Dark;
            this.FormBorderStyle = FormBorderStyle.None;

            loginform.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //Form4 f = new Form4("Done", Color.DarkOrange);
            //f.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            loginform.Visible = true;

            //Form4 f = new Form4("Done", Color.DarkOrange);
            //f.Show();
            //Form1 f1 = new Form1();
            //f1.Show();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}

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
/// <summary>
/// Form Pour afficher les notification 
/// accepte comme paramettre Une Message a afficher et une Couleur 
/// Apres 20s  this.close()
/// Auteur : ASUS - Hnada Mohamed 
/// </summary>
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
           //Position du Notification form par rapport au Screen  
           this.Top = 30;
           this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width-30;


        }
        int S = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            S++;
            if (S == 20) 
            {
                this.Close();

            }
        }
    }
}

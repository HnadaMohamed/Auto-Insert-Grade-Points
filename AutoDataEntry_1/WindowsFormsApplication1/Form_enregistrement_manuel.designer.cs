namespace WindowsFormsApplication1
{
    partial class Form_enregistrement_manuel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_enregistrement_manuel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.checkBox_Message = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NumEtud = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label_num = new System.Windows.Forms.Label();
            this.radioButton_Present = new System.Windows.Forms.RadioButton();
            this.radioButton_Absent = new System.Windows.Forms.RadioButton();
            this.textBox_Note_Etud = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label_etudiantnote = new System.Windows.Forms.Label();
            this.button_verifier_num_etud = new System.Windows.Forms.Button();
            this.textBox_verifer_num_etu = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_nb_feuille = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.insertion = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.vide;
            this.pictureBox1.Location = new System.Drawing.Point(8, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // checkBox_Message
            // 
            this.checkBox_Message.BackColor = System.Drawing.Color.White;
            this.checkBox_Message.ChechedOffColor = System.Drawing.Color.White;
            this.checkBox_Message.Checked = false;
            this.checkBox_Message.CheckedOnColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.checkBox_Message.Location = new System.Drawing.Point(405, 68);
            this.checkBox_Message.Name = "checkBox_Message";
            this.checkBox_Message.Size = new System.Drawing.Size(20, 20);
            this.checkBox_Message.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.label3.Location = new System.Drawing.Point(428, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Message De Confirmation";
            // 
            // textBox_NumEtud
            // 
            this.textBox_NumEtud.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(246)))), ((int)(((byte)(61)))));
            this.textBox_NumEtud.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.textBox_NumEtud.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.textBox_NumEtud.BorderThickness = 1;
            this.textBox_NumEtud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_NumEtud.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox_NumEtud.ForeColor = System.Drawing.Color.White;
            this.textBox_NumEtud.isPassword = false;
            this.textBox_NumEtud.Location = new System.Drawing.Point(145, 15);
            this.textBox_NumEtud.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_NumEtud.Name = "textBox_NumEtud";
            this.textBox_NumEtud.Size = new System.Drawing.Size(204, 30);
            this.textBox_NumEtud.TabIndex = 0;
            this.textBox_NumEtud.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.label_num.Location = new System.Drawing.Point(5, 23);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(117, 16);
            this.label_num.TabIndex = 14;
            this.label_num.Text = "Numéro d\'étudient";
            // 
            // radioButton_Present
            // 
            this.radioButton_Present.AutoSize = true;
            this.radioButton_Present.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Present.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.radioButton_Present.Location = new System.Drawing.Point(520, 20);
            this.radioButton_Present.Name = "radioButton_Present";
            this.radioButton_Present.Size = new System.Drawing.Size(74, 22);
            this.radioButton_Present.TabIndex = 1;
            this.radioButton_Present.TabStop = true;
            this.radioButton_Present.Text = "Présent";
            this.radioButton_Present.UseVisualStyleBackColor = true;
            this.radioButton_Present.CheckedChanged += new System.EventHandler(this.radioButton_Absent_Present_CheckedChanged);
            // 
            // radioButton_Absent
            // 
            this.radioButton_Absent.AutoSize = true;
            this.radioButton_Absent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Absent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.radioButton_Absent.Location = new System.Drawing.Point(406, 20);
            this.radioButton_Absent.Name = "radioButton_Absent";
            this.radioButton_Absent.Size = new System.Drawing.Size(70, 22);
            this.radioButton_Absent.TabIndex = 22;
            this.radioButton_Absent.TabStop = true;
            this.radioButton_Absent.Text = "Absent";
            this.radioButton_Absent.UseVisualStyleBackColor = true;
            this.radioButton_Absent.CheckedChanged += new System.EventHandler(this.radioButton_Absent_Present_CheckedChanged);
            // 
            // textBox_Note_Etud
            // 
            this.textBox_Note_Etud.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(246)))), ((int)(((byte)(61)))));
            this.textBox_Note_Etud.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.textBox_Note_Etud.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.textBox_Note_Etud.BorderThickness = 1;
            this.textBox_Note_Etud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Note_Etud.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox_Note_Etud.ForeColor = System.Drawing.Color.White;
            this.textBox_Note_Etud.isPassword = false;
            this.textBox_Note_Etud.Location = new System.Drawing.Point(145, 63);
            this.textBox_Note_Etud.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Note_Etud.Name = "textBox_Note_Etud";
            this.textBox_Note_Etud.Size = new System.Drawing.Size(204, 30);
            this.textBox_Note_Etud.TabIndex = 2;
            this.textBox_Note_Etud.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_etudiantnote
            // 
            this.label_etudiantnote.AutoSize = true;
            this.label_etudiantnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_etudiantnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.label_etudiantnote.Location = new System.Drawing.Point(5, 71);
            this.label_etudiantnote.Name = "label_etudiantnote";
            this.label_etudiantnote.Size = new System.Drawing.Size(116, 16);
            this.label_etudiantnote.TabIndex = 16;
            this.label_etudiantnote.Text = "La Note d\'étudient";
            // 
            // button_verifier_num_etud
            // 
            this.button_verifier_num_etud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verifier_num_etud.Location = new System.Drawing.Point(24, 527);
            this.button_verifier_num_etud.Name = "button_verifier_num_etud";
            this.button_verifier_num_etud.Size = new System.Drawing.Size(149, 25);
            this.button_verifier_num_etud.TabIndex = 7;
            this.button_verifier_num_etud.Text = "verifier ";
            this.button_verifier_num_etud.UseVisualStyleBackColor = true;
            this.button_verifier_num_etud.Visible = false;
            this.button_verifier_num_etud.Click += new System.EventHandler(this.button_verifier_num_etud_Click);
            // 
            // textBox_verifer_num_etu
            // 
            this.textBox_verifer_num_etu.Location = new System.Drawing.Point(50, 563);
            this.textBox_verifer_num_etu.Name = "textBox_verifer_num_etu";
            this.textBox_verifer_num_etu.Size = new System.Drawing.Size(100, 20);
            this.textBox_verifer_num_etu.TabIndex = 8;
            this.textBox_verifer_num_etu.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.insertion);
            this.panel2.Controls.Add(this.label_etudiantnote);
            this.panel2.Controls.Add(this.textBox_Note_Etud);
            this.panel2.Controls.Add(this.label_num);
            this.panel2.Controls.Add(this.textBox_NumEtud);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkBox_Message);
            this.panel2.Controls.Add(this.radioButton_Present);
            this.panel2.Controls.Add(this.radioButton_Absent);
            this.panel2.Location = new System.Drawing.Point(6, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 155);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label_nb_feuille
            // 
            this.label_nb_feuille.AutoSize = true;
            this.label_nb_feuille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label_nb_feuille.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nb_feuille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.label_nb_feuille.Location = new System.Drawing.Point(199, 73);
            this.label_nb_feuille.Name = "label_nb_feuille";
            this.label_nb_feuille.Size = new System.Drawing.Size(237, 25);
            this.label_nb_feuille.TabIndex = 24;
            this.label_nb_feuille.Text = "Il Vous Reste 0 feuilles ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(598, 10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 26;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label_nb_feuille);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 370);
            this.panel1.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(643, 63);
            this.panel5.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(202)))), ((int)(((byte)(253)))));
            this.panel3.Location = new System.Drawing.Point(-119, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 5);
            this.panel3.TabIndex = 15;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel5;
            this.bunifuDragControl1.Vertical = true;
            // 
            // insertion
            // 
            this.insertion.Location = new System.Drawing.Point(450, 113);
            this.insertion.Name = "insertion";
            this.insertion.Size = new System.Drawing.Size(109, 23);
            this.insertion.TabIndex = 23;
            this.insertion.Text = "Submit";
            this.insertion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.insertion.UseSelectable = true;
            this.insertion.UseStyleColors = true;
            this.insertion.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Form_enregistrement_manuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 365);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_verifer_num_etu);
            this.Controls.Add(this.button_verifier_num_etud);
            this.Controls.Add(this.panel1);
            this.Name = "Form_enregistrement_manuel";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_enregistrement_manuel_FormClosing);
            this.Load += new System.EventHandler(this.Form_enregistrement_manuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private Bunifu.Framework.UI.BunifuCheckbox checkBox_Message;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBox_NumEtud;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.RadioButton radioButton_Present;
        private System.Windows.Forms.RadioButton radioButton_Absent;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBox_Note_Etud;
        private System.Windows.Forms.Label label_etudiantnote;
        private System.Windows.Forms.Button button_verifier_num_etud;
        private System.Windows.Forms.TextBox textBox_verifer_num_etu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_nb_feuille;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton insertion;
    }
}
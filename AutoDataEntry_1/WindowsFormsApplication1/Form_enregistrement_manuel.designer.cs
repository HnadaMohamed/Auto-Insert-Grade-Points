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
            this.insertion = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // insertion
            // 
            this.insertion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.insertion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.insertion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insertion.BorderRadius = 0;
            this.insertion.ButtonText = "Insert";
            this.insertion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertion.DisabledColor = System.Drawing.Color.White;
            this.insertion.ForeColor = System.Drawing.Color.Black;
            this.insertion.Iconcolor = System.Drawing.Color.Transparent;
            this.insertion.Iconimage = ((System.Drawing.Image)(resources.GetObject("insertion.Iconimage")));
            this.insertion.Iconimage_right = null;
            this.insertion.Iconimage_right_Selected = null;
            this.insertion.Iconimage_Selected = null;
            this.insertion.IconMarginLeft = 0;
            this.insertion.IconMarginRight = 0;
            this.insertion.IconRightVisible = true;
            this.insertion.IconRightZoom = 0D;
            this.insertion.IconVisible = true;
            this.insertion.IconZoom = 90D;
            this.insertion.IsTab = false;
            this.insertion.Location = new System.Drawing.Point(545, 278);
            this.insertion.Name = "insertion";
            this.insertion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.insertion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.insertion.OnHoverTextColor = System.Drawing.Color.White;
            this.insertion.selected = false;
            this.insertion.Size = new System.Drawing.Size(96, 27);
            this.insertion.TabIndex = 9;
            this.insertion.Text = "Insert";
            this.insertion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertion.Textcolor = System.Drawing.Color.White;
            this.insertion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertion.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // checkBox_Message
            // 
            this.checkBox_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBox_Message.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBox_Message.Checked = true;
            this.checkBox_Message.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBox_Message.ForeColor = System.Drawing.Color.White;
            this.checkBox_Message.Location = new System.Drawing.Point(492, 242);
            this.checkBox_Message.Name = "checkBox_Message";
            this.checkBox_Message.Size = new System.Drawing.Size(20, 20);
            this.checkBox_Message.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(518, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Message De Confirmation";
            // 
            // textBox_NumEtud
            // 
            this.textBox_NumEtud.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textBox_NumEtud.BorderColorIdle = System.Drawing.Color.White;
            this.textBox_NumEtud.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textBox_NumEtud.BorderThickness = 1;
            this.textBox_NumEtud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_NumEtud.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox_NumEtud.ForeColor = System.Drawing.Color.Black;
            this.textBox_NumEtud.isPassword = false;
            this.textBox_NumEtud.Location = new System.Drawing.Point(212, 182);
            this.textBox_NumEtud.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_NumEtud.Name = "textBox_NumEtud";
            this.textBox_NumEtud.Size = new System.Drawing.Size(204, 38);
            this.textBox_NumEtud.TabIndex = 13;
            this.textBox_NumEtud.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_num.Location = new System.Drawing.Point(72, 190);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(117, 16);
            this.label_num.TabIndex = 14;
            this.label_num.Text = "Numéro d\'étudient";
            // 
            // radioButton_Present
            // 
            this.radioButton_Present.AutoSize = true;
            this.radioButton_Present.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Present.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Present.Location = new System.Drawing.Point(621, 187);
            this.radioButton_Present.Name = "radioButton_Present";
            this.radioButton_Present.Size = new System.Drawing.Size(74, 22);
            this.radioButton_Present.TabIndex = 3;
            this.radioButton_Present.TabStop = true;
            this.radioButton_Present.Text = "Présent";
            this.radioButton_Present.UseVisualStyleBackColor = true;
            this.radioButton_Present.CheckedChanged += new System.EventHandler(this.radioButton_Absent_Present_CheckedChanged);
            // 
            // radioButton_Absent
            // 
            this.radioButton_Absent.AutoSize = true;
            this.radioButton_Absent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Absent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Absent.Location = new System.Drawing.Point(499, 187);
            this.radioButton_Absent.Name = "radioButton_Absent";
            this.radioButton_Absent.Size = new System.Drawing.Size(70, 22);
            this.radioButton_Absent.TabIndex = 2;
            this.radioButton_Absent.TabStop = true;
            this.radioButton_Absent.Text = "Absent";
            this.radioButton_Absent.UseVisualStyleBackColor = true;
            this.radioButton_Absent.CheckedChanged += new System.EventHandler(this.radioButton_Absent_Present_CheckedChanged);
            // 
            // textBox_Note_Etud
            // 
            this.textBox_Note_Etud.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textBox_Note_Etud.BorderColorIdle = System.Drawing.Color.White;
            this.textBox_Note_Etud.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textBox_Note_Etud.BorderThickness = 1;
            this.textBox_Note_Etud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Note_Etud.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox_Note_Etud.ForeColor = System.Drawing.Color.Black;
            this.textBox_Note_Etud.isPassword = false;
            this.textBox_Note_Etud.Location = new System.Drawing.Point(212, 240);
            this.textBox_Note_Etud.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Note_Etud.Name = "textBox_Note_Etud";
            this.textBox_Note_Etud.Size = new System.Drawing.Size(204, 33);
            this.textBox_Note_Etud.TabIndex = 15;
            this.textBox_Note_Etud.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_etudiantnote
            // 
            this.label_etudiantnote.AutoSize = true;
            this.label_etudiantnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_etudiantnote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_etudiantnote.Location = new System.Drawing.Point(72, 248);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(54, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 103);
            this.panel1.TabIndex = 17;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(755, 63);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(43, 103);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 18;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(5, 61);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(43, 103);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 19;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.insertion;
            // 
            // Form_enregistrement_manuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 352);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_etudiantnote);
            this.Controls.Add(this.textBox_Note_Etud);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.textBox_NumEtud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_Message);
            this.Controls.Add(this.insertion);
            this.Controls.Add(this.textBox_verifer_num_etu);
            this.Controls.Add(this.button_verifier_num_etud);
            this.Controls.Add(this.radioButton_Present);
            this.Controls.Add(this.radioButton_Absent);
            this.Name = "Form_enregistrement_manuel";
            this.Text = "Correction Des Erreur";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form_enregistrement_manuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private Bunifu.Framework.UI.BunifuFlatButton insertion;
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
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}
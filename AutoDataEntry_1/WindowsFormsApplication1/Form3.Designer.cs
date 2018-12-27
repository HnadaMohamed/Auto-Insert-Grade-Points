using Bunifu.Framework.UI;

namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.loginform = new System.Windows.Forms.Panel();
            this.texlogin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textpassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.loginform.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(220, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(511, 456);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Best Solution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(59, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "For Quick  and Automatique Data Entry Services ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(687, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(62, 345);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(73, 71);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 8;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // loginform
            // 
            this.loginform.Controls.Add(this.texlogin);
            this.loginform.Controls.Add(this.btn_login);
            this.loginform.Controls.Add(this.label3);
            this.loginform.Controls.Add(this.textpassword);
            this.loginform.Location = new System.Drawing.Point(4, 165);
            this.loginform.Name = "loginform";
            this.loginform.Size = new System.Drawing.Size(334, 251);
            this.loginform.TabIndex = 9;
            // 
            // texlogin
            // 
            this.texlogin.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.texlogin.BorderColorIdle = System.Drawing.Color.White;
            this.texlogin.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.texlogin.BorderThickness = 1;
            this.texlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texlogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.texlogin.ForeColor = System.Drawing.Color.Black;
            this.texlogin.isPassword = false;
            this.texlogin.Location = new System.Drawing.Point(32, 121);
            this.texlogin.Margin = new System.Windows.Forms.Padding(4);
            this.texlogin.Name = "texlogin";
            this.texlogin.Size = new System.Drawing.Size(264, 33);
            this.texlogin.TabIndex = 12;
            this.texlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(107, 215);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(111, 23);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Login";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Login";
            // 
            // textpassword
            // 
            this.textpassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textpassword.BorderColorIdle = System.Drawing.Color.White;
            this.textpassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textpassword.BorderThickness = 1;
            this.textpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textpassword.ForeColor = System.Drawing.Color.Black;
            this.textpassword.isPassword = false;
            this.textpassword.Location = new System.Drawing.Point(32, 165);
            this.textpassword.Margin = new System.Windows.Forms.Padding(4);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(264, 33);
            this.textpassword.TabIndex = 4;
            this.textpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this.btn_login;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.loginform);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form3";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Gestion Scolaire";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.loginform.ResumeLayout(false);
            this.loginform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BunifuImageButton bunifuImageButton1;
        private BunifuImageButton bunifuImageButton2;
        private BunifuElipse bunifuElipse1;
        private BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel loginform;
        private System.Windows.Forms.Label label3;
        private BunifuMetroTextbox textpassword;
        private MetroFramework.Controls.MetroButton btn_login;
        private BunifuMetroTextbox texlogin;
        private BunifuElipse bunifuElipse4;
    }
}
namespace WindowsFormsApplication1
{
    partial class NeuralDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuralDemo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.prcentage = new System.Windows.Forms.TextBox();
            this.textnote = new System.Windows.Forms.TextBox();
            this.getrows = new System.Windows.Forms.TextBox();
            this.getcols = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.threshold = new System.Windows.Forms.Button();
            this.corectScan = new System.Windows.Forms.Button();
            this.edgeDetect = new System.Windows.Forms.Button();
            this.cropNote = new System.Windows.Forms.Button();
            this.calc_note = new System.Windows.Forms.Button();
            this.pictnote = new System.Windows.Forms.PictureBox();
            this.filltre = new System.Windows.Forms.Button();
            this.rows = new System.Windows.Forms.Label();
            this.cols = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictnote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.prcentage);
            this.tabPage3.Controls.Add(this.textnote);
            this.tabPage3.Controls.Add(this.getrows);
            this.tabPage3.Controls.Add(this.getcols);
            this.tabPage3.Controls.Add(this.path);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.threshold);
            this.tabPage3.Controls.Add(this.corectScan);
            this.tabPage3.Controls.Add(this.edgeDetect);
            this.tabPage3.Controls.Add(this.cropNote);
            this.tabPage3.Controls.Add(this.calc_note);
            this.tabPage3.Controls.Add(this.pictnote);
            this.tabPage3.Controls.Add(this.filltre);
            this.tabPage3.Controls.Add(this.rows);
            this.tabPage3.Controls.Add(this.cols);
            this.tabPage3.Controls.Add(this.calc);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1057, 710);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Spliter ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // prcentage
            // 
            this.prcentage.Location = new System.Drawing.Point(129, 265);
            this.prcentage.Name = "prcentage";
            this.prcentage.Size = new System.Drawing.Size(75, 20);
            this.prcentage.TabIndex = 26;
            // 
            // textnote
            // 
            this.textnote.Location = new System.Drawing.Point(140, 372);
            this.textnote.Name = "textnote";
            this.textnote.Size = new System.Drawing.Size(49, 20);
            this.textnote.TabIndex = 18;
            // 
            // getrows
            // 
            this.getrows.Location = new System.Drawing.Point(129, 83);
            this.getrows.Name = "getrows";
            this.getrows.Size = new System.Drawing.Size(75, 20);
            this.getrows.TabIndex = 10;
            // 
            // getcols
            // 
            this.getcols.Location = new System.Drawing.Point(129, 52);
            this.getcols.Name = "getcols";
            this.getcols.Size = new System.Drawing.Size(75, 20);
            this.getcols.TabIndex = 9;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(30, 26);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(275, 20);
            this.path.TabIndex = 7;
            this.path.Text = "path";
            this.path.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(431, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(620, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(329, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 115);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(431, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(620, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // threshold
            // 
            this.threshold.Location = new System.Drawing.Point(230, 267);
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(75, 23);
            this.threshold.TabIndex = 22;
            this.threshold.Text = "Threshold";
            this.threshold.UseVisualStyleBackColor = true;
            this.threshold.Click += new System.EventHandler(this.threshold_Click);
            // 
            // corectScan
            // 
            this.corectScan.Location = new System.Drawing.Point(230, 238);
            this.corectScan.Name = "corectScan";
            this.corectScan.Size = new System.Drawing.Size(75, 23);
            this.corectScan.TabIndex = 21;
            this.corectScan.Text = "Correct";
            this.corectScan.UseVisualStyleBackColor = true;
            this.corectScan.Click += new System.EventHandler(this.corectScan_Click);
            // 
            // edgeDetect
            // 
            this.edgeDetect.Location = new System.Drawing.Point(230, 209);
            this.edgeDetect.Name = "edgeDetect";
            this.edgeDetect.Size = new System.Drawing.Size(75, 23);
            this.edgeDetect.TabIndex = 20;
            this.edgeDetect.Text = "Detect";
            this.edgeDetect.UseVisualStyleBackColor = true;
            this.edgeDetect.Click += new System.EventHandler(this.edgeDetect_Click);
            // 
            // cropNote
            // 
            this.cropNote.Location = new System.Drawing.Point(230, 180);
            this.cropNote.Name = "cropNote";
            this.cropNote.Size = new System.Drawing.Size(75, 23);
            this.cropNote.TabIndex = 19;
            this.cropNote.Text = "Crop Detaills";
            this.cropNote.UseVisualStyleBackColor = true;
            this.cropNote.Click += new System.EventHandler(this.cropNote_Click);
            // 
            // calc_note
            // 
            this.calc_note.Location = new System.Drawing.Point(129, 238);
            this.calc_note.Name = "calc_note";
            this.calc_note.Size = new System.Drawing.Size(75, 23);
            this.calc_note.TabIndex = 17;
            this.calc_note.Text = "Note ";
            this.calc_note.UseVisualStyleBackColor = true;
            this.calc_note.Click += new System.EventHandler(this.calc_note_Click);
            // 
            // pictnote
            // 
            this.pictnote.Location = new System.Drawing.Point(140, 291);
            this.pictnote.Name = "pictnote";
            this.pictnote.Size = new System.Drawing.Size(49, 75);
            this.pictnote.TabIndex = 16;
            this.pictnote.TabStop = false;
            // 
            // filltre
            // 
            this.filltre.Location = new System.Drawing.Point(129, 148);
            this.filltre.Name = "filltre";
            this.filltre.Size = new System.Drawing.Size(75, 23);
            this.filltre.TabIndex = 14;
            this.filltre.Text = "filltre";
            this.filltre.UseVisualStyleBackColor = true;
            this.filltre.Click += new System.EventHandler(this.filltre_Click);
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.Location = new System.Drawing.Point(89, 83);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(29, 13);
            this.rows.TabIndex = 13;
            this.rows.Text = "ligne";
            // 
            // cols
            // 
            this.cols.AutoSize = true;
            this.cols.Location = new System.Drawing.Point(78, 55);
            this.cols.Name = "cols";
            this.cols.Size = new System.Drawing.Size(45, 13);
            this.cols.TabIndex = 12;
            this.cols.Text = "colonne";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(129, 209);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 8;
            this.calc.Text = "calc";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Crop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(501, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 736);
            this.tabControl1.TabIndex = 1;
            // 
            // NeuralDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1080, 748);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "NeuralDemo";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.NeuralDemo_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictnote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        //private DrawingPanel drawingPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox prcentage;
        private System.Windows.Forms.TextBox textnote;
        private System.Windows.Forms.TextBox getrows;
        private System.Windows.Forms.TextBox getcols;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button threshold;
        private System.Windows.Forms.Button corectScan;
        private System.Windows.Forms.Button edgeDetect;
        private System.Windows.Forms.Button cropNote;
        private System.Windows.Forms.Button calc_note;
        private System.Windows.Forms.PictureBox pictnote;
        private System.Windows.Forms.Button filltre;
        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.Label cols;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}


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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Note_Etud = new System.Windows.Forms.TextBox();
            this.button_Inserer = new System.Windows.Forms.Button();
            this.checkBox_Message = new System.Windows.Forms.CheckBox();
            this.radioButton_Absent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NumEtud = new System.Windows.Forms.TextBox();
            this.radioButton_Present = new System.Windows.Forms.RadioButton();
            this.button_verifier_num_etud = new System.Windows.Forms.Button();
            this.textBox_verifer_num_etu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro d\'étudient";
            // 
            // textBox_Note_Etud
            // 
            this.textBox_Note_Etud.Location = new System.Drawing.Point(147, 171);
            this.textBox_Note_Etud.Name = "textBox_Note_Etud";
            this.textBox_Note_Etud.Size = new System.Drawing.Size(100, 20);
            this.textBox_Note_Etud.TabIndex = 4;
            // 
            // button_Inserer
            // 
            this.button_Inserer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inserer.Location = new System.Drawing.Point(278, 247);
            this.button_Inserer.Name = "button_Inserer";
            this.button_Inserer.Size = new System.Drawing.Size(131, 48);
            this.button_Inserer.TabIndex = 5;
            this.button_Inserer.Text = "Insérer";
            this.button_Inserer.UseVisualStyleBackColor = true;
            this.button_Inserer.Click += new System.EventHandler(this.button_enregitrer_Click);
            // 
            // checkBox_Message
            // 
            this.checkBox_Message.AutoSize = true;
            this.checkBox_Message.Location = new System.Drawing.Point(35, 221);
            this.checkBox_Message.Name = "checkBox_Message";
            this.checkBox_Message.Size = new System.Drawing.Size(144, 17);
            this.checkBox_Message.TabIndex = 6;
            this.checkBox_Message.Text = "Message de confirmation";
            this.checkBox_Message.UseVisualStyleBackColor = true;
            // 
            // radioButton_Absent
            // 
            this.radioButton_Absent.AutoSize = true;
            this.radioButton_Absent.Location = new System.Drawing.Point(300, 132);
            this.radioButton_Absent.Name = "radioButton_Absent";
            this.radioButton_Absent.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Absent.TabIndex = 2;
            this.radioButton_Absent.TabStop = true;
            this.radioButton_Absent.Text = "Absent";
            this.radioButton_Absent.UseVisualStyleBackColor = true;
            this.radioButton_Absent.CheckedChanged += new System.EventHandler(this.radioButton_Absent_Present_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "La Note d\'étudient";
            // 
            // textBox_NumEtud
            // 
            this.textBox_NumEtud.Location = new System.Drawing.Point(146, 131);
            this.textBox_NumEtud.Name = "textBox_NumEtud";
            this.textBox_NumEtud.Size = new System.Drawing.Size(100, 20);
            this.textBox_NumEtud.TabIndex = 1;
            // 
            // radioButton_Present
            // 
            this.radioButton_Present.AutoSize = true;
            this.radioButton_Present.Location = new System.Drawing.Point(379, 132);
            this.radioButton_Present.Name = "radioButton_Present";
            this.radioButton_Present.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Present.TabIndex = 3;
            this.radioButton_Present.TabStop = true;
            this.radioButton_Present.Text = "Présent";
            this.radioButton_Present.UseVisualStyleBackColor = true;
            this.radioButton_Present.CheckedChanged += new System.EventHandler(this.radioButton_Absent_Present_CheckedChanged);
            // 
            // button_verifier_num_etud
            // 
            this.button_verifier_num_etud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verifier_num_etud.Location = new System.Drawing.Point(510, 131);
            this.button_verifier_num_etud.Name = "button_verifier_num_etud";
            this.button_verifier_num_etud.Size = new System.Drawing.Size(149, 25);
            this.button_verifier_num_etud.TabIndex = 7;
            this.button_verifier_num_etud.Text = "verifier ";
            this.button_verifier_num_etud.UseVisualStyleBackColor = true;
            this.button_verifier_num_etud.Click += new System.EventHandler(this.button_verifier_num_etud_Click);
            // 
            // textBox_verifer_num_etu
            // 
            this.textBox_verifer_num_etu.Location = new System.Drawing.Point(536, 167);
            this.textBox_verifer_num_etu.Name = "textBox_verifer_num_etu";
            this.textBox_verifer_num_etu.Size = new System.Drawing.Size(100, 20);
            this.textBox_verifer_num_etu.TabIndex = 8;
            // 
            // Form_enregistrement_manuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 309);
            this.Controls.Add(this.textBox_verifer_num_etu);
            this.Controls.Add(this.button_verifier_num_etud);
            this.Controls.Add(this.radioButton_Present);
            this.Controls.Add(this.textBox_NumEtud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_Absent);
            this.Controls.Add(this.checkBox_Message);
            this.Controls.Add(this.button_Inserer);
            this.Controls.Add(this.textBox_Note_Etud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_enregistrement_manuel";
            this.Text = "Form_enregistrement_manuel";
            this.Load += new System.EventHandler(this.Form_enregistrement_manuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Note_Etud;
        private System.Windows.Forms.Button button_Inserer;
        private System.Windows.Forms.CheckBox checkBox_Message;
        private System.Windows.Forms.RadioButton radioButton_Absent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NumEtud;
        private System.Windows.Forms.RadioButton radioButton_Present;
        private System.Windows.Forms.Button button_verifier_num_etud;
        private System.Windows.Forms.TextBox textBox_verifer_num_etu;
    }
}
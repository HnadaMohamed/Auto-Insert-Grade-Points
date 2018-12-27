namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.Proccess = new System.Windows.Forms.Button();
            this.listNote = new System.Windows.Forms.ListBox();
            this.Qrlist = new System.Windows.Forms.ListBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Proccess
            // 
            this.Proccess.Location = new System.Drawing.Point(85, 118);
            this.Proccess.Name = "Proccess";
            this.Proccess.Size = new System.Drawing.Size(487, 23);
            this.Proccess.TabIndex = 11;
            this.Proccess.Text = "Process";
            this.Proccess.UseVisualStyleBackColor = true;
            this.Proccess.Click += new System.EventHandler(this.Proccess_Click);
            // 
            // listNote
            // 
            this.listNote.FormattingEnabled = true;
            this.listNote.Location = new System.Drawing.Point(334, 147);
            this.listNote.Name = "listNote";
            this.listNote.Size = new System.Drawing.Size(238, 511);
            this.listNote.TabIndex = 12;
            // 
            // Qrlist
            // 
            this.Qrlist.FormattingEnabled = true;
            this.Qrlist.Location = new System.Drawing.Point(85, 147);
            this.Qrlist.Name = "Qrlist";
            this.Qrlist.Size = new System.Drawing.Size(243, 511);
            this.Qrlist.TabIndex = 13;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 703);
            this.Controls.Add(this.Qrlist);
            this.Controls.Add(this.listNote);
            this.Controls.Add(this.Proccess);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Proccess;
        private System.Windows.Forms.ListBox listNote;
        private System.Windows.Forms.ListBox Qrlist;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Timer timer1;
    }
}
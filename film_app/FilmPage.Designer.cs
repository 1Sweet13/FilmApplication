namespace film_app
{
    partial class FilmPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmPage));
            panel1 = new Panel();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            lblDesc = new Label();
            lblActors = new Label();
            lblGenre = new Label();
            label5 = new Label();
            lblQual = new Label();
            label4 = new Label();
            lblCount = new Label();
            lblYear = new Label();
            lblAge = new Label();
            label2 = new Label();
            label1 = new Label();
            picCover2 = new PictureBox();
            label3 = new Label();
            labelFilm = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCover2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(axWindowsMediaPlayer1);
            panel1.Controls.Add(lblDesc);
            panel1.Controls.Add(lblActors);
            panel1.Controls.Add(lblGenre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblQual);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblCount);
            panel1.Controls.Add(lblYear);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(picCover2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelFilm);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 895);
            panel1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(0, 448);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(615, 375);
            axWindowsMediaPlayer1.TabIndex = 17;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(235, 52);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Description";
            // 
            // lblActors
            // 
            lblActors.AutoSize = true;
            lblActors.Location = new Point(235, 317);
            lblActors.Name = "lblActors";
            lblActors.Size = new Size(45, 15);
            lblActors.TabIndex = 13;
            lblActors.Text = "Actrors";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(156, 377);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(38, 15);
            lblGenre.TabIndex = 12;
            lblGenre.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 377);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 11;
            label5.Text = "Жанр:";
            // 
            // lblQual
            // 
            lblQual.AutoSize = true;
            lblQual.Location = new Point(156, 362);
            lblQual.Name = "lblQual";
            lblQual.Size = new Size(45, 15);
            lblQual.TabIndex = 10;
            lblQual.Text = "Quality";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 362);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Качество:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(156, 347);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(40, 15);
            lblCount.TabIndex = 8;
            lblCount.Text = "Count";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(155, 332);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 7;
            lblYear.Text = "Year";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(156, 317);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 6;
            lblAge.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 347);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Страна:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 317);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "Возраст:";
            // 
            // picCover2
            // 
            picCover2.Location = new Point(16, 13);
            picCover2.Name = "picCover2";
            picCover2.Size = new Size(200, 300);
            picCover2.SizeMode = PictureBoxSizeMode.StretchImage;
            picCover2.TabIndex = 3;
            picCover2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 332);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Год выхода:";
            // 
            // labelFilm
            // 
            labelFilm.AutoSize = true;
            labelFilm.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            labelFilm.Location = new Point(235, 13);
            labelFilm.Name = "labelFilm";
            labelFilm.Size = new Size(110, 30);
            labelFilm.TabIndex = 0;
            labelFilm.Text = "FilmName";
            // 
            // FilmPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 919);
            Controls.Add(panel1);
            Name = "FilmPage";
            Text = "FilmPage";
            Load += FilmPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCover2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label lblDesc;
        private Label label1;
        private Label lblCount;
        private Label lblYear;
        private Label lblAge;
        private Label label2;
        private Label lblQual;
        private Label label4;
        private Panel panel2;
        private Label lblGenre;
        private Label label5;
        public PictureBox picCover2;
        public Label labelFilm;
        public Label lblActors;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
namespace film_app
{
    partial class CreateFilmPage
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
            panel1 = new Panel();
            listBox2 = new ListBox();
            button3 = new Button();
            txtBoxYear = new TextBox();
            label9 = new Label();
            button2 = new Button();
            picCover1 = new PictureBox();
            button1 = new Button();
            btnCreate = new Button();
            txtBoxActors = new TextBox();
            txtBoxQuality = new TextBox();
            cmbBoxgGenre = new ComboBox();
            txtBoxAge = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cmbBoxCountry = new ComboBox();
            cmbBoxLang = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtBoxDesc = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtBoxMainFilm = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCover1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtBoxYear);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(picCover1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(txtBoxActors);
            panel1.Controls.Add(txtBoxQuality);
            panel1.Controls.Add(cmbBoxgGenre);
            panel1.Controls.Add(txtBoxAge);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbBoxCountry);
            panel1.Controls.Add(cmbBoxLang);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxDesc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBoxMainFilm);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 704);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 459);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(580, 94);
            listBox2.TabIndex = 25;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // button3
            // 
            button3.Location = new Point(315, 385);
            button3.Name = "button3";
            button3.Size = new Size(79, 33);
            button3.TabIndex = 23;
            button3.Text = "загрузить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtBoxYear
            // 
            txtBoxYear.Location = new Point(220, 139);
            txtBoxYear.Name = "txtBoxYear";
            txtBoxYear.Size = new Size(74, 23);
            txtBoxYear.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(145, 147);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 21;
            label9.Text = "Год выхода";
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(398, 264);
            button2.Name = "button2";
            button2.Size = new Size(185, 23);
            button2.TabIndex = 20;
            button2.Text = "Загрузить обложку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // picCover1
            // 
            picCover1.Location = new Point(398, 7);
            picCover1.Name = "picCover1";
            picCover1.Size = new Size(185, 251);
            picCover1.SizeMode = PictureBoxSizeMode.StretchImage;
            picCover1.TabIndex = 19;
            picCover1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(492, 664);
            button1.Name = "button1";
            button1.Size = new Size(109, 40);
            button1.TabIndex = 18;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(3, 664);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(109, 40);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Создать страницу";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtBoxActors
            // 
            txtBoxActors.Location = new Point(3, 224);
            txtBoxActors.Multiline = true;
            txtBoxActors.Name = "txtBoxActors";
            txtBoxActors.Size = new Size(288, 77);
            txtBoxActors.TabIndex = 16;
            // 
            // txtBoxQuality
            // 
            txtBoxQuality.Location = new Point(62, 173);
            txtBoxQuality.Name = "txtBoxQuality";
            txtBoxQuality.Size = new Size(74, 23);
            txtBoxQuality.TabIndex = 15;
            // 
            // cmbBoxgGenre
            // 
            cmbBoxgGenre.FormattingEnabled = true;
            cmbBoxgGenre.Location = new Point(53, 110);
            cmbBoxgGenre.Name = "cmbBoxgGenre";
            cmbBoxgGenre.Size = new Size(125, 23);
            cmbBoxgGenre.TabIndex = 14;
            // 
            // txtBoxAge
            // 
            txtBoxAge.Location = new Point(62, 139);
            txtBoxAge.Name = "txtBoxAge";
            txtBoxAge.Size = new Size(74, 23);
            txtBoxAge.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 113);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 12;
            label8.Text = "Жанр";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 206);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 11;
            label7.Text = "Актёры";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 176);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Качество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 147);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Возраст";
            // 
            // cmbBoxCountry
            // 
            cmbBoxCountry.FormattingEnabled = true;
            cmbBoxCountry.Location = new Point(53, 53);
            cmbBoxCountry.Name = "cmbBoxCountry";
            cmbBoxCountry.Size = new Size(125, 23);
            cmbBoxCountry.TabIndex = 8;
            // 
            // cmbBoxLang
            // 
            cmbBoxLang.FormattingEnabled = true;
            cmbBoxLang.Location = new Point(53, 79);
            cmbBoxLang.Name = "cmbBoxLang";
            cmbBoxLang.Size = new Size(125, 23);
            cmbBoxLang.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 87);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "Язык";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Страна";
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.Location = new Point(6, 334);
            txtBoxDesc.Multiline = true;
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(288, 84);
            txtBoxDesc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 316);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Заголовок фильма";
            // 
            // txtBoxMainFilm
            // 
            txtBoxMainFilm.Location = new Point(10, 24);
            txtBoxMainFilm.Name = "txtBoxMainFilm";
            txtBoxMainFilm.Size = new Size(168, 23);
            txtBoxMainFilm.TabIndex = 0;
            // 
            // CreateFilmPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 728);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateFilmPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateFilmPage";
            Load += CreateFilmPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCover1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCreate;
        private TextBox txtBoxActors;
        private TextBox txtBoxQuality;
        private ComboBox cmbBoxgGenre;
        private TextBox txtBoxAge;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cmbBoxCountry;
        private ComboBox cmbBoxLang;
        private Label label4;
        private Label label3;
        private TextBox txtBoxDesc;
        private Label label2;
        private Label label1;
        private TextBox txtBoxMainFilm;
        private Button button1;
        private Button button2;
        private PictureBox picCover1;
        private TextBox txtBoxYear;
        private Label label9;
        private Button button3;
        private ListBox listBox2;
    }
}
namespace film_app
{
    partial class KRFlim
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button5 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1, 1);
            button1.Name = "button1";
            button1.Size = new Size(88, 65);
            button1.TabIndex = 0;
            button1.Text = "ФИЛЬМЫ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(200, 473);
            button5.Name = "button5";
            button5.Size = new Size(150, 23);
            button5.TabIndex = 4;
            button5.Text = "Добавить фильм";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 72);
            listView1.Name = "listView1";
            listView1.Size = new Size(338, 395);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // KRFlim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 508);
            Controls.Add(listView1);
            Controls.Add(button5);
            Controls.Add(button1);
            Name = "KRFlim";
            Text = "KRFilm";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button5;
        private ListView listView1;
    }
}
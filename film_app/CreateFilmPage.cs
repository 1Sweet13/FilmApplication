
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;

//int index = listBox2.SelectedIndex;
//FilmPage f = new FilmPage(_films[index]);
//f.Show();
namespace film_app
{

    public partial class CreateFilmPage : Form
    {
        public FilmContainer filmContainer;
        MainPage KRFlim;
        
       

        public string path;
        public string pathImg;

        public CreateFilmPage(MainPage owner)
        {
            KRFlim = owner;
            InitializeComponent();
        }
        List<string> Country = new List<string>()
        {
            "Россия","Сша","Канада","Германия","Бразилия","Япония"
        };
        List<string> Genres = new List<string>()
        {
            "Драма","Комедия","Ужасы","Триллер","Боевики","Фантастика","Жетектив","Трагедия","Исторический фильм"

        };
        List<string> Languages = new List<string>()
        {
            "Русский","Английский"
        };

        
        private void CreateFilmPage_Load(object sender, EventArgs e)
        {
            cmbBoxCountry.DataSource = Country; // Передача данных в комбобокс
            cmbBoxgGenre.DataSource = Genres;
            cmbBoxLang.DataSource = Languages;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();          
        }

        public async void btnCreate_Click(object sender, EventArgs e)
        {
            FilmContainer filmContainer = new FilmContainer(txtBoxMainFilm.Text, txtBoxDesc.Text, txtBoxAge.Text, txtBoxQuality.Text, txtBoxActors.Text, txtBoxYear.Text, cmbBoxCountry.Text, cmbBoxgGenre.Text,pathImg, path) ;
            FilmPage filmPage = new FilmPage(filmContainer);
            KRFlim.listBox1.Items.Add(filmContainer.MainNameFilm + " " + txtBoxYear.Text);
            KRFlim._films.Add(filmContainer);

            SqlCommand command = new SqlCommand("INSERT INTO [Filmlist] (NameFilm, Description, PathName)VALUES(@NameFilm,@Description,@PathName)", KRFlim.sqlConnection);

            command.Parameters.AddWithValue("NameFilm", txtBoxMainFilm.Text); 

            command.Parameters.AddWithValue("Description", txtBoxDesc.Text);

            command.Parameters.AddWithValue("PathName", pathImg);

            await command.ExecuteNonQueryAsync();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pathImg = openFileDialog.FileName;
                    picCover1.Image = new Bitmap(pathImg);  
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openVideoDialog = new OpenFileDialog();

            if (openVideoDialog.ShowDialog() == DialogResult.OK)
            {
                path = openVideoDialog.FileName;


            }

        }

    }
}

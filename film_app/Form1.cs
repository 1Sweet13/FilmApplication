using AxWMPLib;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data;
using System.Data.SqlClient;



namespace film_app
{

    public partial class MainPage : Form
    {   
        public SqlConnection sqlConnection;

        public MainPage()
        {
            InitializeComponent();      
        }
            
        public List<FilmContainer> _films = new List<FilmContainer>();

        private void button5_Click(object sender, EventArgs e)
        {
            CreateFilmPage filmPage = new CreateFilmPage(this);
            filmPage.Show();
        }

        private  void listBox1_DoubleClick(object sender, EventArgs e)
        {      
            int index = listBox1.SelectedIndex;
            FilmPage f = new FilmPage(_films[index]);
            f.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            FilmPage a = new FilmPage(_films[index]);
            label1.Text = a.labelFilm.Text;
            pictureBox1.Image = a.picCover2.Image;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void   button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }

        private void MainPage_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private async void MainPage_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ProjectC#\film_app\film_app\Filmslist.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("”спешно");
            }
            SqlDataReader? sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Filmlist]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync(); // —читывает таблицу
                while (await sqlReader.ReadAsync())
                {                   
                    FilmContainer film = new FilmContainer(Convert.ToString(sqlReader["NameFilm"]), Convert.ToString(sqlReader["Description"]), "","","","","","", Convert.ToString(sqlReader["PathName"]), "");
                    _films.Add(film);
                    listBox1.Items.Add(film.MainNameFilm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }

        }


    }
}
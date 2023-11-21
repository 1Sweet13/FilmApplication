using AxWMPLib;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;



namespace film_app
{
    public partial class MainPage : Form
    {
        public FilmContainer filmContainer;

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

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            FilmPage f = new FilmPage(_films[index]);
            f.Show();
        }
    }
}
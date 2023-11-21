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

        public void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Refresh();

        }

        private void cmbBoxCounty_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateFilmPage filmPage = new CreateFilmPage(this);

            filmPage.Show();

          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;
            FilmPage f = new FilmPage(_films[index]);
            f.Show();
            
           


        }
    }
}
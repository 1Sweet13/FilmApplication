
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace film_app
{
    public partial class FilmPage : Form
    {

        public FilmContainer filmContainer;

        public FilmPage(FilmContainer filmContainer)
        {

            InitializeComponent();
            labelFilm.Text = filmContainer.MainNameFilm;
            lblDesc.Text = filmContainer.DescriptionFilm;
            lblYear.Text = filmContainer.Year;
            lblAge.Text = filmContainer.age;
            lblCount.Text = filmContainer.Country;
            lblActors.Text = filmContainer.Actors;
            lblGenre.Text = filmContainer.Genres;
            lblQual.Text = filmContainer.quality;
            picCover2.Image = filmContainer.Image;
            lblDesc.MaximumSize = new Size(305, 217);
            lblActors.MaximumSize = new Size(321, 75);
            this.filmContainer = filmContainer;
            axWindowsMediaPlayer1.URL = filmContainer.pathURI;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Ctlcontrols.pause();


        }


        public void FilmPage_Load(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.URL = filmContainer.pathURI;
           



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}

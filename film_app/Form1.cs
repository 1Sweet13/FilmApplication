using System.Windows.Forms.VisualStyles;


namespace film_app
{
    public partial class KRFlim : Form
    {
        public KRFlim()
        {
            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbBoxCounty_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateFilmPage filmPage = new CreateFilmPage();
            filmPage.Show();
        }
    }
}
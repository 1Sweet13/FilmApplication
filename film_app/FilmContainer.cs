

using Microsoft.DirectX.AudioVideoPlayback;

namespace film_app
{

    public class FilmContainer
    {
        public string MainNameFilm;// Главное название фильма
        public string DescriptionFilm;// Описание фильма
        public string age;// Возрастное ограничение
        public string quality;//Качество
        public string Actors;// Актёры
        public string Year;
        public string Country;
        public string Genres;
        public string pathURI;
        public Image Image;
        


        public FilmContainer
            (
            string name,
            string descFilm, 
            string age,
            string qual,
            string actors,
            string year,
            string count,
            string genres,
            Image image,
            string pathURI
            
            
            )
        {
            MainNameFilm = name;
            DescriptionFilm = descFilm;
            this.age = age;
            quality = qual;
            Actors = actors;
            Year = year;
            Country = count;
            Genres = genres;
            Image = image;
            this.pathURI = pathURI;
        }










    }
}

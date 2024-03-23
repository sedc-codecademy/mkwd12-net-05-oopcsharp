

namespace QinshiftAcademy.MovieApplication.Domain.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name is a required field for cinemas!");
            }

            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public Cinema()
        {
            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public void MoviePlaying(Movie movie)
        {
            if(movie == null)
            {
                throw new Exception("We must have a value for the movie playing");

                //return
            }

            //check if the movie is part of the Movies list
            Movie foundMovie = Movies.FirstOrDefault(m => m.Title.ToLower() == movie.Title.ToLower());
            if (foundMovie == null)
            {
                throw new Exception("THe movie is not part of the cinema's movies");
            }

            //bool doesMovieExist = Movies.Any(m => m.Title.ToLower() == movie.Title.ToLower());

            Console.WriteLine($"We are watching movie {movie.Title}");
        }
    }
}

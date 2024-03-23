using MoviesApp.Domain.Enums;
using System.Xml.Linq;

//Make a class Movie. Movie must have: Title, Genre, Rating, TicketPrice and a constructor for setting them.
//Rating should be a number from 1 to 5. Throw exception if its more or less ( you should also handle other exceptions)
//Set the TicketPrice to be 5 * Rating when creating a new object
//Genre should be an enum with Comedy, Horror, Action, Drama and SciFi
//Make a class Cinema. Cinema must have: Name, Halls, ListOfMovies
//Cinema should have method MoviePlaying  that will have a parameter ‘movie’ and then print out in the console “Watching Movie.Title”
//We will provide 10 movies per cinema to put in the cinema movies list

namespace MoviesApp.Domain
{
    public class Movie
    {
        public string Title { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public GenreEnum Genre { get; set; }


        public Movie(string title, int rating, GenreEnum genre)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("Title must have a value");
            }
            Title = title;

            if(rating < 1 || rating > 5)
            {
                throw new Exception($"Invalid rating value {rating}! Rating must be a number between 1 and 5");
            }
            Rating = rating;
            Genre = genre;
            TicketPrice = rating * 5; //we are using rating after the validation, just in case rating has a wrong value (ex. null)
        }
    }
}

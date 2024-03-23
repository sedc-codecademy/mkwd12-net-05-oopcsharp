using SongsApp.Domain.Enums;

namespace SongsApp.Domain.Models
{
    public class Song
    {
        public string Title { get; set; }
        public double Length { get; set; }
        public GenreEnum Genre { get; set; }

        public Song(string title, double length, GenreEnum genre)
        {
            //TODO validations
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}

using QinshiftAcademy.SongsApplication.Domain.Enums;

namespace QinshiftAcademy.SongsApplication.Domain.Models
{
    public class Song
    {
        public string Title { get; set; }
        public double Length { get; set; }
        public Genre Genre { get; set; }

        public Song(string title, double length, Genre genre)
        {
            //you can have validations, for ex. if (string.IsNullOrEmpty(title))
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}

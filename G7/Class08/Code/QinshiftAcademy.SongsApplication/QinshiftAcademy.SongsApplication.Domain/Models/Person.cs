using QinshiftAcademy.SongsApplication.Domain.Enums;
using System.Reflection.Metadata.Ecma335;

namespace QinshiftAcademy.SongsApplication.Domain.Models
{
    public class Person
    {
        private int _id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusicType { get; set; }

        public List<Song> Songs { get; set; } //the default value here is null!!!!!!

        public Person(string firstName, string lastName, int age, Genre genre)
        {
            _id = new Random().Next(1, 1000);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavouriteMusicType = genre;

            //!!!!!!!!, to avoid NullReference Exception
            Songs = new List<Song>();
        }

        public void AddSong(Song s)
        {
            Songs.Add(s);
        }
    }
}


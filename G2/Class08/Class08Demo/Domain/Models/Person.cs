using Domain.Enums;

namespace Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteGenre { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person(int id, string firstName, string lastName, int age, Genre favouriteGenre)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavouriteGenre = favouriteGenre;
        }

        private string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFavouriteSongs()
        {
            if (FavouriteSongs.Count > 0)
            {
                Console.WriteLine($"\n{GetFullName()} likes these songs:");
                foreach (Song song in FavouriteSongs)
                {
                    Console.WriteLine(song.GetSongInfo());
                }
            }
            else
            {
                Console.WriteLine($"Sorry but {GetFullName()} doesn't have any favourite songs!");
            }
        }
    }
}

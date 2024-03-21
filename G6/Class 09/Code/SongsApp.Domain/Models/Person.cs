//Create a class Person with the following properties: Id, FirstName, LastName, Age, FavoriteMusicType (Genre enum) 
//    and FavoriteSongs
//FavoriteSongs is a list of Songs
//Create a method called GetFavSongs() that will print out all the titles of their favorite songs or write a message
//    that this person hates music if there are no favorite songs in their list
using SongsApp.Domain.Enums;

namespace SongsApp.Domain.Models
{
    public class Person
    {
        private int _id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GenreEnum FavoriteMusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; } //list of song objects, the default will be null

        public Person(string  firstName, string lastName, int age, GenreEnum favouriteType)
        {
            _id = new Random().Next(1, 100000);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favouriteType;

            //!!!!!
            FavouriteSongs = new List<Song>(); //we must create an empty list, because otherwise we have null (if we try to use null.Sth it will throw an error
        }

        public void GetFavSongs()
        {
            if(FavouriteSongs == null || FavouriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music");
            }
            else
            {
                foreach(Song song in FavouriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }
    }
}

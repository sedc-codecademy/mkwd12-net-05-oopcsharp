using SongsApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Person(string firstName, string lastName, int age, GenreEnum favouriteType)
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
            if (FavouriteSongs == null || FavouriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music");
            }
            else
            {
                foreach (Song song in FavouriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }

        public int GetId()
        {
            Console.WriteLine("Getting the id...");
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }
    }
}

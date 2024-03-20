using Models;
using System;

namespace Class09_Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> fansList = new List<Person>();

            //fans
            Person jerry = new Person("Jerry", "Tompson", 78, Genre.Rock);
            Person stefan = new Person("Stefan", "Stefanoski", 28, Genre.Techno);
            Person maria = new Person("Maria", "Campbel", 43, Genre.Classical);
            Person jane = new Person("Jane", "Doe", 28, Genre.Techno);

            //songs
            Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, Genre.Rock);
            Song song3 = new Song("Riders On The Storm", 430, Genre.Rock);
            Song song4 = new Song("Not Fade Away", 108, Genre.Rock);
            Song song5 = new Song("Breaking Glass", 111, Genre.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, Genre.Rock);
            Song song7 = new Song("Walk Of Life", 266, Genre.Rock);
            Song song8 = new Song("Smoke on the Water", 340, Genre.Rock);
            Song song9 = new Song("93 'til Infinity", 209, Genre.Techno);
            Song song10 = new Song("Fight the Power", 321, Genre.Techno);
            Song song11 = new Song("The Message", 363, Genre.Techno);
            Song song12 = new Song("Butterfly Effect", 213, Genre.Techno);
            Song song13 = new Song("No Fear", 182, Genre.Techno);
            Song song14 = new Song("Hereditary", 340, Genre.Techno);
            Song song15 = new Song("Bounce Back", 226, Genre.Techno);
            Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
            Song song17 = new Song("Canon in D major", 376, Genre.Classical);
            Song song18 = new Song("Swan Lake", 461, Genre.Classical);
            Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
            Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, Genre.Classical);
            Song song23 = new Song("Planet E", 420, Genre.Techno);
            Song song24 = new Song("Phasor", 368, Genre.Techno);
            Song song25 = new Song("Counting Comets", 242, Genre.Techno);
            Song song26 = new Song("Cold Summer", 358, Genre.Techno);
            Song song27 = new Song("Destroyer", 359, Genre.Techno);
            Song song28 = new Song("Phalanx", 307, Genre.Techno);
            Song song29 = new Song("Vision", 693, Genre.Techno);
            Song song30 = new Song("Chain Reaction", 181, Genre.Techno);
            Song song31 = new Song("Chain Reaction", 181, Genre.Techno);

            List<Song> songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
            song8, song9, song10, song11, song12, song13, song14, song15,
            song16, song17, song18, song19, song20, song21, song22, song23,
            song24, song25, song26, song27, song28, song29, song30, song31 };

            fansList.Add(jerry);
            fansList.Add(stefan);
            fansList.Add(maria);
            fansList.Add(jane);

            foreach (Person fan in fansList)
            {
                PrintFavoriteSongs(fan);
            }

            //Select the person Jerry and add all the songs which start with the letter B.
            List<Song> songsForJerry = songs.Where(x => x.Title.StartsWith("B")).ToList();
            jerry.FavoriteSongs = songsForJerry;
            //Select the person Maria and add all the songs with length longer than 6 min.
            List<Song> songsForMaria = songs.Where(x => x.Length > 360).ToList();
            maria.FavoriteSongs = songsForMaria;
            //Select the person Jane and add all the songs that are of genre Rock.
            List<Song> songsForJane = songs.Where(x => x.Genre == Genre.Rock).ToList();
            jane.FavoriteSongs = songsForJane;
            //Select the person Stefan and add all songs shorter than 3 min and of genre Hip - Hop.
            List<Song> songsForStefan = songs.Where(x => x.Length < 180 && x.Genre == Genre.Hip_Hop).ToList();
            stefan.FavoriteSongs = songsForStefan;

            foreach (Person fan in fansList)
            {
                PrintFavoriteSongs(fan);
            }

            //Select all people from the fansList array that have 4 or more songs. 

            List<Person> result = fansList.Where(x => x.FavoriteSongs.Count >= 4).ToList();
            List<Person> result1 = fansList.Where(x => x.FavoriteSongs.Where(y => y.Genre == Genre.Classical).Count() > 0).ToList();
            List<Person> result2 = fansList.Where(x => x.FavoriteSongs.Any(y => y.Genre == Genre.Classical)).ToList();


            #region Demo
            try
            {
                List<Song> classicalSongs = songs.Where(x => x.Genre == Genre.Classical).ToList();
                List<Song> classicalSongs1 = songs.Where(x => x.Genre == Genre.Classical && x.Length > 500).ToList();

                List<string> classicalSongsNames = songs.Where(x => x.Genre == Genre.Classical).Select(x => $"{x.Title} ({x.Length}s)").ToList();

                Song firstSongThatContainsTo = songs.First(x => x.Title.ToLower().Contains("to"));
                Song firstSongThatContainsTo1 = songs.First(x => x.Title.ToLower().Contains("Risto"));

                Song firstSongThatContainsTo2 = songs.FirstOrDefault(x => x.Title.ToLower().Contains("to"));
                Song firstSongThatContainsTo2_1 = songs.FirstOrDefault(x => x.Title.ToLower().Contains("Risto"));

                if (firstSongThatContainsTo2 != null)
                {
                    Console.WriteLine(firstSongThatContainsTo2.Title);
                }

                //Console.WriteLine(firstSongThatContainsTo2_1.Title);

                if (firstSongThatContainsTo2_1 != null)
                    Console.WriteLine(firstSongThatContainsTo2_1.Title);

                List<Song> distictSongs = songs.DistinctBy(x => x.Title).ToList();

                List<Song> orderByLenght = songs.OrderBy(x => x.Length).ToList();

                List<IGrouping<Genre, Song>> groupByType = songs.GroupBy(x => x.Genre).ToList();
            }
            catch (InvalidOperationException ex)
            {
                //log this error
                Console.WriteLine("Error happened. please try again");
                //throw;
                throw new NullReferenceException("My custom exception");
            }
            catch(NullReferenceException ex)
            {
                //log this error
                Console.WriteLine("Something is not set. Error happened. please try again");
            }
            catch(Exception ex)
            {
                //log this error
                Console.WriteLine("Global exception.");
            }
            finally
            {
                Console.WriteLine("Thank you for using our app");
            }
            #endregion
        }

        static void PrintFavoriteSongs(Person person)
        {
            if (person.GetFavSongs().Count > 0)
            {
                Console.WriteLine($"{person.FullName} likes these songs:");

                foreach (var song in person.GetFavSongs())
                {
                    Console.WriteLine($"{song.Title} {song.Genre} {song.Length}");
                }
            }
            else
            {
                Console.WriteLine($"Sorry but {person.FullName} doesn't have any favorite songs");
            }
        }
    }
}

using SongsApp.Domain.Models;
using SongsApp.Domain.Enums;
using System.Collections;

Person person = new Person("Tijana", "Stojanovska", 24, GenreEnum.Rock);
person.FirstName = "Petko";
string name = person.FirstName;

//person._id = 3; //ERROR
//int id = person._id //ERROR

Console.WriteLine(person.GetId());

person.SetId(3);
Console.WriteLine(person.GetId());

//Select the person Jerry and add all the songs which start with the letter B.
//Select the person Maria and add all the songs with length longer than 6 min.
//Select the person Jane and add all the songs that are of genre Rock.
//Select the person Stefan and add all songs shorter than 3 min and of genre Techno.
//Select all persons from the persons array that have 4 or more songs.

Person jerry = new Person("Jerry", "Jersky", 30, GenreEnum.Hip_Hop);
Person maria = new Person("Maria", "Mariovska", 30, GenreEnum.Classical);
Person jane = new Person("Jane", "Janovska", 30, GenreEnum.Rock);
Person stefan = new Person("Stefan", "Stefanovski", 30, GenreEnum.Techno);

Song song1 = new Song("Bohemian Rhapsody", 367, GenreEnum.Rock);
Song song2 = new Song("Stairway To Heaven", 480, GenreEnum.Rock);
Song song3 = new Song("Riders On The Storm", 430, GenreEnum.Rock);
Song song4 = new Song("Not Fade Away", 108, GenreEnum.Rock);
Song song5 = new Song("Breaking Glass", 111, GenreEnum.Rock);
Song song6 = new Song("Welcome To The Jungle", 275, GenreEnum.Rock);
Song song7 = new Song("Walk Of Life", 266, GenreEnum.Rock);
Song song8 = new Song("Smoke on the Water", 340, GenreEnum.Rock);
Song song9 = new Song("93 'til Infinity", 209, GenreEnum.Techno);
Song song10 = new Song("Fight the Power", 321, GenreEnum.Techno);
Song song11 = new Song("The Message", 363, GenreEnum.Techno);
Song song12 = new Song("Butterfly Effect", 213, GenreEnum.Techno);
Song song13 = new Song("No Fear", 182, GenreEnum.Techno);
Song song14 = new Song("Hereditary", 340, GenreEnum.Techno);
Song song15 = new Song("Bounce Back", 226, GenreEnum.Techno);
Song song16 = new Song("The Four Seasons", 2520, GenreEnum.Classical);
Song song17 = new Song("Canon in D major", 376, GenreEnum.Classical);
Song song18 = new Song("Swan Lake", 461, GenreEnum.Classical);
Song song19 = new Song("Symphony No. 5", 425, GenreEnum.Classical);
Song song20 = new Song("Ride of the Valkyries", 608, GenreEnum.Classical);
Song song21 = new Song("The Magic Flute", 458, GenreEnum.Classical);
Song song22 = new Song("Carmen Suite No.1", 721, GenreEnum.Classical);
Song song23 = new Song("Planet E", 420, GenreEnum.Techno);
Song song24 = new Song("Phasor", 368, GenreEnum.Techno);
Song song25 = new Song("Counting Comets", 242, GenreEnum.Techno);
Song song26 = new Song("Cold Summer", 358, GenreEnum.Techno);
Song song27 = new Song("Destroyer", 359, GenreEnum.Techno);
Song song28 = new Song("Phalanx", 307, GenreEnum.Techno);
Song song29 = new Song("Vision", 693, GenreEnum.Techno);
Song song30 = new Song("Chain Reaction", 181, GenreEnum.Techno);

List<Person> fans = new List<Person>() //we need a collection on which we will use LINQ
{
    jerry,
    maria,
    stefan,
    jane
};

List<Song> songs = new List<Song>() //we need a collection on which we will use LINQ
{
    song1, song2, song3, song4, song5, song6, song7, song8, song9, song10, song11, song12, song13, song14, song15,
    song16, song17, song18, song19, song20, song21, song22, song23, song24, song25,
    song26, song27, song28, song29, song30
};

//Select the person Jerry and add all the songs which start with the letter B.
Person personJerry = fans.FirstOrDefault(x => x.FirstName == "Jerry"); //same as .Where(x => x.FirstName == "Jerry").FirstOrDefault();
if(personJerry == null)
{
    Console.WriteLine("Jerry was not found");
}

personJerry.FavouriteSongs = songs.Where(x => x.Title.StartsWith("B")).ToList();
personJerry.GetFavSongs();

//Select the person Maria and add all the songs with length longer than 6 min.
Person personMaria = fans.FirstOrDefault(x => x.FirstName.ToLower() == "maria");
if(personMaria == null)
{
    Console.WriteLine("Maria was not found");
}

personMaria.FavouriteSongs = songs.Where(x => x.Length > 360).ToList();
personMaria.GetFavSongs();

//Bonus way
Person FindPerson(List<Person> fansList, string firstName)
{
    Person person = fansList.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
    if(person == null)
    {
        Console.WriteLine($"{firstName} was not found");
    }

    return person;
}

//Select the person Jane and add all the songs that are of genre Rock.
//here we don't have access to fansList => that is a variable that only exists in FindPerson method scope
Person personJane = FindPerson(fans, "Jane");
if(personJane != null)
{
    //x.Genre is of type GenreEnum, that's why we can compare it with GenreEnum.Rock
    personJane.FavouriteSongs = songs.Where(x => x.Genre == GenreEnum.Rock).ToList();
}

//Select the person Stefan and add all songs shorter than 3 min and of genre Techno.
Person personStefan = FindPerson(fans, "Stefan");
if(personStefan != null)
{
    personStefan.FavouriteSongs = songs.Where(x => x.Genre == GenreEnum.Techno && x.Length < 180).ToList();
}

//Select all persons from the fans array that have 4 or more favourite songs.
List<Person> filteredPeople = fans.Where(x => x.FavouriteSongs.Count >= 4).ToList();
foreach(Person p in filteredPeople)
{
    Console.WriteLine($"{p.FirstName}:");
    p.GetFavSongs();

}
//Select all fans names from the fans array that have 4 or more favourite songs.
//WE ALWAYS NEED TO DO THE CONDITION CHECK BEFORE WE SELECT SOME PROPERTY!
List<string> fansNames = fans.Where(x => x.FavouriteSongs.Count >= 4).Select(x => x.FirstName).ToList();
using Domain.Enums;
using Domain.Model;

Console.WriteLine("============== EXERCISES ==============");


#region Exercise 01
Console.WriteLine("\n\n================ Exercise 01 ================\n");

static void Exercise01()
{
    Dictionary<string, string> phoneBook = new Dictionary<string, string>()
    {
        { "Bob", "38978111111" },
        { "John", "38971222222" },
        { "Mickey", "38972333333" },
        { "Petko", "38970444444" },
        { "Stanko", "38970555555" }
    };

    while (true)
    {
        Console.Write("\nEnter contact name: ");
        string contactInput = Console.ReadLine();

        if (string.IsNullOrEmpty(contactInput))
        {
            Console.WriteLine("Please enter value!");
            continue;
        }

        bool contactExists = phoneBook.TryGetValue(contactInput, out string phoneNumber);
        // another way to check if that particular key exists (using ContainsKey)
        //bool contactExists = phoneBook.ContainsKey(contactInput);
        if (!contactExists)
        {
            Console.WriteLine("Contact does not exist!");
            continue;
        }

        string formatedPhoneNumber = string.Format("+{0} {1} {2} {3}", phoneNumber.Substring(0, 3), phoneNumber.Substring(3, 2), phoneNumber.Substring(5, 3), phoneNumber.Substring(8));
        Console.WriteLine($"{contactInput}'s phone is {formatedPhoneNumber}\n");

        Console.WriteLine("Enter X to exit!");
        if (Console.ReadLine().ToLower() == "x")
        {
            break;
        }
    }
}

//Exercise01();
#endregion


#region Exercise 02

Console.WriteLine("\n\n================ Exercise 02 ================\n");

Person personOne = new Person(100, "Person", "Personsky", 10, Genre.Classical);
personOne.FavouriteSongs = new List<Song>()
{
    new Song("Song 1", 1500, Genre.Classical),
    new Song("Song 2", 550, Genre.Techno),
    new Song("Song 3", 500, Genre.Rock),
};

personOne.PrintFavouriteSongs();
Console.WriteLine("=== empty FavouriteSongs list ==");
Person personTwo = new Person(100, "Person2", "Personsky2", 11, Genre.Rock);
personTwo.FavouriteSongs = new List<Song>();
personTwo.PrintFavouriteSongs();
#endregion


#region Sample Data

//fans
List<Person> fans = new()
{
    new Person(1, "Jerry", "Tompson", 78, Genre.Rock),
    new Person(2, "Stefan", "Stefanoski", 28, Genre.Techno),
    new Person(3, "Maria", "Campbel", 43, Genre.Classical),
    new Person(4, "Jane", "Doe", 28, Genre.Techno),
};

//songs
List<Song> songs = new List<Song>()
{
    new Song("Bohemian Rhapsody", 367, Genre.Rock),
    new Song("Stairway To Heaven", 480, Genre.Rock),
    new Song("Riders On The Storm", 430, Genre.Rock),
    new Song("Not Fade Away", 108, Genre.Rock),
    new Song("Breaking Glass", 111, Genre.Rock),
    new Song("Welcome To The Jungle", 275, Genre.Rock),
    new Song("Walk Of Life", 266, Genre.Rock),
    new Song("Smoke on the Water", 340, Genre.Rock),
    new Song("93 'til Infinity", 209, Genre.Techno),
    new Song("Fight the Power", 321, Genre.Techno),
    new Song("The Message", 363, Genre.Techno),
    new Song("Butterfly Effect", 213, Genre.Techno),
    new Song("No Fear", 182, Genre.Techno),
    new Song("Hereditary", 340, Genre.Techno),
    new Song("Bounce Back", 226, Genre.Techno),
    new Song("The Four Seasons", 2520, Genre.Classical),
    new Song("Canon in D major", 376, Genre.Classical),
    new Song("Swan Lake", 461, Genre.Classical),
    new Song("Symphony No. 5", 425, Genre.Classical),
    new Song("Ride of the Valkyries", 608, Genre.Classical),
    new Song("The Magic Flute", 458, Genre.Classical),
    new Song("Carmen Suite No.1", 721, Genre.Classical),
    new Song("Planet E", 420, Genre.Techno),
    new Song("Phasor", 368, Genre.Techno),
    new Song("Counting Comets", 242, Genre.Techno),
    new Song("Cold Summer", 358, Genre.Techno),
    new Song("Destroyer", 359, Genre.Techno),
    new Song("Phalanx", 307, Genre.Techno),
    new Song("Vision", 693, Genre.Techno),
    new Song("Chain Reaction", 181, Genre.Techno),
};

#endregion


#region Exercise 03

Console.WriteLine("\n\n================ Exercise 03 ================\n");

//Select the person Jerry and add all the songs which start with the letter B.
Person jerry = fans.FirstOrDefault(p => p.FirstName == "Jerry");
if (jerry != null)
{
    jerry.FavouriteSongs = songs.Where(s => s.Title.StartsWith('B')).ToList();
    jerry.PrintFavouriteSongs();
}


//Select the person Maria and add all the songs with length longer than 6 min.
Person maria = fans.FirstOrDefault(p => p.FirstName == "Maria");
if (maria is not null)
{
    maria.FavouriteSongs = songs.Where(s => s.Length > 360).ToList();
    maria.PrintFavouriteSongs();
}


//Select the person Jane and add all the songs that are of genre Rock.
Person jane = fans.FirstOrDefault(p => p.FirstName == "Jane");
if (jane != null)
{
    jane.FavouriteSongs = songs.Where(s => s.Genre == Genre.Rock).ToList();
    jane.PrintFavouriteSongs();
}


//Select the person Stefan and add all songs shorter than 3 min and of genre Hip-Hop.
Person stefan = fans.FirstOrDefault(p => p.FirstName == "Stefan");
if (jane != null)
{
    stefan.FavouriteSongs = songs.Where(s => s.Length < 3 * 60 && s.Genre == Genre.HipHop).ToList();
    stefan.PrintFavouriteSongs();
}


// ***REMINDER*** Since objects are *reference* type, when we assign for example Person stefan as a variable, we are actualy passing a reference to that particular object. So when we modify the Person-object stefan, the changes are affecting the object in the list as well.

// => Example of reference type behaviour:
Person stefan2 = stefan;
stefan2.Id = 12312;
Console.WriteLine(stefan2.Id); // 12312
Console.WriteLine(fans.First(p => p.FirstName == "Stefan").Id); // 12312
Console.WriteLine(stefan.Id); // 12312


//Select all persons from the persons array that have 4 or more songs.
List<Person> allPersonsWithOver4Songs = fans.Where(p => p.FavouriteSongs.Count >= 4).ToList();
Console.WriteLine("\n\nPersons with more then 4 favourite songs: ");
foreach (var person in allPersonsWithOver4Songs)
{
    Console.WriteLine(person.GetFullName());
}


#endregion

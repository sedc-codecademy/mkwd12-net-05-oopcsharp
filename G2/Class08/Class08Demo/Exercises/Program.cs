using Domain.Enums;
using Domain.Models;
using System;

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
#endregion





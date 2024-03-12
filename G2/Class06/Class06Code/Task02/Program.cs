using Task02.Models;

/*
    TASK 02:

    [0] Create Console app 

    [1] Create class User
        1.1. Create folder

    [2] Create array with 3 users

    [3] Get user to choose an option ( 1. Login, 2. Register )

    [4] Log in
        4.1. Ask for username & password
        4.2. Check if there is a user with these credentials in the array
            4.2.1. If yes, welcome message + Messages
            4.2.2. If no, print error message ("User not found!")

    [5] Register
        5.1. Ask for inputs (ID, Username, Password)
            5.1.1. Validate the inputs
        5.2. Check if there is a user with the input username in the array.
            5.2.1. If yes, print "User already exists"
            5.2.2. If no, create new User object with inputs
                5.2.2.1. Add it to the Users array
                5.2.2.2. Print all the users by Id and Username

    [6] Great job :)
 */

#region Methods
// [4] Login
static void Login(User[] users)
{
    // 4.1.Ask for username & password
    Console.Write("Enter username: ");
    string username = Console.ReadLine();
    Console.Write("Enter password: ");
    string password = Console.ReadLine();
    // 4.2. Check if there is a user with these credentials in the array
    User foundUser = FindUser(username, password, users);
    // 4.2.1.If yes, welcome message + Messages
    if (foundUser != null)
    {
        Console.WriteLine($"Welcome {foundUser.Username}. Here are your messages:\n");
        foundUser.PrintMessages();
    }
    else
    {
        //4.2.2.If no, print error message("User not found!")
        Console.WriteLine("User not found!");
    }
}

static User FindUser(string username, string password, User[] users)
{
    // 4.2. Check if there is a user with the input credentials in the array
    foreach (User user in users)
    {
        if (user.Username == username && user.Password == password)
        {
            return user;
        }
    }
    return null;
}

static void Register()
{
    // Implementation provided by the students :)
}

#endregion

// [2] Create array with 3 users
User[] users = new User[]
{
    new User
    {
        Id = 1,
        Username = "Bob25",
        Password = "Password123",
        Messages = new string[]
        {
            "Hey Bob! Nice shirt.",
            "Call me pls!",
            "Ke si dojdes li za rucek ?"
        }
    },
    new User
    {
        Id = 20,
        Username = "PinkPanther",
        Password = "Password456",
        Messages = new string[]
        {
            "Taram taram",
            "Study more!",
        }
    },
    new User
    {
        Id = 35,
        Username = "GregGregsky",
        Password = "Password789",
        Messages = new string[]{}
    }
};

// [3] Get user to choose an option ( 1. Login, 2. Register )
Console.WriteLine("Choose an option please: \n1) Login \n2)Register");
string inputChoice = Console.ReadLine();

switch (inputChoice)
{
    case "1":
        // Login Logic
        Login(users);
        break;
    case "2":
        // Register Logic
        break;
    default:
        Console.WriteLine("Invalid choice! Try again.");
        break;
}
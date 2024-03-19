using Excercise3.Classes;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

//Create a class User with the following:

//Id - int
//Username - string
//Password - string
//Messages - Array of strings

//Create an array of users and add 3 users to it manually ( hard-coded ).

//Create a Console UI that will give the user two options to choose from:

//Log in - When selected the user should be asked for username and password. 
//    If the user is found print welcome message and the messages that the user has in the Messages property:
//Welcome NAME. Here are your messages:
//Message1
//Message2
//If not found, it should print an error message

//Register - When selected the user should be asked to enter ID, Username and password. 
//It should then check if a there is already a username in the array of users like that.
//If there is, print a message that there is already a user called like that.
//If not, create a new user object from the information given in the console and add it to the Users array.
//Then print all the users by Id and Username
//Registration complete! Users:
//23 Username1
//44 Username2
//1 Username3
//56 Username4**

#region Methods

User FindUser(User[] users, string username, string password)
{
    foreach (User user in users)
    {
        if (user.Username.ToLower() == username.ToLower() && user.Password == password)
            return user;
    }
    //return "sadafs"; // will throw error because type convert cannot be done
    return null;
}

void Login(User[] users, string username, string password)
{
    User user = FindUser(users, username, password);
    if (user == null)
    {
        Console.WriteLine("User not found!");
        return;
    }
    Console.WriteLine("-----------");
    Console.WriteLine($"Welcome {user.Username}");
    Console.WriteLine("-----------");
    Console.WriteLine("Your messages:");
    foreach (string message in user.messages)
    {
        Console.WriteLine(message);
    }
    Console.WriteLine("--------------");
}

void Register(User[] users, string username, string password, int id)
{
    User user = FindUser(users, username, password);
    if (user != null)
    {
        Console.WriteLine("User already exists!");
        return;
    }
    Array.Resize(ref users, users.Length + 1);
    users[users.Length - 1] = new User() { Id = id, Username = username, Password = password };
    Console.WriteLine("Successfully registered!");
    Console.WriteLine("-----------");
    Console.WriteLine("Users registered so far:");
    Console.WriteLine("-----------");
    foreach (User u in users)
    {
        Console.WriteLine($"ID: {u.Id}, Username: {u.Username}");
    }
    Console.WriteLine("----------");
}

bool UsersUI(User[] users)
{
    Console.WriteLine("Choose: \n1) Log in \n2) register");
    int choice;
    bool isNumber = int.TryParse(Console.ReadLine(), out choice);
    if (!isNumber)
    {
        Console.WriteLine("that was not a number, please try again");
        return false;
    }
    switch (choice)
    {
        case 1:
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Login(users, username, password);
            return true;
        case 2:
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Username: ");
            string newUsername = Console.ReadLine();
            Console.Write("Enter Password: ");
            string newPassword = Console.ReadLine();
            Register(users, newUsername, newPassword, id);
            return true;
        default:
            Console.WriteLine("Please enter 1 or 2");
            return false;
    }
}

#endregion

#region data

User[] users = new User[]
{
    new User() { Id = 10, Username = "slave123", Password = "slave321", messages = new string[] {"Pozdrav od SEDC!", "Zdravo, domasnata mi e prikacena na repo! Link zaboraviv" } },
    new User() { Id = 20, Username = "todor111", Password = "sedcrulz", messages = new string[] {"Imame cas vo ponedelnik", "Domasnata e lesna!"}},
    new User() { Id = 25, Username = "bob123", Password = "bobsky123" , messages = new string[] {"Hi, i am bob!", "im very famous in programming examples!", "I bla bla bla"}}
};

#endregion

while (!UsersUI(users));
Console.ReadLine();
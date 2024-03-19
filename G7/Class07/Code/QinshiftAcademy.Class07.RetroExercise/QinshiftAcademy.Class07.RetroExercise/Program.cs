using QinshiftAcademy.Class07.RetroExercise;

User[] users = new User[3];
//User user = new User();
//user.Id = 1;
//user.Username = "test";

users[0] = new User()
{
    Id = 1,
    Username = "Bob23",
    Password = "mysuperpass",
    Messages = new string[] { "Hey bob! Nice shirt.", "Call me pls!" }
};
users[1] = new User()
{
    Id = 2,
    Username = "Paul26",
    Password = "Paul26Paul",
    Messages = new string[] { "Hey Paul!", "How are you?" }
};
users[2] = new User()
{
    Id = 3,
    Username = "Ana13",
    Password = "AnaBanana",
    Messages = new string[] { "Hey Ana! Nice hat.", "See you later."
                }
};

Console.WriteLine("Enter option 1) Login 2) Register");
bool isNumber = int.TryParse(Console.ReadLine(), out int option);

if (!isNumber)
{
    Console.WriteLine("Invalid option");
    return;
}

if (option != 1 && option != 2)
{
    Console.WriteLine("Invalid option");
    return;
}

if (option == 1)
{
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();

    Console.WriteLine("Enter password");
    string password = Console.ReadLine();

    Login(users, username, password);
}
else
{
    //option == 2
    Console.WriteLine("Enter id:");
    bool isIdValid = int.TryParse(Console.ReadLine(), out int id);
    if (!isIdValid)
    {
        Console.WriteLine("Invalid id value!");
        return;
    }
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();

    Console.WriteLine("Enter password");
    string password = Console.ReadLine();

    Register(users, id, username, password);
}


User FindUser(User[] usersArray, string userName, string password = null)
{
    if (!String.IsNullOrEmpty(password))
    {
        foreach (User user in usersArray)
        {
            if (String.Equals(userName, user.Username, StringComparison.InvariantCultureIgnoreCase) &&
                String.Equals(password, user.Password))
            {
                return user;
            }
        }
    }
    else
    {
        //password == null
        foreach (User user in usersArray)
        {
            if (String.Equals(userName, user.Username, StringComparison.InvariantCultureIgnoreCase))
            {
                return user;
            }
        }

    }

    return null;
}

void Login(User[] usersArray, string username, string password)
{
    User foundUser = FindUser(usersArray, username, password);
    if (foundUser == null)
    {
        Console.WriteLine($"Invalid credentials!");
    }
    else
    {
        Console.WriteLine($"Welcome {foundUser.Username}. Here are your messages:");
        foreach (string message in foundUser.Messages)
        {
            Console.WriteLine(message);
        }
    }
}

void Register(User[] usersArray, int id, string username, string password)
{
    User foundUser = FindUser(usersArray, username);
    if (foundUser != null)
    {
        Console.WriteLine($"User with username: {username} already exists!");
        return;
    }

    User newUser = new User()
    {
        Id = id,
        //automatically generate id
        //Id = usersArray[usersArray.Length - 1].Id + 1,
        Password = password,
        Username = username,
        Messages = new string[0]
    };

    Array.Resize(ref usersArray, usersArray.Length + 1);
    //initialize the last member
    usersArray[usersArray.Length - 1] = newUser;

    Console.WriteLine($"Successfully registered user with username: {username}");

    PrintUsers(usersArray);

}

void PrintUsers(User[] usersArray)
{
    Console.WriteLine("All registered users:");
    foreach (User user in usersArray)
    {
        Console.WriteLine($"{user.Id} - {user.Username}");
    }
}
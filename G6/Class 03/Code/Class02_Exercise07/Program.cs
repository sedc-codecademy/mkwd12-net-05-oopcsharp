//Ask the user to enter a number from 1 to 3
//If the user enters “1” write “You got a new car!”
//If the user enters “2” write “You got a new plane!”
//If the user enter “3” write “You got a new bike!”
//If the user enters a wrong number or character write an error message in the console

Console.WriteLine("Please enter a number between 1 and 3");
string input  = Console.ReadLine();
switch (input)
{
    case "1":
        Console.WriteLine("You got a new car!");
        break;
    case "2":
        Console.WriteLine("You got a new plane!");
        break;
    case "3":
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("Wrong input!");
        break;
}
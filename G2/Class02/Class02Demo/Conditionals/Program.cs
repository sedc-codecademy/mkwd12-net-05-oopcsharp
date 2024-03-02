// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region If/Else Statements
if (5 > 3)
{
    Console.WriteLine("5 is larger than 3");
}
else
{
    // UNREACHABLE CODE !
    Console.WriteLine("5 is not larger than 3");
    // Visual Studio tells us here that this code will never be executed
}

// Get number stats
Console.Write("Enter a number:");

bool isValidNumber = int.TryParse(Console.ReadLine(), out int someNumber);

if (!isValidNumber)
{
    Console.WriteLine("You've entered an invalid number!");
}
else if (someNumber > 0)
{
    Console.WriteLine("Number is positive");
}
else if (someNumber < 0)
{
    Console.WriteLine("Number is negative");
}
else
{
    Console.WriteLine("Number is zero");
}

#endregion

#region Switch statement
int day = 7;

switch (day)
{
    case 1:
    case 2:
    case 3:
    case 4: 
    case 5:
        Console.WriteLine("Work day :(");
        break;
    case 6:
    case 7:
        Console.WriteLine("WEEKEND !!! WOO HOOO !!!");
        break;
    default:
        Console.WriteLine("There is no such day !");
        break;
}
#endregion
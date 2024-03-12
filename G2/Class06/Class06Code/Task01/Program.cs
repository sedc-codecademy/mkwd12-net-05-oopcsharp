Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n=================== TASK 01 ===================\n\n");
Console.ResetColor();

static void PrintNumberStats(double number)
{
    bool isNegative = number < 0 ? true : false;
    // or even simpler syntax
    // => because logical operations like greather then (>), equal to (==) or less then (<), returns boolean
    bool isDecimal = number % 1 != 0;
    bool isEven = number % 2 == 0;
    Console.WriteLine($"\nStats for number: {number}");
    Console.WriteLine(string.Format("{0}", isNegative ? "Negative" : "Positive"));
    // same thing as above, only using string interpolation instead of string.Format 
    Console.WriteLine($"{(isDecimal ? "Decimal" : "Integer")}");
    Console.WriteLine($"{(isEven ? "Even" : "Odd")}");
}

static bool UserInterfaceInit()
{
    Console.ReadLine();
    Console.Clear();

    Console.Write("Enter a number:");
    bool isValidNumber = double.TryParse(Console.ReadLine(), out double number);
    if (!isValidNumber)
    {
        Console.WriteLine("That was not a number! Please try again!");
        return false;
    }
    PrintNumberStats(number);

    Console.Write("\nPress any key to try again or X to exit.");
    string exitApp = Console.ReadLine();
    if (exitApp.ToUpper() == "X")
    {
        return true;
    }

    return false;
}

while (!UserInterfaceInit()) { };

Console.Clear();
Console.WriteLine("Bye Bye :)");
Console.ReadLine();
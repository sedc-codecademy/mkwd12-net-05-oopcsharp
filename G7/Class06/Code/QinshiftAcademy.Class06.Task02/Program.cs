void NumberStats(double number)
{
    bool isNegative = number < 0;
    bool isDecimal = number % 1 > 0;
    //ternary operator
    string type = isDecimal ? "Decimal" : "Whole number";
    bool isEven = number % 2 == 0;
    Console.WriteLine($"Stats for number: {number}");
    Console.WriteLine($"{number} is negative: {isNegative}.");
    Console.WriteLine($"{number} is {type}.");
    Console.WriteLine($"{number} is Even: {isEven}.");
}

bool flag = true;


do
{
    Console.Write("Enter a number:");
    double number;
    bool isNumber = double.TryParse(Console.ReadLine(), out number);
    if (!isNumber)
    {
        Console.WriteLine("That was not a number! Please try again!");
    }
    else
    {
        NumberStats(number);
    }

    Console.Write("Press any key to try again or X to exit.");
    string input = Console.ReadLine();
    if (input.Equals("X", StringComparison.InvariantCultureIgnoreCase)) //ignore case (upper, lower) of both strings
    {
        flag = false;
    }
    flag = true;
}
while (flag);

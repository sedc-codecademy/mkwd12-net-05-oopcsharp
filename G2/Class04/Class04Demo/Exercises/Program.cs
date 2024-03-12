Console.WriteLine("============== EXERCISES ==============");

#region Exercise 1
static int Sum(int num1, int num2)
{
    return num1 + num2;
}

static int Subtract(int num1, int num2)
{
    return num1 - num2;
}

static void Exercise1()
{
    while (true)
    {
        Console.Clear();
        Console.Write("Enter operation:");
        string operation = Console.ReadLine();
        if (operation != "+" && operation != "-")
        {
            Console.WriteLine("Sorry! Wrong operation selected! Try again.");
            Console.ReadLine();
            continue; // prevent the code from further execution and go to next iteration
        }

        Console.Write("Enter first number:");
        bool isFirstNumValid = int.TryParse(Console.ReadLine(), out int parsedNumOne);
        Console.Write("Enter second number:");
        bool isSecondNumValid = int.TryParse(Console.ReadLine(), out int parsedNumTwo);

        if (!isFirstNumValid || !isSecondNumValid)
        {
            Console.WriteLine("You've entered invalid numbers!!! Try again.");
            Console.ReadLine();
            continue; // prevent the code from further execution and go to next iteration
        }

        if (operation == "+")
        {
            Console.WriteLine(Sum(parsedNumOne, parsedNumTwo));
        }
        else if (operation == "-")
        {
            Console.WriteLine(Subtract(parsedNumOne, parsedNumTwo));
        }

        break; // when everything is done, exit the loop
    }
    Console.WriteLine("Everything is done :)");
}
Exercise1();

#endregion


#region Exercise 3
static bool SubstringsExercise()
{
    string message = "Hello from Qinshift Codecademy 2024";
    Console.WriteLine("Please enter a number");

    string resultString = "";
    if (!int.TryParse(Console.ReadLine(), out int parsedInput))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You have entered an incorrect format,\nPress any key to try again!");
        Console.ResetColor();
        return false;
    }
    if (parsedInput > message.Length)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You have entered an incorrect number,\nPress any key to try again!");
        Console.ResetColor();
        return false;
    }
    for (int i = 0; i < parsedInput; i++)
    {
        resultString += message[i];
    }
    Console.WriteLine(resultString);
    return true;
    //resultString = message.Substring(0, parsedInput);
    //Console.WriteLine(resultString + " " + "length of new string is " + resultString.Length);
}
while (!SubstringsExercise())
{
    Console.ReadLine();
    Console.Clear();
}
#endregion


#region Exercise 4
DateTime today = DateTime.Today;
Console.WriteLine(today.AddDays(3));
Console.WriteLine(today.AddMonths(1).AddDays(3));
Console.WriteLine(today.AddYears(-1).AddMonths(-2));
Console.WriteLine(string.Format("{0:MMMM}", today));
Console.WriteLine(today.ToString("yyyy"));
#endregion
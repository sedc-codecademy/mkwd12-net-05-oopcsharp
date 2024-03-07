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
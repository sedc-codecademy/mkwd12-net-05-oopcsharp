//Create two variables and initialize them with a keyboard input
//Write code that can test which number is larger
//Write code that can test the numbers whether they are even or odd
//Write the larger number from the two in the console
//After that write if the number is even or odd

Console.WriteLine("Enter the first number:");
string firstInput = Console.ReadLine();

Console.WriteLine("Enter the second number:");
string secondInput = Console.ReadLine();

int firstNumber;
int secondNumber;

bool firstSuccess = int.TryParse(firstInput, out firstNumber);
bool secondSuccess = int.TryParse(secondInput, out secondNumber);

if(firstSuccess && secondSuccess)
{
    if(firstNumber %2 == 0)
    {
        Console.WriteLine("FirstNumber is an even number");
    }
    else
    {
        Console.WriteLine("FirstNumber is an odd number");
    }

    if(secondNumber %2 == 0)
    {
        Console.WriteLine("SecondNumber is an even number");
    }
    else
    {
        Console.WriteLine("SecondNumber is an odd number");
    }

    if (firstNumber > secondNumber)
    {
        Console.WriteLine("The first number is greater than the second");
    }
    else if (firstNumber < secondNumber)
    {
        Console.WriteLine("The second number is greater than the first");
    }
    else
    {
        Console.WriteLine("The numbers are equal");
    }
}
else
{
    Console.WriteLine("At least one input was incorrect");
}
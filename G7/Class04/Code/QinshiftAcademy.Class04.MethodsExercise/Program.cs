int Sum(int num1, int num2)
{
    return num1 + num2;
}

int Subtract(int num1, int num2)
{
    return num1 - num2;
}

Console.WriteLine("Please enter the first number");
string firstInput = Console.ReadLine();
int firstNumber;
bool firstParseResult = int.TryParse(firstInput, out firstNumber);


Console.WriteLine("Please enter the second number");
string secondInput = Console.ReadLine();
int secondNumber;
bool secondParseResult = int.TryParse(secondInput, out secondNumber);

if(firstParseResult && secondParseResult)
{
    Console.WriteLine("Enter + or -");
    string op = Console.ReadLine();

    switch (op)
    {
        case "+":
            int sum = Sum(firstNumber, secondNumber);
            Console.WriteLine("The sum is: " + sum);
            break;
        case "-":
            int result = Subtract(firstNumber, secondNumber);
            Console.WriteLine("The result is: " + result);
            break;
        default:
            Console.WriteLine("This is not a valid operator");
            break;
    }
}
else
{
    Console.WriteLine("Invalid input");
}

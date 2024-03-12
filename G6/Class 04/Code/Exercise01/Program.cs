//Create 2 methods called Sum and Subtract
//Sum will accept two numbers as parameters and return a result from summing the two numbers
//Subtract will accept two numbers as parameters and return a result from subtracting the two numbers
//Ask a person from the console to enter - or +
//Then ask the person to enter two numbers
//Call the corresponding method ( sum or subtract ) and return the result to the console

int Sum(int num1, int num2)
{
    return num1 + num2;
}

int Substract(int num1, int num2)
{
    return num1 - num2;
}

Console.WriteLine("Enter first number:");
string firstInput  = Console.ReadLine();

Console.WriteLine("Enter second number:");
string secondInput = Console.ReadLine();

bool firstSuccess = int.TryParse(firstInput, out int number1);
bool secondSuccess = int.TryParse(secondInput, out int number2);

if(firstSuccess && secondSuccess)
{
    Console.WriteLine("Enter + or -");
    string op = Console.ReadLine();
    if(op == "+")
    {
        int sum = Sum(number1, number2);
        Console.WriteLine("The sum is: " + sum);
    }else if(op == "-")
    {
        int result = Substract(number1, number2);
        Console.WriteLine("The result is: " + result);
    }
    else
    {
        Console.WriteLine("Wrong operator");
    }
}
else
{
    Console.WriteLine("Wrong input!");
}
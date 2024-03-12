Console.WriteLine("=====Exercise 1=====");

Console.WriteLine("Please enter number of trees");
string input = Console.ReadLine();

int numberOfTrees;
bool parsingResult = int.TryParse(input, out numberOfTrees);

if (parsingResult)
{
    int numberOfBranches = 12;
    int numberOfApplesOnBranch = 8;
    int numberOfApplesInBasket = 5;

    int numberOfApples = numberOfTrees * numberOfBranches * numberOfApplesOnBranch;
    int numberOfBaskets;
    if (numberOfApples % numberOfApplesInBasket == 0)
    {
        numberOfBaskets = numberOfApples / numberOfApplesInBasket;
    }
    else
    {
        numberOfBaskets = numberOfApples / numberOfApplesInBasket + 1;
    }

    Console.WriteLine("We need: " + numberOfBaskets + " baskets.");
}
else
{
    Console.WriteLine("Sorry, your input was invalid, it was not a number.");
    
}


Console.WriteLine("====Exercise 2======");
Console.WriteLine("Enter two numbers");

Console.WriteLine("Enter first number:");
string firstNumberInput = Console.ReadLine();
Console.WriteLine("Enter second number:");
string secondNumberInput = Console.ReadLine();

int firstNumber;
bool firstParsingResult = int.TryParse(firstNumberInput, out firstNumber);

int secondNumber;
bool secondParsingResult = int.TryParse(secondNumberInput, out secondNumber);

if(firstParsingResult && secondParsingResult)
{
    if(firstNumber > secondNumber)
    {
        Console.WriteLine("First number is larger");
    }
    else if(firstNumber < secondNumber)
    {
        Console.WriteLine("Second number is larger");
    }
    else
    {
        Console.WriteLine("The numbers are equal");
    }

    if(firstNumber % 2 == 0)
    {
        Console.WriteLine("The first number is even");
    }
    else
    {
        Console.WriteLine("The first number is odd");
    }
}
else
{
    Console.WriteLine("Not all the inputs were valid");
}

Console.WriteLine("====Exercise 3=====");
Console.WriteLine("Please enter a number from 1 to 3");
string thirdInput = Console.ReadLine();

int doorNumber;
bool thirdParsingResult = int.TryParse(thirdInput, out doorNumber);

if (thirdParsingResult)
{
    switch (doorNumber)
    {
        case 1:
            Console.WriteLine("You got a new car");
            break;
        case 2:
            Console.WriteLine("You got a new plane");
            break;
        case 3:
            Console.WriteLine("You got a new bike");
            break;
        default:
            Console.WriteLine("Invalid number. It has to be between 1 and 3");
            break;
    }
}
else
{
    Console.WriteLine("Invalid input");
}



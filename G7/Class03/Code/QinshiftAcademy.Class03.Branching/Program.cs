
Console.WriteLine("Branching");

//if-else
int firstNumber = 5;
int secondNumber = 3;

if(firstNumber != 0)
{
    Console.WriteLine("The first number is not zero");
}
else
{
    Console.WriteLine("The firstNumber is zero");
}


//if - else if - else

if(firstNumber > 0)
{
    Console.WriteLine("The first number is positive");
}
else if(firstNumber < 0)
{
    Console.WriteLine("The first number is negative");
}
else
{
    Console.WriteLine("The first number is zero");
}


//switch
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Sadly, it is Monday");
        break;
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("It's a working day, fortunately not Monday!");
        break;
    case 6:
    case 7:
        Console.WriteLine("It's weekend!");
        break;
    default:
        Console.WriteLine("Invalid value. The value must be between 1 and 7");
        break;
}


//IF-ELSE
int firstNumber = 5;
int secondNumber = 6;

if(firstNumber == secondNumber)
{
    Console.WriteLine("The numbers are equal");
}
else
{
    Console.WriteLine("The numbers are not equal");
}

if(firstNumber > secondNumber)
{
    Console.WriteLine("The first number is greater than the second");
}
else if(firstNumber < secondNumber)
{
    Console.WriteLine("The second number is greater than the first");
}
else
{
    Console.WriteLine("The numbers are equal");
}

//SWITCH
int day;
Console.WriteLine("Please enter a number between 1 and 7:");

bool success = int.TryParse(Console.ReadLine(), out day);
if (success)
{
    //this is the case when the parsing was successful
    switch (day)
    {
        case 1:
            Console.WriteLine("Monday!");
            break;
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Working day, but it's not Monday");
            break;
        case 6:
        case 7:
            Console.WriteLine("Weekend");
            break;
        default: Console.WriteLine("Invalid value! It is a number, but it is not between 1 and 7");
            break;
    }

}
else
{
    Console.WriteLine("Invalid input!");
}
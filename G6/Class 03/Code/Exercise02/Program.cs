//Get an input number from the console
//Print all even numbers starting from 2
//Get another input number from the console
//Print all odd numbers starting from that number to 1

Console.WriteLine("=====Even numbers====");
Console.WriteLine("Enter a number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

if (firstSuccess)
{
    for (int i = 2; i <= firstNumber; i++)
    {
        if(i%2 == 0)
        {
            Console.WriteLine("i: " + i);
        }
    }

    //second way
    //2,4,6,8.....firstNumber
    for (int i = 2; i<= firstNumber; i += 2) //i = i + 2
    {
        Console.WriteLine("i: " + i);
    }
}
else
{
    Console.WriteLine("Wrong input");
}

Console.WriteLine("=====Odd numbers====");
Console.WriteLine("Enter a number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);
if (secondSuccess)
{
    for(int i = secondNumber; i >= 1; i--)
    {
        if(i%2 != 0) //(i%2 == 1)
        {
            Console.WriteLine("i: " + i);
        }
    }
}
else
{
    Console.WriteLine("Wrong input");
}
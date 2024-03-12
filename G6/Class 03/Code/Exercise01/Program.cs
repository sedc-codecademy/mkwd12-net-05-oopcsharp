//Get an input number from the console
//Print all numbers from 1 to that number
//Get another input number from the console
//Print all numbers from that number to 1


Console.WriteLine("Enter a number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber); //we can declare firstNumber in tryParse

if (firstSuccess)
{
    for(int i = 1; i <= firstNumber; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Wrong input");
}

Console.WriteLine("Enter another number:");
bool secondSuccess = int.TryParse(Console.ReadLine(),out int secondNumber);

if (secondSuccess)
{
    for(int i = secondNumber; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Wrong input");
}
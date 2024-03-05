//Get an input from the console
//Print all numbers from 1 to that number
//Don’t print numbers that can be divided by 3 or 7
//If the number gets to 100 print a message: The limit is reached and stop counting


Console.WriteLine("Enter a number:");
bool success = int.TryParse(Console.ReadLine(), out int number);

if (success)
{
    for(int i =1; i <= number; i++)
    {
        if(i%3 == 0 || i%7 == 0)
        {
            continue;
        }

        Console.WriteLine(i);

        if (i == 100)
        {
            Console.WriteLine("The limit is reached");
            break;

        }

      
    }
}
else
{
    Console.WriteLine("Wrong input!");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a number");

string input = Console.ReadLine();

int number;
bool parsingResult = int.TryParse(input, out number);

if (parsingResult)
{
    for(int i = 1; i <= number; i++)
    {
        if(i % 3 == 0 || i % 7 == 0)
        {
            continue;
        }

        if(i == 100)
        {
            Console.WriteLine("The limit was reached.");
            break;
        }

        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Invalid input");
}

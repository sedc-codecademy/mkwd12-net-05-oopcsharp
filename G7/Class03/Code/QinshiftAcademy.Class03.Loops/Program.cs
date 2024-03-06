// See https://aka.ms/new-console-template for more information
Console.WriteLine("Loops");

Console.WriteLine("====For loop=====");

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("i: " + i);
}

Console.WriteLine("Second for loop:");
//count from 1 to 10, don't print number 5, stop the loop if you encounter number 7
for(int i = 1; i <= 10; i++)
{
    if(i == 5)
    {
        //this will skip the rest of the code for the current iteration and will jump to increment/decrement part
        continue;
    }

    if(i == 7)
    {
        //this will stop the for loop
        break;
    }

    Console.WriteLine("i: " + i);
}


Console.WriteLine("===While loop===");

int counter = 1;
while (counter <= 10)
{
    Console.WriteLine("counter: " + counter);
    counter++;
}


while (true)
{
    Console.WriteLine("The loop will go on unless you enter X or x");
    string input = Console.ReadLine();

    if(input == "x" || input == "X")
    {
        break;
    }
    Console.WriteLine("Your input: " + input);
}

//count from 1 to 20 using while, skip the even numbers
Console.WriteLine("Counting 1 - 20...");

int numCounter = 1;
while(numCounter <= 20)
{
   
    if (numCounter % 2 == 0)
    {
        numCounter++;
        continue;
    }

    Console.WriteLine("NumberCounter: " + numCounter);
    numCounter++;
}

Console.WriteLine("===Do while===");

do
{
    Console.WriteLine("This message will be shown at least once");
}
while (false);

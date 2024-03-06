//==========FOR===================
for(int i = 0; i < 10; i++) //we must declare i with a data type
{
    Console.WriteLine("i: " + i);
}

//loops indefinetly unless there is a condition in the block
//infinite loop
for(; ; )
{
    Console.WriteLine("Enter x to exit the loop");
    string input = Console.ReadLine(); //input is block scoped, it exists only in the for loop

    if (input == "x" || input == "X")
    {
        break; //this will break the inifite for loop
    }
    else
    {
        Console.WriteLine($"input was {input}");
    }
}

//input = "G6"; //input does not exist here

//print all except 5 and exit after it gets to 7 => (0,1,2,3,4,6,7)

for(int i=0; i <= 10; i++)
{
    if (i == 5)
        continue; //it stops the current iteration (it goes next to i++)

    Console.WriteLine("i: " + i);

    if (i == 7)
        break; //it breaks the for loop (it exits the loop)
}

//=============WHILE===============

int counter = 1;

while(counter <= 5)
{
    Console.WriteLine("counter "+ counter);
    counter++;
}

while (true)//infinite loop 
{
    Console.WriteLine("We will loop until you enter x");
    string input = Console.ReadLine(); //input is block scoped, it exists only in the while loop
    if (input == "x" || input == "X")
    {
        break; //this will break the inifite for loop
    }
    else
    {
        Console.WriteLine($"input was {input}");
    }
}
//input = "G6"; //input does not exist here


//use while, count 1-10, skip 3 and 5
int number = 1;
while(number <= 10)
{
    if(number == 3 || number == 5)
    {
        //careful, put the code for incrementing (moving forward) before continue so we don't get an infinite loop
        number++;
        continue; //everthing after continue is not executed in the current iteration
    }

    Console.WriteLine("number: " + number);
    number++;

}

//============DO WHILE==============

do
{
    Console.WriteLine("This will be executed at least once");
} while (false);
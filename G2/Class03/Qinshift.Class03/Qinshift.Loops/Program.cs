// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region For Loop
Console.WriteLine("===== For loop =======!");

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.ReadLine();

//Infinity for loop

//for(; ;)
//{
//    Console.WriteLine("Infinity for loop");
//}

for(int i = 0; i <= 10; i++)
{
    Console.WriteLine("Army: " + i);
    if(i == 5)
    {
        // Continue stops the current loop and continues with the others
        Console.WriteLine("Problem with army: " + i);
        continue;
    }
    if(i == 7)
    {
        // Break stops the whole for and continues forward with the code
        Console.WriteLine("Army is broke down!");
        break;
    }
    Console.WriteLine("Army army test");
}
Console.ReadLine();

#endregion

#region While loop
Console.WriteLine(" ====== While loop =====");
int counter = 0;
while (counter <= 10)
{
    Console.WriteLine(counter);
    counter++;
}

// Infinite while loop
//while(true)
//{
//	Console.WriteLine("This will go on forever!");
//}
//Console.ReadLine();

while (true)
{
    Console.WriteLine("Infinity while loop");
    string input = Console.ReadLine();
    if (input == "list") continue;
    Console.WriteLine("win win win");
    if (input == "X" || input == "x") break;
}


Console.WriteLine("Creating a Clone army:");
int whileDroids = 1;
while (whileDroids <= 10)
{
    Console.WriteLine("Cloning Clone Batalion " + whileDroids);
    if (whileDroids == 5)
    {
        Console.WriteLine("Problem in cloning Clone batalion " + whileDroids);
        whileDroids++;
        continue;
    }
    if (whileDroids == 7)
    {
        Console.WriteLine("Cloning machine broke down!");
        whileDroids++;
        break;
    }
    Console.WriteLine("Clone Batalion " + whileDroids + " is operational.");
    whileDroids++;
}
Console.ReadLine();
#endregion

#region Do While loop
int doWhileCounter = 11;
do
{
    Console.WriteLine(doWhileCounter);
    doWhileCounter++;
}
while(doWhileCounter <= 10);
#endregion

#region Exercise 1 - 3
// Exercise 1
Console.WriteLine("Enter a number:");
int ex1input1 = int.Parse(Console.ReadLine());
for (int i = 1; i <= ex1input1; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Enter another number:");
int ex1input2 = int.Parse(Console.ReadLine());
for (int i = ex1input2; i != 0; i--)
{
    Console.WriteLine(i);
}
Console.ReadLine();

// Exercise 2
Console.WriteLine("Enter a number:");
int ex2input1 = int.Parse(Console.ReadLine());
for (int i = 2; i <= ex2input1; i++)
{
    if (i % 2 == 0) Console.WriteLine(i);
}
Console.WriteLine("Enter another number:");
int ex2input2 = int.Parse(Console.ReadLine());
for (int i = 1; i <= ex2input2; i++)
{
    if (i % 2 != 0) Console.WriteLine(i);
}
Console.ReadLine();

// Exercise 3
Console.WriteLine("Enter a number:");
int ex3input = int.Parse(Console.ReadLine());
for (int i = 1; i <= ex3input; i++)
{
    if (i % 3 == 0 || i % 7 == 0) continue;
    if (i == 100)
    {
        Console.WriteLine("The limit is reached!");
        break;
    }
    Console.WriteLine(i);
}
Console.ReadLine();
#endregion
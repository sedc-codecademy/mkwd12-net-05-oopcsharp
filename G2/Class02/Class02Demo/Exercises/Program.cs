Console.WriteLine("============== EXERCISES ==============");

#region Exercises 1 - 4
// Exercise 1
double numOne = 2;
double numTwo = 4;
double doubleResult = numOne / numTwo;
Console.WriteLine(doubleResult); // 0.5

int numberOne = 2;
int numberTwo = 4;
int intResult = numberOne / numberTwo;
Console.WriteLine(intResult); // 0

// Exercise 2
string a3 = "FirstName";
string b3 = "LastName";
string result3 = a3 + " " + b3; // Adding empty space to divide the strings
Console.WriteLine("Exercise 2 strings Result:" + result3);

string a4 = "5";
string b4 = "7";
string result4 = a4 + b4;
Console.WriteLine("Exercise 2 numbers Result:" + result4);
Console.ReadLine();

// Exercise 3
int a5 = 9;
string b5 = "Code";
string result5 = a5 + b5;
Console.WriteLine("Exercise 3 Result:" + result5);
Console.ReadLine();

// Exercise 4
int credit = 102;
int messageCost = 5;
int messagesSent = credit / messageCost;
Console.WriteLine("You can send: " + messagesSent + " messages!");
Console.ReadLine();

#endregion

// *NOTE* when variable is declared as int it always round the result of a mathematical operation to a whole number (it ignores the decimal fraction)

#region Exercises 5 - 7

// Exercise 5
Console.Write("Enter number of trees: ");
string numberOfTreesInput = Console.ReadLine();
int numberOfApples = 8;
int numberOfBranches = 12;
int applesPerBasket = 5;

bool isValidNumber = int.TryParse(numberOfTreesInput, out int numberOfTrees);

if (!isValidNumber)
{
    Console.WriteLine("You've entere an invalid number!");
}
else
{
    int applesPerTree = numberOfApples * numberOfBranches;
    int sumOfApples = applesPerTree * numberOfTrees;
    int numberOfBaskets = sumOfApples / applesPerBasket;
    Console.WriteLine("For " + numberOfTrees + " apple trees we need " + numberOfBaskets + " baskets.");
}

// Exercise 6
Console.Write("Enter a number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter another number: ");
int num2 = int.Parse(Console.ReadLine());
int larger;
if (num1 > num2)
{
    larger = num1;
    Console.WriteLine("First is larger!");
}
else if (num2 > num1)
{
    larger = num2;
    Console.WriteLine("Second is larger!");
}
else
{
    larger = num1;
    Console.WriteLine("The numbers are equal!");
}

if (larger != 0)
{
    if (larger % 2 == 0)
    {
        Console.WriteLine("Number is Even!");
    }
    else if (larger % 2 != 0)
    {
        Console.WriteLine("Number is Odd!");
    }
}
else
{
    Console.WriteLine("You entered Zero. That is not even nore odd!");
}

// Exercise 7
Console.WriteLine("Whats behind door 1,2,3");
int door;
bool isNumber = int.TryParse(Console.ReadLine(), out door);
if (isNumber)
{
    switch (door)
    {
        case 1:
            Console.WriteLine("You got a new car");
            break;
        case 2:
            Console.WriteLine("You got a new plane");
            break;
        case 3:
            Console.WriteLine("You got a new house");
            break;
        default:
            Console.WriteLine("That was not 1 2 or 3! Sorry!");
            break;
    }
}
else
{
    Console.WriteLine("That was not a number! Sorry!");
}

#endregion

Console.ReadLine();
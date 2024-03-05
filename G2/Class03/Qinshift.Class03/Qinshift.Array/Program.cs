// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Array
Console.WriteLine("=== Array ===");
// An empty array with 3 elements
int[] intArray = new int[3];
// Adding items in the array
intArray[0] = 24;
intArray[1] = 25;
intArray[2] = 100;

Console.WriteLine(intArray);
Console.WriteLine(intArray[0]);

// Creating and initialization of an array
Console.WriteLine("=== Array of string ===");
string[] stringArray = new string[] { "Bob", "Ilija", "Murat", "Sara", "Anamarija" };

Console.WriteLine(stringArray[1]);

Console.WriteLine("=== Array of boolean ===");
bool[] boolArray = new bool[] { true, false, false, true };
Console.WriteLine(boolArray[1]);

Console.WriteLine("=== Array of char ===");
char[] charArray = new char[] { 'A', 'B', 'C', '4' };
Console.WriteLine(charArray[3]);

Console.WriteLine("=== Array ===");
// A shorter way of initializing an array
int[] shortArray = { 4, 124, -12, 90 };
Console.WriteLine(shortArray[2]);

Console.ReadLine();

#endregion

#region Array Methods
// Getting the number of elements from an array
double[] doubleArray = { 2.4, 5, 2.2, 55.90, 123 };

Console.WriteLine("Length of dobulearray is:" + doubleArray.Length); //5
Console.WriteLine(doubleArray[0]); // 2.4

// Reversing an array
Array.Reverse(doubleArray); // {123, 55.90, 2.2, 5, 2.4}
Console.WriteLine(doubleArray[0]); //after reverse 123

// Finding something in an array
Console.WriteLine(" ==== indexOf ===== ");
int indexOf = Array.IndexOf(doubleArray, 55.90);
Console.WriteLine("indexOf: " + indexOf);

//double[] test = Array.Reverse(doubleArray); VOID

int indexOf2 = Array.IndexOf(doubleArray, 600);
Console.WriteLine("indexOf: " + indexOf2);

Console.WriteLine("==== Resize ==== ");
// Change an array number of items
Array.Resize(ref doubleArray, 6);

doubleArray[5] = 44.2;
Console.WriteLine("Length of dobulearray is:" + doubleArray.Length); //6

Array.Resize(ref doubleArray, 1);
Console.WriteLine("Length of dobulearray is:" + doubleArray.Length); //1

Console.ReadLine();
#endregion

#region ForEach
string[] names = { "Bob", "John", "Ronaldo", "Messi" };

foreach(string name in names)
{
    Console.WriteLine(name);
    if (name == "John")
    {
        Console.WriteLine("Is John....");
        continue;
    }
    if(name == "Ronaldo")
    {
        Console.WriteLine("Error");
        break;
    }
}

Console.ReadLine();
#endregion

#region Array
int[][] integerArray = new int[][]
{
    new int[]{1, 4, 10},
    new int[]{22, 33, 66, 124},
    new int[]{22222, 22, 1}
};

Console.WriteLine(integerArray[1][1]);

Console.ReadLine();
#endregion

#region Exercise 4
// Exercise 4
string[] words = new string[] { "Hello", "Hi", "Wow", "Words", "Dinosaur" };
double[] decimals = new double[] { 2.4, 5.4444, 0.00009, 18.9, 999.0002 };
char[] characters = new char[] { 'b', 'c', '0', '#', ']' };
bool[] booleans = new bool[] { true, false, false, true, false };
int[][] arraysOfInts = new int[][] {
                new int[] {2, 4},
                new int[] {-6, 12},
                new int[] {0, 99},
                new int[] {32, 27},
                new int[] {9999, 50}
            };

Console.WriteLine(arraysOfInts[0][0]);

#endregion
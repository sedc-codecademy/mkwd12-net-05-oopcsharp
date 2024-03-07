//array of whole numbers, containing 3 elements
using System.Transactions;

int[] arrayOfInts = new int[3]; //here 3 is not an index, it represents the number of elements (members)

arrayOfInts[0] = 4; //initialize the first element
arrayOfInts[1] = 7;//initialize the second element
arrayOfInts[2] = 3;//initialize the third element

Console.WriteLine("First member: " + arrayOfInts[0]);

//declare and initialize string array
//C# from the given values will see how many elements we will have in the array
string[] arrayOfStrings = new string[] { "Hello", "G6", "C#", "Goodbye" };

Console.WriteLine("Third element: " + arrayOfStrings[2]);

short[] arrayOfShorts = new short[] { 1, 2, 1 };
int[] anotherIntArray = new int[] { 3, 56, 67, 105 };
bool[] arrayOfBools = new bool[] { false, false, true, false };

bool[] anotherBoolArray = new bool[2];
anotherBoolArray[0] = true;
anotherBoolArray[1] = false;

Console.WriteLine("Number of elements in arrayOfBools: " + arrayOfBools.Length);

int indexOf56 = Array.IndexOf(anotherIntArray, 56);
Console.WriteLine("Index of 56: " + indexOf56);

int indexOf200 = Array.IndexOf(anotherIntArray, 200);
Console.WriteLine("Index of 56: " + indexOf200); //it returns -1 if the element is not in the array

double[] doubleArray = new double[] { 3.4, 6.7, 8, 9.1, 100.5 }; //array of 5 doubles

Console.WriteLine("Num of elements in doubleArray: " + doubleArray.Length);

Array.Resize(ref doubleArray, 7);

Console.WriteLine("Num of elements in doubleArray: " + doubleArray.Length);

Console.WriteLine(doubleArray[5]);

doubleArray[5] = 2.3;
doubleArray[6] = 3.5;

Array.Resize(ref doubleArray, 3);
Console.WriteLine("Num of elements in doubleArray: " + doubleArray.Length);

for(int i = 0; i < doubleArray.Length; i++)
{
    Console.WriteLine(doubleArray[i]); //doubleArray[0] => 3.4
}


//FOREACH
foreach(double doubleElement in doubleArray)
{
    Console.WriteLine(doubleElement);
}

string[] names = new string[] { "Vladimir", "Jana", "Matej", "Berat", "Marija" };

foreach(string name in names)
{
    Console.WriteLine(name);
}

Array.Reverse(names);
Console.WriteLine("=====Reveresed=====");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Array of arrays

int[][] matrix = new int[][]
{    
    new int[] { 1, 2,},
    new int[] { 3, 4,},
    new int[] { 5, 6,},
};

                    //[row] [column]
Console.WriteLine(matrix[0][1]); //2
Console.WriteLine(matrix[1][1]); //4
Console.WriteLine(matrix[1][0]); //3
Console.WriteLine(matrix[2][0]); //5

foreach (int[] row in matrix)  //row = int[] {1,2}
{
    Console.WriteLine(row);// we have three arrays - Int32[], Int32[], Int32[]
   
    //we can iterate through the array elements with another foreach ({1,2} in first iteration, {3,4} in second...)
    foreach (int num in row) 
    {
        Console.WriteLine(num);
    }

}

int[] array1 = new int[] { 1, 2 };
int[] array2 = new int[] { 3, 4 };
int[] array3 = new int[] { 5, 6 };

int[][] arrays = new int[][] { array1, array2, array3 };

foreach (int[] array in arrays)
{
    Console.WriteLine(array); //array1
    //Console.WriteLine(array[0]); //array1[0]
   // Console.WriteLine(array[1]); //array1[1]

    foreach(int element in array)
    {
        Console.WriteLine(element);
    }
}


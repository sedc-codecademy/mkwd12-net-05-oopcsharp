// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arrays");

//An array of three integers, we tell C# to allocate memory for three integers
int[] ourIntArray = new int[3];
ourIntArray[0] = 4;
ourIntArray[1] = 7;
ourIntArray[2] = 10;

//declare and initialize an array of three strings
string[] ourStringArray = new string[] { "JavaScript", "C#", "Java" };

bool[] boolArray = new bool[] { true, false, true, false };

Console.WriteLine("The number of members in ourIntArray: " + ourIntArray.Length);

//search for a member
int indexOfMember = Array.IndexOf(ourIntArray, 12);
if (indexOfMember == -1)
{
    Console.WriteLine("We didn't find the member we were searching for");
}
else
{
    Console.WriteLine("The member was found on index " + indexOfMember);
}

//foreach loop
foreach (string language in ourStringArray)
{
    Console.WriteLine("language: " + language);
}


//Resize, change the size of an array
Array.Resize(ref ourIntArray, 5);
Console.WriteLine("OurIntArray's length: " + ourIntArray.Length);

ourIntArray[4] = 7;

foreach (int item in ourIntArray)
{
    Console.WriteLine(item);
}

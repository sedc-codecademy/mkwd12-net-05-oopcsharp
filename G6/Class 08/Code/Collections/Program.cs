using System.Collections;


//Arrays
Console.WriteLine("=========ARRAYS======");
int[] intArray = new int[3]; //allocate memory for 3 ints
string[] stringArray = new string[] {"Hello", "Bye"};

foreach (string str in stringArray)
{
    Console.WriteLine(str);
}

//ArrayList - accepts all types, can have mixed array lists, does not have a constraint on the number of elements
Console.WriteLine("=========ARRAY LIST======");
ArrayList arrayList = new ArrayList(); //empty array list
ArrayList secondArrayList = new ArrayList { "Hello", 5, true };
secondArrayList.Add("Bye");
secondArrayList.Remove(5);//we send the value that we want to remove
secondArrayList.RemoveAt(0); //we send the index of the position that we want to remove
//in each iteration item will have the appropriate data type => var takes the data type based on the value of the variable
//(ex: "Hello" will be string, 5 will be int, true will be bool
foreach (var item in secondArrayList) //var has totally different meaning here than it had in JS
{
    Console.WriteLine(item);
}

for(int i = 0; i < secondArrayList.Count; i++) //Count => number of elements
{
    Console.WriteLine(i.ToString() + secondArrayList[i]);
}

//List - all members must be of the same type, does not have constraints about the number of elements
Console.WriteLine("=========LIST======");
List<int> emptyListOfInts = new List<int>();
List<string> emptyListOfStrings = new List<string>();
List<int> listOfInts = new List<int> { 2, 88, 9 };
listOfInts.Add(5);
listOfInts.Add(-10);
listOfInts.Remove(88);//remove the element with value 88
listOfInts.RemoveAt(0); //remove the element with index 0 (the value 2)
Console.WriteLine(listOfInts[0]);
Console.WriteLine($"Number of elements in list of ints: {listOfInts.Count}");
foreach(int number in listOfInts)
{
    Console.WriteLine(number);
}

//Dictionary - works with key value pairs
Console.WriteLine("=========DICTIONARY======");
//we are telling the dictionary that its keys will be of data type int and its values will be of data type string
Dictionary<int, string> products = new Dictionary<int, string>() //in Dictionary we don't have indexes
{
    {111, "potato" },
    {222, "milk" },
    {333, "bread" }
};

Console.WriteLine(products[222]); //we use the key like we used the index - to access the value for that key

products.Add(444, "tea");
products[111] = "coffee";
Console.WriteLine(products[111]);
bool keyExists = products.ContainsKey(222);
Console.WriteLine(keyExists);
products.Remove(333);
foreach(var item in products)
{
    Console.WriteLine($"{item.Key} - {item.Value}");    
}
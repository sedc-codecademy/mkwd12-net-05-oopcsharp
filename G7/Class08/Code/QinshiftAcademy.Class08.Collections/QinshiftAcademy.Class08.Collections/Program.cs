//Arrays
int[] intArray = new int[3]; //allocate memory for 3 ints

int[] secondIntArray = new int[] { 4, 6, 8 };

Array.Resize(ref intArray, 5);

//List (all members have to be of same type, they are ordered, there is no constraint for number of members)
Console.WriteLine("===List===");

List<int> integerList = new List<int>(); //an empty list, no members still
Console.WriteLine($"integerList's count: {integerList.Count}");
integerList.Add(5); //added member 5 to the list, it resizes automatically
integerList.Add(66);
integerList.Add(-700);
Console.WriteLine($"integerList's count: {integerList.Count}");

integerList.Remove(66); //remove the member 66
Console.WriteLine($"integerList's count: {integerList.Count}");

foreach(int integer in integerList)
{
    Console.WriteLine(integer); 
}

integerList.RemoveAt(0); // remove the member on index 0, all the other members will be relocated
Console.WriteLine("After removeat");
foreach (int integer in integerList)
{
    Console.WriteLine(integer);
}

List<string> secondList = new List<string> { "C#", "Java", "JS", "Python", "VisualBasic" };
secondList.RemoveAt(2);// removing member from index 2

Console.WriteLine("secondList");
foreach (string language in secondList)
{
    Console.WriteLine(language);
}

Console.WriteLine(secondList[2]); //get the member on index 2


//DICTIONARY
Console.WriteLine("===Dictionary===");
//the first data type between the angle brackets is for the keys, the second data type is for the values
Dictionary<int, string> productsInMarket = new Dictionary<int, string>();

productsInMarket.Add(111, "Milk");
productsInMarket.Add(222, "Bread");
productsInMarket.Add(333, "Chocolate");

foreach(KeyValuePair<int, string> item in productsInMarket)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

bool product222Exists = productsInMarket.ContainsKey(222);
if (product222Exists)
{
    //in order to get a value from a dictionary, we can use square brackets and pass the key between the brackets
    Console.WriteLine($"Product with code 222: {productsInMarket[222]}");
}

//foreach(var item in productsInMarket)
//{

//}

//QUEUE (First in First out)
Console.WriteLine("===Queue===");
Queue<int> integerQueue = new Queue<int>(); //empty queue

integerQueue.Enqueue(200); //add 200 to the end of the queue
integerQueue.Enqueue(3); //add 3 to the end of the queue
integerQueue.Enqueue(-5); //add -5 to the end of the queue
integerQueue.Enqueue(44); //add -5 to the end of the queue
integerQueue.Enqueue(770); //add -5 to the end of the queue

foreach(int integer in integerQueue)
{
    Console.WriteLine(integer);
}

//access (get) a member of a queue
int firstMember = integerQueue.Dequeue(); //returns the value of the first member but also takes the first member out
Console.WriteLine($"Num of members in the queue: {integerQueue.Count}");
Console.WriteLine($"firstMember: {firstMember}");
foreach (int integer in integerQueue)
{
    Console.WriteLine(integer);
}

int valueOfFirstMember = integerQueue.Peek(); //just take the value of the first member, but leave the first member in the queue
Console.WriteLine($"Num of members in the queue: {integerQueue.Count}");
Console.WriteLine($"valueOfFirstMember: {valueOfFirstMember}");
foreach (int integer in integerQueue)
{
    Console.WriteLine(integer);
}

//STACK (Last in First Out)
Console.WriteLine("===Stack===");
Stack<string> stringStack = new Stack<string>();

stringStack.Push("C#"); //add member at the end of the stack
stringStack.Push("JS");
stringStack.Push("Java");
stringStack.Push("Python");

foreach(string language in stringStack)
{
    Console.WriteLine(language);
}

string lastMember = stringStack.Pop(); //take the last member out of the stack
Console.WriteLine($"lastMember: {lastMember}");
foreach (string language in stringStack)
{
    Console.WriteLine(language);
}

string valueOfLastMember = stringStack.Peek(); //just take the value of the last member, but keep it in the stack
Console.WriteLine($"valueOfLastMember: {valueOfLastMember}");
foreach (string language in stringStack)
{
    Console.WriteLine(language);
}

using System.Collections;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n===================== COLLECTIONS =====================\n\n");
Console.ResetColor();


// IEnumerable: An Interface which represents a collection that can be enumerated and iterated over. 
// Interfaces will be a topic covered in the Advanced C# subject. 
// Helper method for print
static void PrintCollectionItems(IEnumerable collection)
{
    Console.WriteLine($"\nPrinting collection of type: {collection.GetType().Name}");
    foreach (var item in collection)
	{
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}


#region Array & ArrayList
Console.WriteLine("\n===================== Array & ArrayList =====================\n\n");
// Arrays => collection type with pre-defined length and items of same data type
// Usecase: used when a fixed-size collection is needed (typically some 'constant' arrays, e.g. application colors)
// NOTE: Not suitable for data manipulation !!!

int[] integers = new int[] { 1, 2, 3, 4, 5 };
Array.Resize(ref integers, integers.Length + 1);
integers[integers.Length - 1] = 6;
//integers[^1] = 6;
PrintCollectionItems(integers);


// ArrayList => collection of objects (items of any kind), without fixed size
// NOTE: Avoid using them, since they are not type-safe and can lead to many potential issues.
ArrayList arrayList = new ArrayList() { 123, "text", true };
arrayList.Add(1342.4343);
PrintCollectionItems(arrayList);
#endregion


#region List
Console.WriteLine("\n===================== List<T> =====================\n\n");
// Most used collection type !!!
// List<T> => generic collection that stores items of the same type T
// T => the type of elements in the list (placeholder for any datatype)
// NOTE: List<T> provides methods for manipulating elements and it is more flexible than arrays because it can resize dynamically

List<string> strings = new List<string>() { "text 1", "text 2" };
strings.Add("text 3");

List<int> integerList = new List<int>() { 1, 2, 3 };
//integerList.Add("test"); // compile-time error
integerList.Remove(2);
PrintCollectionItems(integerList);
Console.WriteLine("The length of the integer list is " + integerList.Count);
#endregion


#region HashSet

Console.WriteLine("\n===================== HashSet<T> =====================\n\n");
// HashSet => generic collection that stores unique elements. It does not allow duplicate elements.
// Usecase: for collection of unique elements without duplicates.

HashSet<int> intHashSet = new HashSet<int>() { 1, 2, 3, 3, 3, 4, 5 };
intHashSet.Add(2);
Console.WriteLine("The length of the HashSet collection is " + intHashSet.Count);
#endregion


#region Dictionary

Console.WriteLine("\n\n================== Dictionary<TKey, TValue> ==================\n");
// Dictionary => generic collection of key-value pairs.
// TKey => placeholder for data type of the keys
// TValue => placeholder for data type of the values
// Usecase: Dictionaries are used when you need to store key-value pairs for quick lookup and retrieval.
// NOTE: Dictionaries do not allow duplicate keys, and each key must be unique within the collection.

// Syntax: Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
Dictionary<string, int> dictionary = new Dictionary<string, int>()
{
    { "One", 1 },
    { "Two", 2 },
    { "Three", 3 }
};
dictionary.Add("Four", 4);

// ===> Accessing values in a dictionary
// 1) using dictionary[key] syntax
Console.WriteLine(dictionary["Three"]); // 3
// Console.WriteLine(dictionary["blabla"]); // KeyNotFoundException

// 2) using TryGetValue method
bool keyExists = dictionary.TryGetValue("One", out int value);
Console.WriteLine(value); // 1
bool keyExists2 = dictionary.TryGetValue("blabla", out int value2);

// ===> Creating an empty dictionary
Dictionary<string, string> lastNames = new Dictionary<string, string>();
// Adding elements to an empty dictionary
// 1) with Add(key, value) => better way
lastNames.Add("Bob", "Bobsky");
Console.WriteLine(lastNames["Bob"]);
// 2) with dictionary[key] = value
lastNames["John"] = "Doe";
Console.WriteLine(lastNames["John"]);

//PrintCollectionItems(lastNames);

foreach (var item in lastNames)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

#endregion


#region Stack & Queue

Console.WriteLine("\n\n================== Stack<T> & Queue<T> ==================\n");
// => don't have indexing of elements

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
//Console.WriteLine(stack[0]); // error => no indexing
PrintCollectionItems(stack); // 3 2 1

// Pop() => *removes and returns* the last added item in the stack
int lastAddedItem = stack.Pop();
Console.WriteLine("The last added item has been removed. Item: " + lastAddedItem);
Console.WriteLine(stack.Count);

stack.Push(15);

// Peek() => *returns* the last added item in the stack (does not remove it from the collection)
int lastAddedItemValue = stack.Peek();
Console.WriteLine("The value of the LAST item is: " + lastAddedItemValue);
Console.WriteLine(stack.Count); // 3


// Queue
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
PrintCollectionItems(queue); // 1 2 3


// Dequeue() => *removes and returns* the first added item in the queue
int firstItemAdded = queue.Dequeue(); // 1
Console.WriteLine("The first added item has been removed. Item: " + firstItemAdded); // 1
Console.WriteLine(queue.Count); // 2

queue.Enqueue(15);

// Peek() => *return* the first item in the queue (does not remove it)
int firstQueueItem = queue.Peek();
Console.WriteLine("The value of the FIRST item is " + firstQueueItem); // 2 
#endregion


Console.ReadLine();
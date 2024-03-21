using Domain.Model;
using System.Collections;

Console.WriteLine("\n================= Language Integrated Query (LINQ) =================\n\n");
// LINQ (Language Integrated Query) is a set of features in .NET that provides a unified way to query data from different data sources
// LINQ allows you to write queries directly in C# code, making it easier to work with data from in-memory collections, databases, XML, and other sources.
// LINQ query => expression that retrieves data from a data source

#region Helper Methods
static void PrintCollectionItems(IEnumerable collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

static void PrintDogs(List<Dog> dogs)
{
    foreach (Dog dog in dogs)
    {
        Console.Write($"{dog.Name} {dog.Age}. ");
    }
    Console.WriteLine();
} 
#endregion


#region Data Samples
List<int> integersSample = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

List<Dog> dogsSample = new List<Dog>
{
    new Dog("Aks", 7),
    new Dog("Lav", 5),
    new Dog("Sparky", 2),
    new Dog("Butch", 1),
    new Dog("Zoe", 3),
    new Dog("Chapo", 1),
    new Dog("William", 4),
    new Dog("Billy", 1),
    new Dog("Buck", 2),
};
#endregion


#region Where

Console.WriteLine("\n============= Where =============\n\n");
// Where => filters a collection of values based on a condition (written as lambda expression/arrow function)
// Returns a new collection containing only the elements that satisfy the condition

// Example: Get only the even numbers
//List<int> evenNumbers = integersSample.Where(n => n % 2 == 0); // ERROR!
// => returns IEnumerable by default
// => Using ToList to convert the result from IEnumerable to List type
List<int> evenNumbers = integersSample.Where(n => n % 2 == 0).ToList();
PrintCollectionItems(evenNumbers);

// Example: Get dogs older than 3 years
List<Dog> dogsOlderThan3 = dogsSample.Where(dog => dog.Age > 3).ToList();
//PrintCollectionItems(dogsOlderThan3); // will print the object path
PrintDogs(dogsOlderThan3);


// Example: Get only dogs older than 4 years, with Name starting on letter 'A'
//List<Dog> dogsStartingWithA = dogsSample.Where(dog => dog.Age > 4).Where(dog => dog.Name.StartsWith('A')).ToList(); // BAD WAY !!!
List<Dog> dogsStartingWithAOlderThan4 = dogsSample.Where(dog => dog.Age > 4 && dog.Name.StartsWith('A')).ToList();
PrintDogs(dogsStartingWithAOlderThan4);

// *NOTE* If you have multiple conditions don't chain multiple Where methods, simply write the conditions with logical operator (&&, ||)

#endregion


#region Select

Console.WriteLine("\n============= Select =============\n\n");
// Select => projects each element of a collection into a new form
// Select is used to transform elements of a collection, such as extracting specific properties from objects or performing calculations on values.

// Example: Square numbers in array
List<int> squaredNumbers = integersSample.Select(num => num * num).ToList();
PrintCollectionItems(squaredNumbers);

// Example: Select dogs names
List<string> dogsNames = dogsSample.Select(dog => dog.Name).ToList();
PrintCollectionItems(dogsNames);

// Step by step...
// List<string> dogsNamesResult = new List<string>();
// foreach (Dog dog in dogsSample)
// {
//     dogsNamesResult.Add(dog.Name);
// }

// Combining Where & Select
// Example: Get dogs names of dogs with 1 year
List<string> dogsOneYearNames = dogsSample.Where(dog => dog.Age == 1).Select(dog => dog.Name).ToList();
PrintCollectionItems(dogsOneYearNames);

#endregion


#region First, FirstOrDefault

Console.WriteLine("\n============= First, FirstOrDefault =============\n\n");
// First => returns the first element of a collection
// FirstOrDefault => returns the first element of a collection, or a default value if the collection contains no elements

// Example: Get first dog with age higher than 10
//Dog olderThan10Dog = dogsSample.First(dog => dog.Age > 10); // will throw Exception if no item was found
Dog olderThan10Dog = dogsSample.FirstOrDefault(dog => dog.Age > 10); // null
Console.WriteLine(olderThan10Dog == null); // True

Dog firstWithAge2 = dogsSample.FirstOrDefault(dog => dog.Age == 2);
Console.WriteLine(firstWithAge2.Name);

// Example get first number
int firstInt = integersSample.First();
Console.WriteLine(firstInt); // 1

#endregion


#region Last, LastOrDefault

Console.WriteLine("\n============= Last, LastOrDefault =============\n\n");
// Last => returns the last element of a collection
// LastOrDefault => returns the last element of a collection, or a default value if the collection contains no elements

Dog lastDog = dogsSample.Last();
Console.WriteLine(lastDog.Name);

int lastIntLargerThan50 = integersSample.LastOrDefault(n => n > 50);
Console.WriteLine(lastIntLargerThan50);
#endregion


#region LINQ Syntax
Console.WriteLine("\n============= LINQ Syntax =============\n\n");
// Example: Get numbers larger than 5

// 1) Method syntax
var numbersLargerThan5MethodSyntax = integersSample.Where(num => num > 5);

// 2) Query-like syntax
var numbersLargetThan5QuerySyntax = from num in integersSample
                                    where num > 5
                                    select num;

// Example: Get all 2 year old dogs names (query syntax)
List<string> dogsNamesQuerySyntax = (from dog in dogsSample
                                     where dog.Age == 2
                                     select dog.Name).ToList();

#endregion


Console.ReadLine();
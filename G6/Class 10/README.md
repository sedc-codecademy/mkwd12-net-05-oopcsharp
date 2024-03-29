# Class 09 - Error handling and Exceptions 😮

## LINQ

LINQ is a component of the .NET framework that helps in writing queries for certain data. These queries can be very complex and very specific. With LINQ this can be made simpler and quicker. These queries are done by chaining methods and working with some collections. The LINQ methods always work with IEnumerable collections, meaning that they always return a very generic collection and work with a very generic and basic collection. It is up to us to convert it to our preferred collection later.

```csharp
List<string> strings = new List<string>(){"bob","midge","Red","Kitty","Fez"};
// Where
List<strings> 3letterNames = strings.Where(x => x.Length == 3).ToList();
// Select
List<int> numberOfLetters = strings.Select(x => x.Length).ToList();
// First item
numberOfLetters.First();
numberOfLetters.FirstOrDefault();
// Last item
numberOfLetters.Last();
numberOfLetters.LastOrDefault();

## Error handling

There are two main types of errors when working with C# and those are:

* Build time errors - Errors that happen while the code is compiling and that are preventing the code from building and compiling ( Ex: Typo, Variable type mismatch, etc. )
* Run time errors - Errors that happen while the application is already built and running ( Ex. A variable exceeded its range, we called a method to a null variable, etc. )

The errors in C# can be handled by writing a try/catch/finally block. This block tracks errors that will happen in the try block, add them in the catch block if something happens, and then execute the final block by default.

```csharp
try
{
  int input = int.Parse(Console.ReadLine());
}
catch{Exception}
{
  Console.WriteLine("There was a problem!");
}
finally
{
  Console.WriteLine("Everything is done!");
}
```

## Exceptions

Exceptions are basically the embodiment of errors while working with C#. They are objects that hold errors neatly in one place. Every time an error happens, an exception is created and we can see this exception in detail while we are in Debug mode. Exceptions store a lot of data inside of them so the developer knows exactly what happened, where, and how it happened. There are also different types of exceptions that represent a common error that can happen. We can write multiple catch blocks to handle different types of exceptions. The exceptions are caught by order, first checks the first block, then second, and so on

### Catching an exception

```csharp
try
{
  int input = int.Parse(Console.ReadLine());
}
catch{Exception ex}
{
  Console.WriteLine($"ERROR: {ex.Message}");
}
finally
{
  Console.WriteLine("Everything is done!");
}
```

### Capture multiple exceptions

```csharp
try
{
  int input = int.Parse(Console.ReadLine());
}
catch{FormatException}
{
  Console.WriteLine("WRONG FORMAT! PLEASE ENTER THE RIGHT ONE!");
}
catch{Exception ex}
{
  Console.WriteLine($"ERROR: {ex.Message}");
}
finally
{
  Console.WriteLine("Everything is done!");
}
```

## Extra Materials 📘

* [Official Microsoft documentation for try/catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch)
* [Handling exceptions best practices](https://stackify.com/csharp-exception-handling-best-practices/)

# Class 07 - Constructors, Enums, Class Libraries, and Inheritance 😜

## Constructors

A huge role in C# classes plays the constructors. Constructor is a method that is executed when an object is created from a class. Constructors in C# classes are written as methods but they don't have any return value and their name is always the same as the class name. The only thing that we can manipulate in a constructor is the parameters. Constructors in C# classes can have multiple constructors, and depending on how we create a class, we get a different execution of a constructor. This always depends on the parameters

```csharp
public class Person
{
  public string Name {get;set;}
  public string Age {get;set;}
  private long AccountNumber {get;set;}
  // Parametarless constructor ( new Person() )
  public Person(){
    AccountNumber = 34235432452;
  }
  // Constructor with parameters ( new Person("Bob", 34) )
  public Person(string name, int age)
  {
    Name = name;
    Age = age;
    AccountNumber = 25325325221;
  }
  public void Talk(string text){
    Console.WriteLine($"Human {Name} is saying {text}");
  }
}
```

### Constructing object from the constructor with parameters

```csharp
// Using the first constructor
Person George = new Person();
// Using the second constructor
Person bill = new Person("Bill", 25);
bill.Talk();
```

## Enumerations

Enumerations are sort of like a collection of values that are fixed. When it is created it is done so with the idea in mind that the values will never change and while the application is running it is impossible to add or remove an enumeration value. That is why they are usually used for common things that don't change like, names of the days of the week, names of months, names of continents, statuses from servers, etc.

```csharp
public enum Days 
{
  Monday,
  Tuesday,
  Wednesday,
  Thursday,
  Friday,
  Saturday,
  Sunday
}
```

### Using enums

Enumeration values can be used with the same syntax as properties on a class. The main difference is that enumerations do not have an instantiation. We can use them right away.

```csharp
// "today" is some variable of type Days enum that we get from somewhere
if( today == Days.Friday )
{
  Console.WriteLine("PARTY");
} 
```

## Class Library

The class library project is a special project that is made for storing and using classes. This project can't be the main running project since it is not made for running but storing classes. When we want to use classes from class libraries in other projects we need to remember to:

* Add a reference to that class library project to the current project
  * You can't have two projects referencing each other
* Add a using statement above in the document where you are writing your code to access the class from the class library  

## Class-based Inheritance

Inheritance is one of the main concepts of object-oriented programming. It is used to connect and link entities that have some hierarchical relation to one another. It can be used to link business logic as well as reuse and organize code. Class-based inheritance means that the inheriting is abstract and that it is done on a class level. Classes inherit from other classes and when an object is created, it has the properties and methods of all the classes in the chain. C# Classes can inherit only from 1 class at a time.

### Overriding methods

C# classes that inherit from other classes have a pretty cool feature. They can override the methods that are on their parents. As long as their parent classes have a method that is open for overriding, they can override it and change the implementation.

```csharp
public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and it's of the age of {Age}.");
    }
}
```

We override the method PrintInfo() from Human to do something else

```csharp
public class Programmer : Human
{
    public string[] ProgrammingLanugages { get; set; }
    public void DevelopApp()
    {
        Console.WriteLine($"The programmer {Name} is developing an app...");
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and these are the programming lanugages they know:");
        foreach (string language in ProgrammingLanugages)
        {
            Console.WriteLine(language);
        }
    }
}
```

## Extra Materials 📘

* [Official Microsoft documentation for Constructors](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
* [.net pearls on Enums](https://www.dotnetperls.com/enum)
* [Official Microsoft documentation for inheritance](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance)
* [.NET Pearls on Overriding](https://www.dotnetperls.com/override)

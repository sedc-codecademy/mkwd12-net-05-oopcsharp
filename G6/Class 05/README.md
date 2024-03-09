# Class 05 - Classes and Objects 😍


## DateTime

DateTime is a complex type in C# representing the date and the time at a particular moment. This complex type can be edited, manipulated, and used every time we need to store dates or time and change or use it easily.

### Creating DateTime

```csharp
DateTime aDate = new DateTime(); // Creating a new empty date
DateTime aCustomDate = new DateTime(1992, 10, 15); // Creating a custom date
DateTime currentDay = DateTime.Today; // Getting todays date without time
DateTime currentDateTime = DateTime.Now; // Getting todays date with time
```

### Converting and formating a string

```csharp
string dateFormat1 = DateTime.Now.ToString("MM/dd/yyyy"); // Formating date to string
string dateFormat2 = DateTime.Now.ToString("dddd, dd MMMM yyyy"); // Formating date to string
string stringDate = "12-15-2012"; 
DateTime convertedDate = DateTime.Parse(stringDate); // Converting string to date
```

### Manipulating DateTime

```csharp
DateTime  currentDateTime  =  DateTime.Now;

// Adding or removing days to a DateTime date
DateTime addedDays = currentDateTime.AddDays(2);
Console.WriteLine(addedDays);
DateTime removedDays = currentDateTime.AddDays(-5);
Console.WriteLine(removedDays);

// Adding months to a DateTime date
DateTime addedMonths = currentDateTime.AddMonths(2);
Console.WriteLine(addedMonths);

// Adding years to a DateTime date
DateTime addedYears = currentDateTime.AddYears(2);
Console.WriteLine(addedYears);

// Adding hours to a DateTime date
DateTime addedHours = currentDateTime.AddHours(3);
Console.WriteLine(addedHours);

// Get the number of the month from a DateTime
int month = currentDateTime.Month;
Console.WriteLine(month);

// Get the number of the day from a DateTime
int day = currentDateTime.Day;
Console.WriteLine(day);

// Get the number of the year from a DateTime
int year = currentDateTime.Year;
Console.WriteLine(year);


## Classes

Classes are the backbone of every object-oriented language. As we mentioned before classes are a building block of all object-oriented applications. Classes are independent and inside them, they hold methods values properties that are unique to them. When an application starts all of these classes work together to create a whole application. A class is not a normal entity. You can’t print a class or write a class. Classes are just templates that are used to build objects with the same functionalities that we are going to give the class to have. So if a class has a property name every object that is created from that class will have a property name as well. With these classes, we can create a network of entities and concepts that build our business logic and with that, use object-oriented programming

### Access Modifiers

Access modifiers are keywords that are used to set who can and can not use your property, method, or class. These modifiers can span from use only in the class, to use only in a project to use anywhere where there is a reference to the class. We always add them in the code to tell the program where they can be accessed. If for some reason we don't add an access modifier for most entities, by default they become private. The most common access modifiers are:

* public - Can be accessed anywhere where there is a reference
* private - Can be accessed only in the class itself, not outside
* protected - Can be accessed only in the class itself, or classes derived from it
* internal - Can be accessed only in the project our class is in

### Creating a class

```csharp
public class Person
{
  public string Name {get;set;}
  public string Age {get;set;}
  private long AccountNumber {get;set;} // Can't be accessed from outside
  public void Talk(string text){
    Console.WriteLine($"Human {Name} is saying {text}");
  }
}
```

## Objects

Objects in C# are the physical representation of the data that is created by the template ( the class ). These objects almost always come from some class and are used as a business logic entity for the most part. Sometimes when we have service classes, they are used as the service object it self-created from the service class. Objects can be created on their own or created with properties already ahead. These are a few ways of creating objects from a class:

```csharp
Person bob = new Person();
bob.Name = "Bob";
bob.Age = 31;
bob.Talk();
```

```csharp
Person anne = new Person(){
  Name = "Anne",
  Age = 34
};
anne.Talk();
```

## Extra Materials 📘

* [Official Microsoft documentation for classes](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes)
* [Object Oriented C# in depth](https://www.c-sharpcorner.com/UploadFile/mkagrahari/introduction-to-object-oriented-programming-concepts-in-C-Sharp/)
* [.NET Pearls - DateTime](https://www.dotnetperls.com/datetime)
* [.NET Pearls - DateTime format](https://www.dotnetperls.com/datetime-format)

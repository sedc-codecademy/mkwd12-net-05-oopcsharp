// See https://aka.ms/new-console-template for more information
using Qinshift.ConsoleAppClasses.MyClasses;

Console.WriteLine("Hello, World!");

#region ClassesAndObject
// Creating an empty person object ( using the parameterless constructor )
Person bob = new Person(); //empty
bob.Name = "Bob Bobsky";
bob.Age = 26;
//bob.id = 1231231; // We can't access this. It's private
Console.WriteLine(bob.Name); ;
Console.WriteLine(bob.Age); ;
//Console.WriteLine(bob.id); // We can't access this. It's private

bob.Talk("Hello form G2");
// Creating a person object using the second construvtor with parameters
Person bill = new Person("Bill", 25);
bill.Talk("I'm a student.");

// Creating an empty person object and immediately giving it values to the properties
Person jill = new Person()
{
    Name = "Jill Jillsky",
    Age = 33
};
jill.Talk("Hello everybody");

//Person test = new Person("Test", 123, 22);

Product car = new Product()
{
    Name = "Audi",
    Price = 12000
};

car.Buy(5000.90);
car.Buy(14000);

Product phone = new Product("Iphone 15 pro max", 1800);
phone.Buy(2000);

// Creating an annonimous object
// We cant add methods in these objects, just properties
var annonObject = new
{
    Name = "Random Object",
    Quantity = 25
};
Console.WriteLine(annonObject.Name);
Console.ReadLine();
#endregion
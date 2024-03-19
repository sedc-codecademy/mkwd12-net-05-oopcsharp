// See https://aka.ms/new-console-template for more information
using Qinshift.Class07.Inheritance.Models;

Console.WriteLine("Hello, World!");

#region Inheritance
//Animal animal = new Animal()
//{
//    Id = 5,
//    Name = "Dambo",
//    Type = "Elephant"
//};

//animal.Eat();
//animal.PrintInfo();

Console.WriteLine("==========================");
//Dog spark = new Dog()
//{
//    Id = 1,
//    Name = "Spark",
//    Type = "Dog",
//    Race = "Labrador"
//};

//spark.Eat();
//spark.PrintInfo();
//spark.Bark();

//Dog bak = new Dog("Bak", "Dog");
//bak.Eat();

Console.WriteLine("==========================");
//Cat garfild = new Cat()
//{
//    Id = 55,
//    Name = "Garfild",
//    Lazyness = "Very"
//};
//garfild.Eat();

Cat tom = new Cat("Tom", "Cat","Vary");
tom.Meow();

#endregion
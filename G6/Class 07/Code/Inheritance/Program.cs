using Inheritance.Models;

Animal animal = new Animal();
animal.Name = "Test animal";
animal.Type = "test";
//animal.Age //ERROR => protected property (Program.cs is not derived from Animal class
//animal._Id //ERROR => private property

animal.PrintInfo();

//animal.PrintAge(); //does not exist in Animal, only in Cat class

Cat cat = new Cat();
cat.Name = "Sharko";
cat.Type = "Cat";
cat.PrintInfo(); // call the implementation from the Cat class

cat.PrintAge();

Dog dog = new Dog();
dog.Name = "Lesi";
dog.Type = "Dog";
dog.Color = "White";
dog.PrintInfo(); //inherited from base class, we didn't override the method for the Dog class, it will call PrintInfo from Animal
//dog.PrintAge(); //ERROR, PrintAge exists onbly in Cat class

Dog newDog = new Dog("Reks", "Brown");
newDog.PrintInfo();

newDog.Type = "Black dog";
newDog.PrintInfo();
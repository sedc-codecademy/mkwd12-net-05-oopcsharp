using QinshiftAcademy.Class09.LINQ;

List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name = "Sparky", Age = 2},
                new Dog(){Name = "Butch", Age = 1},
                new Dog(){Name = "Zoe", Age = 3},
                new Dog(){Name = "Sia", Age = 1},
                new Dog(){Name = "William", Age = 4},
                new Dog(){Name = "Billy", Age = 1},
                new Dog(){Name = "Buck", Age = 2}
            };

//Dog dog = new Dog();
//dog.Name = "Sparky";
//dog.Age = 2;

Dog dog = new Dog()
{
    Name = "Sparky",
    Age = 2
};


//Find all dogs whose name has more than 3 characters. Don't change the original collection!!!
List<Dog> dogsWithLargerName = new List<Dog>();

foreach(Dog d in dogs)
{
    if(d.Name.Length > 3)
    {
        dogsWithLargerName.Add(d);
    }
}

List<Dog> dogsWithNameWithMoreThan3Chars = dogs.Where(x => x.Name.Length > 3).ToList();
Console.WriteLine("All dogs with more than 3 chars in the name:");
foreach(Dog d in dogsWithNameWithMoreThan3Chars)
{
    Console.WriteLine(d.Name);
}

//Find all the dogs whose name starts with an S
List<Dog> dogsWhoseNameStartsWithS = dogs.Where(dog => dog.Name.StartsWith("S")).ToList();
Console.WriteLine("All dogs whose name starts with an S:");
foreach (Dog d in dogsWhoseNameStartsWithS)
{
    Console.WriteLine(d.Name);
}

//Find the first dog that is older than 2
Dog firstDogOlderThanTwo = dogs.First(d => d.Age > 2);
Console.WriteLine(firstDogOlderThanTwo.Name);

//the First method will throw an exception if it doesn't find a member that fulfills the condition!!!
//Dog firstDogOfAgeFive = dogs.First(d => d.Age == 5);


//FirstOrDefault -> if it finds a member that fulfills the condition, it will return the first member that fulfills the condition
//but if it doesn't find any members that fulfill the condition, it will return a default value for the type used in the collection
//in our case, default value for Dog is null
Dog firstDogOfAgeFive = dogs.FirstOrDefault(d => d.Age == 5);
if(firstDogOfAgeFive == null)
{
    Console.WriteLine("There is no dog of age five");
}

//we have Last/LastOrDefault that work the same way as First/FirstORDefault, just search for the last instead of for the first member
Dog lastDogWhoseNameStartsWithB = dogs.LastOrDefault(d =>  d.Name.StartsWith("B"));
if(lastDogWhoseNameStartsWithB != null)
{
    Console.WriteLine($"Last dog whose name starts with B: {lastDogWhoseNameStartsWithB.Name}");
}

//take the names of all of the dogs
List<string> dogsNames = dogs.Select(d => d.Name).ToList();
Console.WriteLine("Dogs' names:");
foreach(string name in dogsNames)
{
    Console.WriteLine(name);
}

//get the age multiplied by 2 for all dogs whose name starts with S
//1. filter
List<Dog> dogsNameStartsWithS = dogs.Where(dog => dog.Name.StartsWith("S")).ToList();
Console.WriteLine("dogsNameStartsWithS:");
foreach (Dog d in dogsNameStartsWithS)
{
    Console.WriteLine(d.Name);
}

//2. project the multiplied age
List<int> ages = dogsNameStartsWithS.Select(d => d.Age * 2).ToList();

//SECOND WAY, we can use chaining
List<int> agesMultiplied = dogs.Where(dog => dog.Name.StartsWith("S")).Select(d => d.Age * 2).ToList();
Console.WriteLine("Multiplied ages:");
foreach(int age in agesMultiplied)
{
    Console.WriteLine(age);
}
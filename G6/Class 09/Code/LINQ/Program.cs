using LINQ;
using System.Linq;

List<Dog> dogs = new List<Dog>()
{
    new Dog("Sparky", 2),
    new Dog("Butch", 1),
    new Dog("Zoe", 3),
    new Dog("Lucy", 2),
    new Dog("Billy", 4),
    new Dog("Buck", 1),
};

//Find all dogs whose name has more than 3 characters
//this does not change the original list
List<Dog> dogsWithNameLongerThan3 = dogs.Where(x => x.Name.Length > 3).ToList();

Console.WriteLine("=====ORIGINAL LIST=========");
foreach(Dog dog in dogs)
{
    Console.WriteLine(dog.Name); 
}

Console.WriteLine("=====Longer than 3=========");
foreach (Dog dog in dogsWithNameLongerThan3)
{
    Console.WriteLine(dog.Name);
}

//all dogs whose name starts with s
List<Dog> dogsStartingWithS = dogs.Where(d => d.Name.StartsWith("S") || d.Name.StartsWith("s")).ToList();

List<Dog> dogsNotStartingWithS = dogs.Where(d => !d.Name.StartsWith("S") && !d.Name.StartsWith("s")).ToList();

Console.WriteLine("=====Starts with s=========");
foreach (Dog dog in dogsStartingWithS)
{
    Console.WriteLine(dog.Name);
}

//Find the first dog older than 2
//First way
Dog firstDogOlderThanTwo1 = dogs.Where(x => x.Age > 2).First(); //get all dogs older than 2, then get the first one

//Second way
Dog firstDogOlderThanTwo2 = dogs.First(x => x.Age > 2); //get the first dog older than 2 

//Dog dogWithNameOnA = dogs.First(x => x.Name.StartsWith("A")); //this will throw an error beacuse in our list we do not have a dog whose name starts with A

Dog dogWithNameOnA = dogs.FirstOrDefault(x => x.Name.StartsWith("A"));
if(dogWithNameOnA != null)
{
    Console.WriteLine("There is a dog whose name starts with A: " + dogWithNameOnA.Name);
}
else
{
    Console.WriteLine("There is no dog whose name starts with A");
}

//First dog with age 1, whose name starts with B
//we can use as many conditions as we need and use them with || or && depending on our business logic
Dog dogAged1B = dogs.FirstOrDefault(x => x.Age == 1 && x.Name.StartsWith("B"));

List<string> namesOfDogs = dogs.Select(x => x.Name).ToList();

//take the names of all the dogs aged 2
//List<string> namesOfDogsAged2 = dogs.Select(x => x.Name).Where(// here we are working with an IEnumerable<string> (we have only the name, so we cannot filter by the age of the dogs, because we already selected only the name)
List<string> namesOfDogsAged2 = dogs.Where(x => x.Age == 2).Select(x => x.Name).ToList();

List<string> namesOfDogsAged2AndStartsWithL = 
     dogs //here we have the whole List<Dog>
    .Where(x => x.Age == 2) //here we have a collection of dogs aged 2
    .Select(x => x.Name) //here we have IEnumerable<string> with names of dogs aged 2
    .Where(x => x.StartsWith("L")) //here we have a collection with names of dogs aged 2, starting with L
    .ToList(); //here we convert the IEnumerable to List

//take the last dog aged 1
Dog lastDogAged1 = dogs.Last(x => x.Age == 1); //this might throw an error
Dog lastDogAged1SecondOption = dogs.LastOrDefault(x => x.Age == 1);

//Any - tells us if there is an element that fulfills a condition
bool isThereADogNamedLucy = dogs.Any(x => x.Name == "Lucy"); //true
bool isThereADogNamedRex = dogs.Any(x => x.Name == "Rex"); //false

//All - checks if all elements fulfill a condition
bool allDogsAgedAbove0 = dogs.All(x => x.Age > 0); //checks if all dogs are older than 0 => true
bool allDogsAgedAbove3 = dogs.All(x => x.Age > 3); //checks if all dogs are older than 3 => false

//Order by
List<Dog> orderedDogs = dogs.OrderBy(x => x.Age).ToList();  //default is asceding
List<Dog> orderedDogsDesc = dogs.OrderByDescending(x => x.Age).ToList();

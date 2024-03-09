namespace Qinshift.ConsoleAppClasses.MyClasses
{
    public class Person
    {
        // Properties must have type, acces modifier and get/set
        public string Name { get; set; }
        public int Age { get; set; }
        private long id { get; set; }// Private method that can only be accessed in this class
                                     // Constructors

        public Person() // an empty constructor that generates a Social Security Number
        {
            //Name = "bob";
            //Age = 12;
            id = GenerateId();

        }
        public Person(string name, int age) // Constructor that adds values to properties through parameters
        {
            Name = name;
            Age = age;
            id = GenerateId();
        }
        private long GenerateId() // Private method that can only be accessed in this class
        {
            return new Random().Next(10000, 999999); // gets a random number between the values
        }
        // Public method that can be accessed anywhere
        public void Talk(string text)
        {
            Console.WriteLine($"The person named {Name} id:{id} age: {Age}, is saying: {text}");
        }
    }
}

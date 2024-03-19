namespace Qinshift.Class07.Inheritance.Models
{
    public class Dog : Animal
    {
        public string Race { get; set; }

        public Dog()
        {
            Console.WriteLine("A new instance of an dog has been created. Dog constructor");
        }
        public Dog(string name, string type)
        {
            Name = name;
            Type = type;
            Console.WriteLine("A new instance of an dog has been created. Dog constructor with name and type");
        }

        public void Bark()
        {
            Console.WriteLine($"{Name}: Bark, Bark, Bark");
        }
    }
}

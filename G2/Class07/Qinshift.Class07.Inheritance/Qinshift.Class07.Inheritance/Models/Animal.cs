namespace Qinshift.Class07.Inheritance.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Animal()
        {
            Console.WriteLine("A new instance of an animal has been created. Animal constructor");
        }

        public Animal(string type)
        {
            Type = type;
            Console.WriteLine("A new instance of an animal has been created. Animal constructor with type");
        }

        public Animal(string name, string type)
        {
            Name = name;
            Type = type;
            Console.WriteLine("A new instance of an animal has been created. Animal constructor with type and name");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} animal named {Name} is eating!!");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Type: {Type}");
        }
    }
}

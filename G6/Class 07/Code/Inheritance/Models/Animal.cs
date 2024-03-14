namespace Inheritance.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        protected int Age { get; set; }
        private int _Id { get; set; }

        public Animal()
        {
            _Id = new Random().Next(1, 10000);
        }

        public Animal(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
            _Id = new Random().Next(1, 10000);
        }

        public Animal(string type)
        {
            Type = type;
            Console.WriteLine("Calling the type constructor");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"The animal with id : {_Id} and name {Name} and type {Type} is {Age} years old");
        }
    }
}

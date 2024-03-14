namespace Inheritance.Models
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        public Dog() //:base()
        {
            Console.WriteLine("Calling default Dog constructor");
        }

        public Dog(string name, string color) : base("Dog") //it will call the constr from Animal(string type)
        {
            Name = name; //this is a property from the parent class, but we can give it value here
            Color = color;
        }
    }
}

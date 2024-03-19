using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Class07.Inheritance.Models
{
    public class Cat : Animal
    {
        public string Lazyness { get; set; }

        public Cat() : base("Cat")
        {
            Console.WriteLine("Create cat constructor.");
        }
        public Cat(string name, string type, string lazyness) : base(name, type)
        {
            Lazyness = lazyness;
            Console.WriteLine("A new instance of cat with two parameters!");
        }

        public override void Eat()
        {
            Console.WriteLine($"You dont tell a  {Name} cat when to eat.");
        }
        public void Meow()
        {
            Console.WriteLine("Meow Meow...");
        }
    }
}

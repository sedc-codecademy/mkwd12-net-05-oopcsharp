namespace Inheritance.Models
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }

        //specific only for  the Cat class => the Animal class does not have a PrintAge method
        public void PrintAge()
        {
            //we can use Age because it is protected in the Animal class and it is inherited in the Cat class
            Console.WriteLine($"The cat is {Age} years old");

            //we cannot use _id because it is private in the Animal class
           // Console.WriteLine($"The cat with id {_Id} is {Age} years old"); //ERROR
        }

        //first call the default constr from the base class (Animal), then execute the default constr from Cat class
        public Cat() : base()
        {
            Console.WriteLine("Calling the default Cat constructor");
        }

        //OVERRIDE METHODS
        //we need to use the override keyword
        public override void PrintInfo()
        {
            string lazy = IsLazy ? "is lazy" : "isn't lazy";
            //base.PrintInfo(); this way we can access the PrintInfo implementation from the base class and extend it

            //this way we totally change the implementation
            Console.WriteLine(string.Format("The cat {0} is {1} years old and it {2}", Name, Age, lazy));
        }
    }
}

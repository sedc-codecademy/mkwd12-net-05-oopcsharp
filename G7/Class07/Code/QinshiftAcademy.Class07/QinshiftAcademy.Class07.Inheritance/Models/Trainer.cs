

namespace QinshiftAcademy.Class07.Inheritance.Models
{
    public class Trainer : Person
    {
        //public and protected properties from Person are inherited
        //public and protected methods from Person are inherited
        //specific property for the Trainer class
        public string[] Subjects { get; set; }

        //even if we don't specify : base(), the default constructor from the base class will be called
        public Trainer()
        {
            Subjects = new string[1];
            Subjects[0] = "Intro";
        }

        //when this constructor from Trainer is called, the costructor that has type parameter from Person
        //will be called
        public Trainer(string firstName, string lastName, int age) : base("Trainer")
        {
            Subjects = new string[1];
            Subjects[0] = "Intro";

            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override void PrintId()
        {
            Console.WriteLine($"Trainer's id: {Id}");
        }
    }
}

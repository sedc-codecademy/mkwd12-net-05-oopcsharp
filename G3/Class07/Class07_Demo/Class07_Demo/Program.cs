using Class07_Demo.Models;

namespace Class07_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Petko", "Petkovski", "petko@gmail.com", "070123456", "G3");

            Console.WriteLine(s1.GetInfo());

            Trainer t1 = new Trainer()
            {
                FirstName = "Jane",
                LastName = "Janevski",
                Email = "jane@gmail",
                PhoneNumber = "070111222",
                YearsOfExperience = 5
            };

            Console.WriteLine(t1.GetInfo());
        }
    }
}
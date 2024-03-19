

namespace QinshiftAcademy.Class07.Inheritance.Models
{
    public class Person
    {
        //the Id property will be accessible from the class and the inherited classes, but not from the rest of the code
        protected int Id { get; set; }

        //they are accessible from the class, the inherited classes, but also outside of the hierarchy, from the rest of the code
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //this property is only accessible in the Person class
        private long _ssn { get; set; }

        public string Type { get; set; }


        public Person()
        {
            Id = new Random().Next(1, 1000);
            _ssn = new Random().Next(100000, 9999999);
        }

        public Person(string type)
        {
            Id = new Random().Next(1, 1000);
            _ssn = new Random().Next(100000, 9999999);
            Type = type;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Person's info: {Id} {FirstName} {LastName} {Age}");
        }

        //we mark this method as virtaul because we want to inherit it in the specific classes
        //but we want to give it a specific implementation in the inherited classes
        public virtual void PrintId()
        {
            Console.WriteLine($"Person's id: {Id}");
        }
    }
}

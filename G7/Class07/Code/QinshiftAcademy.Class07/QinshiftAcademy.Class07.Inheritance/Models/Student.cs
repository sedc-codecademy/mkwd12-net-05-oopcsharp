

namespace QinshiftAcademy.Class07.Inheritance.Models
{
    public class Student : Person
    {
        //Student class has Academy property but also has all the protected and public properties from Person
        public string Academy { get; set; }

        //public and protected methods from Person are also inherited
        //PrintInfo method is inherited from Person class

        //this is a specific method for the Student class
        public void PrintStudentInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} with Id {Id} studies at {Academy} academy");
            //Console.WriteLine($"Ssn: {_ssn}"); _ssn is private proeprty for Person
        }

        //we specify explicitly that the default construcotr from the base class will be called
        public Student() : base()
        {

        }

        //Student class gives a specific implementation for the PrintId method
        public override void PrintId()
        {
            Console.WriteLine($"Student's id: {Id}");
        }
    }
}

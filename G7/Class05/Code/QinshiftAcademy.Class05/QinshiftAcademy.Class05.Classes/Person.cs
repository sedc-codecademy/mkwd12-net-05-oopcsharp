

namespace QinshiftAcademy.Class05.Classes
{
    public class Person
    {
        //Properties
        //public properties are available from everywhere, we can also access them through objects in Program.cs
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //private properties are only accessible in the methods of the given class
        private long _ssn {  get; set; }


        //Constructors
        //Constructors are public because they are called outside of the class, when creating objects
        //Constructors are named after the class, same name as the class

        //if we don't specify a constructor in the class's definition, the default constructor is called

        //default constructor, it has no parameters
        public Person()
        {
            _ssn = new Random().Next(100000, 999999);
        } 

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

            _ssn = new Random().Next(100000, 999999);
        }

        //we can have as mnay constructors as we need, but they must differ in signature
        //they must have different number of parameters or different types of parameters
        //this one is ok, because it also has 3 parameters, but they are with different types from the one above
        public Person(string streetName, int num, int code)
        {

        }

        //Methods
        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} is {Age} years old");
        }

        public void SetSsn(long ssn)
        {
            if(ssn > 100000 && ssn < 999999)
            {
                _ssn = ssn;
            }
            else
            {
                Console.WriteLine("The ssn has to be between 100000 and 999999");
            }
        }

        public long GetSsn()
        {
            return _ssn;
        }
    }
}

namespace Classes //the path from our sln to our class => in this case it is the project Classes
{
    public class Person //the default is internal
    {
        //we can access FIrstName, LastName and Age from anywhere
        public string FirstName { get; set; } //getters and setters
        public string LastName { get; set; }
        public int Age { get; set; }

        //we can access _ssn only from Person class (and its methods)
        private long _ssn {  get; set; }

        //Constructor
        //Construcor is always public and has the same name as the class
        //we need it in order to instantiate objects
        public Person()
        {
            _ssn = new Random().Next(100000, 999999); //gets a random number from 100000 to 999999
        }

        public Person(string firstName, string lastName, int age, long ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            if(ssn >=100000 && ssn <= 999999)
            {
                _ssn = ssn;
            }
           
        }

        //we can create more constructors with different params
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = 0;
            _ssn = new Random().Next(100000, 999999);
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Firstname: {FirstName} LastName = {LastName} Age: {Age} SSN: {_ssn}");
        }

        public void Says(string message)
        {
            Console.WriteLine($"{FirstName} {LastName} says {message}");
        }

        //we can use this way to get the value of _ssn from outside
        public long GetSSN()
        {
            return _ssn;
        }

        //we can set the ssn value from outside, but in a controlled way
        public void SetSSN(long ssn)
        {
            if (ssn >= 100000 && ssn <= 999999)
            {
                _ssn = ssn;
            }
            else
            {
                Console.WriteLine("Invalid ssn value");
            }
        }
    }
}

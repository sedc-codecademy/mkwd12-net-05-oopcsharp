namespace Class07_Demo.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Person() { }

        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName} - email: {Email} ({PhoneNumber})";
        }
    }
}

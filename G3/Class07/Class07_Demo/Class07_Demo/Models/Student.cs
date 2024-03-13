namespace Class07_Demo.Models
{
    public class Student : Person
    {
        public string Group { get; set; }

        public Student(string firstName, string lastName, string email, string phoneNumber, string group)
            : base(firstName, lastName, email, phoneNumber)
        {
            Group = group;
        }

        //Valid if there is a default/empty constructor
        //public Student(string firstName, string lastName, string email, string phoneNumber, string group)
        //{
        //    Group = group;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Email = email;
        //    PhoneNumber = phoneNumber;
        //}
    }
}

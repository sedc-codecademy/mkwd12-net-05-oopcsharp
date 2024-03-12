namespace ClassesRecap.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student {GetFullName()} is {Age} years old and studies at the {Academy} in the group {Group}");
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

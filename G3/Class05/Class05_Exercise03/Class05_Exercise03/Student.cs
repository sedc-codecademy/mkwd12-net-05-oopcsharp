namespace Class05_Exercise03
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Student(string firstName, string lastName, string academy, string group)
        {
            FirstName = firstName;
            LastName = lastName;
            Academy = academy;
            Group = group;
        }

        public Student()
        {
        }

        public string GetStudentInfo()
        {
            return $"{FirstName} {LastName} - {Academy}/{Group}";
        }
    }
}

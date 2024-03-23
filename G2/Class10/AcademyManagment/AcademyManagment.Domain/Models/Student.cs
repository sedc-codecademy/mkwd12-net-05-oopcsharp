using AcademyManagment.Domain.Enums;

namespace AcademyManagment.Domain.Models
{
    public class Student : User
    {
        public string CurrentSubject { get; set; }
        public Dictionary<string, int> SubjectGrade { get; set; }

        public Student(string username, string password, string firstName, string lastName, int age) : base(username, password, firstName, lastName, age)
        {
            Role = Role.Student;
        }

        public Student(string username, string password) : base(username, password)
        {
            Role = Role.Student;
        }
    }
}

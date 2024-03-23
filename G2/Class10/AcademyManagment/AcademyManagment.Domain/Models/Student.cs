using AcademyManagment.Domain.Enums;

namespace AcademyManagment.Domain.Models
{
    public class Student : User
    {
        public string CurrentSubject { get; set; }
        public Dictionary<string, int> SubjectGrade { get; set; }

        public Student(string firstName, string lastName, int age, string username, string password) : base(firstName, lastName, age, username, password)
        {
            Role = Role.Student;
        }
    }
}

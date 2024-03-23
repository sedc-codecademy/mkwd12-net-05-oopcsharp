using AcademyManagment.Domain.Enums;
using AcademyManagment.Domain.Models.BaseModel;

namespace AcademyManagment.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string username, string password, string firstName, string lastName, int age)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

    }
}

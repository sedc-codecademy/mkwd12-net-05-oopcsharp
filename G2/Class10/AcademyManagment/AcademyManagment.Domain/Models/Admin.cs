using AcademyManagment.Domain.Enums;

namespace AcademyManagment.Domain.Models
{
    public class Admin : User
    {
        public Admin(string firstName, string lastName, int age, string username, string password) : base(firstName, lastName, age, username, password)
        {
            Role = Role.Admin;
        }
    }
}

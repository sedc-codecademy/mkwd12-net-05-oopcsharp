using AcademyManagment.Domain.Enums;

namespace AcademyManagment.Domain.Models
{
    public class Admin : User
    {
        public Admin(string username, string password, string firstName, string lastName, int age) : base(username, password, firstName, lastName, age)
        {
            Role = Role.Admin;
        }

        public Admin(string username, string password) : base(username, password)
        {
            Role = Role.Admin;
        }
    }
}

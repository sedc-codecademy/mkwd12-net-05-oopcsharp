using AcademyManagment.Domain.Enums;
namespace AcademyManagment.Domain.Models
{
    public class Trainer : User
    {
        public Trainer(string username, string password, string firstName, string lastName, int age) : base(username, password, firstName, lastName, age)
        {
            Role = Role.Trainer;
        }
    }
}

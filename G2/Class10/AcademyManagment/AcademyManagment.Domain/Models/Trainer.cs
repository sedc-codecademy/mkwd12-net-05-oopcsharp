using AcademyManagment.Domain.Enums;
namespace AcademyManagment.Domain.Models
{
    public class Trainer : User
    {
        public Trainer(string firstName, string lastName, int age, string username, string password) : base(firstName, lastName, age, username, password)
        {
            Role = Role.Trainer;
        }
    }
}

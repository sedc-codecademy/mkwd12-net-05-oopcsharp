using SEDC.AcademyManagement.Domain.Enums;
namespace SEDC.AcademyManagement.Domain.Classes
{
    public class Admin : AcademyMember
    {
        public Admin(string userName, string firstName, string lastName, int age) : base(userName, firstName, lastName, age)
        {
            Role = Role.Admin;
        }
    }
}

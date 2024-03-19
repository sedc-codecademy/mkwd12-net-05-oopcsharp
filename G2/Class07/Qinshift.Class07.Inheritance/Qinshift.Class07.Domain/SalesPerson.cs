using Qinshift.Class07.Domain.Enums;
namespace Qinshift.Class07.Domain
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Sales;
            Salary = 500;
        }
    }
}

using Qinshift.Class07.Domain.Enums;

namespace Qinshift.Class07.Domain
{
    public class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Bonus = 0;
            Salary = salary;
            Role = Role.Manager;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }
    }
}

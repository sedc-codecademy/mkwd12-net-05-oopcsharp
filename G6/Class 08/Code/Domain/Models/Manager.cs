//Add class Manager that inherits from Employee and has a new property called Bonus - double, private
//Create a constructor that sets all properties except Bonus
//Create a method called AddBonus that adds bonus to the Bonus property
//Override the method GetSalary to return the Salary + Bonus


using Domain.Enums;

namespace Domain.Models
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }

        public Manager(string firstName, string lastName, RoleEnum role, double salary) 
            :base(firstName, lastName, role, salary)
        {
            _bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            _bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}

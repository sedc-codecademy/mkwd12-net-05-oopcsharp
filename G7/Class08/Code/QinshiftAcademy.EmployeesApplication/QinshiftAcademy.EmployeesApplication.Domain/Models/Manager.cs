using QinshiftAcademy.EmployeesApplication.Domain.Enums;

namespace QinshiftAcademy.EmployeesApplication.Domain.Models;

public class Manager : Employee
{
    private double _bonus { get; set; }

    public Manager(string firstName, string lastName, double salary) 
        : base(firstName, lastName, salary, EmployeeRole.Manager)
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

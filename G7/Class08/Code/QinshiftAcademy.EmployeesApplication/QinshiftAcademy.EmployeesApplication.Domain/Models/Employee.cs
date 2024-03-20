using QinshiftAcademy.EmployeesApplication.Domain.Enums;

namespace QinshiftAcademy.EmployeesApplication.Domain.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeRole Role { get; set; }
        protected double Salary { get; set; }

        public Employee() { }

        public Employee(string firstName, string lastName, double salary, EmployeeRole role)
        {
            //do validations

            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Salary}");
        }
    }
}



using QinshiftAcademy.EmployeesApplication.Domain.Enums;

namespace QinshiftAcademy.EmployeesApplication.Domain.Models
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue {  get; set; }

        public SalesPerson()
        {
            Salary = 500;
            Role = EmployeeRole.Sales;
        }

        public SalesPerson(string firstName, string lastName, double revenue) 
            : base(firstName, lastName, 500, EmployeeRole.Sales)
        {
            _successSaleRevenue = revenue;
        }

        public void AddSuccessRevenue(double successSaleRevenue)
        {
            _successSaleRevenue += successSaleRevenue; 
        }

        public override double GetSalary()
        {
            if(_successSaleRevenue < 2000)
            {
                return Salary + 500;
            }
            else if(_successSaleRevenue >= 2000 && _successSaleRevenue < 5000)
            {
                return Salary + 1000;
            }
            else
            {
                return Salary + 1500;
            }
        }
    }
}

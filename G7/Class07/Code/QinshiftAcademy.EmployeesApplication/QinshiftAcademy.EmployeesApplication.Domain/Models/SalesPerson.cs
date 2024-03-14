

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
    }
}

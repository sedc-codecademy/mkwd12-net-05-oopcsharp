using QinshiftAcademy.EmployeesApplication.Domain.Enums;
using QinshiftAcademy.EmployeesApplication.Domain.Models;

Employee employee = new Employee();

Employee secondEmployee = new Employee("Kate", "Katesky", 1000, EmployeeRole.Manager);
secondEmployee.PrintInfo();

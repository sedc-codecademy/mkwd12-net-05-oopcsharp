using QinshiftAcademy.EmployeesApplication.Domain.Enums;
using QinshiftAcademy.EmployeesApplication.Domain.Models;

Employee employee = new Employee();

Employee secondEmployee = new Employee("Kate", "Katesky", 1000, EmployeeRole.Manager);
secondEmployee.PrintInfo();

double secondEmployeeSalary = secondEmployee.GetSalary();

Manager manager = new Manager("Paul", "Paulsky", 1000);
manager.AddBonus(200);

double managerSalary = manager.GetSalary();

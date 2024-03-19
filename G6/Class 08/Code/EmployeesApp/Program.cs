using Domain.Models;
using Domain.Enums;

Employee employee = new Employee("Petko", "Petkovski", RoleEnum.Other, 600);
employee.PrintInfo();
//double employeesSalary = employee.Salary =>ERROR, Salary is protected

double employeesSalary = employee.GetSalary();
Console.WriteLine(employeesSalary);

SalesPerson salesPerson = new SalesPerson("Stefan", "Stefanovski", 0);
salesPerson.PrintInfo();
salesPerson.AddSuccessRevenue(2500);
Console.WriteLine(salesPerson.GetSalary());

Manager manager = new Manager("Nikola", "Nikolovski", RoleEnum.Manager, 1000);
manager.PrintInfo(); //inherited from Employee
manager.AddBonus(100);
double managerSalary  = manager.GetSalary();
Console.WriteLine(managerSalary);
manager.AddBonus(150);
managerSalary = manager.GetSalary();
Console.WriteLine(managerSalary);
Console.WriteLine(manager.GetSalary());

// See https://aka.ms/new-console-template for more information
using Qinshift.Class07.Domain;
using Qinshift.Class07.Domain.Enums;

Console.WriteLine("Hello, World!");

Employee employee = new Employee()
{
    FirstName = "Zlatko",
    LastName = "Zlatev",
    Role = Role.Other
};

employee.PrintInfo();

Manager manager = new Manager("Elon", "Mask", 200);
manager.PrintInfo();
manager.AddBonus(100);
manager.PrintInfo();
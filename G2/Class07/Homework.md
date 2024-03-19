# Homework Class 7 📒

## Task 1
Extend the exercise for Employees with two more Employees. Add a class called Contractor that inherits from Employee. The employee should have properties: WorkHours ( double ), PayPerHour ( int ) and Responsible (Manager ( object )).
* The GetSalary method should be overridden to return WorkHours * PayPerHour and also change the Salary property to that amount 
* A new method called CurrentPosition should return the department of the manager that is responsible for this Contractor

## Task 2
* Make an array called Company with 2 contractors, 2 managers and 1 salesPerson
* Make a new class CEO that inherits from Employee that will have a property Employees ( an array of Employees), Shares property ( int ), SharesPrice ( double )
* The shares price should not be accessed from outside of the class
* There should be a method called AddSharesPrice() that will accept a double number and it will change the SharesPrice. This is the only way to change SharesPrice
* The CEO should have a method called PrintEmployees() that will print all employees that work for his company. 
* The CEO should override the GetSalary method to return Salary + Shares * SharesPrice
* Create a new instance of CEO and call: ceoName.PrintInfo(), ceoName.PrintEmployees() and ceoName.GetSalary() to check if everything is working. 
* Expected output: 
  * CEO:
  * First Name: Ron, Last Name: Ronsky, Salary: 1500
  * Salary of CEO is: 2900
  * Employees:
  * Bob Bobert
  * Rick Rickert
  * Mona Monalisa
  * Igor Igorsky
  * Lea Leova

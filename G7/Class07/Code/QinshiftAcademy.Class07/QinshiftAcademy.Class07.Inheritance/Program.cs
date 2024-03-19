using QinshiftAcademy.Class07.Inheritance.Models;

Person person = new Person();

person.FirstName = "Paul"; // public property
person.LastName = "Paulsky"; // public property
person.Age = 40; // public property
//person.Id = 5; //protected ERROR
//person._ssn = 453453453; ERROR, this is private property

Student student = new Student();
student.FirstName = "Jake"; //FirstName is inherited from Person and is public
student.LastName = "Jakesky"; 
student.Age = 23; 
student.Academy = "Programming Academy";
//student.Id = 4; //protected, inherited from Person, can be used only within the classes, ERROR
//student._ssn = 543643; _ssn is not inherited, it is only accessible for the Person class

person.PrintInfo(); //public method

student.PrintInfo(); //public method, inherited from Person, accessible from everywhere
student.PrintStudentInfo(); //public method, specific for student

Trainer trainer = new Trainer("Kate", "Katesky", 30);
trainer.PrintInfo();

person.PrintId(); //the implementation from Person class for this method will be called
student.PrintId(); //the implemnetation from Student class will be called
trainer.PrintId(); //the implementation from Trainer class will be called



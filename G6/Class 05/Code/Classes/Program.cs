using Classes;

//Program.cs is always the first class that gets called when executing a project
//Thst's why we create objects from Person here

Person firstPerson = new Person(); //call the default, empty constructor
firstPerson.FirstName = "Petko";
Console.WriteLine(firstPerson.FirstName);   

//_ssn is private and can be accessed only in the class
//firstPerson._ssn =>ERROR

Person secondPerson = new Person("Marko", "Markovski", 22, 123244);
Console.WriteLine($"{secondPerson.FirstName} {secondPerson.LastName}");

Person thirdPerson = new Person("Nikola", "Nikolovski");
Console.WriteLine(thirdPerson.FirstName + " " + thirdPerson.Age);

firstPerson.PrintDetails();
secondPerson.PrintDetails();
thirdPerson.PrintDetails();

secondPerson.Says("Hello G6");

Console.WriteLine(firstPerson.GetSSN());
//firstPerson._ssn = 123123; //ERROR
firstPerson.SetSSN(123123);
Console.WriteLine(firstPerson.GetSSN());

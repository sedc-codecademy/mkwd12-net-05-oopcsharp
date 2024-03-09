using QinshiftAcademy.Class05.Classes;

//default constructor is called here
Person person = new Person();

//this is alowed because FirstName property is public
person.FirstName = "Kate";
person.LastName = "Katesky";
person.Age = 20;

//this method is public, so it can be called
//it sets the ssn in a controlled way
person.SetSsn(555555);

long firstPersonSsn = person.GetSsn();
Console.WriteLine(firstPersonSsn);  

Console.WriteLine(person.FirstName);

//this is not allowed, because _ssn is private, and can be accessed only within Person class
//person._ssn = 7634756374; ERROR!!!!

//Console.WriteLine(person._ssn);

//default constructor is called here
Person secondPerson = new Person();
secondPerson.FirstName = "John";

//secondPerson._ssn = 74857348; PRIVATE property

//the constructor with parameters will be called
Person thirdPerson = new Person("Paul", "Paulsky", 28);

Console.WriteLine(thirdPerson.FirstName);
Console.WriteLine(thirdPerson.LastName);
Console.WriteLine(thirdPerson.Age);


thirdPerson.PrintInfo();

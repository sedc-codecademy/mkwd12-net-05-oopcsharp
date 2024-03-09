using QinshiftAcademy.Class05.Exercise01;

Console.WriteLine("Enter first name");
string firstName = Console.ReadLine();

Console.WriteLine("Enter last name");
string lastName = Console.ReadLine();

Console.WriteLine("Enter age");
string age = Console.ReadLine();

Human human = new Human(firstName, lastName, Convert.ToInt32(age));

string stats = human.GetPersonStats();
Console.WriteLine(stats);

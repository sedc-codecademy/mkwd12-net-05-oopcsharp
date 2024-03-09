//Function (method) that has no parameters and returns no value

void PrintMessage()
{
    Console.WriteLine("Hello from our first method");
}

PrintMessage();

//Function (method) that has no return value, but has parameters

void PrintGreeting(string firstName)
{
    Console.WriteLine("Hello " + firstName);
}
PrintGreeting("Marko");

//several parameters
void PrintInfo(string firstName, int age)
{
    Console.WriteLine(firstName + " is " + age + " years old");
}
PrintInfo("Tanja", 29);

//method to return a value

string GetMessage()
{
    return "This is our first returned value";
}

string message = GetMessage();
Console.WriteLine(message);

Console.WriteLine(GetMessage());

string GetInfo(string firstName, string lastName, int age)
{
    return firstName + " " + lastName + " " + age;
}

string info = GetInfo("John", "Johnsky", 35);
Console.WriteLine(info);
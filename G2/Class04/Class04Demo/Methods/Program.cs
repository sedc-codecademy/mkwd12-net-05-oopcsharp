Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n=============== METHODS ===============\n\n");
Console.ResetColor();

// Main Syntax: 
// <access modifier> <return type> <method name>(<parameter1 type> <parameter1 name>...)
// {
//    Method body (the logic of the method)
// }

// *** For now because we are using the Program.cs to write our code we will use the following syntax ***
// static <return type> <method name> (<parameter1 type> <parameter1 name>...)
// {
//    Method body (the logic of the method)
// }

#region Methods
// => Method - reusable block of code
// => the methods are named using *PascalCase* naming convention !!!
// => for better readability try declaring the methods at the top of the file, and then call them as needed 

// void => means we don't have a return value

// 1) Method with no parameters & no return (*void*)
// method declaration
static void Greet()
{
    Console.WriteLine("Hello from Qinshift Academy");
}
// method execution
Greet();

// 2) Method with parameters but no return (void)
static void GreetStudent(string student)
{
   Console.WriteLine("Hello student " + student);
}
GreetStudent("Viktor"); 

// 3) Method with parameters and return

static string GetFullName(string firstName, string lastName)
{
    string fullName = firstName + " " + lastName;
    return fullName;
}
GetFullName("Don", "Donsky"); // we don't save the value to a variable / nothing happens
string bobFullName = GetFullName("Bob", "Bobsky");
Console.WriteLine(bobFullName);

static void PrintPersonInfo(bool isStudent, string firstName, string lastName)
{
    if (isStudent)
    {
        Console.WriteLine(GetFullName(firstName, lastName) + " is a programming student.");
    }
    else
    {
        Console.WriteLine(GetFullName(firstName, lastName) + " is NOT a programming student.");
    }
}

PrintPersonInfo(true, "John", "Johnsky");
PrintPersonInfo(false, "Petko", "Petkovsky");

#endregion

Console.ReadKey();
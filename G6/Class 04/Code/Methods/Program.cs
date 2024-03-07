//METHODS

//function (method) with no params and no return values
//void represents that the method does not return anything
void PrintMessage()
{
    Console.WriteLine("Hello from our first method");
}

PrintMessage();

//function (method) with string param and no return values
void Greeting(string name)
{
    Console.WriteLine("Hello " + name);
}

Greeting("G6");
//Greeting(10);

void PrintInfo(string name, int age)
{
    Console.WriteLine(name + " is " + +age);
}

PrintInfo("Tijana", 24);

//Return value

string GetMessage()
{
    return "Hello from G6";
}

string message = GetMessage();
Console.WriteLine("Message: " +message);
Console.WriteLine("Message: " + GetMessage());

string CheckIfItIsWeekend(bool isWeekend)
{
    if (isWeekend)
    {
        return "Yay! It's the weekend";
    }
    else
    {
        return "Sorry, it is a working day";
    }
}

string weekendMessage = CheckIfItIsWeekend(false);
Console.WriteLine("Message: " + weekendMessage);
Console.WriteLine("Message: " + CheckIfItIsWeekend(true));
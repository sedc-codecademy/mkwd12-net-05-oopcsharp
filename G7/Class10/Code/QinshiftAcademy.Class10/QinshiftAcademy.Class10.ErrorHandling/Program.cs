using QinshiftAcademy.Class10.ErrorHandling;

try
{
    Console.WriteLine("Please enter a number");
    string input = Console.ReadLine();

    int number = int.Parse(input);

    Console.WriteLine(number);
}
catch (Exception e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
    Console.WriteLine("You can have a look at the stack trace:");
    Console.WriteLine(e.StackTrace);
}
finally
{
    Console.WriteLine("This message will be displayed anyway.");
}


Console.WriteLine("We are going further");


Console.WriteLine("Handling specific exceptions");
//there can be different types of exceptions that happen in code
//all exceptions inherit from the Exception class
//we can have multiple catch blocks, but only one catch block gets executed when an error happens
//we should always put the specific catch blocks first, since when an error happens it will try to see if it can be handled
//by a catch block, starting from the first one
//if no catch block suits, it will go to the general one (Exception) since all exceptions inherit from Exception
//always put specific catch blocks first, general ones last
try
{
    Console.WriteLine("Please enter a number");
    string inputString = Console.ReadLine();

    int secondNumber = int.Parse(inputString);

    Console.WriteLine(secondNumber);

    // string message = null;
    // Console.WriteLine(message.Length);

    int[] array = new int[] { 5, 6, 7 };
    Console.WriteLine(array[5]);

}
catch (FormatException e)
{
    Console.WriteLine("The input could not be parsed");
}
catch (NullReferenceException e)
{
    Console.WriteLine("Probably you have a variable with null value");

}
catch (Exception e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
    Console.WriteLine("You can have a look at the stack trace:");
    Console.WriteLine(e.StackTrace);
}

//Throwing an exception

try
{
    Console.WriteLine("Please enter an option: a or b");
    string option = Console.ReadLine();

    if (option.ToLower() != "a" && option.ToLower() != "b")
    {
        throw new Exception("Invalid option entered. Value must be a or b");
    }

    //you can also throw specific Exceptions
   // throw new ArgumentNullException("Message");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}


//function that potentially could lead to an error
void PrintSkills(Human human)
{
    foreach(Skill s in human.Skills)
    {
        Console.WriteLine(s.Name);
    }
}

//FIRST OPTION is to put the call of the function in a try catch block
try
{
    Human human = new Human();
    PrintSkills(human);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

//SECOND OPTION - to handle the exceptions in the method itself
void SecondPrintSkills(Human human)
{
    try
    {
        foreach (Skill s in human.Skills)
        {
            Console.WriteLine(s.Name);
        }
    }
    catch(NullReferenceException e)
    {
        Console.WriteLine(e.Message);
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

SecondPrintSkills(new Human());





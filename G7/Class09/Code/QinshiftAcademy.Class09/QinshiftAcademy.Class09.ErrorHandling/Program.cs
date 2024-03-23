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
catch(NullReferenceException e)
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




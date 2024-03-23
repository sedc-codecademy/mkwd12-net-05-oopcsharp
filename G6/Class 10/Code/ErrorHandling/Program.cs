
using ErrorHandling;
using System.Linq.Expressions;

try
{
    //in try we write the code that we want to be executed and that might throw an error
    Console.WriteLine("Enter a number:");
    string input = Console.ReadLine();
    int number = int.Parse(input); //if we enter a wrong input, this line will throw an error

    //this line will be executed onlu if the lines above don't throw an Exception
    //otherwise we will be redirected to the catch block
    Console.WriteLine("You have entered: " +number);

}catch(Exception e)
{
    Console.WriteLine("The input that you entered was not a correct number");
}
finally
{
    Console.WriteLine("This message will be written anyway!");
}

//Throwing an exception

try
{
    Console.WriteLine("Enter a or b:");
    string character = Console.ReadLine();

    if(character.ToLower() == "a" || character.ToLower() == "b")
    {
        Console.WriteLine("Correct input");
    }
    else
    {
        throw new Exception("User did not enter a or b");
    }
    
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}

//Specific exeptions
//ONLY ONE CATCH BLOCK CAN BE EXECUTED AT A TIME
//We have a general Exception and more specific exceptions, we need to order them from most specific to least specific
try
{
    Console.WriteLine("Enter a number:");
    string input = Console.ReadLine();
    int num = int.Parse(input);

    //string nullString = null;
    //Console.WriteLine(nullString.Length); //if we don't have a specific catch block for the exception, it will go into the Exception catch block

}catch(OverflowException e)
{
    Console.WriteLine("We have more data than what could fit in an int");
}catch(FormatException e)
{
    Console.WriteLine("The input that was entered was in a wrong format");
}
//catch (NullReferenceException e)
//{
//    Console.WriteLine("Null");
//}
catch (Exception e) //this is the most generic exception, that's why we put it last; ALL OTHER EXCEPTIONS INHERIT FROM EXCEPTION
{
    Console.WriteLine(e.Message);
}

//This method will let the potential exception go outside of the method => to the line where the method is called
void PrintSkills(Human human)
{
    foreach(Skill skill in human.Skills) //human.Skills might throw an error
    {
        Console.WriteLine(skill.Name);//skill.Name might throw an error
    }
}

//FIRST OPTION - CALL TO METHOD TO BE IN A TRY-CATCH BLOCK
try
{
    //PrintSkills(null); //this will cause an exception to be thrown on line 76 (human.Skills will be null.Skills which will throw an error)
    // Human human = new Human("Petko");
    //  PrintSkills(human); //we didn't set Skills to be an empty list, the defualt is null, so an exception will be thrown on line 78 (skill.Name will be null.Name whick=h will throw an error)
    Console.WriteLine("Test");
}
catch(Exception e)
{
    Console.WriteLine("We are here because PrintSkills threw an exception");
}

//SECOND OPTION - Handle the exceptions in the method
//This method won't propagate the potential exception to the outside (to the line where it was called)
void PrintHumanSkills(Human human)
{
    try
    {
        foreach (Skill skill in human.Skills) //human.Skills might throw an error
        {
            Console.WriteLine(skill.Name);//skill.Name might throw an error
        }
    }
    catch(NullReferenceException e)
    {
        Console.WriteLine("The human or his/her skills were null");
    }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
Human h = new Human("petko");
PrintSkills(h);
using Qinshift.Domain;

#region Methods

static void HumanSkill(Human human)
{
    try
    {
        foreach (var skill in human.Skills)
        {
            Console.WriteLine(skill.Name);
        }
    }
    catch(NullReferenceException nullEx)
    {
        Console.WriteLine("Catch inside the method" + nullEx.Message);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Catch inside the method" + ex.Message);
    }
}

static void HumanSkill2(Human human)
{
        foreach (var skill in human.Skills)
        {
            Console.WriteLine(skill.Name);
        }
}

static void HumanSkill3(Human human)
{
    try
    {
        string message = Console.ReadLine();
        if(message == "b")
        {
            Console.WriteLine("You entered a b!");
        }
        else
        {
            throw new CustomException("You entered a wrong message");
        }
    }
    catch(CustomException customEx)
    {
        Console.WriteLine(customEx.Message);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}
#endregion

#region Exception
Console.WriteLine("Number Exception");
Console.WriteLine("Enter a number:");

try
{
    int number = Int32.Parse(Console.ReadLine());
    Console.WriteLine("The number you entered is: " + number);
}
catch (Exception ex)
{
    //Console.WriteLine(ex.Message);
    Console.WriteLine("ERROR: " + ex.Message);
}
finally
{
    Console.WriteLine("Press any key to exit.");
    Console.ReadLine();
}

Console.WriteLine("===== CUSTOM EXCEPTION ===");
Console.WriteLine("Enter the letter a or b");
try
{
    string letter = Console.ReadLine().ToLower();
    if(letter == "a" || letter == "b")
    {
        Console.WriteLine("You have entered a or b!");
    }
    else
    {
        throw new Exception("That is not a or b!! SORRY");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Press any key to exit.");
    Console.ReadLine();
}

Console.WriteLine("===== Specific EXCEPTION ===");
try
{
    Console.WriteLine("Enter some character!");
    char character = char.Parse(Console.ReadLine());
    Console.WriteLine("You entered a: " + character);
    Console.WriteLine("Enter a number!");
    int integerInput = Int32.Parse(Console.ReadLine());
    Console.WriteLine("You entered a " + integerInput);
}
catch (OverflowException overFlow)
{
    Console.WriteLine(overFlow.Message);
}
catch(FormatException formatEx)
{
    Console.WriteLine(formatEx.Message);
}
catch(NullReferenceException nullEx)
{
    Console.WriteLine(nullEx.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

finally
{
    Console.WriteLine("Press any key to exit.");
    Console.ReadLine();
}

Console.WriteLine("====== Catching exception from inside of a methods ====");

try
{
    //HumanSkill(new Human() { Name = "Bob Bobsky" });
    //HumanSkill2(new Human() { Name = "Bob Bobsky" });
    HumanSkill3(new Human() { Name = "Bob Bobsky" });

}
catch(Exception ex)
{
    Console.WriteLine("Catch outside the methods: " + ex.Message);
}


#endregion
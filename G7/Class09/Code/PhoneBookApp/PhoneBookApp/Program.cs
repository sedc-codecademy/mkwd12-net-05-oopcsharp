Dictionary<string, long> phoneBook = new Dictionary<string, long>()
{
    { "Bob", 71123123},
    { "Kate", 71553123},
    { "Paul", 71553188},
    { "Ana", 71577188},
    { "Jill", 71577198},
};

//THE KEYS IN A DICTIONARY MUST BE UNIQUE

Console.WriteLine("Enter a name");
string input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Invalid input");
}
else
{
    if (phoneBook.ContainsKey(input)) //check if the dictionary contains a record
    {
        Console.WriteLine($"The phone number of {input} is {phoneBook[input]}");
    }
    else
    {
        Console.WriteLine("No phone number found");
    }

    //second way
    //foreach (var item in phoneBook)
    //{
    //    if (item.Key.ToLower() == input.ToLower())
    //    {
    //        Console.WriteLine(item.Value); //phone number
    //        break;
    //    }
    //}

}


//if (phoneBook.ContainsKey(input.ToLower()))
//{
//    phoneBook[input.ToLower()]
//}

//jILl

//Create a PhoneBook Dictionary with 5 names and phone numbers. 
//Through the console ask the person to enter a name.
//Try and find that names phone number in your PhoneBook
//If you can find it, print it in the console
//If you can’t, print an error message

Dictionary<string, long> phoneBook = new Dictionary<string, long>() //the phone number could be a very big number
{
    {"Bob", 070123123 }, //the leading 0 will not be printed; if we want to see the 0, we need to use it as a string
    {"John", 070456456 },
    {"Ana", 071789987 },
    {"Kate", 072753357 }
};

//THE KEYS IN A DICTIONARY MUST BE UNIQUE!
Console.WriteLine("Enter a name:");
string input  = Console.ReadLine(); //if we only click ENTER it will have a value of an empty string

//if(input == null || input == '' //'' means empty string
//'' != ' ' //the first one is an empty string and the second one is space character
if (string.IsNullOrEmpty(input)) //check if the input is an empty string or a null value for validation
{
    Console.WriteLine("Invalid input");
}
else
{
    if (phoneBook.ContainsKey(input)) //check if the dictionary contains a recors with a key that is the same as the input
    {
        //we cannot use .Value for printing the value, because we do not have the concrete element
        //we only have the whole dictionary and the key(the input)
        Console.WriteLine($"The phone number of {input} is {phoneBook[input]}"); //get the value using the input as the key
    }
    else
    {
        Console.WriteLine("No phone number found");
    }


    //SECOND WAY
    //foreach (var phone in phoneBook)
    //{
    //    if(phone.Key.ToLower() == input.ToLower())
    //    {
    //        Console.WriteLine(phone.Value); //we can use .Value because we have a concrete item from the dictionary
    //        break;
    //    }
    //}
}
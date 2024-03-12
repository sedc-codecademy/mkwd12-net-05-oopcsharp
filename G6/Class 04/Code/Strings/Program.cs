//=========STRINGS============

string message = "We are learning about strings";
string academy = "SEDC";

//Concatenation
string firstMessage = "Welcome to " + academy;
Console.WriteLine(firstMessage);

string secondMessage = $"Welcome to {academy}";
Console.WriteLine(secondMessage);

int year = 2024;
string thirdMessage = $"Welcome to {academy} in {year} year";
Console.WriteLine(thirdMessage);

//formatting strings
string fourthMessage = string.Format("Welcome to {0} in {1} year!", academy, year);
Console.WriteLine(fourthMessage);

//Escape 
//we use \ as an escape character
string firstString = "Check your c:\\drive";
Console.WriteLine(firstString);

string secondString = "We have \"fair\" elections"; //we want to print out the " so we use the escape character infront 
Console.WriteLine(secondString);

//new line

string stringWithNewLine = "This is first line.\n This is second line";
Console.WriteLine(stringWithNewLine);

//we can use @ to escape special charcters in the whole string

string driveMessage = @"Check your c\:drive and D:\drive"; // same as:  "Check your c:\\drive and D:\\drive"
Console.WriteLine(driveMessage);

string quotesString = @"These are ""fair"" elections"; //when we have " we need to unescape them with another "
Console.WriteLine(quotesString);


string percentString = string.Format("{0:P} participated in the elections", 0.57);
Console.WriteLine(percentString);

string phoneNumber = string.Format("{0:+389##-###-###}", 70123456);
Console.WriteLine(phoneNumber);

string stringWithN = @"Hello world.\nThis is G6.";
string replacedString = stringWithN.Replace("\\n", "\n");
Console.WriteLine(replacedString);
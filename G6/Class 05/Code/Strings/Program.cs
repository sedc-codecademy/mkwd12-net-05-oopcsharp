//=========STRINGS============

using System.Globalization;

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
string fourthMessage = string.Format("Welcome to {0} in {1} year {0}!", academy, year);
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

string stringWithN = @"Hello world.\nThis is G6."; //Hello world.\\nThis is G6
string replacedString = stringWithN.Replace("\\n", "\n");
Console.WriteLine(replacedString);

//=======STRING METHODS==========
string ourString = "     We are learning C# and it is FUN and EASY. Okay maybe just FUN.       ";

string lowerCaseString = ourString.ToLower(); //all characters to lower case
string upperCaseString = ourString.ToUpper(); //all characters to upper case

Console.WriteLine($"ourString: {ourString}");
Console.WriteLine($"lowerCaseString {lowerCaseString}");
Console.WriteLine($"upperCaseString {upperCaseString}");

Console.WriteLine($"upperCaseStringLowered {upperCaseString.ToLower()}");

//Length
Console.WriteLine("The length of our string is: " + ourString.Length);
string[] splittedString = ourString.Split('.');
Console.WriteLine(splittedString.Length);
Console.WriteLine(splittedString[0]);
Console.WriteLine(splittedString[2]);
Console.WriteLine(splittedString[1]);

string stringWithDots = "Hello. from. SEDC";
string replacesStringWithoutDots = stringWithDots.Replace(".", "");
string replacesStringWithQuestionMarks = stringWithDots.Replace(".", "?");
Console.WriteLine(stringWithDots);
Console.WriteLine(replacesStringWithoutDots);
Console.WriteLine(replacesStringWithQuestionMarks);

string test = "Test";
bool startsWithTe = test.StartsWith("Te"); //we can send as many characters as we want to check ex: Te or T or Tes
Console.WriteLine(startsWithTe); //true
bool startsWithte = test.StartsWith("te");
Console.WriteLine(startsWithte); //false
bool startsWithTeWithSpace = test.StartsWith("Te ");
Console.WriteLine(startsWithTeWithSpace); //false
bool startsWithF = test.StartsWith("F");
Console.WriteLine(startsWithF); //false

string te = "Te";
bool startsWithVariable = test.StartsWith(te);
Console.WriteLine(startsWithVariable); //true

int indexOfFun = ourString.IndexOf("FUN"); //returns the first occurence of FUN
int indexOfJS= ourString.IndexOf("JS"); //returns -1

Console.WriteLine(indexOfFun);
Console.WriteLine(indexOfJS);

bool containsFUN = ourString.Contains("FUN"); //returns true or false, wheter FUN is found in ourString
bool containsJS = ourString.Contains("JS"); //returns true or false, wheter JS is found in ourString

Console.WriteLine(containsFUN);
Console.WriteLine(containsJS);

string trimmedString = ourString.Trim();
Console.WriteLine($"ourString: {ourString}");
Console.WriteLine($"trimmedString: {trimmedString}");

string substring = ourString.Substring(5, 16); //take the substring starting from index 5 and next 16 characters
Console.WriteLine(substring);

string[] words = "We are learning C# at SEDC".Split(" ");

foreach(string word in words)
{
    Console.WriteLine(word);
}

char[] chars = ourString.ToCharArray();

foreach (char c in chars)
{
    Console.WriteLine(c);
}

//Concatenation

string academy = "Qinshift";
string greeting = "Welcome to " + academy;
Console.WriteLine(greeting);

//interpolation
string secondGreeting = $"Welcome to {academy}";
int year = 2024;
string thirdGreeting = $"Welcome to {academy} - {year}";
Console.WriteLine(thirdGreeting);

//format
string fourthGreeting = string.Format("Welcome to {0} - {1}", academy, year);
Console.WriteLine(fourthGreeting);

string checkMessage = "Check your C:\\ drive";
string electionsMessage = "We have \"fair\" elections";

Console.WriteLine(checkMessage);
Console.WriteLine(electionsMessage);

string checkDrivesMessage = @"Check your C:\ drive and your D:\ drive";
Console.WriteLine(checkDrivesMessage);

//combination of escaping characters and string interpolation
string exampleMessage = $@"Check your C:\ drive and your D:\ drive in {year}";
Console.WriteLine(exampleMessage);

//new line
string messageWithNewLine = $"Welcome to {academy}. \n It is year {year}";
Console.WriteLine(messageWithNewLine);

string percentString = string.Format("{0:P} particated in the elections", 57);
Console.WriteLine(percentString);

string phoneNumber = string.Format("{0:+389##-###-###}", 71856848);
Console.WriteLine(phoneNumber);

Console.WriteLine("===string methods====");
string message = "Welcome to Qinshift Academy";
string lowerCaseString = message.ToLower();
string upperCaseString = message.ToUpper();

Console.WriteLine(lowerCaseString);
Console.WriteLine(upperCaseString);

string explanation = "We are learning C#.It is fun and easy. We can't wait for advanced concepts";
string[] splittedStrings = explanation.Split('.');
foreach(string item in splittedStrings)
{
    Console.WriteLine(item);
}

bool startsWith = explanation.StartsWith("We");
Console.WriteLine(startsWith);

int indexOfFun = explanation.IndexOf("fun");
Console.WriteLine();

//start from index 19 in explanation and take the next 10 characters
string substring = explanation.Substring(19, 10);
Console.WriteLine(substring);

bool areEqual = " some message " == "some message";
Console.WriteLine(areEqual);

//removes blank spaces at the beginning and at the end
string trimmedMessage = " some message ".Trim();

string sentence = "";
string defaultString = null;

//check if a string has value
bool stringIsNullOrEmpty = string.IsNullOrEmpty(sentence);
Console.WriteLine(stringIsNullOrEmpty);


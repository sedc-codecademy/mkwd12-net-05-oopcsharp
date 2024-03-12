//    Excercise 1
//    You are given the following string "The whole group of G6 loves C#.They find learning this language fun and easy!".
//    Print the text after the ".", using string methods.

string message = "The whole group of G6 loves C#.They find learning this language fun and easy!";

//FIRST WAY
int indexOfDot = message.IndexOf('.');
if (indexOfDot == -1)
{
    Console.WriteLine("Dot was not found!");
}
else
{
    string substring = message.Substring(indexOfDot + 1);
    Console.WriteLine(substring);
}

//Second Way
string[] subStrings = message.Split(".");
if (subStrings.Length > 1)
{
    Console.WriteLine(subStrings[1]);
}
else
{
    Console.WriteLine("Dot was not found!");
}

Console.ReadLine();



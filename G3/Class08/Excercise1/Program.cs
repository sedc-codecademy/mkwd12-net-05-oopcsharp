Console.WriteLine("Hello, World!");

//    Excercise 1
//    You are given the following string "The whole group of G3 loves C#.
//    They find learning this language fun and easy!".
//    Print the text after the ".", using string methods.

string message = "The whole group of G3 loves C3 The find learning this language fun and easy";

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

//SECOND WAY
string[] substrings = message.Split('.');
if(substrings.Length > 1)
{
    Console.WriteLine(substrings[1]);
}
else
{
    Console.WriteLine("Dot was not found!");
}

Console.ReadLine();



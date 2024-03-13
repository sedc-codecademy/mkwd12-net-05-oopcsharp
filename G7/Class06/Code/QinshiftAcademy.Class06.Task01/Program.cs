string message = "The whole group of G2 loves C#.They find learning this language fun and easy!";
//FIRST WAY
int indexOfDot = message.IndexOf(".");
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
string[] subStrings = message.Split(".");
if (subStrings.Length > 1)
{
    Console.WriteLine(subStrings[1]);
}
else
{
    Console.WriteLine("Dot was not found!");
}
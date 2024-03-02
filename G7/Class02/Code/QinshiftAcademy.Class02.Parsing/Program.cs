Console.WriteLine("Enter your name");

string name = Console.ReadLine();

Console.WriteLine("Hello " + name);

//the input that we get from Console.ReadLine is always a string. If we want to save it, it must be in a string variable
string number = Console.ReadLine();
Console.WriteLine(number);

string intString = "5";
string doubleString = "2.5";

//1. FIRST WAY - USING PARSE

int parsedInt = int.Parse(intString);
Console.WriteLine(parsedInt);

//ERROR
//int anotherParsedInt = int.Parse("some string");
//Console.WriteLine(anotherParsedInt);

double parsedDouble = double.Parse(doubleString);
Console.WriteLine(parsedDouble);

//2. SECOND WAY - CONVERT

int convertedInt = Convert.ToInt32(intString);
Console.WriteLine("convertedInt: " + convertedInt);

//ERROR
//int anotherConvertedInt = Convert.ToInt32("test");
//Console.WriteLine(anotherConvertedInt);

double convertedDouble = Convert.ToDouble(doubleString);
Console.WriteLine("convertedDouble: " + convertedDouble);

//3 THIRD WAY - TRY PARSE

Console.WriteLine("====Third way=====");

int tryParsedIntValue;
bool didParseSucceed = int.TryParse(intString, out tryParsedIntValue);

Console.WriteLine(tryParsedIntValue);

double tryParsedDoubleValue;

bool didDoubleParseSucceed = double.TryParse("Test", out tryParsedDoubleValue);
Console.WriteLine(didDoubleParseSucceed);
Console.WriteLine(tryParsedDoubleValue);
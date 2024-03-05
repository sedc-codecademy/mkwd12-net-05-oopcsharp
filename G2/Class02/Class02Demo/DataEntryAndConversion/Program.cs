// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Data Entry
Console.Write("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);

var number = Console.ReadLine();
Console.WriteLine("The type of the number input is " + number.GetType());
#endregion

// *NOTE* Everything we get as an input from COnsole.Readline() is of type string !!!

#region Conversion

string numberString = "2";
string doubleString = "3.5";

// 1) converting with Convert
int convertInt = Convert.ToInt32(numberString);
double convertDouble = Convert.ToDouble(doubleString);
Console.WriteLine(convertInt + convertDouble); // 5.5

// 2) converting with Parse
int parseInt = int.Parse(numberString);
double parseDouble = double.Parse(doubleString);

// 3) converting with *TryParse*

Console.Write("Enter number:");
string inputNumber = Console.ReadLine();
//int parsedInputNumber = int.Parse(inputNumber);
// will get runtime error if the input is not a valid number
// ERROR: System.FormatException: 'Input string was not in a correct format.'

//int parsedValue;
// if TryParse is successfull we will put the converted value in parsedValue variable
// we create boolean variable (isParsed) that will keep info if the parsing was done or not
//bool isParsed = int.TryParse(inputNumber, out parsedValue); // here we use predefined variable to store the parsed value
bool isParsed = int.TryParse(inputNumber, out int parsedNumber); // here we declare the variable when the value is parsed


Console.WriteLine(isParsed);
Console.WriteLine(parsedNumber);

if (isParsed)
{
    Console.WriteLine("Successfully parsed number");
}
else
{
    Console.WriteLine("You've entered invalid number!");
}


#endregion

Console.ReadLine();
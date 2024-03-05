//=======Type.parse(value)=======

string numberString = "20";

//int.parse will fail on any input besides a valid int string (any text string, null..)
int parsedString = int.Parse(numberString); 
Console.WriteLine("parsedString: " + parsedString);

double parsedDouble = double.Parse("92.5");
double parsedNumberDouble = double.Parse(numberString);
Console.WriteLine("parsedNumberDouble: " + parsedNumberDouble);
Console.WriteLine("parsedDouble: " + parsedDouble);

string wrongString = "G6";
//int wrongStringParsed = int.Parse(wrongString);

//int parseNull = int.Parse(null); //it does not work with null value

//======Convert.ToType(value)=======

int number = Convert.ToInt32(numberString);
Console.WriteLine("number: " + number);

int nullNumber = Convert.ToInt32(null); //with null value it returns 0
Console.WriteLine("nullNumber: " + nullNumber);

//int wrongNumber = Convert.ToInt32(wrongString);
//Console.WriteLine("wrongNumber: " + wrongNumber);

//====Try parse=======

int parsedValue;
//in success we will store if the parsing was successful or not
//in parsedValue we will have the result from the parse
bool success = int.TryParse("30", out parsedValue);
Console.WriteLine("parsedValue: " + parsedValue);
Console.WriteLine("success: " + success);


int secondParsedValue;
bool secondSuccess = int.TryParse("test", out secondParsedValue);
Console.WriteLine("secondParsedValue: " + secondParsedValue);
Console.WriteLine("secondSuccess: " + secondSuccess);

int inputParsedValue;
Console.WriteLine("Enter your group number");
string input = Console.ReadLine();
bool inputSuccess = int.TryParse(input, out inputParsedValue);

if (inputSuccess)
{
    Console.WriteLine("Hello from G" + inputParsedValue);
}
else
{
    Console.WriteLine("Wrong input! You didn't enter a number");
}

//===Switch====
int day = 3;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Work day,but it isn't Monday");
        break;
    case 6:
    case 7:
        Console.WriteLine("It's the weekend!");
        break;
    default:
        Console.WriteLine("Invalid value! Enter a number between 1 and 7");
        break;
}
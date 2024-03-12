
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("We will be working with data types");

//we must decalre the type of data that the variable will hold

int ourFirstIntVariable = 5; //declaration and initialization
int ourSecondIntVariable; //declaration

long ourLongVariable = 4564564564;
long secondLongVariable = 8485834758347;

//reinitialization
ourFirstIntVariable = 10;
//initialize
ourSecondIntVariable = 789;

//this is an error, the data type of the value doesn't match the data type of the variable
//ourLongVariable = true; ERRROR!

Console.WriteLine("Value of ourFirstIntVariable:");
Console.WriteLine(ourFirstIntVariable);
Console.WriteLine("Value of ourLongVariable:");
Console.WriteLine(ourLongVariable);


//DECIMALS
float ourFirstFloatVariable = 2.5F;
double ourFirstDoubleVariable = 2.5;

//CHARACTERS AND STRIGNS
char letterAsChar = 'H';
char digitAsChar = '4';

string message = "Hello from our Console App";

//BOOL
bool ourFirstBoolVariable = true;

int sum = 5 + 3;

sum += 10; // sum = sum + 10;
sum++; //sum = sum + 1;
sum--; // sum = sum - 1;

Console.WriteLine("The value of sum is:");
Console.WriteLine(sum);


bool resultOfIntComparison = (ourFirstIntVariable == ourSecondIntVariable);
Console.WriteLine("resultOfIntComparison: " + resultOfIntComparison);

bool isFirstNumberLarger = ourLongVariable > secondLongVariable;

//assign a value of one variable to another one

int firstNumber = 10;
int secondNumber = firstNumber;

//secondNumber = isFirstNumberLarger; ERROR - they are of different data type


//DEFAULT VALUES

int intWithoutExplicitValue; //0
double defaultDoubleVariable; //0

bool ourDefaultBoolVariable; //false

//Console.WriteLine(intWithoutExplicitValue); ERROR use of unassigned variable

string anotherMessage; //null

string stringWithNullValue = null;

//WE CAN NOT USE UNASSIGNED VARIABLES!!!

//WE CAN ASSIGN DEFAULT VALUES
int myDefaultIntVariable = default; //0
Console.WriteLine(myDefaultIntVariable);

string myDefaultString = default; //null

bool myDefaultBool = default; // false

double myDefaultDouble = default; //0


Console.WriteLine("====Exercise 1 ======");
double firstDouble = 10.2;
double secondDouble = 3.5;

//the result of division of two numbers where at least one is double is saved into a double, is of type double
double doubleDivisionResult = firstDouble / secondDouble;
Console.WriteLine("Result of division of two doubles:");
Console.WriteLine(doubleDivisionResult);

int firstInteger = 12;
int secondInteger = 3;

int firstResultOfIntDivision = firstInteger / secondInteger;
Console.WriteLine("Value of firstResultOfIntDivision: ");
Console.WriteLine(firstResultOfIntDivision);

//when both of the operands in divison are integers ( whole numbers) the result holds just the whole part of the division result
int secondResultOfIntDivision = secondInteger / firstInteger;
Console.WriteLine(secondResultOfIntDivision);

//in order to get the whole decimal result of the division
//at least one of the operands must be a double

double thirdDouble = 12;
double fourthDouble = 3;

double result = fourthDouble / firstInteger;
double secondResult = fourthDouble / thirdDouble;
Console.WriteLine(secondResult);


Console.WriteLine("====Exercise 2====");

string firstPartOfMessage = "Hello";
string secondPartOfMessage = "Qinshift";

string wholeMessage = firstPartOfMessage + " " + secondPartOfMessage;
Console.WriteLine(wholeMessage);

string numberNineString = "9";
string numberThreeString = "3";

//when used with strings plus is used for concatenation
string concatenatedResult = numberNineString + numberThreeString; //93
Console.WriteLine(concatenatedResult);

Console.WriteLine("====Exercise 3====");

//when using the plus operator with values, where at least one is a string, the result is a concatenated string
int ourNumber = 12;
string ourStringNumber = "3";

string differentDatatYpesConcatenation = ourNumber + ourStringNumber;
Console.WriteLine(differentDatatYpesConcatenation);

Console.WriteLine("====Exercise 4===");
int numberOfCredits = 102;
int numberOfCreditsPerSms = 5;

int numberOfSmsMessages = numberOfCredits / numberOfCreditsPerSms;
Console.WriteLine("The number of messages we can send is: " + numberOfSmsMessages);


string input = Console.ReadLine();
Console.WriteLine(input);
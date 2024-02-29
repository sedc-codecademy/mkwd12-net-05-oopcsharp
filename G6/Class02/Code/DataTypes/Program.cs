Console.WriteLine("Data types:");

//Whole numbers
int firstIntVariable = 5555; //declaration and initialization
Console.WriteLine("firstIntVariable: " + firstIntVariable); //concatenation

short firstShortVariable = 6;
Console.WriteLine($"firstShortVariable: {firstShortVariable} firstIntVariable: {firstIntVariable}!"); //interpolation

//int firstIntVariable = 444; //Error, cannot declare a variable with the same name

//reinitialization - we can change the value of the variable
firstIntVariable = 77;
Console.WriteLine("firstIntVariable: " + firstIntVariable);

//Decimal numbers
float firstFloatVariable = 1.567f; //we need to use f to make the number from type float
Console.WriteLine("firstFloatVariable: " + firstFloatVariable);

double firstDoubleVariable = 2.456;
Console.WriteLine("firstDoubleVariable: " + firstDoubleVariable);

char firstCharVariable = 'a'; //chars are always written in single quotes!!
Console.WriteLine("firstCharVariable: " + firstCharVariable);

string message = "Hello from Qinshift Academy"; //strings are always written in double quotes!!
Console.WriteLine("message: " + message);

string singleCharacterString = "a"; //we can have only one character in string, the number of character is not limited
//char multuipleCharactersChar = 'ab'; //this is not allowed

bool firstBool = true;
bool secondBool = false;

int number; //declaration
number = 5; //initialization
number = 10;
//number = "Hello"; //Error

//Implicitly typed variables take the type of the value that is first given to the variable!
var secondNumber = 8;  //int secondNumber = 8;

//secondNumber = "Hello"; //this is not allowed, secondNumber is of type int

DateTime date = DateTime.Now;
Console.WriteLine("today: " + date);

//Operators
int sum = 5 + 5;
Console.WriteLine("sum: " + sum);

sum += 90;
Console.WriteLine("sum: " + sum);

//Console.WriteLine("a: " + a);//cannot use a here
int a;
//Console.WriteLine("a: " + a); //still cannot use a here
a = 2;
Console.WriteLine("a: " +  a); //we can use use a now

sum++; //sum = sum + 1; sum +=1;

int secondSum = sum; //we can use the value of another variable if it is from the same type
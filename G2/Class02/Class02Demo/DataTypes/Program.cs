// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello students from G2 :)");

/*  DataTypes in C#
 
    1. Integer types (Whole numbers)
        => *byte*: 8-bit unsigned integer (0 to 255)
        => *short*: 16-bit signed integer (-32,768 to 32,767)
        => *int*: 32-bit signed integer (-2,147,483,648 to 2,147,483,647)
        => *long*: 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)

    2. Floating-Point numbers (numbers with fractional point)
        => *float*: 32-bit single-precision floating-point type
        => *double*: 64-bit double-precision floating-point type
        => *decimal*: 128-bit decimal type for financial and monetary calculations

    3. Boolean
        => bool: (true or false)

    4. Character
        => char: represents a single 16-bit Unicode character

    5. String
        => string: sequence of characters (text)

    6. DateTime, object, dynamic etc...
 */

#region Data Types & Variables

// 1) NUMBER TYPES

// Variable declaration
//int number;
// Variable initialization
//number = 100;
// Declaration and initialization
int number = -100;

// SYNTAX: [typeOfTheValue] [nameOfTheVariable] = [value];

//int integerVariable2 = 233.23423; // Syntax (Compile-time) error: "Cannot implicitly convert type double to int"
long hugeInt = 2_147_483_648; // the underscore _ is used only for better readability

double doubleVariable = -23432.34433;

float floatVariable = 23.233223f;
decimal decimalVariable = 34343.34343m;


// 2) TEXT TYPES (string, char)
string predmet = "C# Basic";
Console.WriteLine(predmet);

//string novString = 'Hello from Quinshift Academy'; // ERROR
// NOTE: 
// strings must be written in DOUBLE QUOTES ("")
// characters must be written in SINGLE QUOTES ('')
char characterVariable = 'a';
//char characterVariable2 = "a"; // ERROR


// 3) BOOLEAN
bool booleanVariable = false;


// Q: SO, WHY IS C# STRONGLY TYPED LANGUAGE ???
//predmet = 1231231; // error
//booleanVariable = "string vrednost // error

// *** Once a variable is declared with a certain data type, it cannot be reassigned to a variable from different type ***

// => Implicitly typed variables take the type of the assigned value
var num = 33; // here num is of type int
//num = "nekoj tekst"; // error
// NOTE: Don't use var througout this course ! :)

#endregion

#region Operations
int sum = 2 + 6;
sum += 12; // sum = sum + 12
sum++; // sum = sum + 1

Console.WriteLine(sum); // 21
Console.WriteLine(sum++);
Console.WriteLine(sum++); 
Console.WriteLine(++sum);
// ++num => first increment then use the value
// num++ => first use the value then increment it

bool isLarger = 6 > 12 && 4 > 2;
Console.WriteLine(isLarger);

string stringConcatenation = "Hello" + " " + "G2 students!";

#endregion

#region Default Values and Null
// => default keyword provides a default value of a type

int numOne = default;
double doubleVariableTwo = default;
long longVariableTwo = default;
Console.WriteLine(numOne); // 0
Console.WriteLine(doubleVariableTwo); // 0
Console.WriteLine(longVariableTwo); // 0

bool defaultBoolean = default;
Console.WriteLine(defaultBoolean); // false

char defaultChar = default; // Null character

string defaultString = default;  // Null

#endregion

Console.ReadLine();
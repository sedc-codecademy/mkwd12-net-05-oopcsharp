Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n=============== STRINGS ===============\n\n");
Console.ResetColor();

#region String Concatenation
Console.WriteLine("\n\n============= String Concatenation =============\n");

// Normal strings
string firstName = "Bob";
string lastName = "Bobsky";

// String concatenation

// 1) using '+' operator
string hello1 = "Hello " + firstName + " " + lastName;
// 2) using string.Format
string hello2 = string.Format("Hello {0} {1}", firstName, lastName);
// 3) using string.Concat
string hello3 = string.Concat("Hello ", firstName, " ", lastName);
// 4) using *String Interpolation* // GREAT !
string hello4 = $"Hello {firstName} {lastName}";
// 5) using StringBuilder (only for info, will be explained in detail in the next subject)

Console.WriteLine(hello1);
Console.WriteLine(hello2);
Console.WriteLine(hello3);
Console.WriteLine(hello4);

Console.ReadLine();
#endregion


#region String Formatting
Console.WriteLine("\n\n============= String Formatting ===/==========\n");

// *Currency formatting*
//string currency = string.Format("Price {0}", 123.43);
//string currency = string.Format("Price {0:C}", 123.43);
string currency = string.Format("Price {0:C1}", 123.43);
Console.WriteLine(currency);

// *Percent formatting*
//string percent = string.Format("{0:P}", 0.5); // 50.00%
string percent = string.Format("{0:P0}", 0.5); // 50%
Console.WriteLine(percent);

// *Custom formatting*
string customPhoneNumberFormat = string.Format("Phone {0:0##-###-###}", 078223305);
Console.WriteLine(customPhoneNumberFormat);

int number = 1_234_567;
Console.WriteLine(number); // 1234567
Console.WriteLine(string.Format("Number format: {0:#,##0}", number)); // 1,234,567 

#endregion


#region Escaping Reserved Characters
Console.WriteLine("\n\n============= Escaping Reserved Characters =============\n");
Console.ReadLine();
//Console.WriteLine("Check your c:\ drive"); // error
//Console.WriteLine("We will have "fair" elections"); // error
//Console.WriteLine("The \n sign means: new line"); // sign means.... will be printed in new line

// Reserved Characters in C#: \, \n, \t, ", \a, etc...

// 1) Escaping with "\" (backslash)
string escape1 = "Check your c:\\ drive";
string escape2 = "We will have \"fair\" elections";
string escape3 = "The \\n sign means: new line";

// 2) Escaping a whole string with "@"
escape1 = @"Check your c:\ drive";
escape2 = @"We will have ""fair"" elections";
//escape2 = @"We will have 'fair' elections"; 
escape3 = @"The \n sign means: new line";

Console.WriteLine(escape1);
Console.WriteLine(escape2);
Console.WriteLine(escape3);
#endregion


#region ToString()
Console.WriteLine("\n\n============= ToString() =============\n");

int someNumber = 1234;

// => Convert other datatypes to string
string convertedNumber = someNumber.ToString();

// => Using ToString for formatting
string formatedString = someNumber.ToString("#,##0");
Console.WriteLine(formatedString);

#endregion


#region String Methods
Console.WriteLine("\n\n============= String Methods =============\n");

string ourTestString = "    We are learning C#. It is FUN and EASY. Okay maybe just FUN.    ";

// 1) *ToUpper* & *ToLower
// => Makes our string Upper/Lower Case
string lower = ourTestString.ToLower();
string upper = ourTestString.ToUpper();
Console.WriteLine(lower);
Console.WriteLine(upper);

// 2) Length (property)
// => Prints the length of our string
Console.WriteLine(ourTestString.Length);

// 3) *Split*
// => Splits the string and makes an array of strings (splits on character selected)
string[] splitted = ourTestString.Split('.');
Console.WriteLine(splitted[0]);
Console.WriteLine(splitted[1]);
Console.WriteLine(splitted[2]);

// 4) *Join*
// => Concatenates the members of a collection (array), using the specified separator between each member
string joinedString = string.Join(".(PERIOD)", splitted);
Console.WriteLine(joinedString);

string testString = "This is a test string";
string[] splittedTestString = testString.Split(" ");
string joinedTestString = string.Join("-", splittedTestString);
Console.WriteLine(joinedTestString);

// 5) *Contains*
// => Checks if a string contains some character or substring
bool containsString = ourTestString.Contains("rning");
Console.WriteLine(containsString); // true
Console.WriteLine(ourTestString.Contains("blabla")); // false

// 6) *Substring*
// => Cuts the string in to a substring that starts from index 5 and takes the next 16 characters
string substring = ourTestString.Substring(6);
Console.WriteLine(substring);
substring = ourTestString.Substring(7, 14);
Console.WriteLine(substring);

// 7) *string.IsNullOrEmpty* & *string.IsNullOrWhitespace*
// => checks if a string is 'null' or empty ("") | or consists of whitespace ("   ")
// => used for string validations
Console.WriteLine(string.IsNullOrEmpty("TEST")); // false
Console.WriteLine(string.IsNullOrEmpty("")); // true
Console.WriteLine(string.IsNullOrWhiteSpace("")); // true
Console.WriteLine(string.IsNullOrEmpty("    ")); // false
Console.WriteLine(string.IsNullOrWhiteSpace("   ")); // true

// 8) *Replace*
// => returns a new string in which all occurences of the specified string is replaced with string value
string replaceCSharp = ourTestString.Replace("C#", "C# Basic");
Console.WriteLine(replaceCSharp);

// 9) Trim
// => It trims the white spaces at the front and back of the string
string trimmedString = ourTestString.Trim();
Console.WriteLine(trimmedString);

// 10) StartsWith & EndsWith
// => Checks if a string starts with some string given and returns true or false
bool startsWith = ourTestString.StartsWith("   W");
Console.WriteLine(startsWith);

// 11) IndexOf 
// => Checks if a string exists and if so returns an index, if not -1
int indexOfString = ourTestString.IndexOf("FUN");
int nonExistingString = ourTestString.IndexOf("Nope");
Console.WriteLine(indexOfString);
Console.WriteLine(nonExistingString);

// 12) ToCharArray
// => Creates an array of characters with every character from our string
char[] chars = ourTestString.ToCharArray();
Console.WriteLine(chars.Length);
Console.WriteLine(chars[6]);
// => Two ways to turn char[] back to string
Console.WriteLine(string.Join("", chars));
Console.WriteLine(new string(chars));

#endregion

Console.ReadLine();
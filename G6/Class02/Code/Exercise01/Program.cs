//Declare two double variables
//Initialize them and divide them in a new variable
//Declare two integer variables
//Initialize them and divide them in a new variable
//Print the results in the console and compare

double firstDouble;
double secondDouble;
firstDouble = 5; //we can store this in a doubble (this is the same as 5.0)
secondDouble = 1.5;
double doubleResult = firstDouble / secondDouble;
Console.WriteLine(doubleResult);

int firstInt = 9;
int secondInt = 5;

int intResult = firstInt / secondInt;
Console.WriteLine("intResult: " + intResult);

//when we divide two whole numbers the result will be a whole number
double doubleIntResult = firstInt / secondInt;
Console.WriteLine("doubleIntResult: " + doubleIntResult);

//when we divide a whole number and a decimal number the result will be a decimal number
double differentTypesResult = firstInt / firstDouble;
Console.WriteLine("differentTypesResult: " + differentTypesResult);

//Extra - casting
double doubleIntCastResult = (double)firstInt / secondInt;
Console.WriteLine("doubleIntCastResult: " + doubleIntCastResult);
DateTime emptyDateTime = new DateTime();
Console.WriteLine(emptyDateTime);

DateTime specificDate = new DateTime(1999, 10, 5);
Console.WriteLine(specificDate);

DateTime dateAndTime = new DateTime(2024, 3, 1, 12, 39, 39);
Console.WriteLine(dateAndTime);


//date and time at the current time zone of the operating system that the app is being executed on
DateTime currentDateTime = DateTime.Now;
Console.WriteLine(currentDateTime);


//this is date and time without time zones, at the universal date and time, UTC time
DateTime universalDateTime = DateTime.UtcNow;
Console.WriteLine(universalDateTime);

DateTime parsedDate = DateTime.Parse("02/26/2024");
Console.WriteLine(parsedDate);

int currentYear = DateTime.Now.Year;
Console.WriteLine(currentYear);

int monthFromParsedDate = parsedDate.Month;
Console.WriteLine(monthFromParsedDate);

DateTime dateFiveDaysAhead = DateTime.Now.AddDays(5);
Console.WriteLine(dateFiveDaysAhead);

//if we want to go in the past we pass a negative value to the Add[Something] methods
DateTime dateTimeOneYearAgo = DateTime.Now.AddYears(-1);
Console.WriteLine(dateTimeOneYearAgo);

string formattedDate = DateTime.Now.ToString("dddd.MMM.yyyy");
Console.WriteLine(formattedDate);

string secondFormattedDate = DateTime.Now.ToString("MM-ddd-yyyyy");
Console.WriteLine(secondFormattedDate);

string formattedDateAndTime = DateTime.Now.ToString("dddd.MMMM.yyyy HH:mm:ss");
Console.WriteLine(formattedDateAndTime);






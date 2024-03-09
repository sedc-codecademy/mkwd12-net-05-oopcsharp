//====DATE TIMES========

DateTime emptyDateTime = new DateTime();
Console.WriteLine(emptyDateTime);

//create DateTime with current Date and time (local date and time, from the server)
DateTime currentDateTime = DateTime.Now;
Console.WriteLine("current date time: "+currentDateTime);

DateTime specificDate = new DateTime(1999, 07, 28);
Console.WriteLine(specificDate);

//year month day hour minute seconds
DateTime anotherDateTime = new DateTime(2021, 9, 6, 12, 34, 45);
Console.WriteLine(anotherDateTime);

//parse the date string. pass a string in the format for dates from the server
//ex: on my laptop is month/day/year
DateTime parsedDate = DateTime.Parse("03/26/2024");
//DateTime wrongFormatParsedDate = DateTime.Parse("26/03/2024"); //this won't work on my server (my laptop)
Console.WriteLine(parsedDate);
//Console.WriteLine(wrongFormatParsedDate)

DateTime universalDateTime = DateTime.UtcNow;
Console.WriteLine("utc: "+ universalDateTime);

int day = currentDateTime.Day;
Console.WriteLine($"current day: {day}");

int month = currentDateTime.Month;
Console.WriteLine($"current month: {month}");

var dayOfWeek = currentDateTime.DayOfWeek;
Console.WriteLine($"dayOfWeek: {dayOfWeek}");

int year = DateTime.Now.Year;
Console.WriteLine($"current year: {year}");

DateTime firstDateTime = new DateTime(2000, 2, 3, 15, 55, 20);
DateTime secondDateTime = new DateTime(2024, 5, 3, 13, 45, 20);

//difference is of type TimeSpan
var difference = secondDateTime - firstDateTime;
Console.WriteLine(difference);

int days = difference.Days;
int hours = difference.Hours;
int minutes = difference.Minutes;
Console.WriteLine($"Days {days} Hours: {hours} Minutes: {minutes}");

//get the date and time 5 days from now
DateTime fiveDaysAhead = DateTime.Now.AddDays(5);
Console.WriteLine(fiveDaysAhead);

//get the date time 5 days and 5 hours from now
DateTime fiveDaysAndfiveHoursFromNow = DateTime.Now.AddDays(5).AddHours(5);
//DateTime fiveDaysAndfiveHoursFromNow = fiveDaysAhead.AddHours(5);
Console.WriteLine(fiveDaysAndfiveHoursFromNow);

//get the date and time 2 years and 3 months ago

DateTime twoYearsAndThreeMonthsAgo = DateTime.Now.AddYears(-2).AddMonths(-3);
Console.WriteLine(twoYearsAndThreeMonthsAgo);

//get date and time 3 years and 1 month ago
DateTime threeYearsAndOneMonthAgo = DateTime.Now.AddYears(-3).AddMonths(-1);
Console.WriteLine(threeYearsAndOneMonthAgo);

//Formatting datetime to string
string formattedString = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(formattedString);

string anotherFormattedDate = DateTime.Now.ToString("dddd, dd MMMM yyyy");
Console.WriteLine(anotherFormattedDate);

string yetAnotherFormattedDate = DateTime.Now.ToString("MMMM dd");
Console.WriteLine(yetAnotherFormattedDate);

int a = 5;
string five = a.ToString();
Console.WriteLine();


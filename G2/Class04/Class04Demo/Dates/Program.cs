Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n=============== DATES ===============\n\n");
Console.ResetColor();

// Represents an instance in time, typically expressed as a date and time of day
// Usecases:
// 1) Logging
// 2) Scheduling tasks
// 3) Data Tracking
// 4) Adding unique timestamps etc...

#region Creating DateTime
Console.WriteLine("============= Creating DateTime =============\n");

// 1) Creating an empty DateTime
DateTime emptyDate = new DateTime();
Console.WriteLine(emptyDate);

// 2) Creating a custom date          
DateTime customDate = new DateTime(1994, 5, 20);
Console.WriteLine(customDate);

// 3) Creating a DateTime with the current Date
DateTime currentDay = DateTime.Today;
Console.WriteLine(currentDay);

// 4) Creating a DateTime with the current Date and Time
DateTime currentDateAndTime = DateTime.Now;
Console.WriteLine(currentDateAndTime);
//Console.WriteLine(DateTime.UtcNow); // UTC => Coordinated Universal Time

Console.ReadLine();
#endregion


#region Parsing
Console.WriteLine("\n============= Parsing =============\n");
// => Converting from string to DateTime
// => Variations:
//string stringDate = "12.15.2012";
//string stringDate = "12/15/2012 11:14:34";
//string stringDate = "12/15/12";
//string stringDate = "dec.15.12";
string stringDate = "12-14-2020";
DateTime convertedDate = DateTime.Parse(stringDate);
Console.WriteLine(convertedDate);
#endregion


#region DateTime Properties
Console.WriteLine("\n============= DateTime Properties =============\n");
// Get current Date
Console.WriteLine(DateTime.Today);
// Get current Date and Time
Console.WriteLine(DateTime.Now);
// Get the number of the month from a DateTime
int month = currentDateAndTime.Month;
Console.WriteLine(month);
// Get the number of the day from a DateTime
int day = currentDateAndTime.Day;
Console.WriteLine(day);
// Get the number of the year from a DateTime
int year = currentDateAndTime.Year;
Console.WriteLine(year);

Console.WriteLine(currentDateAndTime.Minute);
Console.WriteLine(currentDateAndTime.DayOfWeek);
Console.WriteLine(currentDateAndTime.Ticks);
#endregion


#region DateTime Methods
Console.WriteLine("\n============= DateTime Methods =============\n");

// 1) Adding or removing days to a DateTime date
DateTime addedDays = currentDateAndTime.AddDays(2);
Console.WriteLine(addedDays);
DateTime removedDays = currentDateAndTime.AddDays(-5);
Console.WriteLine(removedDays);

// 2) Adding/Removing months to a DateTime date
DateTime addedMonths = currentDateAndTime.AddMonths(2);
Console.WriteLine(addedMonths);

// 3) Adding/Removing years to a DateTime date
DateTime addedYears = currentDateAndTime.AddYears(2);
Console.WriteLine(addedYears);

// 4) Adding/Removing hours to a DateTime date
DateTime addedHours = currentDateAndTime.AddHours(3);
Console.WriteLine(addedHours);

#endregion


#region Formatting Dates
Console.WriteLine("\n============= Formatting Dates =============\n");

string dateFormat1 = currentDateAndTime.ToString("MM/dd/yyyy");
string dateFormat2 = currentDateAndTime.ToString("MM/dd/yyyy HH:mm:ss");
string dateFormat3 = currentDateAndTime.ToString("dddd, dd MMMM yyyy");
string dateFormat4 = string.Format("Today is {0:MM/dd/yy}, {0:dddd}", currentDateAndTime);
string dateFormat5 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}", currentDateAndTime);
Console.WriteLine(dateFormat1);
Console.WriteLine(dateFormat2);
Console.WriteLine(dateFormat3);
Console.WriteLine(dateFormat4);
Console.WriteLine(dateFormat5);

string dateFormatInStringInterpolation = $"Today is {currentDateAndTime:dd MMMM}";
Console.WriteLine(dateFormatInStringInterpolation);
#endregion


#region Bonus
Console.WriteLine("\n============= BONUS =============\n");

// *** Comparing Dates ***
Console.WriteLine(DateTime.Now < DateTime.UtcNow);
Console.WriteLine(new DateTime(1995, 5, 5) == new DateTime(1995, 5, 5));

// *** Calculate time distance between two dates ***
DateTime dateInstance1 = DateTime.UtcNow;
DateTime dateInstance2 = DateTime.UtcNow.AddDays(3).AddHours(5.5);
// TimeSpan => represents a time interval
TimeSpan timeDifference = dateInstance2 - dateInstance1;
//TimeSpan timeDifference2 = dateInstance2.Subtract(dateInstance1); // same thing as above just using built-in method
Console.WriteLine($"The time differene between {dateInstance1:MM/dd/yyyy HH:mm:ss} and {dateInstance2:MM/dd/yyyy HH:mm:ss} is exactly {timeDifference.Days} days, {timeDifference.Hours} hours and {timeDifference.Minutes} minutes.");

// *** Other useful methods ***
Console.WriteLine(DateTime.UtcNow.ToShortDateString()); // 3/7/2024
Console.WriteLine(DateTime.UtcNow.ToLongDateString()); // Thursday, March 7, 2024
Console.WriteLine(DateTime.UtcNow.ToShortTimeString()); // 11:30 AM
Console.WriteLine(DateTime.UtcNow.ToLongTimeString()); // 11:30:52 AM
Console.WriteLine(DateTime.UtcNow.ToFileTime()); // 133542846524008581 // used as unique timestamp for some scenarios (for example timestamp in some file name)

#endregion

Console.ReadLine();

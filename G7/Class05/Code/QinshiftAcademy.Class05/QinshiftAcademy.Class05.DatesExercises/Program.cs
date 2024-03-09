//print the date that is 3 days from now
DateTime dateThreeDaysAhead = DateTime.Now.AddDays(3);
Console.WriteLine(dateThreeDaysAhead);

//print the date one month ahead
DateTime dateOneMonthAhead = DateTime.Now.AddMonths(1);
Console.WriteLine(dateOneMonthAhead);

//print the date that is one month and 3 days ahead
DateTime dateTimeOneMonthThreeDaysAhead = DateTime.Now.AddMonths(1).AddDays(3);
Console.WriteLine(dateTimeOneMonthThreeDaysAhead);

//date one year and two months ago
DateTime dateTimeOneYearTwoMonthsAgo = DateTime.Now.AddYears(-1).AddMonths(-2);
Console.WriteLine(dateTimeOneYearTwoMonthsAgo);

//current year
Console.WriteLine(DateTime.Now.ToString("yyyy"));

//current month
Console.WriteLine(DateTime.Now.ToString("MMMM"));

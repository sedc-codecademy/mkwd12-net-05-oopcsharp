//Print the date that is 3 days from now 
//Print the date that is one month from now
//Print the date that is one month and 3 days from now
//Print 1 year and 2 months ago from today
//Print only the current month of today
//Print only the current year of today

Console.WriteLine(DateTime.Now.AddDays(3));
Console.WriteLine(DateTime.Now.AddMonths(1));
Console.WriteLine(DateTime.Now.AddMonths(1).AddDays(3));
Console.WriteLine(DateTime.Now.AddYears(-1).AddMonths(-2));

Console.WriteLine(string.Format("{0:MMMM}", DateTime.Now));
Console.WriteLine(string.Format("{0:yyyy}", DateTime.Now));
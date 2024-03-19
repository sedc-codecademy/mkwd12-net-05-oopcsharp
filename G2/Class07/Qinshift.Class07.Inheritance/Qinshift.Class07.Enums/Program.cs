// See https://aka.ms/new-console-template for more information
using Qinshift.Class07.Enums.Enums;

Console.WriteLine("Hello, World!");

#region Methods
static void IsWeekend(Days day)
{
    if(day == Days.Saturday || day == Days.Sunday)
    {
        Console.WriteLine($"YEEEES. It's {day}");
    }
    else
    {
        Console.WriteLine($"NOOOOO!! It's {day}");

    }
}
#endregion


#region Using Enums
Days monday = Days.Monday;

IsWeekend(monday);
IsWeekend(Days.Sunday);
#endregion

#region Converting Enums
int num = 2;
Days dayTwo = (Days)num;
Console.WriteLine(dayTwo);

Days dayThree = Days.Wednesday;
int numThree = (int)dayThree; //3
Console.WriteLine(numThree);

Days dayFour = Days.Thursday;
string stringDay = dayFour.ToString(); // Thursday
Console.WriteLine(stringDay);

Console.WriteLine("Enter enum");
string input = Console.ReadLine();
if (Enum.TryParse(input, out Days inputDay))
{
    Console.WriteLine($"You enter enum: {inputDay}");
}
else
{
    Console.WriteLine("ERROR!!!!!");
}
#endregion
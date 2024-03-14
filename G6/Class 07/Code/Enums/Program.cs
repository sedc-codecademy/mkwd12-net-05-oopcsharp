using Enums;

int day = 5;

if(day == 5) //NOT A GOOD PRACTICE, NOT CLEAR
{
    Console.WriteLine("Yay it's Friday");
}

if(day == (int)DaysOfWeekEnum.Friday) //we need to convert enum to int so we can compare it
{
    Console.WriteLine("Yay it's Friday");
}

int roleNumber = 1;

if(roleNumber == (int)RoleEnum.Administrator)
{
    Console.WriteLine($"This is the {RoleEnum.Administrator.ToString()}");
}else if(roleNumber == (int)RoleEnum.User)
{
    Console.WriteLine($"This is the {RoleEnum.User.ToString()}");
}

//(int)RoleEnum.Administrator => this way we get the value (number value) of the enum => 1
//RoleEnum.Administrator.ToString() => this way we get the string value (the name) of the enum => Administrator

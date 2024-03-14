using QinshiftAcademy.Class07.Enums;

string role = "";

if (role == "Admin")
{

}

if (role == "Administrator")
{

}

if (role == "admin")
{

}

//because role variable is of type string, we must convert the member Admin of enum Role to string
//in order to compare
if(role == Role.Admin.ToString())
{

}

User user = new User();
user.FirstName = "Paul";
user.LastName = "Paulsky";
user.Role = Role.SuperAdmin;

//check if the user is an admin
//because property Role is of type enum Role, we can directly compare
if(user.Role == Role.Admin)
{

}

int day = 6;
//this is more readable
//we must convert the enum values to int in order to compare
if(day == (int)DaysOfWeek.Saturday || day == (int)DaysOfWeek.Sunday)
{

}

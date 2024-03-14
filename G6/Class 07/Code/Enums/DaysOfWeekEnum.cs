
namespace Enums
{
    public enum DaysOfWeekEnum //we change the class keyword with enum keyword
    {
        //if we don't specify the value the first enum will have value 0
        Monday = 1,
        Tuesday, //the next value will have (previous enum value + 1)
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}

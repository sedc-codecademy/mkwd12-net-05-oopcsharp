using System.Text;

namespace Class04_Exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
//            Print the date that is 3 days from now
//            Print the date that is one month from now
//            Print the date that is one month and 3 days from now
//            Print 1 year and 2 months ago from today
//            Print only the current month of today
//            Print only the current year of today


            DateTime now = DateTime.Now;

            DateTime threeDaysFromNow = now.AddDays(3);
            //DateTime threeDaysFromNow = DateTime.Now.AddDays(3);
            Console.WriteLine($"Three days from now: {threeDaysFromNow}");

            Console.WriteLine($"One month from now {now.AddMonths(1)}");

            Console.WriteLine($"Date that is one month and 3 days from now: {AddDaysAndMonthsFromNow(3, 1)}");

            Console.WriteLine($"Month: {now.Month}");
            string temp = now.ToString("MMMM");
            Console.WriteLine($"Month: {temp}");
            Console.WriteLine($"Year: {now.Year}");
        }

        //public - access modifier, defines from where this method can be accessed
        //static - because we want to use this method in the Main function, we define it as static (we will discuss about static later)
        //DateTime - return time, result that the method returns
        //AddDaysAndMonthsFromNow - name of the method
        //(int days, int months) - input parameters to the method, needs to be specified with the data type
        public static DateTime AddDaysAndMonthsFromNow(int days, int months)
        {
            DateTime now = DateTime.Now;

            return now.AddDays(days).AddMonths(months);
        } 
    }
}
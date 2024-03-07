using System.Globalization;
using System.Text;

namespace Class04_DateTime_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime date = new DateTime();
            DateTime date1 = new DateTime(2024, 3, 6);
            DateTime date2 = new DateTime(2024, 3, 6, 10, 30, 50);

            DateTime date3 = DateTime.Now;
            DateTime date4 = DateTime.UtcNow;

            DateTime date5 = date3.AddDays(30);

            Console.WriteLine(date5.DayOfWeek);

            DateTime date6 = date3.AddDays(-1);
            Console.WriteLine(date6.DayOfWeek);

            //format and printing
            Console.WriteLine(date3);
            Console.WriteLine(date3.ToString());

            Console.WriteLine(date3.ToString(new CultureInfo("en-US")));

            Console.WriteLine(date3.ToString("ddd*MMMM*yyyy HH-mm-ss zz"));

        }
    }
}
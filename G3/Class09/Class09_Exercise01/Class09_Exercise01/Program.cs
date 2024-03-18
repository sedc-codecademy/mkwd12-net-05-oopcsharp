using System.Globalization;

namespace Class09_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
            {
                { "Risto", "070123456"},
                { "Slave", "070123455"},
                { "Saso", "070123454"},
                { "Maja", "070123453"},
                { "Aleksandra", "070123452"},
            };

            while(true)
            {
                Console.Write("Please enter a name for search: ");
                string input = Console.ReadLine();

                bool phoneFound = phoneBook.TryGetValue(input, out string phone);

                if (!phoneFound)
                {
                    Console.WriteLine("The name was not found in the phone book");
                }
                else {
                    Console.WriteLine($"We found phone number: {phone}");
                }

                Console.Write("Enter y if you want to search once again: ");
                string choice = Console.ReadLine();

                if(!string.Equals(choice, "y", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
            }
        }
    }
}
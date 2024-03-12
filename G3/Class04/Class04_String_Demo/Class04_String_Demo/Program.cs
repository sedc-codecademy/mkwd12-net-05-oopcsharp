using System.Globalization;
using System.Text;

namespace Class04_String_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int eurMoney = 100;
            int mkdMoney = 1000;

            string message = "You have " + eurMoney + " euro, and " + mkdMoney + " denars.";
            Console.WriteLine(message);
            string message1 = string.Format("You have {0} euro, and {1} denars.", eurMoney, mkdMoney);
            Console.WriteLine(message1);
            string message2 = $"You have {eurMoney} euro, and {mkdMoney} denars.";
            Console.WriteLine(message2);

            decimal dollarAmount = 2345.50M;

            string dollarAmountFormatted = dollarAmount.ToString("C", new CultureInfo("en-US"));
            Console.WriteLine($"Amount: {dollarAmountFormatted}");

            Console.WriteLine(string.Format("Amount: {0:C}", dollarAmount));
            Console.WriteLine($"Amount: {dollarAmount:C}");

            decimal percent = 0.23M;

            Console.WriteLine($"Percent: {percent:P}");

            Console.WriteLine(string.Format("{0:0##/###-###}", 070123456));

            string[] students = { "Slave", "Risto", "Aleksandar" };

            string studentsFormatted = "";
            for(int i = 0; i < students.Length; i++)
            {
                if(i < students.Length - 1)
                {
                    studentsFormatted += students[i] + ", ";
                } else
                {
                    studentsFormatted += students[i];
                }
            }

            Console.WriteLine(studentsFormatted);

            string studentsFormatted1 = string.Join(", ", students);
            Console.WriteLine(studentsFormatted1);

            string phrase = "MVR is the best institution";

            char[] phraseArray = phrase.ToCharArray();

            Console.WriteLine($"Lenght is: {phrase.Length}");

            string[] words = phrase.Split(" ");

            string smallPhrase = phrase.Substring(4);
            string smallerPhrase = phrase.Substring(4, 11);

            Console.WriteLine(phrase.ToUpper());

            string phrase2 = "This is Coding Academy.\nIt is located into Qinshift";
            Console.WriteLine(phrase2);

            Console.WriteLine("|Id|Name|");
            Console.WriteLine(string.Format("|{0,10}|{1,10}|", "Id", "Name"));

            string street = "st. \"Avenue\"";
            Console.WriteLine(street);

            string filePath = "home\\something\\SEDC";
            Console.WriteLine(filePath);

            string filePath1 = @$"""home\something\SEDC""";
            Console.WriteLine(filePath1);

            Console.WriteLine(phraseArray);
        }
    }
}
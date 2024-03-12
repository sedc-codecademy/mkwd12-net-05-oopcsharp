namespace Class04_Function_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            decimal result = ConvertFromMkdToEur(1000);

            Console.WriteLine($"Conversion: {result} eur.");
        }

        public static decimal ConvertFromMkdToEur(int value)
        {
            decimal result = value / 61.5M;

            //return result;

            return value / 61.5M;
        }
    }
}
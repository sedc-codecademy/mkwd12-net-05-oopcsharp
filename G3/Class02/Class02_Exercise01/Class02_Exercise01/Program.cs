namespace Class02_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstDecimal = 5.555;
            double secondDecimal = 6.666;

            double result = firstDecimal / secondDecimal;

            //float firstDecimal = 5.555f;
            //float secondDecimal = 6.666f;

            //double result = firstDecimal / secondDecimal;

            Console.WriteLine(result);

            int firstNumber = 203;
            int secondNumber = 100;

            //int result1 = firstNumber / secondNumber;
            double result1 = firstNumber / (double) secondNumber;

            Console.WriteLine(result1);
        }
    }
}
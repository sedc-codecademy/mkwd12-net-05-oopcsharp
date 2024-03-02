namespace Class02_Exercise06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();

            if(!int.TryParse(input, out int firstNumber))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Please enter a second number");
            string input2 = Console.ReadLine();

            if (!int.TryParse(input2, out int secondNumber))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            if(firstNumber > secondNumber)
            {
                Console.WriteLine($"First number {firstNumber} is larger than second number {secondNumber}");
            }
            else if(firstNumber < secondNumber)
            {
                Console.WriteLine($"First number {firstNumber} is lower than second number {secondNumber}");
            }
            else //if(firstNumber == secondNumber)
            {
                Console.WriteLine("Numbers are equal");
            }

            if(firstNumber % 2 == 0)
            {
                Console.WriteLine("First number is even");
            } else
            {
                Console.WriteLine("First number is odd");
            }

            if (secondNumber % 2 == 0)
            {
                Console.WriteLine("Second number is even");
            }
            else
            {
                Console.WriteLine("Second number is odd");
            }
        }
    }
}
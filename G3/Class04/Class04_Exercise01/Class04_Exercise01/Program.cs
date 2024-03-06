namespace Class04_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstNumber;
            int secondNumber;
            string operation;

            while(true)
            {
                Console.WriteLine("Please enter first number:");
                string input = Console.ReadLine();

                if(!int.TryParse(input, out firstNumber))
                {
                    Console.WriteLine("Wrong input.");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Please enter second number:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out secondNumber))
                {
                    break;
                }

                Console.WriteLine("Wrong input.");
            }

            while(true)
            {
                Console.WriteLine("Please enter the operator (+ -)");
                operation = Console.ReadLine();

                if(operation != "+" && operation != "-")
                {
                    Console.WriteLine("Wrong operator.");
                    continue;
                }

                break;
            }

            int result = 0;

            switch(operation)
            {
                case "+":
                    result = Sum(firstNumber, secondNumber);
                    break;
                case "-":
                    result = Subtract(firstNumber, secondNumber);
                    break;
            }

            Console.WriteLine($"The result is: {result}");
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }        
    }
}
namespace Class02_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            string input = Console.ReadLine();

            //Console.WriteLine($"You have entered: {input}");

            Console.WriteLine("Input second number:");
            string input2 = Console.ReadLine();

            //Type.Parse
            //int number1 = int.Parse(input);
            //int number2 = int.Parse(input2);

            //Convert.Type
            //int number1 = Convert.ToInt32(input);
            //int number2 = Convert.ToInt32(input2);

            int number1;
            bool success = int.TryParse(input, out number1);

            if(!success)
            {
                Console.WriteLine("Wrong input for number 1");
                return;
            }

            int number2;
            bool success2 = int.TryParse(input2, out number2);

            if(!success2)
            {
                Console.WriteLine("Wrong input for number 2");
                return;
            }

            int result = number1 + number2;
            Console.WriteLine($"The result is {result}");
        }
    }
}
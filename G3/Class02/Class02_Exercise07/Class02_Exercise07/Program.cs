namespace Class02_Exercise07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number between 1 and 3");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You got a new car");
                    break;
                case "2":
                    Console.WriteLine("You got a new plane");
                    break;
                case "3":
                    Console.WriteLine("You got a new bike");
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
namespace Class03_Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    break;
                }

                Console.WriteLine("Wrong input, please try again.");
            }

            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    //brojot se deli ili so 3 ili so 7
                    continue;
                }

                //brojot ne se deli nitu so 3 nitu so 7
                Console.WriteLine($"{i}");
                counter++;

                if(counter == 100)
                {
                    break;
                }

                //if (!(i % 3 == 0 || i % 7 == 0))
                //{
                //    //brojot ne se deli nitu so 3 nitu so 7
                //    Console.WriteLine($"{i}");
                //    counter++;

                //    if (counter == 100)
                //    {
                //        break;
                //    }
                //}                
            }
        }
    }
}
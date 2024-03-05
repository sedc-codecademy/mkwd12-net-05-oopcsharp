namespace Class02_Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the rating:");
            string input = Console.ReadLine();

            //decimal rate;
            //bool success = decimal.TryParse(input, out rate);

            //if (!success)
            //{
            //    Console.WriteLine("Wrong input");
            //}
            //else
            //{
            //    Console.WriteLine($"Your rate is: {rate}");
            //}

            //decimal rate;
            //bool success = decimal.TryParse(input, out rate);

            //if (!success)
            //{
            //    Console.WriteLine("Wrong input");
            //    return;
            //}

            //Console.WriteLine($"Your rate is: {rate}");

            //bool success = decimal.TryParse(input, out decimal rate);

            //if (!success)
            //{
            //    Console.WriteLine("Wrong input");
            //    return;
            //}

            //Console.WriteLine($"Your rate is: {rate}");


            if (!decimal.TryParse(input, out decimal rate))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine($"Your rate is: {rate}");
        }
    }
}
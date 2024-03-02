using System.Text;

namespace Class03_Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("Ве молам внесете број:");

            //string input = Console.ReadLine();

            //if(!int.TryParse(input, out int number))
            //{
            //    Console.WriteLine("Невалиден внес");
            //    return;
            //}

            //Console.WriteLine($"Бројот што го внесовте е:{number}");

            int number;

            while (true)
            {
                Console.WriteLine("Ве молам внесете број:");

                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    break;
                }

                Console.WriteLine("Невалиден внес");
            }

            Console.WriteLine($"Бројот што го внесовте е:{number}");
        }
    }
}
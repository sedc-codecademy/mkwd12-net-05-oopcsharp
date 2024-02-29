namespace Class02_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo 1");

            int numberOfUsers;
            numberOfUsers = 20;

            int numberOfClassrooms = 3;

            numberOfClassrooms = 4;

            Console.WriteLine(numberOfUsers);
            Console.WriteLine(numberOfClassrooms);

            Console.WriteLine($"Broj na korisnici: {numberOfUsers}");

            float averageRate = 4.3f;

            double averageRate2 = 4.3;

            decimal averageRate3 = 4.3m;

            Console.WriteLine(averageRate);

            char sign = 'a';

            string firstName = "Risto";
            string lastName = "Panchevski";

            Console.WriteLine($"{firstName} {lastName}");

            long bigNumber = 12121312;

            ulong bigNumber2 = 11111111111111111111;

            //Operators

            int a = 5;
            int b = 7;

            //int sum = a + b;
            int sum;
            sum = a + b;

            a += b;

            Console.WriteLine(sum);
            Console.WriteLine(a);
            Console.WriteLine(b);

            //
            int x = 3;
            int y = 8;

            int sum1 = y + x++;
            int sum2 = y + ++x;

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum1);

            //
            int n1 = 10;
            int n2 = 3;

            int result = n1 / n2;
            //int result = n2 / n1;
            
            Console.WriteLine(result);

            //still int number as result
            //float result1 = n1 / n2;

            float result1 = n1 / (float) n2;
            Console.WriteLine(result1);

            int n3 = 10;
            float n4 = 3f;
            float result2 = n3 / n4;
            Console.WriteLine(result2);


        }
    }
}
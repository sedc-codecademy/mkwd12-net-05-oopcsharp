namespace Class03_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR Loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number i: {i}");
            }

            int j;

            for (j = 10; j > 0; j--)
            {
                Console.WriteLine($"Number j: {j}");
            }

            int k = 10;

            for (; k > 0; k--)
            {
                Console.WriteLine(k);
            }

            //for (;;)
            //{
            //    Console.WriteLine(k);
            //}

            //for (; ; )
            //{
            //    if (k > 0)
            //    {
            //        Console.WriteLine(k);
            //        k--;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            #endregion


            #region While
            int start = 90;

            //while(start <= 100)
            //{
            //    Console.WriteLine(start);

            //    start++;
            //}

            while (true)
            {
                Console.WriteLine(start);

                start++;

                if(start > 100)
                {
                    break;
                }
            }
            #endregion


            int z = 50;
            do
            {
                Console.WriteLine(z);
                z--;
            } while (z > 50);
        }
    }
}
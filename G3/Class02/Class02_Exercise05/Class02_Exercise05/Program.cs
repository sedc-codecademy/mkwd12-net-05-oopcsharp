namespace Class02_Exercise05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of trees:");
            string input = Console.ReadLine();

            if(!int.TryParse(input, out int numberOfTrees))
            {
                Console.WriteLine("Wrong input for number of trees");
                return;
            }

            int numberOfBranchesPerTree = 12;
            int numberOfApplesPerBranch = 8;
            int basketCapacity = 5;

            int numberOfBasketsNeeded;

            int totalNumberOfApples = numberOfTrees * numberOfBranchesPerTree * numberOfApplesPerBranch;

            numberOfBasketsNeeded = totalNumberOfApples / basketCapacity;

            if((totalNumberOfApples % basketCapacity) > 0)
            {
                //numberOfBasketsNeeded++;
                //numberOfBasketsNeeded += 1;
                numberOfBasketsNeeded = numberOfBasketsNeeded + 1;
            }

            Console.WriteLine($"You need {numberOfBasketsNeeded} baskets");


            //DEMO IF-ELSE
            string carBrand = "Opel";

            //if(carBrand == "Mitsubishi")
            //{
            //    Console.WriteLine("Mak auto star");
            //}
            //else if(carBrand == "Peugeot")
            //{
            //    Console.WriteLine("Euroimpex");
            //}
            //else if(carBrand == "Opel")
            //{
            //    Console.WriteLine("Euroimpex");
            //}

            if (carBrand == "Mitsubishi")
            {
                Console.WriteLine("Mak auto star");
            }
            else if (carBrand == "Peugeot" || carBrand == "Opel")
            {
                Console.WriteLine("Euroimpex");
            }
        }
    }
}
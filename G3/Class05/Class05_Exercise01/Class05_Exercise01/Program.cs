namespace Class05_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human trainer = new Human();
            trainer.FirstName = "Risto";
            trainer.LastName = "Panchevski";
            trainer.DateOfBirth = new DateTime(1989, 7, 20);

            string result = trainer.GetPersonStats();
            Console.WriteLine(result);

            Human trainer2 = new Human()
            {
                FirstName = "Slave",
                LastName = "Ivanovski",
                DateOfBirth = DateTime.Now.AddYears(-20)
            };

            Console.WriteLine(trainer2.GetPersonStats());

            Human trainer1 = new Human("Risto", "Panchevski", new DateTime(1989, 7, 20));
            Console.WriteLine(trainer1.GetPersonStats());

            //string firstName = GetStringInputFromConsole("Vnesete ime:");
            //string lastName = GetStringInputFromConsole("Vnesete prezime:");

            //Human trainer3 = new Human()
            //{
            //    FirstName = firstName,
            //    LastName = lastName
            //};

            Human trainer3 = new Human(GetStringInputFromConsole("Vnesete ime:"), GetStringInputFromConsole("Vnesete prezime:"), DateTime.Now);

            Console.Write(trainer3.GetPersonStats());
        }

        public static string GetStringInputFromConsole(string displayMessage)
        {
            Console.WriteLine(displayMessage);
            string input = Console.ReadLine();

            return input;
        }
    }
}
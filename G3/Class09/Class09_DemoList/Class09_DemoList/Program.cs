using Models;

namespace Class09_DemoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> names = new List<string>();
            List<User> users = new List<User>();

            //List<int> numbers2;

            //Console.Write(numbers.Count);
            //Console.WriteLine(numbers2.Count);

            numbers.Add(2);
            numbers.Add(5);

            names.Add("Slave");
            names.Add("Risto");

            users.Add(new User()
            {
                FirstName = "Risto",
                LastName = "Panchevski"
            });

            users.Add(new User()
            {
                FirstName = "Slave",
                LastName = "Ivanovski"
            });

            List<int> largeNumbers = new List<int>() { 1000, 1001, 1200 };
            largeNumbers.Add(1500);

            numbers.AddRange(largeNumbers);

            User user2 = users[1];
            Console.WriteLine($"{user2.FirstName} {user2.LastName}");

            numbers.Remove(1000);

            numbers.RemoveAt(2);

            numbers.ForEach(number =>
            {
                Console.WriteLine(number);
            });

            numbers.ForEach(Console.WriteLine);
        }
    }
}
namespace Class09_DemoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>() {
                {500, "Aleksandar" },
                {700, "Mile" }
            };


            students.Add(100, "Risto");
            students.Add(200, "Slave");
            students.Add(300, "Sasho");
            bool success = students.TryAdd(100, "Jovan");

            if (!students.ContainsKey(100))
            {
                students.Add(100, "Jovan");
            }

            Console.WriteLine(students[100]);

            students.Remove(300);

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
        }
    }
}
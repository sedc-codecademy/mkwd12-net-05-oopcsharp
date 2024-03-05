namespace Class03_Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[10];

            Console.WriteLine(numbers[5]);

            numbers[1] = 7;
            Console.WriteLine(numbers[1]);

            string[] students = new string[20];
            students[0] = "Risto";
            students[1] = "Slave";
            students[2] = "Darko";

            string[] classes = new string[2] { "C# Basic", "C# Advance" };

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            //string[] reverseArray = students.Reverse().ToArray();
            Array.Reverse(students);

            int indexOfSlave = Array.IndexOf(students, "Slave");

            //int[] marks = new int[] { 5, 5, 7 };
            int[] marks = { 5, 5, 7 };

            int[] marksCopy = marks;

            //marks[3] = 8; => throws an exception out of range

            Array.Resize(ref marks, 5);
            marks[3] = 8;


            Array.Resize(ref marks, 2);
            Array.Resize(ref marks, 5);

            foreach(string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
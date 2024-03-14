namespace Class05_Exercise03
{
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public string Academy { get; set; }

        public Student(string name, string group, string academy)
        {
            Name = name;
            Group = group;
            Academy = academy;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Group} {Academy}");
        }
    }
}

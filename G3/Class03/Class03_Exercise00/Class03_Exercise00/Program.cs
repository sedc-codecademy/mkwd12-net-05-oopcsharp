namespace Class03_Exercise00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko", "Stanko", "Branko", "Zdravko", "Zdravko" };

            string[] uniqueNames = new string[0]; // = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            int[] nameAppearance = new int[0]; // = { 3, 1, 2, 2, 1};

            foreach(string student in students)
            {
                int index = Array.IndexOf(uniqueNames, student);

                if(index == -1) //first appearance of the name
                {
                    Array.Resize(ref uniqueNames, uniqueNames.Length + 1);
                    Array.Resize(ref nameAppearance, nameAppearance.Length + 1);

                    uniqueNames[uniqueNames.Length - 1] = student;
                    nameAppearance[nameAppearance.Length - 1] = 1;
                } else
                {
                    nameAppearance[index]++;
                }
            }

            for(int i = 0; i < uniqueNames.Length; i++)
            {
                Console.WriteLine($"{uniqueNames[i]}: {nameAppearance[i]}");
            }
        }
    }
}
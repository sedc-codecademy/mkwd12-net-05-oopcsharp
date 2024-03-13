namespace Class05_Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Petko", "Petkovski", "SEDC", "G1");
            Student s2 = new Student("Bob", "Bobsky", "SEDC", "G3");
            Student s3 = new Student("Krste", "Krstevski", "SEDC", "G3");
            Student s4 = new Student("Marko", "Markovski", "SEDC", "G3");
            Student s5 = new Student("Jane", "Janevski", "SEDC", "G6");

            Student[] students = new Student[5] { s1, s2, s3, s4, s5 };

            while(true)
            {
                Console.WriteLine("Please enter serch phrase:");
                string input = Console.ReadLine();

                //Search
                Student[] result = new Student[0];

                foreach(Student s in students)
                {
                    //if(s.FirstName.ToLower().Contains(input.ToLower()) || s.LastName.ToLower().Contains(input.ToLower()))
                    //{
                    //    Array.Resize(ref result, result.Length + 1);
                    //    result[result.Length - 1] = s;
                    //}

                    if (s.FullName.ToLower().Contains(input.ToLower()))
                    {
                        Array.Resize(ref result, result.Length + 1);
                        result[result.Length - 1] = s;
                    }
                }

                //Print result
                if(result.Length == 0)
                {
                    Console.WriteLine("No records found.");
                } else
                {
                    Console.WriteLine("Results:");
                    foreach (Student s in result)
                    {
                        Console.WriteLine(s.GetStudentInfo());
                    }
                }

                Console.WriteLine("Do you want to search one more time y/n?");
                string choice = Console.ReadLine();

                if(choice != "y" && choice != "Y")
                {
                    break;
                }
            }

        }
    }
}


namespace QinshiftAcademy.Class06.RetroExercise
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        //the properties of this class should be required

        public Student(string firstName, string lastName, string academy, string group)
        {
            //if (string.IsNullOrEmpty(firstName))
            //{
            //    Console.WriteLine("FirstName parameter doesn't have a value. A default value will be used.");
            //    FirstName = "No first name";
            //}
            //else
            //{
            //    FirstName = firstName;
            //}
            FirstName = ValidateInput(firstName, "First Name");

            //if (string.IsNullOrEmpty(lastName))
            //{
            //    Console.WriteLine("LastName parameter doesn't have a value. A default value will be used.");
            //    LastName = "No last name";
            //}
            //else
            //{
            //    LastName = lastName;
            //}
            LastName = ValidateInput(lastName, "Last Name");

            //if (string.IsNullOrEmpty(academy))
            //{
            //    Console.WriteLine("Academy parameter doesn't have a value. A default value will be used.");
            //    Academy = "No academy";
            //}
            //else
            //{
            //    Academy = academy;
            //}
            Academy = ValidateInput(academy, "Academy");

            //if (string.IsNullOrEmpty(group))
            //{
            //    Console.WriteLine("Group parameter doesn't have a value. A default value will be used.");
            //    Group = "No group";
            //}
            //else
            //{
            //    Group = group;
            //}

            Group = ValidateInput(group, "Group");
        }

        private string ValidateInput(string input, string nameOfField)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"{nameOfField} parameter doesn't have a value. A default value will be used.");
                return $"No {nameOfField}";
            }

            return input;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Academy} {Group}");
        }
    }
}

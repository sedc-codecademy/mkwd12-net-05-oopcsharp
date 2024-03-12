using QinshiftAcademy.Class06.RetroExercise;

Student[] students = new Student[5];

students[0] = new Student("Tanja", "Panchevska", "Qinshift", "Group7");
students[1] = new Student("Aleksandar", "Milovski", "Qinshift", "Group6");
students[2] = new Student("Marko", "Markovski", "Qinshift", "Group6");
students[3] = new Student("Ana", "Markovska", "Qinshift", "Group5");
students[4] = new Student("Jovana", "Petrovska", "Qinshift", "Group8");

foreach(Student student in students)
{
    student.PrintInfo();
}

Console.WriteLine("Please enter a first name to search for");
string inputName = Console.ReadLine();

Student foundStudent = FindStudent(students, inputName);

if(foundStudent != null)
{
    foundStudent.PrintInfo();
}
else
{
    Console.WriteLine($"Student with firstName {inputName} was not found.");
}

Student FindStudent(Student[] studentsArray, string firstName)
{
    foreach(Student student in studentsArray)
    {
        if (inputName.ToLower() == student.FirstName.ToLower())
        {
            return student;
        }
    }

    return null;
}


//bool isFound = false;
//foreach(Student student in students) 
//{
//    if (inputName.ToLower() == student.FirstName.ToLower())
//    {
//        student.PrintInfo();
//        isFound = true;
//        break;
//    }
//}

//if (!isFound)
//{
//    //the student was not found
//}





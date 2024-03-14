//Create a class Student that has properties: Name, Academy and Group
//Create an array with 5 new Students(objects)
//The user should enter a name and the user information should be displayed in the console if a user by that name exists
//If there is no such user it should show an error message

using Class05_Exercise03;

Student[] students = new Student[]
{
    new Student("Petko", "G1", "SEDC"),
    new Student ("Nikola", "G2", "Network"),
    new Student ("Marko", "G5", "Design"),
    new Student ("Ana", "G5", "Design"),
    new Student ("Simona", "G7", "Web Development")
};

Console.WriteLine("Enter a student name:");
string name = Console.ReadLine();
//FindStudent(students, Console.ReadLine());
Student student = FindStudent(students, name);

if(student != null)
{
    student.PrintInfo();
}
else
{
    Console.WriteLine($"Student with name: {name} was not found");
}

Student FindStudent(Student[] studentArray, string name)
{
    foreach(Student student in studentArray)
    {
        if(name.ToLower() == student.Name.ToLower())
        {
            return student; 
        }
    }
    return null; //after we iterate the whole array, if there was not a match - we return null
}
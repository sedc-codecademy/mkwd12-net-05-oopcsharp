using ClassesRecap.Models;


#region Ways to create instances (objects) from class
// 1) using the empty constructor
Student petko = new Student();
petko.Id = 1;
petko.FirstName = "Petko";
petko.LastName = "Petkovski";
petko.Age = 32;
// petko.PrintInfo();

// 2) using custom defined constructor with parameters
Student john = new Student(2, "John", "Johnsky");
// john.PrintInfo();

// 3) using {} to explicitly assign all properties
Student bob = new Student()
{
    Id = 3,
    FirstName = "Bob",
    LastName = "Bobsky",
    Group = "G2",
    Academy = "Academy of programming",
    Age = 25
};
// bob.PrintInfo();

//Student jane = new Student(4, "Jane", "Doe");
#endregion

// Create array of 5 students
Student[] students = new Student[]
{
    petko,
    john,
    bob,
    new Student(4, "Jane", "Doe"),
    new Student()
    {
        Id = 5,
        FirstName = "Mickey",
        LastName = "Mouse"
    }
};

// Print students full names in console
foreach (Student student in students)
{
    Console.WriteLine(student.GetFullName());
}

Console.ReadLine();
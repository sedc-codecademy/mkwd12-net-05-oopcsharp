using System;
using System.Collections.Generic;
using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Classes
{
    public class Student : AcademyMember
    {
        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject, int> Grades { get; set; }
        public Student(string userName, string firstName, string lastName, int age) : base(userName, firstName, lastName, age)
        {
            Role = Role.Student;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public void PrintDetails()
        {
            Console.WriteLine($"{FirstName} {LastName} {Age}");
            if (CurrentSubject == null)
            {
                Console.WriteLine("The student is currently on a holiday");
            }
            else
            {
                Console.WriteLine($"The current subject is {CurrentSubject.Name}");
            }
            if (Grades == null)
            {
                Console.WriteLine("The student has still no grades");
            }
            else
            {
                Console.WriteLine("Grades:");
                foreach (var item in Grades)
                {
                    Console.WriteLine($"{item.Key.Name} {item.Value}"); // item.Key == subject, item.Value == grade (int)

                }
            }
        }
    }
}

using SEDC.AcademyManagement.Domain.Classes;
using SEDC.AcademyManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.AcademyManagement
{
    class Program
    {
        public static List<Subject> Subjects;
        public static List<Admin> Admins;
        public static List<Trainer> Trainers;
        public static List<Student> Students;
        static void Main(string[] args)
        {
            FillDatabase();
            Console.WriteLine("Welcome");
            while (true)
            {
                
                try
                {
                    Console.WriteLine("Enter username");
                    string userName = Console.ReadLine();
                    if (string.IsNullOrEmpty(userName))
                    {
                        throw new Exception("You must enter username");
                    }

                    //first check admins
                    Admin admin = SearchAdmins(userName);
                    if(admin != null)
                    {
                        Console.WriteLine("Enter option");
                        Console.WriteLine("1) Add teacher, 2) Remove teacher, 3) Add student, 4) Remove student," +
                            "5) Add admin, 6) Remove admin");
                        int option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                AddMember(Role.Trainer);
                                break;
                            case 2:
                                Console.WriteLine("Enter username");
                                string username = Console.ReadLine();
                                RemoveTrainer(username);
                                break;
                            case 3:
                                AddMember(Role.Student);
                                break;
                            case 4:
                                Console.WriteLine("Enter username");
                                string studentUsername = Console.ReadLine();
                                RemoveStudent(studentUsername);
                                break;
                            case 5:
                                AddMember(Role.Admin);
                                break;
                            case 6:
                                Console.WriteLine("Enter username");
                                string adminUsername = Console.ReadLine();
                                if (adminUsername == admin.UserName)
                                    throw new Exception("You can not delete yourself");
                                RemoveAdmin(adminUsername);
                                break;
                            default:
                                throw new Exception("You must enter valid option 1-6");
                                
                        }
                    }
                    else
                    {
                        //not an admin
                        Trainer trainer = Trainers.FirstOrDefault(x => x.UserName == userName);
                        if(trainer != null)
                        {
                            //trainer
                            Console.WriteLine("Enter option 1) See students 2) See subjects");
                            int trainerOption = int.Parse(Console.ReadLine());
                            switch (trainerOption)
                            {
                                case 1:
                                    PrintStudents();
                                    break;
                                case 2:
                                    PrintSubjects();
                                    break;
                                default:
                                    throw new Exception("You must enter valid option 1/2");

                            }
                        }
                        else
                        {
                            //not an admin, not a trainer
                            Student student = Students.FirstOrDefault(x => x.UserName == userName);
                            if(student == null)
                            {
                                throw new Exception("The user does not exist");
                            }
                            student.PrintDetails();
                        }
                    }
                }
                catch(FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input was not a number");
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("An error occured");
                    Console.WriteLine(ex.Message);
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to continue? Type yes");
                string response = Console.ReadLine();
                if(response.ToLower() == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
            Console.ReadLine();
        }


        private static void PrintStudents()
        {
            Console.WriteLine("Here are the students:");
            foreach(Student student in Students)
            {
                Console.WriteLine(student.GetFullName());
            }
        }

        private static void PrintSubjects()
        {
            Console.WriteLine("Here are the subjects:");
            foreach (Subject subject in Subjects)
            {
                Console.WriteLine(subject.Name);
                int numOfStudents = Students.Count(x => subject.Name == x.CurrentSubject.Name);
                Console.WriteLine(numOfStudents);
            }
        }

        private static void RemoveAdmin(string username)
        {
            Admin admin = Admins.FirstOrDefault(x => x.UserName == username);
            if (admin == null)
            {
                throw new Exception("There is no such admin");
            }
            Admins.Remove(admin);
        }

        private static void RemoveStudent(string username)
        {
            Student student = Students.FirstOrDefault(x => x.UserName == username);
            if (student == null)
            {
                throw new Exception("There is no such student");
            }
            Students.Remove(student);
        }

        private static void RemoveTrainer(string username)
        {
            Trainer trainer = Trainers.FirstOrDefault(x => x.UserName == username);
            if(trainer == null)
            {
                throw new Exception("There is no such trainer");
            }
            Trainers.Remove(trainer);
        }

        private static void AddMember(Role role)
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("You must enter username");
            }

            Admin admin = SearchAdmins(username);
            Trainer trainer = SearchTrainers(username);
            Student student = SearchStudents(username);

            if(admin != null || trainer != null || student != null)
            {
                throw new Exception("User with this username already exists");
            }

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            if (string.IsNullOrEmpty(firstName))
            {
                throw new Exception("You must enter first name");
            }

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            if (string.IsNullOrEmpty(lastName))
            {
                throw new Exception("You must enter last name");
            }

            int age = int.Parse(Console.ReadLine());
            if(age < 16)
            {
                throw new Exception("Age must be greater than 16");
            }

            if(role == Role.Admin)
            {
                Admins.Add(new Admin(username, firstName, lastName, age));
            }
            else if (role == Role.Trainer)
            {
                Trainers.Add(new Trainer(username, firstName, lastName, age));
            }
            else
            {
                Student newStudent = new Student(username, firstName, lastName, age);
               
                Console.WriteLine("Enter subject name");
                string currentSubject = Console.ReadLine();
                Subject current = Subjects.FirstOrDefault(x => x.Name == currentSubject);
                newStudent.CurrentSubject = current;

                Students.Add(newStudent);
            }
        }


        private static Admin SearchAdmins(string username)
        {
            return Admins.FirstOrDefault(x => x.UserName == username);
        }

        private static Trainer SearchTrainers(string username)
        {
            return Trainers.FirstOrDefault(x => x.UserName == username);
        }

        private static Student SearchStudents(string username)
        {
            return Students.FirstOrDefault(x => x.UserName == username);
        }

        private static void FillDatabase()
        {
            Subjects = new List<Subject>();
            Subjects.Add(new Subject { Name = "HTML" });
            Subjects.Add(new Subject { Name = "Basic JS" });
            Subjects.Add(new Subject { Name = "Advanced JS" });
            Subjects.Add(new Subject { Name = "Basic C#" });

            Admins = new List<Admin>();
            Admins.Add(new Admin("ddejan", "Dejan", "Dejanovski", 30));
            Admins.Add(new Admin("iigor", "Igor", "Igevski", 32));

            Trainers = new List<Trainer>();
            Trainers.Add(new Trainer("saleksandar", "Aleksandar", "Stojanovski", 25));
            Trainers.Add(new Trainer("iangela", "Angela", "Ilievska", 25));
            Trainers.Add(new Trainer("sstefan", "Stefan", "Stamenov", 23));

            
            
            Students = new List<Student>();
            Students.Add(new Student("pfilip", "Filip", "Petrovski", 21)
            {
                CurrentSubject = Subjects.Last()
            });
            Students.First().Grades = new Dictionary<Subject, int>(); // Students.First() -> filip
            Students.First().Grades.Add(Subjects.FirstOrDefault(x=>x.Name == "Basic JS"), 5);


            Dictionary<Subject, int> grades = new Dictionary<Subject, int>();
            grades.Add(Subjects.FirstOrDefault(x => x.Name == "Advanced JS"), 5);
            grades.Add(Subjects.FirstOrDefault(x => x.Name == "Basic C#"), 4);
            Students.Add(new Student("mmarija", "Marija", "Mitrevska", 22)
            {
                CurrentSubject = Subjects.First(),
                Grades = grades
            });

        }
    }
}

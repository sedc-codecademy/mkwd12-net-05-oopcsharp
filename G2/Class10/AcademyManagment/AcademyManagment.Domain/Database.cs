using AcademyManagment.Domain.Models;

namespace AcademyManagment.Domain
{
    // we don't want the Database to be exposed everywhere in the solution so we set the Access Modifier to internal
    internal class Database
    {
        public List<Admin> Admins { get; set; } = new List<Admin>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();

        public Database()
        {
            SeedData();
        }

        private void SeedData()
        {
            string[] subjects = { "HTML5", "CSS3", "BasicJS", "AdvancedJS", "BasicCSharp", "AdvancedCSharp", "Database" };

            Admins = new List<Admin>()
            {
                new Admin("bobsky123", "bobsky123", "Bob", "Bobsky", 28),
                new Admin("doe123", "doe123", "John", "Doe", 23),
                new Admin("mmouse123", "mmouse123", "Mickey", "Mouse", 32),
                new Admin("pink123", "pink123", "Pink", "Panther", 31),
            };

            Trainers = new List<Trainer>()
            {
                new Trainer("ile123", "ile123", "Ilija", "Mitev", 20),
                new Trainer("danilo123", "danilo123", "Danilo", "Borozan", 21),
            };

            Students = new List<Student>()
            {
                new Student("jane123", "jane123", "Jane", "Doe", 20)
                {
                    CurrentSubject = subjects[4],
                    SubjectGrade = new Dictionary<string, int>()
                    {
                        { subjects[3], 5 },
                        { subjects[2], 4 },
                        { subjects[1], 5 },
                        { subjects[0], 5 },
                    }
                },
                new Student("john123", "john123", "John", "Smith", 22)
                {
                    CurrentSubject = subjects[2],
                    SubjectGrade = new Dictionary<string, int>()
                    {
                        { subjects[1], 3 },
                        { subjects[0], 2 },
                    }
                },
                new Student("petko123", "petko123", "Petko", "Petkovski", 28)
                {
                    CurrentSubject = subjects[0],
                    SubjectGrade = new Dictionary<string, int>()
                },
                new Student("rob123", "rob123", "Rob", "Robsky", 35)
                {
                    CurrentSubject = subjects[6],
                    SubjectGrade = new Dictionary<string, int>()
                    {
                        { subjects[5], 5 },
                        { subjects[4], 5 },
                        { subjects[3], 4 },
                        { subjects[2], 3 },
                        { subjects[1], 5 },
                        { subjects[0], 5 },
                    }
                },
                new Student("petkana123", "petkana123", "Petkana", "Petkovska", 19)
                {
                    CurrentSubject = subjects[3],
                    SubjectGrade = new Dictionary<string, int>()
                    {
                        { subjects[2], 2 },
                        { subjects[1], 4 },
                        { subjects[0], 4 },
                    }
                },
            };
        }
    }
}

using AcademyManagment.Domain.Enums;
using AcademyManagment.Domain.Models;

namespace AcademyManagment.Domain
{
    /// <summary>
    ///     Methods for communicating with our in-memory 'Database'
    /// </summary>
    public class DataAccess
    {
        private Database _database;
        public DataAccess()
        {
            _database = new Database();
        }

        /// <summary>
        ///     Method used for verifying the login process. Check if a user with the entered credentials exists in our database.
        /// </summary>
        /// <returns>If found the whole Admin object. If not, null (default)</returns>
        public Admin GetAdmin(string username, string password)
        {
            Admin adminFromDb = _database.Admins.FirstOrDefault(admin => admin.Username == username && admin.Password == password);
            return adminFromDb;
        }

        public Trainer GetTrainer(string username, string password)
        {
            return _database.Trainers.FirstOrDefault(a => a.Username == username && a.Password == password);
        }

        public Student GetStudent(string username, string password)
        {
            return _database.Students.FirstOrDefault(a => a.Username == username && a.Password == password);
        }

        public bool CheckIfUserExists(string username, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    return _database.Admins.Any(a => a.Username == username);
                case Role.Trainer:
                    return _database.Trainers.Any(t => t.Username == username);
                case Role.Student:
                    return _database.Students.Any(s => s.Username == username);
                default:
                    return false;
            }
        }

        public void CreateNewUser(string username, string password, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    Admin newAdmin = new Admin(username, password);
                    _database.Admins.Add(newAdmin);
                    break;
                case Role.Trainer:
                    Trainer newTrainer = new Trainer(username, password);
                    _database.Trainers.Add(newTrainer);
                    break;
                case Role.Student:
                    Student newStudent = new Student(username, password);
                    _database.Students.Add(newStudent);
                    break;
                default:
                    throw new Exception("Error occured while saving new user to database!");
            }
        }

        /// <summary>
        ///     Method used for retriveing the usernames of the users of a specific type.
        /// </summary>
        /// <param name="role">The type of the users we need</param>
        /// <param name="logedInAdmin">The logged in admin.</param>
        /// <returns>List of the usernames</returns>
        public List<string> GetUsernames(Role role, Admin logedInAdmin)
        {
            switch (role)
            {
                case Role.Admin:
                    return _database.Admins.Where(a => a.Username != logedInAdmin.Username)
                                           .Select(a => a.Username)
                                           .ToList();
                case Role.Trainer:
                    return _database.Trainers.Select(t => t.Username).ToList();
                case Role.Student:
                    return _database.Students.Select(s => s.Username).ToList();
                default:
                    throw new Exception("Error occured while retriving usernames from database!");
            }
        }

        /// <summary>
        ///     Method used for deleting users.
        /// </summary>
        /// <param name="username">The username of the user we want to delete</param>
        /// <param name="role">The type(role) of the user we are deleting/removing from the list</param>
        /// <returns>boolean</returns>
        public bool DeleteUser(string username, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    Admin adminDb = _database.Admins.FirstOrDefault(a => a.Username == username);
                    return _database.Admins.Remove(adminDb);
                case Role.Trainer:
                    Trainer trainerDb = _database.Trainers.FirstOrDefault(t => t.Username == username);
                    return _database.Trainers.Remove(trainerDb);
                case Role.Student:
                    Student studentDb = _database.Students.FirstOrDefault(s => s.Username == username);
                    return _database.Students.Remove(studentDb);
                default:
                    return false;
            }
        }
    }
}

using AcademyManagment.Domain;
using AcademyManagment.Domain.Enums;
using AcademyManagment.Domain.Exceptions;
using AcademyManagment.Domain.Models;

namespace AcademyManagment.Services.UserServices
{
    public class AdminService
    {
        private DataAccess _dataAccess;
        public AdminService()
        {
            _dataAccess = new DataAccess();
        }

        public Admin AdminLogin(string username, string password)
        {
            Admin adminDb = _dataAccess.GetAdmin(username, password);
            if (adminDb == null)
            {
                throw new LoginException("Invalid credentials entered! Try again.");
            }
            return adminDb;
        }

        public void CreateUser(string username, string password, Role role)
        {
            bool userExists = _dataAccess.CheckIfUserExists(username, role);
            if (userExists)
            {
                throw new AdminException($@"{role} with username ""{username}"" already exists!");
            }
            _dataAccess.CreateNewUser(username, password, role);
        }

        public List<string> GetUsersToRemove(Role role, Admin logedInAdmin)
        {
            return _dataAccess.GetUsernames(role, logedInAdmin);
        }

        public void DeleteUser(string username, Role role)
        {
            bool isUserDeleted = _dataAccess.DeleteUser(username, role);
            if (!isUserDeleted)
            {
                throw new AdminException($"An error occured deleting user from database. Username: {username}");
            }
        }

    }
}

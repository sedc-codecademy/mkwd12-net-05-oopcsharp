using AcademyManagment.Domain.Enums;
using AcademyManagment.Domain.Exceptions;
using AcademyManagment.Domain.Models;
using AcademyManagment.Services;
using AcademyManagment.Services.UserServices;

namespace AcademyManagment.App.UI
{
    /// <summary>
    ///     The whole Console UI. Contains methods with different menues. 
    /// </summary>
    public class UserInterface
    {
        // private fields (properties) holding instances of the services we use
        private ValidationService _validationService;
        private AdminService _adminService;
        public UserInterface()
        {
            // we create the instances of the services in the constructor / they are created when we create the UserInterface object 
            _validationService = new ValidationService();
            _adminService = new AdminService();
        }

        /// <summary>
        ///     The only method called in Program.cs. Wrapper method for all the UI that the application uses.
        /// </summary>
        /// <returns>boolean</returns>
        public bool InitApp()
        {
            try
            {
                WelcomeMenu();
                int choice = _validationService.GetValidOption(new int[] { 1, 2, 3 });

                Console.Clear();
                WriteInColor($"Welcome {(Role)choice}. Enter your credentials:\n", ConsoleColor.DarkCyan);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter username:");
                string username = _validationService.GetStringInput();
                Console.Write("Enter password:");
                string password = _validationService.GetStringInput();
                Console.ResetColor();

                switch ((Role)choice)
                {
                    case Role.Admin:
                        Admin logedInAdmin = _adminService.AdminLogin(username, password);
                        WriteInColor($"Hello admin {logedInAdmin.GetFullName()}", ConsoleColor.Green);
                        while (!AdminUI(logedInAdmin)) ;
                        break;
                    case Role.Trainer:
                        // UNDER CONSTRUCTION ...
                        break;
                    case Role.Student:
                        // UNDER CONSTRUCTION ...
                        break;
                    default:
                        break;
                }

                EndMenu();
                return true;
            }
            catch (InputValidationException ex)
            {
                WriteInColor("\n[INPUT VALIDATION FAILED]", ConsoleColor.DarkRed);
                WriteInColor(ex.Message, ConsoleColor.Red);
            }
            catch (LoginException ex)
            {
                WriteInColor("\n[LOGIN FAILED]", ConsoleColor.DarkRed);
                WriteInColor(ex.Message, ConsoleColor.Red);
            }
            catch (Exception ex)
            {
                WriteInColor(ex.Message, ConsoleColor.Red);
            }
            Console.ReadLine();
            return false;
        }

        public void WelcomeMenu()
        {
            Console.Clear();
            // ===> Before creating WriteInColor method
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("Welcome to Academy Managment");
            //Console.ResetColor();
            // ===> After creating WriteInColor method
            WriteInColor("Welcome to Academy Managment", ConsoleColor.DarkCyan);
            WriteInColor("\nChoose your role to login:\n1) Admin \n2) Trainer \n3) Student", ConsoleColor.Cyan);
        }

        public void EndMenu()
        {
            Console.Clear();
            WriteInColor("Thank you for using Academy Managment!", ConsoleColor.DarkCyan);
            WriteInColor("\nBye bye and have a wonderful day :)", ConsoleColor.Cyan);
            Console.ReadLine();
        }

        #region Admin UI

        /// <summary>
        ///     Contains all the Admin menus
        /// </summary>
        /// <param name="loggedInAdmin">The logged in admin</param>
        public bool AdminUI(Admin loggedInAdmin)
        {
            try
            {
                AdminMainMenu();
                int inputChoice = _validationService.GetValidOption(new int[] { 1, 2, 3, 4 });
                if (inputChoice == 4)
                {
                    return true; // exit the while loop where AdminUI is called
                }
                bool adminActionCompleted = AdminActionMenu((Role)inputChoice, loggedInAdmin);
                if (!adminActionCompleted)
                {
                    return false;
                }
                Console.ReadLine();
                WriteInColor("Would you like to continue? (Y/N)", ConsoleColor.DarkCyan);
                string input = _validationService.GetStringInput();
                if (input.ToLower() == "y")
                {
                    return false;
                }
                return true;
            }
            catch (AdminException ex)
            {
                WriteInColor($"\n[ADMIN ACTION FAILED]", ConsoleColor.DarkYellow);
                WriteInColor(ex.Message, ConsoleColor.Yellow);
            }
            catch (InputValidationException ex)
            {
                WriteInColor("\n[INPUT VALIDATION FAILED]", ConsoleColor.DarkRed);
                WriteInColor(ex.Message, ConsoleColor.Red);
            }
            catch (Exception ex)
            {
                WriteInColor(ex.Message, ConsoleColor.Red);
            }
            Console.ReadLine();
            return false;
        }

        public void AdminMainMenu()
        {
            Console.Clear();
            WriteInColor("Welcome to the Admin Menu.", ConsoleColor.DarkCyan);
            WriteInColor("\nSelect option: \n1) Manage Admins \n2) Manage Trainers \n3) Manage Students \n4) Logout", ConsoleColor.Cyan);
        }

        public bool AdminActionMenu(Role role, Admin logedInAdmin)
        {
            Console.Clear();
            WriteInColor($"Manage {role} menu.", ConsoleColor.DarkCyan);
            WriteInColor("\nSelect Action: \n1) Add \n2) Remove \n3) Go back", ConsoleColor.Cyan);
            int actionType = _validationService.GetValidOption(new int[] { 1, 2, 3 });
            switch (actionType)
            {
                case (int)AdminAction.CreateUser:
                    CreateUserMenu(role);
                    break;
                case (int)AdminAction.DeleteUser:
                    DeleteUserMenu(role, logedInAdmin);
                    break;
                case 3:
                    return false;
            }
            return true;
        }

        /// <summary>
        ///     The Admin menu for creating users.
        /// </summary>
        /// <param name="role">Type of user we are creating</param>
        public void CreateUserMenu(Role role)
        {
            Console.Clear();
            WriteInColor($"Enter new {role.ToString().ToLower()} credentials:\n", ConsoleColor.DarkCyan);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Username:");
            string username = _validationService.GetStringInput();
            Console.Write("Password:");
            string password = _validationService.GetStringInput();
            Console.ResetColor();
            _adminService.CreateUser(username, password, role);
            WriteInColor($"\nUser {username} successfully created!", ConsoleColor.Green);
        }

        /// <summary>
        ///     The Admin menu for deleting users.
        /// </summary>
        /// <param name="role">The type of the users we need to delete (Admins, Trainers, Students)</param>
        /// <param name="logedInAdmin"></param>
        public void DeleteUserMenu(Role role, Admin logedInAdmin)
        {
            Console.Clear();
            WriteInColor($"Choose which {role} to delete:\n", ConsoleColor.DarkCyan);
            List<string> users = _adminService.GetUsersToRemove(role, logedInAdmin);
            if (users.Count == 0)
            {
                WriteInColor($"\nNo {role}s available at the moment.", ConsoleColor.DarkYellow);
                return;
            }
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {users[i]}");
            }
            int option = _validationService.GetValidOption(Enumerable.Range(1, users.Count).ToArray());
            // Enumerable.Range(1, users.Count).ToArray() ===> creates array with values ranging from 1 ... users.Count
            string selectedUser = users[option - 1]; // Get the user based on the option selected 
            _adminService.DeleteUser(selectedUser, role);
            WriteInColor($"\nSuccessfully deleted {role}: \"{selectedUser}\".", ConsoleColor.Green);
        }
        #endregion


        /// <summary>
        ///     Helper method for writing text in console with specified color.
        /// </summary>
        /// <param name="text">Text to be written in the console</param>
        /// <param name="color">Color of the text</param>
        public void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}

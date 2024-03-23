using AcademyManagment.Domain.Enums;
using AcademyManagment.Services;
using AcademyManagment.Services.UserServices;

namespace AcademyManagment.App.UI
{
    public class UserInterface
    {
        private ValidationService _validationService;
        private AdminService _adminService;
        public UserInterface()
        {
            _validationService = new ValidationService();
            _adminService = new AdminService();
        }

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

                Console.ReadLine();
                return true;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Console.ReadLine();
                return false;
            }
        }

        public void WelcomeMenu()
        {
            Console.Clear();
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("Welcome to Academy Managment");
            //Console.ResetColor();
            WriteInColor("Welcome to Academy Managment", ConsoleColor.DarkCyan);
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("\nChoose your role to login:\n1) Admin \n2) Trainer \n3) Student");
            //Console.ResetColor();
            WriteInColor("\nChoose your role to login:\n1) Admin \n2) Trainer \n3) Student", ConsoleColor.Cyan);
        }

        public void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}

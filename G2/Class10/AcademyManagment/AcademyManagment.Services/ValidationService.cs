namespace AcademyManagment.Services
{
    public class ValidationService
    {
        public int GetValidOption(int[] validOptions)
        {
            string input = GetStringInput();
            bool isValidFormat = int.TryParse(input, out int parsedInput);
            if (!isValidFormat)
            {
                throw new FormatException("Invalid input format! Try again.");
            }
            bool isValidChoice = validOptions.Contains(parsedInput);
            if (!isValidChoice)
            {
                throw new Exception("Invalid option! Try again.");
            }
            return parsedInput;
        }

        public string GetStringInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Please enter value!");
            }
            return input;
        }
    }
}

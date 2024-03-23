using AcademyManagment.Domain.Exceptions;

namespace AcademyManagment.Services
{
    /// <summary>
    ///     Contains methods for validating and retrieving user inputs
    /// </summary>
    public class ValidationService
    {
        /// <summary>
        ///     Method for retriving and validating user choice from a range of options (1,2,3...)
        /// </summary>
        /// <param name="validOptions">Integer array containing the valid option from which the user can choose</param>
        /// <returns>Valid input choice</returns>
        /// <exception cref="InputValidationException">
        ///     Custom Exception thrown if input validation fails
        /// </exception>
        public int GetValidOption(int[] validOptions)
        {
            string input = GetStringInput();
            bool isValidFormat = int.TryParse(input, out int parsedInput);
            if (!isValidFormat)
            {
                throw new InputValidationException("Invalid input format! Try again.");
            }
            bool isValidChoice = validOptions.Contains(parsedInput);
            if (!isValidChoice)
            {
                throw new InputValidationException("Invalid option! Try again.");
            }
            return parsedInput;
        }

        /// <summary>
        ///     Method for validating and retriveing string input
        /// </summary>
        /// <returns>Valid input string</returns>
        /// <exception cref="InputValidationException">Thrown if the user doesn't enter a value</exception>
        public string GetStringInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new InputValidationException("Please enter value!");
            }
            return input;
        }
    }
}

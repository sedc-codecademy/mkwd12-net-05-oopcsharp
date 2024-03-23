namespace AcademyManagment.Domain.Exceptions
{
    /// <summary>
    ///     Custom Exception used within the Validation logic
    /// </summary>
    public class InputValidationException : Exception
    {
        public InputValidationException(string message) : base(message) 
        {
            
        }
    }
}

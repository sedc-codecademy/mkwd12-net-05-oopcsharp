namespace AcademyManagment.Domain.Exceptions
{
    /// <summary>
    ///     Custom Exception used within the Login logic
    /// </summary>
    public class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {

        }
    }
}

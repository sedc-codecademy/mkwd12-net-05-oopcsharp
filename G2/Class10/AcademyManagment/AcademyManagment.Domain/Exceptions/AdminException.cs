namespace AcademyManagment.Domain.Exceptions
{
    /// <summary>
    ///     Custom Exception used within the Admin logic
    /// </summary>
    public class AdminException : Exception
    {
        public AdminException(string message) : base(message)
        {

        }
    }
}

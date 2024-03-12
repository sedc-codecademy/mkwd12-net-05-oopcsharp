namespace Task02.Models
{
    // [1] Create class User
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User()
        {
            
        }

        public void PrintMessages()
        {
            foreach (string message in Messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}

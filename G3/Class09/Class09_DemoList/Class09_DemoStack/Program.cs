using Models;

namespace Class09_DemoStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<User> usersStack = new Stack<User>();

            usersStack.Push(new User
            {
                FirstName = "Risto",
                LastName = "Panchevski"
            });

            usersStack.Push(new User
            {
                FirstName = "Slave",
                LastName = "Ivanovski"
            });

            User u = usersStack.Peek();
            bool success1 = usersStack.TryPeek(out User u1);

            User user = usersStack.Pop();
            User user1 = usersStack.Pop();
            //User user2 = usersStack.Pop();
            bool success = usersStack.TryPop(out User user2);
        }
    }
}
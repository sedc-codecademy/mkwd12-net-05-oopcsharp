using Models;

namespace Class07_Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order()
            {
                Street = "street",
                PhoneNumber = "080123123",
                Status = StatusEnum.Ordered
            };

            if(o1.Status < StatusEnum.Deliver)
            {
                Console.WriteLine("Order is still in progress!");
            }
        }
    }
}
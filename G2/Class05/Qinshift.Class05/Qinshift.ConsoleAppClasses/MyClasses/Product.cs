namespace Qinshift.ConsoleAppClasses.MyClasses
{
    public class Product
    {
        private long id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
            id = GenerateId();
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            id = GenerateId();
        }
        private long GenerateId()
        {
            return new Random().Next(10000, 999999);
        }

        public void Buy(double money)
        {
            if(money >= Price)
            {
                Console.WriteLine($"You just bought a product {Name} with price {Price}. id; {id}");
            }
            else
            {
                Console.WriteLine($"You need {Price - money} more to buy this product {Name}");
            }
        }
    }
}

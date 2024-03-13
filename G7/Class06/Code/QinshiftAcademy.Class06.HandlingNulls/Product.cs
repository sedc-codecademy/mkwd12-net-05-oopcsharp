

namespace QinshiftAcademy.Class06.HandlingNulls
{
    public class Product
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        //if we don't create any constructors, then the class has the default constructor
        //if we define at least one construcotr, then the class has only the construcotrs we defined

        public bool CheckIfYouCanBuy(double money)
        {
            if(money > Price)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you don't have enough money");
                return false;
            }
        }
    }
}

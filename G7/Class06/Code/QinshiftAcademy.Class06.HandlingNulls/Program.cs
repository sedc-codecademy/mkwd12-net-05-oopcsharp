using QinshiftAcademy.Class06.HandlingNulls;

Product product = new Product();
product.Name = "Milk";
product.Price = 70;
product.Code = 777;
product.Quantity = 20;

Product secondProduct = null; //null
//Null is the default value for each variable that should hold an object, but is not initialized

void TryToBuyProduct(Product product, double money)
{
    if(product == null)
    {
        Console.WriteLine("An error occurred. Product has null value.");
        return;
    }

   bool canBeBought = product.CheckIfYouCanBuy(money);

    if (canBeBought)
    {
        Console.WriteLine("You can buy the product");
    }
    else
    {
        Console.WriteLine("Come back later");
    }
}

TryToBuyProduct(product, 60);

TryToBuyProduct(secondProduct, 50);




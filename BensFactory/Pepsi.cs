
namespace BensFactory
{
    class Pepsi : SoftDrink
    {
        public Pepsi()
        {
            Name = "Pepsi";
            Price = 1.25f;
        }
        public Pepsi(float price)
        {
            Name = "Pepsi";
            Price = price;
        }
    }
}

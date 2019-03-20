
namespace BensFactory
{
    class Coke : SoftDrink
    {
        public Coke()
        {
            Name = "Coke";
            Price = 1.50f;
        }
        public Coke(float price)
        {
            Name = "Coke";
            Price = price;
        }
    }
}

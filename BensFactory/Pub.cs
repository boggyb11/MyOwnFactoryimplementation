using System;

namespace BensFactory
{
    class Pub : SoftDrinkFactory
    {
        public Pub()
        {

        }

        public override void DisplayDrinksMenu()
        {
            foreach (var item in SoftDrinksOnSale)
            {
                Console.WriteLine($"{item.Name} - £{ item.Price}");
            }
        }

        public override void ServeDrink(SoftDrink softDrink)
        {
            Console.WriteLine($"Served : {softDrink.Name} from the pub");
        }

        public override void SetDrinksMenu()
        {
            SoftDrinksOnSale.Add(new Coke(2.0f));
            SoftDrinksOnSale.Add(new Pepsi(1.5f));
        }
    }
}

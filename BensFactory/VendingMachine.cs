using System;

namespace BensFactory
{
    class VendingMachine : SoftDrinkFactory
    {
        public VendingMachine()
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
            Console.WriteLine($"Served : {softDrink.Name} from the vending machine");
        }

        public override void SetDrinksMenu()
        {
            SoftDrinksOnSale.Add(new Coke(1.0f));
            SoftDrinksOnSale.Add(new Pepsi(0.5f));
        }
    }
}

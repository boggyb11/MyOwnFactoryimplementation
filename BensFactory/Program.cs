using System;

namespace BensFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftDrinkFactory pub = new Pub();
            pub.DisplayDrinksMenu();
            pub.ServeDrink(new Coke());
            
            SoftDrinkFactory vendingMachine = new VendingMachine();
            vendingMachine.DisplayDrinksMenu();
            vendingMachine.ServeDrink(new Pepsi());

            Console.ReadKey();
        }
    }
}

using System.Collections.Generic;

namespace BensFactory
{
    abstract class SoftDrinkFactory
    {
        public SoftDrinkFactory()
        {
            SetDrinksMenu();
        }

        public List<SoftDrink> SoftDrinksOnSale { get; } = new List<SoftDrink>();

        public abstract void ServeDrink(SoftDrink softDrink);

        public abstract void DisplayDrinksMenu();

        public abstract void SetDrinksMenu();
    }
}

using System;
using VMschool.Interface;

namespace VMschool.VendingIitems.ProductCategory
{
	public class Snack : VendingItem, IVendingItem
    {
        private bool _isEaten;

        public void Use()
        {
            if (_isEaten)
                Console.WriteLine("You've already eaten " + ProductName + ".");
            else
                Console.WriteLine("You ate " + ProductName + ".");
            _isEaten = true;
        }

        public void Buy()
        {
            //Console.WriteLine("You bought " + ProductName + " for " + ProductPrice + Config.CURRENCY + ".");
            Console.WriteLine("You bought " + ProductName + ".");

        }
        public int Price()
        {
            return ProductPrice;
        }
    }
}


using System;
using VMschool.Interface;

namespace VMschool.VendingIitems.ProductCategory
{
	public class Beverage : VendingItem, IVendingItem
    {
        private bool _isEmpty;

        public void Use()
        {
            if (_isEmpty)
                Console.WriteLine(ProductName + " is empty.");
            else
                Console.WriteLine("You drank " + ProductName + ".");
            _isEmpty = true;
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


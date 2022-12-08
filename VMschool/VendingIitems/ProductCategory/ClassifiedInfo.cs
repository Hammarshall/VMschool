using System;
namespace VMschool.VendingIitems.ProductCategory
{
	public class ClassifiedInfo
	{
        public abstract void Use();

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
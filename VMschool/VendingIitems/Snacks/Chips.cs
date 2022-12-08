using System;
using VMschool.VendingIitems.ProductCategory;

namespace VMschool.VendingIitems.Snacks
{
	public class Chips : Snack
    {
		public Chips()
		{
            ProductName = "Chips";
            ProductPrice = 30;
            ProductDescription = "Flavour: BBQ";
        }
	}
}
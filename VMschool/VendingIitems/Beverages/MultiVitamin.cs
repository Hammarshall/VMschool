using System;
using VMschool.VendingIitems.ProductCategory;

namespace VMschool.VendingIitems.Beverages;

internal class MultiVitamin : Beverage
{
    public MultiVitamin()
    {
        ProductName = "Multi vitamin beverage";
        ProductPrice = 40;
        ProductDescription = "This beverage is old but gold";
    }
}
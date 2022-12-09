using System;
using VendingMachine.Class;


namespace VendingMachine.Class;

internal class MultiVitamin : Beverage // arv från Beverage
{
    public MultiVitamin()
    {
        ProductName = "Multi vitamin beverage";
        ProductPrice = 40;
        ProductDescription = "This beverage is old but gold";
    }
}
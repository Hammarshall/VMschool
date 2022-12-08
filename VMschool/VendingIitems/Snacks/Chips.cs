using System;
using VendingMachine.Class;

namespace VendingMachine.Class;

public class Chips : Snack
{
    public Chips()
    {
        ProductName = "Chips";
        ProductPrice = 30;
        ProductDescription = "Flavour: BBQ";
    }
}
using System;
using VendingMachine.Class;

namespace VendingMachine.Class;

public class Popcorn : Snack // arv
{
    public Popcorn() // object for item (product) popcorn
    {
        ProductName = "Popcorn";
        ProductPrice = 5;
        ProductDescription = "Salted";
    }
}
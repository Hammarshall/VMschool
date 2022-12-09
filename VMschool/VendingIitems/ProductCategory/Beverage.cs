using System;
using VMschool.Interface;

namespace VendingMachine.Class;

public abstract class Beverage : VendingItem, IVendingItem // ärver från vendigitem och interface
{
    private bool _isEmpty;

    public void Use() // functions for drinks , they are the same for every drink
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
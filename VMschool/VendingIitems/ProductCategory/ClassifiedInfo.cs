using System;
using VMschool.Interface;

namespace VendingMachine.Class;

public abstract class ClassifiedInfo : VendingItem, IVendingItem
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
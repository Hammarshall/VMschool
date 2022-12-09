using System;
using VMschool.Interface;

namespace VendingMachine.Class;

public abstract class ClassifiedInfo : VendingItem, IVendingItem // arv
{
    public abstract void Use(); // denna innehåller mindre då dessa producter är lite mera unika och behöver skräddarsys lite mer

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
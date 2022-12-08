using System;
using VendingMachine.Class;
using VMschool;

namespace VendingMachine;

public abstract class VendingItem
{
    public string? ProductName { get; set; } // Name
    public int ProductPrice { get; set; } // Price
    public string? ProductDescription { get; set; } // Description

    public void Description()
    {
            Console.WriteLine(ProductDescription + ".\nPrice: " + ProductPrice + Config.CURRENCY + ".");
    }
    public void ShowProductName()
    {
            Console.WriteLine(ProductName + "");
    }
}
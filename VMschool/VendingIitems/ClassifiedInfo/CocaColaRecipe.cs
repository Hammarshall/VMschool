using System;
using VendingMachine.Class;

namespace VendingMachine.Class;

public class CocaColaRecipe : ClassifiedInfo
{
    private bool _isUsed; // is it used?

    public CocaColaRecipe() // object 
    {
        ProductName = "The original recipe for Coca Cola";
        ProductPrice = 130;
        ProductDescription = "Top Secret informaion worth to kill for"; // unikt för varje product
    }

    public override void Use() // when its used
    {
        if (_isUsed)
            Console.WriteLine("The recipe is forever gone, but still exists in your memory.");
        else
            Console.WriteLine("You learned the recipe and set it on fire.");
        _isUsed = true;
    }
}
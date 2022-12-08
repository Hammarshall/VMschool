using System;
using VendingMachine.Class;

namespace VendingMachine.Class;

public class NuclearCodes : ClassifiedInfo
{
    private bool _isUsed; // is it used


    public NuclearCodes()
    {
        ProductName = "Worlds Nuclear Codes";
        ProductPrice = 150;
        ProductDescription = "With a kick of a button all your probems can go boom";
    }

    public override void Use()
    {
        if (_isUsed)
            Console.WriteLine("Russia is no more.");

        else
            Console.WriteLine("You nuked Russia.");
        _isUsed = true;
    }
}
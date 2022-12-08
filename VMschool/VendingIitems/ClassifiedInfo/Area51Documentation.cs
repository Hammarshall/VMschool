using System;
using VendingMachine.Class;

namespace VendingMachine.Class;

internal class Area51Documentation : ClassifiedInfo
{
    public Area51Documentation()
    {
        ProductName = "Documentation for Area 51";
        ProductPrice = 120;
        ProductDescription = "All the secrets you could ever imagine";
    }

    public override void Use()
    {
        Console.WriteLine("Download success.... now RUN!");
    }
}
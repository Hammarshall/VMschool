using System;
namespace VMschool.VendingIitems.ClassifiedInfo
{
	public class Area51Documentation : ClassifiedInfo
    {
        public Area51Documentation() // object
        {
            ProductName = "Documentation for Area 51";
            ProductPrice = 120;
            ProductDescription = "All the secrets you could ever imagine";
        }

        public override void Use() // function for use is special for this object
        {
            Console.WriteLine("Download success.... now RUN!");
        }
    }
}
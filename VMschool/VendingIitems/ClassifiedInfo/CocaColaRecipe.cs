using System;
namespace VMschool.VendingIitems.ClassifiedInfo
{
	public class CocaColaRecipe : ClassifiedInfo
    {
        private bool _isUsed; // is it used? 

        public CocaColaRecipe()
        {
            ProductName = "The original recipe for Coca Cola";
            ProductPrice = 130;
            ProductDescription = "Top Secret informaion worth to kill for";
        }

        public override void Use()
        {
            if (_isUsed)
                Console.WriteLine("The recipe is forever gone, but still exists in your memory.");
            else
                Console.WriteLine("You learned the recipe and set it on fire.");
            _isUsed = true;
        }
    }
}
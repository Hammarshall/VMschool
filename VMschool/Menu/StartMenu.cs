using System;
using VMschool.Money;

namespace VMschool.Menu
{
	public class StartMenu
	{
        public static void Start() //Metod för att starta metod Menu
        {
            new VendingMachine().UserMenu();
        }
    }
}


using System;
using VMschool.Money;

namespace VMschool.Menu;

public class StartMenu
{
    public static void Start() //Starts the program
    {
        new VendingMachine().UserMenu();
    }
}
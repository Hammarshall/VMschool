using System;
using VMschool.Interface;
using VMschool.Money;
using VendingMachine.Class;

namespace VMschool;

public class VendingMachine
{
    public int amountDeposited;
    private Wallet wallet = new();

    public void UserMenu()
    {
        var option = 0;
        var isInvalidInput = false;

        do
        {
            Console.WriteLine(
                @"Main menu 
                1. See all Beverages
                2. See all Snacks
                3. See all Classified info
                4. Insert Money
                5. Exit program. ");
            try
            {
                option = int.Parse(Console.ReadLine());
                isInvalidInput = false;
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input, try again...");
                isInvalidInput = true; //True = skrev bokstav, ska vara siffror.
            }
        } while (isInvalidInput); //Kör sålänge = false

        switch (option)
        {
            case 1: //Beverages
                BevMenu();
                break;
            case 2: //Snacks
                SnackMenu();
                break;
            case 3: //ClassifiedInfo
                CIMenu();
                break;
            case 4: //Deposit money
                Console.WriteLine("TOTAL: " + wallet.GetMoney());
                Console.WriteLine(wallet.GetMoneyDetails());
                var amount = int.Parse(Console.ReadLine());
                Console.WriteLine("You deposited: " + DepositMoney(wallet, amount));
                Console.WriteLine(wallet.GetMoneyDetails());
                UserMenu();
                break;

            case 5: // Exit
                Console.WriteLine("Money refund: " + amountDeposited + "$");
                wallet.ReturnFunds(amountDeposited);
                Console.WriteLine(wallet.GetMoneyDetails());
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid input, try again!");
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();
                Console.Clear();
                UserMenu();
                break;
        }
    }

    private void BevMenu() // menu for all drinks
    {
        var option = 0;
        var isInvalidInput = false;

        do
        {
            Console.WriteLine(
                                @"Bevrage Menu:
                                1. Gin and Tonic
                                2. Multivitamin
                                3. Whiskey Sour ");
            try
            {
                option = int.Parse(Console.ReadLine());
                isInvalidInput = false;
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input, try again...");
                isInvalidInput = true;
            }
        } while (isInvalidInput);

        switch (option) // choose with drink you whant
        {
            case 1:
                DisplayItem(new GT());
                break;

            case 2:
                DisplayItem(new MultiVitamin());
                break;

            case 3:
                DisplayItem(new WhiskySour());
                break;
        }
    }

    private void CIMenu() // ClassifiedInfo menu
    {
        var option = 0;
        var isInvalidInput = false;

        do
        {
            Console.WriteLine(@"ClassifiedInfo Menu:
                                1. Area51Documentation
                                2. CocaColaRecipe
                                3. NuclearCodes ");
            try
            {
                option = int.Parse(Console.ReadLine());
                isInvalidInput = false;
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input, try again...");
                isInvalidInput = true;
            }
        } while (isInvalidInput);

        switch (option) // choose product from the menu
        {
            case 1:
                DisplayItem(new Area51Documentation());
                break;

            case 2:
                DisplayItem(new CocaColaRecipe());
                break;

            case 3:
                DisplayItem(new NuclearCodes());
                break;
        }
    }

    private void SnackMenu() // snack menu
    {
        var option = 0;
        var isInvalidInput = false;

        do
        {
            Console.WriteLine(@"Snack Menu:
                                1. Chips
                                2. Nuts
                                3. Popcorn");
            try
            {
                option = int.Parse(Console.ReadLine());
                isInvalidInput = false;
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input, try again...");
                isInvalidInput = true;
            }
        } while (isInvalidInput);

        switch (option) // all snacks to choose from
        {
            case 1:
                DisplayItem(new Chips());
                break;

            case 2:
                DisplayItem(new Nuts());
                break;

            case 3:
                DisplayItem(new Popcorn());
                break;
        }
    }

    private void DisplayItem(IVendingItem item) // displays the choosen item from all of the diffrent menus
    {
        item.ShowProductName(); // shows name
        item.Description(); // shows desc

        Console.WriteLine("Purchase? (Y/N)");
        var key = Console.ReadLine().ToUpper();

        if (key == "Y")
        {
            Console.Write("How many would you like to purchase? ");
            int numDrinks = int.Parse(Console.ReadLine());

            int totalPrice = 0;
            if (numDrinks > 0) // chooses how many they whant
            {
                totalPrice = numDrinks * item.Price();

                if (amountDeposited >= totalPrice) // the user has enough cash to make the purchase
                {
                    //Console.WriteLine("You have enough cash to make the purchase.");
                    Console.WriteLine("The total price for {0} is {1:C}.", numDrinks, totalPrice);
                    BuyItem(item);
                }
                else // not enough cash in the mashine
                {
                    Console.WriteLine("You do not have enough cash to make the purchase.");
                }
            }
        }
        UserMenu(); // takes the user back to main menu
    }

    private void BuyItem(IVendingItem item) // when the user chooses to buy the item
    {
        if (amountDeposited >= item.Price()) // if the deposited amout is more than the item price
        {
            amountDeposited -= item.Price(); // removes the item price from the money in the mashine
            item.Buy();
            item.Use();
            item.Use();
            Console.WriteLine("Money left in VendigMacine: " + amountDeposited + "$");
        }
        else // the deposited amount is to litte
        {
            Console.WriteLine("Deposit more money!");
            Console.WriteLine("Money left in VendigMacine: " + amountDeposited + "$");
        }
    }

    public int DepositMoney(Wallet wallet, int amount) // deposit money from wallet into mashine
    {
        var possibleAmount = wallet.Deposit(amount);
        amountDeposited += possibleAmount;
        return possibleAmount;
    }
}
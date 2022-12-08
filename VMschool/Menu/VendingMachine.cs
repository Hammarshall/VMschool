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
                7. Exit program. ");
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
                case 5: // Get back money

                case 7: // Exit
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

        private void BevMenu()
        {
            var option = 0;

            var isInvalidInput = false;
            do
            {
                Console.WriteLine(@"Bevrage Menu
                                1. GT
                                2. Multi
                                3. WS ");
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

            switch (option)
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

        private void CIMenu()
        {
            var option = 0;

            var isInvalidInput = false;
            do
            {
                Console.WriteLine(@"ClassifiedInfo Menu
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

            switch (option)
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

        private void SnackMenu()
        {
            var option = 0;

            var isInvalidInput = false;
            do
            {
                Console.WriteLine(@"Snack Menu
                                1. Chips
                                2. Nuts
                                3. PopC ");
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

            switch (option)
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

        private void DisplayItem(IVendingItem item)
        {
            item.ShowProductName();
            item.Description();

            Console.WriteLine("Köpa? (Y/N)");
            var key = Console.ReadLine().ToUpper();

            if (key == "Y")
            {
                Console.Write("How many would you like to buy? ");
                int numDrinks = int.Parse(Console.ReadLine());

                int totalPrice = 0;

                if (numDrinks > 0)
                {
                    totalPrice = numDrinks * item.Price();

                    if (amountDeposited >= totalPrice)
                    {
                        //Console.WriteLine("You have enough cash to make the purchase.");
                        Console.WriteLine("The total price for {0} is {1:C}.", numDrinks, totalPrice);
                        BuyItem(item);
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough cash to make the purchase.");
                    }
                }
            }
            UserMenu();
        }

        private void BuyItem(IVendingItem item)
        {
            if (amountDeposited >= item.Price())
            {
                amountDeposited -= item.Price();
                item.Buy();
                item.Use();
                item.Use();
                Console.WriteLine("Money left in VendigMacine: " + amountDeposited + "$");
            }
            else
            {
                Console.WriteLine("Deposit more money!");
                Console.WriteLine("Money left in VendigMacine: " + amountDeposited + "$");
            }
        }

        public int DepositMoney(Wallet wallet, int amount)
        {
            var possibleAmount = wallet.Deposit(amount);
            amountDeposited += possibleAmount;
            return possibleAmount;
        }
}
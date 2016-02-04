using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Exercise 5.1, 5.2, 5.3, 5.4
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CanRack sodaRack = new CanRack();
            CoinBox changeBox = new CoinBox(new List<Coin> {
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME),
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

            Console.WriteLine("******Welcome to the .NET Soda Vending Machine******");
            CanRack rack = new CanRack();
            PurchasePrice myPrice = new PurchasePrice(100);
          
            while (true)
            {
                Console.WriteLine("Enter '1' to purchase a soda.\nEnter '2' to exit");
                string userValue = Console.ReadLine();
                int convertedUserValue;
                if (int.TryParse(userValue, out convertedUserValue) == true)
                {
                    if (convertedUserValue == 1)
                    {
                        Console.WriteLine("Here is what we have in store");
                        rack.DisplayCanRack();
                        Console.Write("\nPlease enter the Flavor you would like: ");
                        string UserFlavorInput = Console.ReadLine();

                        try
                        {
                            Flavor UserFlavor = FlavorOps.ToFlavor(UserFlavorInput);

                            if (!rack.IsEmpty(UserFlavor))
                            {
                                Console.Write("Please insert {0:C} into the machine ", myPrice.DecimalPrice);
                                decimal Total = 0;

                                while (Total < myPrice.DecimalPrice)
                                {
                                    string CoinString = Console.ReadLine();
                                    Coin CoinInput = new Coin(CoinString.ToUpper());
                                    Total = Total + CoinInput.ValueOf;
                                    Console.WriteLine("You inserted a {0}. Your total is {1}", CoinInput, Total);
                                }

                                rack.RemoveACanOf(UserFlavor);
                                Console.WriteLine("Dispensed 1 can of {0} Soda", UserFlavor);
                                Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, we are out of {0}", UserFlavor);
                                continue;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Please try again and type in a valid flavor");
                        }
                    }
                    if (convertedUserValue == 2)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid option");
                }
            }
        }
    }
}
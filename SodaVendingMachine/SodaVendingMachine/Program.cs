using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Exercise 4.1 and 4.2
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        Console.Write("Please insert {0:C} into the machine ", myPrice.DecimalPrice);
                        decimal Total = 0;

                        while (Total < myPrice.DecimalPrice)
                        {
                            string CoinString = Console.ReadLine();
                            Coin CoinInput = new Coin(CoinString.ToUpper());
                            Total = Total + CoinInput.ValueOf;
                            Console.WriteLine("You inserted a {0}. Your total is {1}", CoinInput, Total);
                        }

                        rack.RemoveACanOf(UserFlavorInput);
                        Console.WriteLine("Dispensed 1 can of {0} Soda", UserFlavorInput);
                        Console.ReadLine();
                        continue;
                    }

                    if (convertedUserValue == 2)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, that is not a valid option");
                    }
                }
            }

















        }
    }
}

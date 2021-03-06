﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._3_CoinBox
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchasePrice sodaPrice = new PurchasePrice(0.35M);
            CanRack sodaRack = new CanRack();
            CoinBox changeBox = new CoinBox(new List<Coin> { 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME), 
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER), 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

            Boolean timeToExit = false;
            do
            {
                sodaRack.DisplayCanRack();
                Console.Write("Please insert {0:c} worth of coins: ", sodaPrice.PriceDecimal);

                decimal totalValueInserted = 0M;
                while (totalValueInserted < sodaPrice.PriceDecimal)
                {
                    // get the coin inserted
                    string coinNameInserted = Console.ReadLine().ToUpper();
                    Coin coinInserted = new Coin(coinNameInserted);
                    Console.WriteLine("You have inserted a {0} worth {1:c}", coinInserted, coinInserted.ValueOf);
                    changeBox.Deposit(coinInserted);

                    // running total of the value of the coins inserted
                    totalValueInserted += coinInserted.ValueOf;
                    Console.WriteLine("Total value inserted is {0:c}", totalValueInserted);
                }

                // select a flavor of soda
                Boolean canDispensed = false;
                while (!canDispensed)
                {
                    Console.Write("What flavor would you like? : ");
                    string flavorName = Console.ReadLine().ToUpper();

                    // Well, this used to be trouble. 
                    Flavor flavorEnumeral = FlavorOps.ToFlavor(flavorName);

                    if (!sodaRack.IsEmpty(flavorEnumeral))
                    {
                        sodaRack.RemoveACanOf(flavorEnumeral);
                        Console.WriteLine("Thanks, here is your can of {0}.", flavorEnumeral);
                        canDispensed = true;
                    }
                    else
                    {
                        Console.WriteLine("We are out of {0}", flavorEnumeral);
                    }
                }

                Console.Write("Exit the vending machine? (y/n): ");
                string response = Console.ReadLine();
                timeToExit = response.Trim().ToUpper().StartsWith("Y");

            } while (!timeToExit);

            Console.WriteLine("Contents of Coin Box:");

            Console.WriteLine("{0}\tHalf Dollar(s)", changeBox.HalfDollarCount);
            Console.WriteLine("{0}\tQuarter(s)", changeBox.QuarterCount);
            Console.WriteLine("{0}\tDime(s)", changeBox.DimeCount);
            Console.WriteLine("{0}\tNickel(s)", changeBox.NickelCount);
            Console.WriteLine("{0}\tSlug(s)", changeBox.SlugCount);

            Console.WriteLine();
            Console.WriteLine("Total value in coin box is {0:c}", changeBox.ValueOf);
        }
    }
}

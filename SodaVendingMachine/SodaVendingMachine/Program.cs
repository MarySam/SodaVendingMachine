using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Exercise 3.1 and 3.2
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome to the .NET Soda Vending Machine******");

            //Objects.
            CanRack rack = new CanRack();
            PurchasePrice myPrice = new PurchasePrice(35);

            Console.Write("Please insert {0} cents into the machine ", myPrice.Price);
            Console.ReadLine();

            rack.RemoveACanOf(Flavor.orange);
            Console.WriteLine("Dispensed 1 can of {0} Soda", Flavor.orange);
            Console.ReadLine();
        }
    }
}

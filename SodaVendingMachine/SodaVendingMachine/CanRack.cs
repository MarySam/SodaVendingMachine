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
    class CanRack
    {
        //Declaring our variable rack.
        private Dictionary<Flavor, int> rack = null;

        //Constructor for a can rack. The rack starts out full.
        public CanRack()
        {
            //Instantiate the rack Dictionary
            this.rack = new Dictionary<Flavor, int>();
            this.FillTheCanRack();
        }

        public int GetNumberOfCans(Flavor FlavorofCan)
        {
            return this.rack[FlavorofCan];
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            Debug.WriteLine("Adding a can of {0}", (object)FlavorOfCanToBeAdded);
            this.rack[FlavorOfCanToBeAdded]++;
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            Debug.WriteLine("Removing a can of {0}", (object)FlavorOfCanToBeRemoved);
            this.rack[FlavorOfCanToBeRemoved]--;
        }

        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the Rack");
            this.rack[Flavor.Regular] = 3;
            this.rack[Flavor.Orange] = 3;
            this.rack[Flavor.Lemon] = 3;
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            Debug.WriteLine("Emptying a bin of {0}", (object)FlavorOfBinToBeEmptied);
            this.rack[FlavorOfBinToBeEmptied] = 0;
        }

        public bool IsFull(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine("Checking whether bin of {0} is full", (object)FlavorOfBinToCheck);
            return this.rack[FlavorOfBinToCheck] > 2;
        }

        public bool IsEmpty(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine("Checking whether bin of {0} is empty", (object)FlavorOfBinToCheck);
            return this.rack[FlavorOfBinToCheck] < 1;
        }

        //Method to display the Flavor and Quantity of Cans
        public void DisplayCanRack()
        {
            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                int QuantityOfFlavor = this.rack[aFlavor];
                Console.WriteLine("Flavor: {0} Inventory: {1} ", aFlavor, QuantityOfFlavor);
            }

        }

    }
}

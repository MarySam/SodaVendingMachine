using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Exercise 2.1 and 2.2
//Author:  Sam, Mary


namespace SodaVendingMachine
{
    class CanRack
    {
        private int[] quantities;

        private string[] flavors;

        //Constructor for a can rack. The rack starts out full.
        public CanRack()
        {
            this.quantities = new int[3];
            this.flavors = new string[] { "Regular", "Orange", "Lemon" };
            this.FillTheCanRack();
        }

        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            Debug.WriteLine("Adding a can of {0}", (object)FlavorOfCanToBeAdded);
            int binIndex = GetBinIndex(FlavorOfCanToBeAdded);
            this.quantities[binIndex]++;
        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            Debug.WriteLine("Removing a can of {0}", (object)FlavorOfCanToBeRemoved);
            int binIndex = GetBinIndex(FlavorOfCanToBeRemoved);
            this.quantities[binIndex]--;
        }

        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the Rack");
            this.quantities[0] = 3;
            this.quantities[1] = 3;
            this.quantities[2] = 3;
        }

        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            Debug.WriteLine("Emptying a bin of {0}", (object)FlavorOfBinToBeEmptied);
            int binIndex = GetBinIndex(FlavorOfBinToBeEmptied);
            this.quantities[binIndex] = 0;
        }

        public bool IsFull(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("Checking whether bin of {0} is full", (object)FlavorOfBinToCheck);
            int binIndex = GetBinIndex(FlavorOfBinToCheck);
            return this.quantities[binIndex] > 2;
        }

        public bool IsEmpty(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("Checking whether bin of {0} is empty", (object)FlavorOfBinToCheck);
            int binIndex = GetBinIndex(FlavorOfBinToCheck);
            return this.quantities[binIndex] < 1;
        }

        private int GetBinIndex(string flavorOfCan)
        {
            for (int i = 0; i < this.flavors.Length; i++)
            {
                if (flavorOfCan == this.flavors[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

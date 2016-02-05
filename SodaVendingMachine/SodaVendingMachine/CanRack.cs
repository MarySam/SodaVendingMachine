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
    class CanRack
    {
        private int[] quantities;

        //Constructor for a can rack. The rack starts out full.
        public CanRack()
        {
            //Gives us an array based on the size of the enum.
            this.quantities = new int[Enum.GetValues(typeof(Flavor)).Length];

            this.FillTheCanRack();
        }

        //Method that gets the number of cans.
        public int GetNumberOfCans(String FlavorofCan)
        {
            int binIndex = GetBinIndex(FlavorofCan);
            return this.quantities[binIndex];
        }

        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            Debug.WriteLine("Adding a can of {0}", (object)FlavorOfCanToBeAdded);
            int binIndex = GetBinIndex(FlavorOfCanToBeAdded);
            this.quantities[binIndex]++;
        }

        //Overloaded method with flavor parameter.
        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            this.AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            Debug.WriteLine("Removing a can of {0}", (object)FlavorOfCanToBeRemoved);
            int binIndex = GetBinIndex(FlavorOfCanToBeRemoved);
            this.quantities[binIndex]--;
        }

        //Overloaded method with flavor parameter.
        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            this.RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
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

        //Overloaded method with flavor parameter.
        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            this.RemoveACanOf(FlavorOfBinToBeEmptied.ToString());
        }

        public bool IsFull(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("Checking whether bin of {0} is full", (object)FlavorOfBinToCheck);
            int binIndex = GetBinIndex(FlavorOfBinToCheck);
            return this.quantities[binIndex] > 2;
        }

        //Overloaded method with flavor parameter.
        public void IsFull(Flavor FlavorOfBinToCheck)
        {
            this.IsFull(FlavorOfBinToCheck.ToString());
        }

        public bool IsEmpty(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("Checking whether bin of {0} is empty", (object)FlavorOfBinToCheck);
            int binIndex = GetBinIndex(FlavorOfBinToCheck);
            return this.quantities[binIndex] < 1;
        }

        //Overloaded method with flavor parameter.
        public void IsEmpty(Flavor FlavorOfBinToCheck)
        {
            this.IsEmpty(FlavorOfBinToCheck.ToString());
        }

        //Method to display the Flavor and Quantity of Cans
        //console.writeline should eventually be moved.
        public void DisplayCanRack()
        {
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                int QuantityOfFlavor = this.GetNumberOfCans(flavorName);
                Console.WriteLine("Flavor: {0} Inventory: {1}", flavorName, QuantityOfFlavor);
            }

        }

        private int GetBinIndex(string flavorOfCan)
        {
            //Converts the string representation of the name or numeric value of 
            //one or more enumerated constants to an equivalent enumerated object. 
            Flavor FlavorValue = (Flavor)Enum.Parse(typeof(Flavor), flavorOfCan,true);
            //Casting an enum into an int.
            return (int)FlavorValue;
        }
    }
}

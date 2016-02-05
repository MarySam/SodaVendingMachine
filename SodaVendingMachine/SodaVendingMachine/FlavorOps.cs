using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 5.1, 5.2, 5.3, 5.4
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    public static class FlavorOps
    {
        //A collection called _allFlavors of type Flavors that is static.   
        private static List<Flavor> _allFlavors = new List<Flavor>();

        //static constructor
        static FlavorOps()
        {
            _allFlavors.Add(Flavor.Regular);
            _allFlavors.Add(Flavor.Orange);
            _allFlavors.Add(Flavor.Lemon);

            //foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            //{
            //    Flavor flavorEnumeral = ToFlavor(flavorName);
            //    _allFlavors.Add(flavorEnumeral);
            //}
        }

        //method to convert a string value into an enumeral
        public static Flavor ToFlavor(string Flavorname)
        {
            Flavor flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), Flavorname, true);
            return flavorEnumeral;
        }

        //property to return a List<Flavor> of all of the Varieties
        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
                //Enum.GetValues(typeof(Flavor)).Cast<Flavor>().ToList();
            }
        }
    }
}

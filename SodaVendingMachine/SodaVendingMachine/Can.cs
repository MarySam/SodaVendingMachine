using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 3.1 and 3.2
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    public enum Flavor { regular, orange, lemon};

    class Can
    {
        public readonly Flavor TheFlavor = Flavor.regular;

        //Default constructor.
        public Can ()
        {

        }

        //Constructor that accepts Flavor as a parameter.
        public Can (Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }
    }
}

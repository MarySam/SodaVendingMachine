using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 5.1, 5.2, 5.3, 5.4
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    public enum Flavor { Regular, Orange, Lemon };

    class Can
    {
        public readonly Flavor TheFlavor = Flavor.Regular;

        //Default constructor.
        public Can()
        {

        }

        //Constructor that accepts Flavor as a parameter.
        public Can(Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }
    }
}

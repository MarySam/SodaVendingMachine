﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 4.1 and 4.2
//Author:  Sam, Mary

namespace SodaVendingMachine
{
    public enum Flavor { Regular, Orange, Lemon};

    class Can
    {
        public readonly Flavor TheFlavor = Flavor.Regular;

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
